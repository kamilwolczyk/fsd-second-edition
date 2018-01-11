var app = app || {};

(function () {
    function initialize() {
        document.querySelectorAll('#color-options').forEach(function (item) {
            item.addEventListener('click', colorPickerHandler);
        });
    }

    function colorPickerHandler(event) {

        let colorChoice = $('#color-choice');        
        let selectedItem = $(event.target);
        let selectedColor = selectedItem.attr('start-color');
        let newColor = $('#selected-color')
        //let shadow = $('selected'); // w CSS
        
        newColor.html(selectedColor);

        colorChoice.removeClass();        
        colorChoice.addClass(selectedColor);
        //selectedItem.addClass(shadow);// w CSS
    }

    app.colorSelector = {
        initialize: initialize
    };
})();