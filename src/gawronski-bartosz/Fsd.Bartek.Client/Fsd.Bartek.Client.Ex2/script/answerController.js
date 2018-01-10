var app = app || {};

(function () {
    var correctCount = 0;
    var correctAnswer;

    function initialize() {
        

        document.querySelectorAll('.answer').forEach(function(item){
            item.addEventListener('click', checkAnswer);
        });

        document.getElementById('next-question').addEventListener('click', nextQuestion);

        app.service.elementText();
    }

    function checkAnswer(event) {
        const button = event.target;
        let correct = app.service.check(button.innerText);

        if(correct){
            app.userInterface.changeButton(false,button);      
            correctAnswer = true;
        }else{
            app.userInterface.changeButton(false,button);
            correctAnswer = false;
        }
    }

    function nextQuestion() {
        var questions;
        if(correctAnswer){
            correctCount++;
        }

        app.userInterface.changeButton(true);
        app.service.elementText();
    }

    function summary(){
        app.userInterface.summaryDisplay(correctCount);
    }

    app.answerController = {
        initialize: initialize,
        summary: summary
    };
}());