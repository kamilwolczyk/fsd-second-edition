$(document).ready(function () {
  var linkButtons = $('.contentLink');

  linkButtons.click(function () {
    var link = $(this).attr('data-link');
    $('#content').load(link);
  });

  linkButtons.first().click();
});
