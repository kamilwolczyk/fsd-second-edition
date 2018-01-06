var app = app || {};

(function () {
    const COUNT_ATTRIBUTE = 'question-count';
    const COUNTER = document.getElementById('counter');
    const QUESTIONS_AMOUNT = 3;
    var questions = [];
    var answers = [];

    function initialize() {
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                questions = JSON.parse(this.responseText).results;

                app.helpers.createAnswerFields(4);
                nextQuestion();
            };
        };
        xhttp.open("GET", `https://opentdb.com/api.php?amount=${QUESTIONS_AMOUNT}&type=multiple`, true);
        xhttp.send();
    };

    function nextButtonClickEvent() {
        const SELECTED = document.querySelector('.selected');
        const ACTUAL_COUNT = parseInt(COUNTER.getAttribute(COUNT_ATTRIBUTE), 10);
        if (SELECTED == null) {
            return;
        };

        answers[ACTUAL_COUNT - 1] = SELECTED.textContent;
        app.helpers.clearSelect();

        if (ACTUAL_COUNT == QUESTIONS_AMOUNT) {
            app.helpers.printScore(getScore());
        }
        else {
            nextQuestion();
        };
    };

    function getScore() {
        var score = 0;
        for (i = 0; i < questions.length; i++) {
            if (answers[i] == questions[i].correct_answer) {
                score++;
            }
        };
        return `${score}/${QUESTIONS_AMOUNT} (${Math.round(score / QUESTIONS_AMOUNT * 1000) / 10}%)`;
    };

    function nextQuestion() {
        var count = parseInt(COUNTER.getAttribute(COUNT_ATTRIBUTE), 10);
        app.questionPrinter.initialize(questions, count);
        count++;
        COUNTER.setAttribute(COUNT_ATTRIBUTE, count);
    };

    app.quiz = {
        initialize: initialize,
        nextClick: nextButtonClickEvent
    };
})();