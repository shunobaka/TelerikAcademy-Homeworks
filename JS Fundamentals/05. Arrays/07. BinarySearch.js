var arr = [2, 3, 4, 5, 6, 7, 37, 47, 62, 73, 78, 84, 535],
    searched = 535,
    foundIndex = -1,
    left = 0,
    right = arr.length - 1,
    middle;

while (right - left >= 1) {
    middle = (left + (right - left) / 2) | 0;
    if (searched === arr[middle]) {
        foundIndex = middle;
        break;
    } else if (searched < arr[middle]) {
        right = middle - 1;
    } else {
        left = middle + 1;
    }
    if (right === left) {
        if (searched === arr[left]) {
            foundIndex = left;
            break;
        }
    }
}

console.log(foundIndex);
