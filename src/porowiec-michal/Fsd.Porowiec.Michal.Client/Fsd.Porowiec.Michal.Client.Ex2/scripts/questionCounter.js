var app = app || {}; 

(function(){
    var chosenAnswer;

    document.querySelectorAll(".quiz-answer").forEach(el => el.addEventListener("click", (e) => {
    chosenAnswer = e.target.innerHTML
    }));

    var checkAnswer = function(correctAnswer) {
        if(chosenAnswer == correctAnswer) {
             return true;
        }
        else {
            return false;
        }
    }
    
    app.questionCounter = {
        checkAnswer : checkAnswer
    }
}())