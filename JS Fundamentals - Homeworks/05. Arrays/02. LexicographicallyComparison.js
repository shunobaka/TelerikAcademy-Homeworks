var arrOne = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'],
	arrTwo = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'z'],
	index,
	arrayLen = arrOne.length;

if (arrOne.length !== arrTwo.length) {
    console.log('Arrays are different!');
} else {
    for (index = 0; index < arrayLen; index += 1) {
        if (arrOne[index] !== arrTwo[index]) {
            console.log('Arrays are different!');
            return;
        }
    }
    console.log('Arrays are the same!');
}
