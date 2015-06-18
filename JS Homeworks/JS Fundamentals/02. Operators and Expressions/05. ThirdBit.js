var number = 62241;
var mask = 1 << 3;
var thirdBit = (number & mask) >> 3;

console.log('The third bit is: ' + thirdBit);