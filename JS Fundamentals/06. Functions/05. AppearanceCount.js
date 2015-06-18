var array = [5, 3, 6, 234, 7, 5, 6, 2, 5, 6, 5, 3, 7, 789, , 6, 75, 46, 3, 543, 3, 24, 5],
    searchedNumber = 5;

countOccurences(array, searchedNumber);

function countOccurences(array, searchedNumber) {
    var counts = 0,
        index;

    for (index in array) {
        if (array[index] === searchedNumber) {
            counts += 1;
        }
    }

    console.log('The appearance count of the number is: ' + counts + ' times');
}
