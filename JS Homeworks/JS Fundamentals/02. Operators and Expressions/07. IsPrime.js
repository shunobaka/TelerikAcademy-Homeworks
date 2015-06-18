var numberIsPrime = true,
	number = 37,
	maxDivider = Math.sqrt(number);

if (!(number) || number === 1) {
    numberIsPrime = false;
} else {
    var currentCheck = 2;
    for (currentCheck; currentCheck <= maxDivider; currentCheck += 1) {
        if (!(number % currentCheck)) {
            numberIsPrime = false;
        }
    }
}

console.log('The number is prime: ' + numberIsPrime);
