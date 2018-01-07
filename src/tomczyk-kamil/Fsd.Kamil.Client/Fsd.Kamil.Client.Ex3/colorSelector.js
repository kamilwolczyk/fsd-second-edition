var app = app || {};

(function () {
    function initialize() {
        document.querySelectorAll('#color-options').forEach(function (item) {
            item.addEventListener('click', ColorPickerHandler);
        });
    }

    function ColorPickerHandler(event) {

        let colorOptions = $('#color-options');
        let colorChoice = $('#color-choice');        
        let selectedItem = $(event.target);
        let selectedColor = selectedItem.attr('start-color');
        let newColor = $('#selected-color')
        let shadow = $('selected');
        
        newColor.html(selectedColor);

        colorChoice.removeClass();        
        colorChoice.addClass(selectedColor);
        selectedItem.addClass(shadow);
    }

    app.colorSelector = {
        initialize: initialize
    };
})();