var app = app || {};

(function () {
    function initialize(questions, number) {
        printQuestion(questions, number);
        printAnswers(questions[number])
    };


    function printQuestion(questions, number) {
        document.getElementById('category').innerHTML = questions[number].category;
        document.getElementById('counter').innerHTML = `${number + 1} / ${questions.length}`;
        document.getElementById('question-text').innerHTML = questions[number].question;
    };

    function printAnswers(question) {
        var answers = [];

        answers.push(question.correct_answer);
        answers = answers.concat(question.incorrect_answers);

        const answersAmount = answers.length;

        app.viewManager.removeAllAnswerFields();
        app.viewManager.createAnswerFields(answersAmount);

        for (i = 0; i < answersAmount; i++) {
            var randomAnswer = answers[Math.floor(Math.random() * answers.length)];
            document.getElementById(`answer${i + 1}`).innerHTML = randomAnswer;
            answers.splice(answers.indexOf(randomAnswer), 1);
        };
    };

    app.questionPrinter = {
        initialize: initialize
    };
})();