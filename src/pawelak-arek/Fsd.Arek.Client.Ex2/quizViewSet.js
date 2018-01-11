var quizView = quizView || {};

(function () {

    var setBackgroundAnswerBox = function (color) {
        $('.answer-box').css('background-color', color);
    }

    var setAnswerBoxColor = function(event){
        quizView.setBackgroundAnswerBox('rgb(173, 173, 20)');
        $(event.target).css('background-color', 'red');
    }

    quizView.setBackgroundAnswerBox = setBackgroundAnswerBox;
    quizView.setAnswerBoxColor = setAnswerBoxColor;
})();