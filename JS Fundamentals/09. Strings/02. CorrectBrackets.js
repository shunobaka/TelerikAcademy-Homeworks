var expOne = '((a+b)/5-d)',
	expTwo = ')(a+b))';

var resultOne = checkBrackets(expOne);
var resultTwo = checkBrackets(expTwo);

console.log('Checking if correct:');
console.log('First expression: ' + expOne + ' - ' + resultOne);
console.log('Second expression: ' + expTwo + ' - ' + resultTwo);

function checkBrackets(expression) {
	var len,
		index,
		bracetsCount = 0;

	for (index = 0, len = expression.length; index < len; index += 1) {
		if (expression[index] === '(') {
			bracetsCount += 1;
		}
		if (expression[index] === ')') {
			bracetsCount -= 1;
		}
	}

	if (bracetsCount) {
		return false;
	}
	else {
		return true; 
	}
}