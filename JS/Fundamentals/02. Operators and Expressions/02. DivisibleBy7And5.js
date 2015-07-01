var testIntOne = 35;
var testIntTwo = 30;

function CheckIfDevisible(number) {
    if (!(number % 5) && !(number % 7)) {
        console.log('Number is devisible by 7 and 5!');
    } else {
        console.log('Number is not devisible by 7 and 5 at the same time!');
    }
}

console.log('Checking for 35:');
CheckIfDevisible(testIntOne);
console.log('Checking for 30:');
CheckIfDevisible(testIntTwo);
