/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

function solve() {
    return function(element, contents) {
        if (element === null || element === undefined) {
            throw new Error('The element cannot be null or undefined.');
        }

        if (contents === undefined) {
            throw new Error('The contents must be defined.');
        }

        if (!Array.isArray(contents)) {
            throw new Error('The contents must be an array.');
        }

        if (!(element instanceof HTMLElement)) {
            if (typeof(element) !== 'string') {
                throw new Error('Element must be a valid DOM element or string id.');
            }

            element = document.getElementById(element);

            if (element === null) {
                throw new Error('There is no element with this id.');
            }
        }

        var contentToAppend = document.createDocumentFragment();

        for (var content in contents) {
            var currentContent = contents[content];

            if (typeof(currentContent) !== 'string' &&
                (isNaN(currentContent) || Array.isArray(currentContent))) {
                throw new Error('The content must be either a string or a number.');
            }

            var div = document.createElement('div');
            div.innerHTML = currentContent;
            contentToAppend.appendChild(div);
        }

        element.innerHTML = '';
        element.appendChild(contentToAppend);
    };
}
