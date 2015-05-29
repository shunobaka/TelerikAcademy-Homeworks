var array = new Array(20),
	arrLen = array.length,
	index;

for (index = 0; index < arrLen; index += 1) {
    array[index] = index * 5;
}

for (index = 0; index < arrLen; index += 1) {
    console.log('Array[' + index + '] = ' + array[index]);
}