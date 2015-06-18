var frmt = '{0}, {1}, {0} text {2}';

var result = stringFormat(frmt, 1, 'Pesho', 'Gosho');

console.log(result);

function stringFormat() {
    var placeholder,
        index,
        argsLen,
        args = arguments,
        text = args[0];

    for (index = 1, argsLen = args.length; index < argsLen; index += 1) {
    	placeholder = '{' + (index - 1) + '}';

    	while (text.indexOf(placeholder) !== -1) {
    		text = text.replace(placeholder, args[index]);
    	}
    }

    return text
}
