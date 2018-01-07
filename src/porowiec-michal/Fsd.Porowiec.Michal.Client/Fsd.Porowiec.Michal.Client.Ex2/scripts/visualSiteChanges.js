var app = app || {};

(function() {
    function answerButtonClicked(e) { 
        changeAnswerBackground(e);
    }
    
    function changeAnswerBackground(e) {
        var a = document.getElementsByClassName(event.target.className.split(' ')[0])
        Array.from(a).forEach( el => el.classList.remove("quiz-answer-choosed"))

        var choosedElement = document.getElementById(e.target.id)
        choosedElement.classList.add('quiz-answer-choosed')
    } 

    function resetBackgrounds(){
        var a = document.getElementsByClassName('quiz-answer-choosed')
        Array.from(a).forEach( el => el.classList.remove("quiz-answer-choosed"))
    }

    function viewChanger(score,questionNumber) { 
        document.getElementById('quiz-question').classList.add('quiz-question-hide')
        document.getElementById('quiz-summary').classList.add('quiz-summary-show')
        document.getElementById('score-input').innerText = `You've got ${score} on ${questionNumber} points.`;
    }

    function visualAsyncInvoke() {
        document.querySelectorAll(".quiz-answer").forEach(el => el.addEventListener("click",answerButtonClicked ))
        document.querySelector("#site-hidder").classList.add('site-hidder-hide');        
    }
    app.visualSiteChanges = {
        visualAsyncInvoke: visualAsyncInvoke,
        viewChanger: viewChanger,
        resetBackgrounds: resetBackgrounds
    }
}())