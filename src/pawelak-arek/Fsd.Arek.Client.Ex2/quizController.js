var app = app || {};

(function () {
    var questionData;
    var indexQuestion = 0;
    correct_answer = false;

    var createQuiz = function (data) {
        var count = 0;
        questionData = data;
        quizStatus = false;

        quizView.showQuestion(questionData[indexQuestion].question);
        quizView.showAnswer(questionData[indexQuestion].answer);

        quizWindow.buttonNext.click(
            function () {
                indexQuestion++;
                correct_answer === true ? count++ : count;

                if (indexQuestion < questionData.length) {
                    quizView.showQuestion(questionData[indexQuestion].question);
                    quizView.showAnswer(questionData[indexQuestion].answer);
                } else {
                    quizView.showScore(count);
                }
            }
        )
    };

    function checkAnswer(event) {
        text = $(event.target).text();
        questionData[indexQuestion].correct_answer == text ? correct_answer = true : correct_answer = false;
    }

    app.quizController = {
        initialize: createQuiz,
        checkAnswer: checkAnswer
    }
})();