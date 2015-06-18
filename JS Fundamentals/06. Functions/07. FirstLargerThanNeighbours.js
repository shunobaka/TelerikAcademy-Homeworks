var array = [58, 57, 6, 36, 39, 47, 61, 87, 98, 18, 73, 24, 84, 92, 1, 58, 59, 95, 87];

firstBiggerThanNeighbours(array);

function firstBiggerThanNeighbours(array) {
    var arrLen = array.length,
        indexToCheck,
        returnIndex,
        firstFound = -1;

    for (indexToCheck = 1; indexToCheck < arrLen - 2; indexToCheck += 1) {
        returnIndex = checkIfGreaterThanNeighbours(array, indexToCheck);
        if (returnIndex !== -1) {
            firstFound = returnIndex;
            break;
        }
    }

    console.log('The index of the first element bigger than it\'s neighbours is: ' + firstFound);
}

function checkIfGreaterThanNeighbours(array, indexToCheck) {
    if (array[indexToCheck - 1] < array[indexToCheck] && array[indexToCheck + 1] < array[indexToCheck]) {
        return indexToCheck;
    } else {
        return -1;
    }
}
