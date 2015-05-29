var initArr = [62, 4, 7, 3, 37, 3, 84, 6, 73, 47, 5, 535, 78],
    arrLen = initArr.length,
    index,
    innerCounter,
    minNum,
    indexOfMin,
    tmp;

for (index = 0; index < arrLen - 1; index += 1) {
    minNum = initArr[index + 1];
    indexOfMin = index + 1;
    for (innerCounter = index + 1; innerCounter < arrLen; innerCounter += 1) {
        if (initArr[innerCounter] < minNum) {
            minNum = initArr[innerCounter];
            indexOfMin = innerCounter;
        }
    }
    if (minNum < initArr[index]) {
        tmp = initArr[index];
        initArr[index] = initArr[indexOfMin];
        initArr[indexOfMin] = tmp;
    }
}

console.log(initArr);
