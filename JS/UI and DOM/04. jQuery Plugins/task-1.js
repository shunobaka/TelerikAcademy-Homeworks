function solve() {
    return function(selector) {
    	var $select = $(selector).hide();
    	var $selectParent = $select.parent();
    	var $container = $('<div />')
    		.addClass('dropdown-list')
    		.append($select);
    	var $currentSelection = $('<div class="current" data-value />')
    		.html('Select a value')
    		.appendTo($container);
    	var $optionsContainer = $('<div />')
    		.addClass('options-container')
    		.css({
    			'position': 'absolute',
    			'display': 'none'
    		})
    		.appendTo($container);
    	
    	$select.children().each(function(index, option) {
    		var $option = $('<div />')
    			.addClass('dropdown-item')
    			.attr('data-value', $(option).attr('value'))
    			.attr('data-index', index)
    			.html($(option).html())
    			.appendTo($optionsContainer);
    	});

    	$currentSelection.on('click', function() {
    		$optionsContainer.toggle();
    	});

    	$optionsContainer.on('click', '.dropdown-item', function() {
    		var $this = $(this);

    		$currentSelection.html($this.html());
    		$select.val($this.attr('data-value'));
    		$optionsContainer.hide();
    	});

    	$selectParent.prepend($container);
    };
}
