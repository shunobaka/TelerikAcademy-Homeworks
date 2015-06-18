var a = 5.5,
	b = 4.5,
	temp;

if (a > b) {
    temp = a;
    a = b;
    b = temp;
}

console.log(a + ' ' + b);
