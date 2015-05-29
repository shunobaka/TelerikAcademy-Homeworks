var a = -0.5,
    b = 4,
    c = -8,
    discriminant = Math.pow(b, 2) - 4 * a * c,
    rootOne,
    rootTwo;

if (discriminant === 0) {
    rootOne = (-b) / (2 * a);
    console.log('Only real root is: x = ' + rootOne);
} else if (discriminant > 0) {
    rootOne = (-b + Math.sqrt(discriminant)) / (2 * a);
    rootTwo = (-b - Math.sqrt(discriminant)) / (2 * a);
    console.log('The roots are: x1 = ' + rootOne + ', x2 = ' + rootTwo);
} else {
    console.log('There are no real roots!');
}
