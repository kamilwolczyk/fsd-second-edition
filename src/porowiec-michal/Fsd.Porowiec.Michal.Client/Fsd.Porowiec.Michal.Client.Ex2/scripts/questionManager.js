var app = app || {};

(function(){
    var properAnswer;
    var questionCounter;
    var questionNumber;
    var score = 0;
    var changeQuestion = function(data) { 
        document.getElementById('quiz-answer-button').addEventListener('click', (e) => {
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