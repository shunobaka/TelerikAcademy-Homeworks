/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
    var number,
        maxDiviser,
        diviser,
        isPrime,
        primes = [];

    from = +from;
    to = +to;

    if (isNaN(from) || isNaN(to)) {
        throw new Error();
    }

    for (number = from; number <= to; number += 1) {
        maxDiviser = Math.sqrt(number);
        isPrime = true;

        for (diviser = 2; diviser <= maxDiviser; diviser += 1) {
        	if (!(number % diviser)) {
        		isPrime = false;
        		break;
        	}
        }

        if (isPrime && number > 1) {
        	primes.push(number);
        }
    }

    return primes;
}

module.exports = findPrimes;
