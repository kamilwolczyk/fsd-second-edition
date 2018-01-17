var app = app || {};

(function () {
    let colors = [
        'red',
        'blue',
        'green',
        'black',
        'white',
        'gray',
        'yellow',
        'orange',
        'purple',
    ];

    function initialize() {
        const palette = document.querySelector('#color-palette');

        colors.forEach(function (color) {
            palette.appendChild(document.createElement('div')).classList.add('tile', color);
        });

        palette.querySelectorAll('.tile').forEach(function (item) {
            item.addEventListener('click', app.clickEvents.tileClick);
        });
    };

    app.palette = {
        initialize: initialize
    };
})();