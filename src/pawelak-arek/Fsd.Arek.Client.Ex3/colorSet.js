var app = app || {};

(function () {
    function initialize() {
        $('.box').click(function () {
            var color = $(this).attr('dataColor');
            $('#box-color-selected').css('background', color);
        });
    }

    app.colorSet = {
        initialize: initialize
    };
})();