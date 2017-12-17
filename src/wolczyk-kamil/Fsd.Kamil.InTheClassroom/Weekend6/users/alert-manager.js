var app = app || {};

(function () {
    let alertContainer;

    function initialize() {
        alertContainer = $('#alert-container');
    }

    function add(message) {
        var item = $('<div></div>')
            .attr('role', 'alert')
            .addClass('alert alert-danger')
            .text(message);

        alertContainer.append(item);

        setTimeout(() => {
            item.remove();
        }, 2000);
    }

    function clear(text) {
        alertContainer.empty();
    }

    app.alertManager = {
        add: add,
        clear: clear,
        initialize: initialize
    };
})();