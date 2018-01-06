var app = app || {};

(function () {
    function answerClickEvent(event) {
        const answer = event.target;
        app.helpers.clearSelect();
        answer.classList.add('selected');
    };

    app.clickEvents = {
        answerClick: answerClickEvent,
    };
})();