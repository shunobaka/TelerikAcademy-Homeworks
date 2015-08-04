/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
    return function(selector, count) {
        if (selector === undefined || selector === null) {
            throw new Error('The selector cannot be null or undefined.');
        }

        if (typeof(selector) !== 'string') {
            throw new Error('The selector must be a string.');
        }

        var $container = $(selector);

        if ($container.length === 0) {
            return this;
        }

        if (count === undefined || count === null) {
            throw new Error('The count must be defined.');
        }

        if (typeof(count) === 'string') {
            count = +count;
        }

        if (isNaN(count)) {
            throw new Error('Count must be either a number string or a number.');
        }

        if (count < 1) {
            throw new Error('The count must be more than zero.');
        }

        var $ul = $('<ul />').addClass('items-list');
        for (var index = 0; index < count; index += 1) {
            var $li = $('<li />')
                	.addClass('list-item')
                	.html('List item #' + index)
                	.appendTo($ul);
        }

        $container.append($ul);
    };
}
