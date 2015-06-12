String.prototype.bind = function(element, object) {
	var prop,
		regex,
		element = this;

	for (prop in object) {
		regex = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(</.*?>)');

		element = element.replace(regex, function(match, p1, p2, p3){
			return p1 + object[prop] + p3;
		});

		regex = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>');

		element = element.replace(regex, function(match, p1) {
			return p1 + ' href="' + object[prop] + '">';
		});

		regex = new RegExp('(<.*?data-bind-class="' + prop + '".*?)>');

		element = element.replace(regex, function(match, p1) {
			return p1 + ' class="' + object[prop] + '">';
		});
	}

	return element;
}

var element = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>';

console.log(element.bind(element, {name: 'Elena', link: 'http://telerikacademy.com'}))