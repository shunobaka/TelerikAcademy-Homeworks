var array = [58, 59, 6, 36, 65, 47, 61, 87, 98, 18, 73, 24, 84, 92, 1, 58, 59, 95, 87],
    indexToCheck = 17;

checkIfGreaterThanNeighbours(array, indexToCheck);

function checkIfGreaterThanNeighbours(array, indexToCheck) {
    var arrayLength = array.length;

    if (indexToCheck < 1 || indexToCheck > arrayLength - 2) {
        console.log('The index doesn\'t have two neighbours or is outside the array!');
    } else {
        if (array[indexToCheck - 1] < array[indexToCheck] && array[indexToCheck + 1] < array[indexToCheck]) {
            console.log('The number is bigger than it\'s neighbours!');
        } else {
            console.log('The number is smaller than 1 or more of it\'s neightbours!');
        }
    }
}