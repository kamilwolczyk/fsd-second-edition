var app = app || {};

(function() {
    var questionNumber = 5;
    
    app.questionGetter.getQuestions(questionNumber, data => {
        app.questionManager.questionManagerInvoker(data, questionNumber);
    })
}())