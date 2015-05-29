var xOfPoint = 2;
var yOfPoint = 1.5;
var radius = 3;

var isInCircle = (xOfPoint - 1) * (xOfPoint - 1) + (yOfPoint - 1) * (yOfPoint - 1) <= radius * radius;
var outsideRect = xOfPoint < -1 || xOfPoint > 5 || yOfPoint > 1 || yOfPoint < -1;

if (isInCircle && outsideRect) {
    console.log('Point is in the circle and outside rectangle!');
} else {
    console.log('Point is either outside circle or inside rectangle :(');
}
