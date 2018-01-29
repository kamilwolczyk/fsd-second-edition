var app = app || {};

(function () {
    function initialize() {
        document.querySelectorAll('.gate').forEach(function (item) {
            item.addEventListener('click', gateClickEventHandler);

            if (!app.test) {
                console.error('Test module is not defined!');
            }

            app.test.sayHello();
        });
    }

    function gateClickEventHandler(event) {
        const COUNT_ATTRIBUTE = 'data-count';
        const gate = event.target;
        let count = gate.getAttribute(COUNT_ATTRIBUTE);
        count = parseInt(count, 10) + 1;

        gate.setAttribute(COUNT_ATTRIBUTE, count);
        gate.querySelector('span').innerText = count;

        app.log.addNewLog(`Kliknieto bramke numer ${gate.getAttribute('id')}`);
    }

    app.counter = {
        initialize: initialize
    };
})();