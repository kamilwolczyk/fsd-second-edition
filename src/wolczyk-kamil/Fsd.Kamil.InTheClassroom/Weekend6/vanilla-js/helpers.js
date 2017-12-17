var app = app || {};

(function () {
    function setTwoDigits(value) {
        return value > 9 ? value : `0${value}`;
    }

    app.helpers = {
        setTwoDigits: setTwoDigits
    };
})();