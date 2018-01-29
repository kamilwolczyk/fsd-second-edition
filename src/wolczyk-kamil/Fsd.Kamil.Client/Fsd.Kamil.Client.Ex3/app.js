$(document).ready(function () {
  var COLORS = [
    'red',
    'blue',
    'green',
    'black',
    'white',
    'silver',
    'yellow',
    'orange',
    'purple',
  ];

  var COLOR_ATTR = 'data-color';
  var SELECTED_ITEM_CLASS = 'selected';

  var selectorPanel = $('#selector-panel');
  var previewBox = $('#preview-box');

  var selectColor = function (event) {
    var selectedItem = $(event.target);
    var selectedColor = selectedItem.attr(COLOR_ATTR);

    previewBox.removeClass();
    $('.selector-color').removeClass(SELECTED_ITEM_CLASS);

    selectedItem.addClass(SELECTED_ITEM_CLASS);
    previewBox.addClass(selectedColor);
    $('#selected-color-name').html(selectedColor);
  }

  COLORS.forEach(function (color) {
    var item = $('<div></div>')
      .addClass('selector-color')
      .addClass(color)
      .attr(COLOR_ATTR, color)
      .click(selectColor);

    selectorPanel.append(item);
  })
});