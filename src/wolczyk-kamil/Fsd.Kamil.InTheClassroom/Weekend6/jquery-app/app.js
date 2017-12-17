$(document).ready(function () {
    $('.link-button').click(event => {
        var button = $(event.target);
        var url = `parts/${button.attr('data-url')}`;
        $('#part-page').load(url);
    });

    console.log('Document has been loaded');
});