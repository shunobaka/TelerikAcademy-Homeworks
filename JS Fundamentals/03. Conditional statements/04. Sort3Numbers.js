var numberA = -1.1,
    numberB = -0.5,
    numberC = -0.1,
    tmp;

if (numberA < numberB) {
    if (numberB < numberC) {
        tmp = numberA;
        numberA = numberC;
        numberC = tmp;
    } else {
        if (numberA > numberC) {
            tmp = numberA;
            numberA = numberB;
            numberB = tmp;
        } else {
            tmp = numberA;
            numberA = numberB;
            numberB = numberC;
            numberC = tmp;
        }
    }
} else if (numberA > numberB) {
    if (numberB < numberC) {
        tmp = numberB;
        numberB = numberC;
        numberC = tmp;
    }
} else {
    if (numberC > numberA) {
        tmp = numberA;
        numberA = numberC;
        numberC = tmp;
    }
}

console.log(numberA + ' ' + numberB + ' ' + numberC);
