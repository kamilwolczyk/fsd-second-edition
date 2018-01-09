var app = app || {};

(function () {
    function answerClickEvent(event) {
        const answer = event.target;
        app.viewManager.clearSelect();
        answer.classList.add('selected');
    };

    function startButtonClickEvent() {
        document.getElementById('start-button').style.display = 'none';
        document.querySelector('.container').style.display = 'block';
        app.quiz.nextQuestion();
        document.getElementById('next-button').style.display = 'block';
    }

    function nextButtonClickEvent() {
        const selected = document.querySelector('.selected');
        const ACTUAL_COUNT = parseInt(document.getElementById('counter').getAttribute('question-count'), 10);

        if (selected == null) {
            return;
        };

        app.quiz.setAnswer(ACTUAL_COUNT, selected.textContent);
        app.viewManager.clearSelect();

        if (ACTUAL_COUNT == app.quiz.getQuestionsAmount()) {
            app.viewManager.printScore(app.quiz.getScore());
        }
        else {
            app.quiz.nextQuestion();
        };
    };

    app.clickEvents = {
        answerClick: answerClickEvent,
        startClick: startButtonClickEvent,
        nextClick: nextButtonClickEvent
    };
})();