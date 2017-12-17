var app = app || {};

(function () {
    function initialize() {
        displayTime();
        setInterval(displayTime, 1000);
    }

    function displayTime() {
        const date = new Date(),
            hoursNode = document.getElementById('hours'),
            minutesNode = document.getElementById('minutes'),
            secondsNode = document.getElementById('seconds');

        hoursNode.innerText = app.helpers.setTwoDigits(date.getHours());
        minutesNode.innerText = app.helpers.setTwoDigits(date.getMinutes());
        secondsNode.innerText = app.helpers.setTwoDigits(date.getSeconds());
    }

    app.clock = {
        initialize: initialize
    };
})();