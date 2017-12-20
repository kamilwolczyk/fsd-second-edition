var app = app || {};

(function () {
    function initialize() {
        document.querySelectorAll('.answer').forEach(function(item){
            item.addEventListener('click', checkAnswer);
        });

        document.getElementById('next-question').addEventListener('click', nextQuestion)
    }

    function checkAnswer(event) {
        const DATA_ANSWER = 'data-answer';
        const button = event.target;
        let correct = app.service.check(button.getAttribute(DATA_ANSWER));

        if(correct){
            app.userInterface.changeButton(false,button);
        }else{
            app.userInterface.changeButton(false,null);
        }
    }

    function nextQuestion() {
        //console.log("work");
        app.userInterface.changeButton(true);
        //TODO: implementation
    }

    app.answerControler = {
        initialize: initialize
    };
}());