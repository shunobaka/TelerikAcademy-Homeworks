var str = 'Test string to reverse';

var reversed = reverseString(str);

console.log(str);
console.log('Reversed:');
console.log(reversed);

function reverseString(str) {
    var index,
        result = '';

    for (index = str.length - 1; index >= 0; index -= 1) {
        result += str[index];
    }

    return result;
}
