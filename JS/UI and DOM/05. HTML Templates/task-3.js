function solve() {
    return function() {
        $.fn.listview = function(data) {
        	var $this = this;

        	var templateId = $this.attr('data-template');
        	var template = handlebars.compile($('#' + templateId).html());

        	var result = '',
        		index,
        		len;

        	for (index = 0, len = data.length; index < len; index += 1) {
        		result += template(data[index]);
        	}

        	$this.html(result);
        };
    };
}
