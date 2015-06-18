var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

var output = replaceTags(input);

console.log(output);

function replaceTags(input) {
	var openTagTillURL = input.indexOf('<a href="');;

	while (openTagTillURL !== -1) {
		input = input.replace('<a href="', '[URL=').replace('">', ']').replace('</a>', '[/URL]');
		openTagTillURL = input.indexOf('<a href="');
	}

	return input;
}