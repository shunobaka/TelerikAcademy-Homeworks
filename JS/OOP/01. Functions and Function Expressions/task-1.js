/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(numbers) {
    if (!numbers) {
        throw new Error();
    }

    if (numbers.length === 0) {
        return null;
    }

    return numbers.reduce(function(s, number) {
        number = +number;

        if (isNaN(number)) {
            throw new Error();
        }

        return s + number;
    }, s = 0);
}

module.exports = sum;