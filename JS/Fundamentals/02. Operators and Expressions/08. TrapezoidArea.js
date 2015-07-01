var sideA = 2;
var sideB = 1;
var heightH = 33;

function CalcTrapezoidArea(a, b, h) {
    var area = (a + b) / 2 * h;
    return area;
}

console.log('The area is: ' + CalcTrapezoidArea(sideA, sideB, heightH));
