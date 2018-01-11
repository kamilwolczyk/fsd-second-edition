var app = app || {};

(function () {

    var initialize = function(event){
        app.quizController.checkAnswer(event);
        quizView.setAnswerBoxColor(event);
    };
    
    app.eventDispatcher = {
        initialize: initialize,
    }
})();