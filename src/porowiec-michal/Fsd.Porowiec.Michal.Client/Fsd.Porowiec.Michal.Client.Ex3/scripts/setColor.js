var app = app || {};

(function(){
    var getColor = function(e) {
        var selectedDivColor = window.getComputedStyle(e.target, null).backgroundColor;

        $("#chosen-color").css('background-color', selectedDivColor)

        $("#chosen-color-text").text("Chosen Color: " + $(e.target).attr("data-color-name"))

    }

    $(".color-choice").on("click", getColor)

}())