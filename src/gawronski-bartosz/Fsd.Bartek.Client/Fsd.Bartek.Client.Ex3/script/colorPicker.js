var app = app || {};

(function(){
    var picker = $('.picker');
    var name = $('.name');

    function initialize(){
        $('.squre').click(function(item){
            let id = $(item.target).attr('id');
            app.addSqure.squres.forEach(function(squre){
                if(squre.id == id){
                    $(picker).css('background-color', squre.color);
                    $(name).text(`${squre.name}`);
                }
            });
        });
    }

     app.colorPicker = {
        init: initialize
     }
}());