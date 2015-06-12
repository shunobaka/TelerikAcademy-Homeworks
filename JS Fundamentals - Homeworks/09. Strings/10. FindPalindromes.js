var text = 'This is a text with ABBA palindromes such as lamal and exe and this is a script which finds tacocat such.';

var result = findPalndromes(text);
console.log(result);

function findPalndromes(text) {
    var palindromes = [],
        words = text.split(' ');

    palindromes = words.filter(function(element) {
        var len,
            index;
            
        for (len = element.length, index = 0; index < (len / 2) | 0; index += 1) {
        	if (element[index] !== element[len - 1 - index]) {
        		break;
        	}

        	if (index === (((len / 2) | 0) - 1)) {
        		return element;
        	}
        }
    });

    return palindromes;
}
