var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    arrLength = arr.length,
    index,
    check,
    currentNumber = 0,
    counter = 0,
    mostFrequent = 0,
    highestCount = 0;

for (index = 0; index < arrLength; index += 1) {
    currentNumber = arr[index];
    for (check = 0; check < arrLength; check += 1) {
        if (currentNumber === arr[check]) {
            counter++;
        }
    }

    if (counter > highestCount) {
        highestCount = counter;
        mostFrequent = currentNumber;
    }

    counter = 0;
}

console.log('The most frequent number is: ' + mostFrequent + ' (' + highestCount + ' times)');
