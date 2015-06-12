String.prototype.format = function(options) {
	var option,
		toReplace,
		str = this;

	for (option in options) {
		toReplace = new RegExp('#{' + option + '}');
		str = str.replace(toReplace, options[option]);
	}

	console.log(str);
}

var options = {name: 'John'};
'Hello, there! Are you #{name}?'.format(options);

options = {name: 'John', age: 13};
'My name is #{name} and I am #{age}-years-old'.format(options);