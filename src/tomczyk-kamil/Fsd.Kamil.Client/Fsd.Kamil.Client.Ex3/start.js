$(document).ready(function(){

    let colors = ['red', 'blue', 'green', 'pink','yellow'];
    let colorPickerSide = $('#color-options');
    let att = 'start-color';

    colors.forEach(function (color) {
        
        var item = $('<div></div>')
        .addClass('square ' + color)
        .attr(att, color)
        colorPickerSide.append(item);
        })
});