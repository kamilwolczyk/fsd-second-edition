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
        'purple'
    ];

    function initialize() {
        const palette = document.querySelector('#color-palette');

        colors.forEach(function (color) {
            palette.appendChild(document.createElement('div')).classList.add('square', color);
        });

        palette.querySelectorAll('.square').forEach(function (item) {
            item.addEventListener('click', squareClickEventHandler);
        });
    };

    function squareClickEventHandler(event) {
        const square = event.target;
        const rectangle = document.querySelector('.rectangle');

        if (document.getElementById('selected')) {
            document.getElementById('selected').removeAttribute('id');
        };

        square.id = "selected";

        if (rectangle.classList.item(1)) {
            rectangle.classList.remove(rectangle.classList.item(1));
        };
        rectangle.classList.add(square.classList.item(1));
        
        document.getElementById('name-of-selected').textContent=`Color selected: ${rectangle.classList.item(1)}`;
    };

    app.palette = {
        initialize: initialize
    };
})();