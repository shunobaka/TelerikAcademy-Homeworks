var number = 3113765;

function CheckThirdDigit(numberToCheck) {
    numberToCheck /= 100;
    var result = Math.floor(numberToCheck) % 10;
    return result;
}

if (CheckThirdDigit(number) === 7) {
    console.log('The third digit is 7!');
} else {
    console.log('The third digit is NOT 7!');
}
