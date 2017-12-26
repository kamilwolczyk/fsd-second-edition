var app = app || {};

(function(){
    var picker = $('.picker');

    function initialize(){
        $('.squre').click(function(item){
            let color = $(item.target).attr('data-color');
            $(picker).css('background-color', color)
        });
    }

     app.colorPicker = {
        init: initialize
     }
}());