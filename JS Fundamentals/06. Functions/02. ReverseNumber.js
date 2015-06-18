var number = 5443.432;

function reverseNumber(num) {
	var result = '';
    num = num + '';
    index = num.length - 1;

    for (index; index >= 0; index -= 1) {
        result += num[index];
    }

    return result * 1;
}

console.log(reverseNumber(number));
