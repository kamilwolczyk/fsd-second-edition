var app = app || {};

(function(){
    var divColors = [
        new divColor("rgb(255, 0, 0)","Red"),
        new divColor("rgb(0, 255, 0)","Green"),
        new divColor("rgb(0, 0, 255)","Blue"),
        new divColor("rgb(0, 0, 0)","Black"),
        new divColor("rgb(255, 255, 255)","White"),
        new divColor("rgb(255,255,0)","Yellow"),
        new divColor("rgb(0,255,255","Light Blue"),
        new divColor("rgb(255,0,255)","Purple"),
        new divColor("rgb(100,100,100","Dark Gray")
    ];

    var divFabric = function() {
        divColors.forEach( (el,i) => {
            $('<div/>', {
                id: "color-choice" + i+1,
                class: "color-choice",
                style: "background-color: " + el.color,
                "data-color-name": el.colorName
            }).appendTo("#color-choice-section");
        })
    }

    divFabric()

    app.createDivs = {
        divColors: divColors
    }
}())