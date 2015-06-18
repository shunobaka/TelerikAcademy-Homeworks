var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    arrLen = arr.length,
    index,
    lastElement = arr[0],
    longestSeq = '',
    currentSeq = arr[0] + '';

for (index = 1; index < arrLen; index += 1) {
    if (arr[index] === lastElement) {
        currentSeq += ', ' + arr[index];
    } else {
        if (currentSeq.length > longestSeq.length) {
            longestSeq = currentSeq;
        }
        currentSeq = arr[index] + '';
    }
    lastElement = arr[index];
}

if (currentSeq.length > longestSeq.length) {
    longestSeq = currentSeq;
}

console.log('Initial array = ' + arr);
console.log('Longest sequence = ' + longestSeq);
