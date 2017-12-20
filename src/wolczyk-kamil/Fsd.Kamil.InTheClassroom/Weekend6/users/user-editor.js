var app = app || {};

(function () {
    let firstNameField,
        lastNameField,
        emailField;

    function getItem() {
        return new Person(firstNameField.val(), lastNameField.val(), emailField.val());
    }

    function setItem(item) {
        firstNameField.val(item.firstName);
        lastNameField.val(item.lastName);
        emailField.val(item.email);
    }

    function clear() {
        setItem(new Person('', '', ''));
    }

    function addPerson() {
        if (!validate()) {
            app.alertManager.add('Formularz jest niepoprawny');
            return;
        }

        app.userGrid.addItem(getItem());
        clear();
    }

    function validate() {
        return false;
    }

    function initialize() {
        let form = $('#user-form');
        firstNameField = form.find('#first-name');
        lastNameField = form.find('#last-name');
        emailField = form.find('#email');

        form.bind('reset', clear);
        form.submit(function (event) {
            event.preventDefault();
            addPerson();
        });

        $('#show').click(() => {
            $('#user-form').show('slow');
        });

        $('#hide').click(() => {
            $('#user-form').hide('slow');
        });
    }

    app.userEditor = {
        initialize: initialize
    };
})();