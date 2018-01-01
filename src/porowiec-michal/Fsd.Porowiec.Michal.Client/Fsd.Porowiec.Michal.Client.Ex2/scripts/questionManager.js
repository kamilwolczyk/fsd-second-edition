var app = app || {};

(function(){
    var properAnswer;
    var questionCounter;
    var questionNumber;
    var score = 0;
    var changeQuestion = function(data) { 
        document.getElementById('quiz-answer-button').addEventListener('click', (e) => {
            app.questionChanger(e);
        })
    }

    var questionManagerInvoker = function(data, _questionNumber) {
        questionNumber = _questionNumber;
        properAnswer = data[0].correctAnswer;

        app.questionDisplay.questionDisplayInvoker(data[0], 1, _questionNumber);

        questionCounter = 2;

        app.visualSiteChanges.visualAsyncInvoke();

        changeQuestion(data);
    }

    app.questionManager = {
        questionManagerInvoker : questionManagerInvoker
    }
}())