var app = app || {};

(function(){
    var correctAnswer;

    function check(answer) {        
        return correctAnswer === answer;
    }

    function elementText(){
        var questions = app.apiControler.getQuestion();

        if(questions === null){
            app.answerControler.summary();
        }else{
            app.userInterface.elementText(`Question ${questions.number+1}/10`,questions.question,questions.answer);
            correctAnswer = questions.answer[0];
        }
    }

    app.service = {
        check: check,
        elementText: elementText
    }
}());