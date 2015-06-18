var numberN = 57,
	count;

for (count = 1; count <= numberN; count += 1) {
    if ((count % 3) && (count % 7)) {
        console.log(count);
    }
}
