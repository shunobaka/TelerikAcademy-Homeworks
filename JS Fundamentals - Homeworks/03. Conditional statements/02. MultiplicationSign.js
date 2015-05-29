var numberA = -2,
    numberB = 1,
    numberC = 3,
    sign;

if (numberA === 0 || numberB === 0 || numberC === 0) {
    sign = '0';
} else if (numberA > 0) {
    if (numberB > 0) {
        if (numberC > 0) {
            sign = '+';
        } else {
            sign = '-';
        }
    } else {
        if (numberC > 0) {
            sign = '-';
        } else {
            sign = '+';
        }
    }
} else {
    if (numberB > 0) {
        if (numberC > 0) {
            sign = '-';
        } else {
            sign = '+';
        }
    } else {
        if (numberC > 0) {
            sign = '+';
        } else {
            sign = '-';
        }
    }
}

console.log('The sign of the result is: ' + sign);
