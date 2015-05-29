var text = 'This is just some test sample text to test the test script Test.',
    searchedWord = 'test';

findOccurences(text, searchedWord);

function findOccurences(text, word) {
    var counts = 0,
        lastFoundIndex = 0;

    for (;;) {
        lastFoundIndex = text.toLowerCase().indexOf(searchedWord, lastFoundIndex + 1);
        if (lastFoundIndex !== -1) {
            counts += 1;
        } else {
            break;
        }
    }

    console.log(text);
    console.log('The number of occurences of the word \'' + searchedWord + '\' is ' + counts);
}
