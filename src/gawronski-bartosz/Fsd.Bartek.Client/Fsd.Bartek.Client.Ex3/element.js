var app = app || {};

(function(){
    var squre = $('.squre');

    function initialize(){
        squre.map(function(){
            let color = $(this).attr('data-color');
            $(this).css('background-color', color)
        });
    }

    app.element = {
        init: initialize
    }
}());