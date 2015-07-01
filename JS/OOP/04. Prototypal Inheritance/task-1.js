/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
    .init('head')
    .appendChild(meta)

var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
    .init('body')
    .appendChild(div)
    .addAttribute('id', 'cuki')
    .addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
    .init('html')
    .appendChild(head)
    .appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
    function validate(type, value) {
        var typeCheckRegex = /^[A-z0-9]+$/g;
        var attCheckRegex = /^[A-z0-9-]+$/g;

        if (typeof(value) !== 'string') {
            throw new Error('The ' + type + ' must be a string!');
        }
        if (value.length < 1) {
            throw new Error('The ' + type + ' must be non-empty!');
        }
        if (type === 'type') {
            if (!typeCheckRegex.test(value)) {
                throw new Error('The type must contain only letters and digits!');
            }
        } else {
            if (!attCheckRegex.test(value)) {
                throw new Error('The attribute name must contain only letters, digits and dashes!');
            }
        }
    }

    var domElement = (function() {
        var domElement = {
            init: function(type) {
                validate('type', type);
                this.type = type;
                this.attributes = [];
                this.children = [];
                this.parent = false;
                this.content = '';

                return this;
            },
            appendChild: function(child) {
                if (typeof(child) === 'object') {
                    child.parent = this;
                }

                this.children.push(child);

                return this;
            },
            addAttribute: function(name, value) {
                validate('attribute name', name);

                var attribute = [name, value];

                for (var att in this.attributes) {
                    if (this.attributes[att][0] === name) {
                        this.attributes.splice(att, 1);
                        break;
                    }
                }

                this.attributes.push(attribute);

                return this;
            },
            removeAttribute: function(attribute) {
                var attributeExists = false;
                for (var att in this.attributes) {
                    if (this.attributes[att][0] === attribute) {
                        this.attributes.splice(att, 1);
                        attributeExists = true;
                        break;
                    }
                }

                if (!attributeExists) {
                    throw new Error('No such attribute exists!');
                }

                return this;
            },
            get innerHTML() {
                var output = '<';
                output += this.type;

                this.attributes.sort(function(a, b) {
                    return a[0] > b[0];
                });

                for (var att in this.attributes) {
                    output += ' ' + this.attributes[att][0] + '="' + this.attributes[att][1] + '"';
                }

                output += '>';

                if (this.children.length === 0) {
                    output += this.content;
                } else {
                    for (var child in this.children) {
                        if (typeof(this.children[child]) === 'string') {
                            output += this.children[child];
                        } else {
                            output += this.children[child].innerHTML;
                        }
                    }
                }

                output += '</' + this.type + '>';

                return output;
            },
            get content() {
                return this._content;
            },
            set content(value) {
                if (this.parent) {
                    this.parent.content = value;
                }

                this._content = value;
            }
        };

        return domElement;
    }());

    return domElement;
}

module.exports = solve;
