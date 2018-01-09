var app = app || {};

(function () {
    const QUESTIONS_AMOUNT = 5;
    const API_URL = `https://opentdb.com/api.php?amount=${QUESTIONS_AMOUNT}`;
    var questions = [];
    var answers = [];

    function initialize() {
        app.ajaxReader.getObjectFromApi(API_URL, function (object) {
            questions = object.results;
        });
    };

    function setAnswer(number, answer) {
        answers[number - 1] = answer;
    };

    function getQuestionsAmount() {
        return QUESTIONS_AMOUNT;
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
        const COUNT_ATTRIBUTE = 'question-count';
        const counter = document.getElementById('counter');

        var count = parseInt(counter.getAttribute(COUNT_ATTRIBUTE), 10);
        count++;
        counter.setAttribute(COUNT_ATTRIBUTE, count);

        app.questionPrinter.initialize(questions, count - 1);
    };

    app.quiz = {
        initialize: initialize,
        setAnswer: setAnswer,
        getQuestionsAmount: getQuestionsAmount,
        getScore: getScore,
        nextQuestion: nextQuestion
    };
})();