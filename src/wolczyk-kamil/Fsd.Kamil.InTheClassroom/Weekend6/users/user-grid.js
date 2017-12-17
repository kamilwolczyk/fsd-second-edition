var app = app || {};

(function () {
    let gridBody;

    function initialize() {
        gridBody = $('#user-grid tbody');
    }

    function addItem(person) {
        var data = [
            person.firstName,
            person.lastName,
            person.email,
        ];

        gridBody.append(app.grid.createAndFillRow(data));
    }

    app.userGrid = {
        initialize: initialize,
        addItem: addItem
    };
})();