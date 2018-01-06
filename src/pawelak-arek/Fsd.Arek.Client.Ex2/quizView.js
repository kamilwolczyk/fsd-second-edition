var quizView = quizView || {};

(function () {

    var showQuestion = function (questionModel) {
        quizWindow.question.html(questionModel);
    }

    var showAnswer = function (questionModel) {
        if ($('.answer-box').length != 0) {
            $('.answer-box').remove();
        }

        for (var i = 0; i < questionModel.length; i++) {
            quizWindow.answerContainer.append($("<div>").addClass('answer-box').html(questionModel[i]).attr("onClick", "app.quizController.checkAnswer(event)"));
        }
    }

    var showScore = function (text) {
        $('.answer-box').remove();
        quizWindow.question.html(text);
    }

    var setBackgroundAnswerBox = function (color) {
        $('.answer-box').css('background-color', color);
    }

    quizView.showQuestion = showQuestion;
    quizView.showAnswer = showAnswer;
    quizView.showScore = showScore;
    quizView.setBackgroundAnswerBox = setBackgroundAnswerBox;
})();