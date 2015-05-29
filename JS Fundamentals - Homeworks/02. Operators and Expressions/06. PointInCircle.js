var xOfPoint = 1.5;
var yOfPoint = -3;
var radius = 5;

var isInCircle = (xOfPoint * xOfPoint + yOfPoint * yOfPoint) <= radius * radius;

console.log('The point is in the circle: ' + isInCircle);