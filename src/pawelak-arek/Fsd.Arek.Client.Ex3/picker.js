var app = app || {};

(function () {
    const COLOR_PALLETE = ["#ad1818", "#7FFF00", "#DC143C", "#006400", "#8FBC8F", "#696969", "blue"];

    function initialize() {
        var i;
        var item = '.box';
        for (i = 0; i < COLOR_PALLETE.length; i++) {
            $('#color-picker').append('<div class="box" dataColor=' + COLOR_PALLETE[i] + ' >' + i + '</div>');
        }
        setBackground(item);
    };

    function setBackground(item) {
        i = 0;
        $(item).each(function () {
            $(this).css('background', COLOR_PALLETE[i++]);
        });
    }

    app.picker = {
        initialize: initialize
    };
})();