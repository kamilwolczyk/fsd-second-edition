var app = app || {};

(function(){
    var setSelected = function(e) {
        $(".color-choice").removeClass("color-choice-selected");
   
        $(e.target).addClass("color-choice-selected");
    }

    $(".color-choice").on("click", setSelected)
}())