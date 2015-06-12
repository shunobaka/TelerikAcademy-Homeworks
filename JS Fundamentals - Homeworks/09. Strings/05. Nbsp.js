var text = 'This is   some   random function    which replaces  stuff  .';

var result = replaceNbsp(text);

console.log(result);

function replaceNbsp(text) {
	while (text.indexOf(' ') !== -1) {
		return text.replace(/ /g, '&nbsp;');
	}
}