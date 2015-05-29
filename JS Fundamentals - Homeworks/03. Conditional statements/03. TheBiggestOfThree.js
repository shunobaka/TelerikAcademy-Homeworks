var numberA = 5,
    numberB = -2,
    numberC = 0,
    biggest;

if (numberA > numberB) {
    if (numberA > numberC) {
        biggest = numberA;
    } else {
        biggest = numberC;
    }
} else {
    if (numberB > numberC) {
        biggest = numberB;
    } else {
        biggest = numberC;
    }
}

console.log('The biggest of the three is: ' + biggest);
