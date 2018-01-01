var app = app || {};

(function() {
    var questionChanger = function (e) {
        if(Array.from(document.getElementsByClassName('quiz-answer-choosed')).length < 1) {
            return;
        };
        
        if(questionCounter <= questionNumber) {

            app.questionDisplay.questionDisplayInvoker(data[questionCounter-1], questionCounter, questionNumber)

            if(app.questionCounter.checkAnswer(properAnswer)) {
                score++
            }

            properAnswer = data[questionCounter-1].correctAnswer;
            
            questionCounter++
        }
        else {
            app.visualSiteChanges.viewChanger(score,questionNumber);
        }
        app.visualSiteChanges.resetBackgrounds(e);
    }

    app.questionChanger = questionChanger;
}())