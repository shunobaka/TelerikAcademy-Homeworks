var text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
	searchedSubStr = 'in';

var countOfSubs = occurencesOfSubString(text, searchedSubStr);

console.log('There are ' + countOfSubs + ' occurences of "' + searchedSubStr + '" in the text!');

function occurencesOfSubString(text, substring) {
	var lastFoundIndex = -1,
		count = 0;

	while (text.indexOf(substring, lastFoundIndex + 1) !== -1) {
		lastFoundIndex = text.indexOf(substring, lastFoundIndex + 1);
		if (lastFoundIndex !== -1) {
			count++;
		}
	}

	return count;
}