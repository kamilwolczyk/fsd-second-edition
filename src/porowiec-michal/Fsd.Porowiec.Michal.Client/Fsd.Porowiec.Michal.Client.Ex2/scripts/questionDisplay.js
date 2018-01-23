var app = app || {};

(function(){
    var questionDisplayInvoker = function(data,currentQuestionNumber, questionNumber) { 
        divTextOutput(data, currentQuestionNumber, questionNumber);
    }

    var divTextOutput = function(data, currentQuestionNumber, questionNumber) {
        var allAnswers = [];
        allAnswers.push(data.correctAnswer,data.incorrectAnswers[0],data.incorrectAnswers[1],data.incorrectAnswers[2]);
        allAnswers = app.helpers.shuffle(allAnswers);

        app.helpers.putText("quiz-header","Question " + currentQuestionNumber + '/' + questionNumber)
        app.helpers.putText("quiz-text",data.question)
        for(var i = 0; i < 4; i++) {
            app.helpers.putText("quiz-answer" + (i+1) ,allAnswers[i])
        }
    }

    app.questionDisplay = {
        questionDisplayInvoker: questionDisplayInvoker
    }
}())