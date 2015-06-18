var numbers = [5, 4, 7, 32, 6, 87, 25, 56, 32, 5, 654, 2, 53, 699],
	min = numbers[0],
	max = numbers[0],
	counter,
	sequenceLength = numbers.length;

for (counter = 1; counter < numbers.length; counter += 1) {
    if (numbers[counter] > max) {
        max = numbers[counter];
    }
    if (numbers[counter] < min) {
        min = numbers[counter];
    }
}

console.log('The min is: ' + min);
console.log('The max is: ' + max);
