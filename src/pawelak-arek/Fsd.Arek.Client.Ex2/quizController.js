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
                if (!quizStatus) {
                    indexQuestion++;
                    correct_answer === true ? count++ : count;

                    if (indexQuestion < questionData.length) {
                        quizView.showQuestion(questionData[indexQuestion].question);
                        quizView.showAnswer(questionData[indexQuestion].answer);
                    } else {
                        quizView.showScore(count);
                        quizWindow.buttonNext.text('Play again?');
                        quizStatus = true;
                    }
                } else {
                    resetQuizController();
                    //nie działa :)
                    // app.start();
                }
            }
        )
    };

    function resetQuizController() {
        indexQuestion = 0;
        correct_answer = false;
    }

    function checkAnswer(event) {

        quizView.setBackgroundAnswerBox('rgb(173, 173, 20)');
        $(event.target).css('background-color', 'red');
        text = $(event.target).text();

        if (questionData[indexQuestion].correct_answer == text) {
            correct_answer = true;
        } else {
            correct_answer = false;
        }
    }

    app.quizController = {
        initialize: createQuiz,
        checkAnswer: checkAnswer
    }
})();