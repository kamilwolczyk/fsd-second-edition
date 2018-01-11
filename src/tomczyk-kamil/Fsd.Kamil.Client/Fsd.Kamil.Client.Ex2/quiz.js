var app = app || {};

(function () {
    
    let questions = [];
    let currentQuestion = 0;
    let score = 0;
    let questionsCount=3;

    let opt1 = document.getElementById('opt1');
    let opt2 = document.getElementById('opt2');
    let opt3 = document.getElementById('opt3');
    let opt4 = document.getElementById('opt4');

    let nextButton = document.getElementById('next-button');
    let result = document.getElementById('quiz-result');    
    let countAttri = 'count';
    
    function initialize() {

        var http = new XMLHttpRequest();
        
        http.onreadystatechange = function () {
            if (http.readyState == 4 && http.status == 200) {
                questions = JSON.parse(http.responseText).results;
                //to dla mnie notatki:) 4 oznacza, że 'complete', a 200, że 'success', standardowy zapis            
                app.question.initialize(questions, currentQuestion); //pierwsze załadowanie pytania
            };
        };

        http.open("GET", `https://opentdb.com/api.php?amount=${questionsCount}&&category=12&difficulty=easy&type=multiple`, true);
        http.send();
    };

    function nextQuestion() {

        currentQuestion = parseInt(questionCounter.getAttribute(countAttri), 10); //czytamy numer aktualnego pytania
        let selectedOption = document.querySelector('input[type=radio]:checked');
        let totalQuestions = questions.length;
        let answerValue = selectedOption.value;
        let answer = document.getElementById('opt' + answerValue);
        
        if (!selectedOption) {
            alert('Nie została wybrana żadna odpowiedź!');
            return;
        }
     
        // console.log(questions[currentQuestion].correct_answer);
        if(questions[currentQuestion].correct_answer == answer.textContent){
            score=score+1;
        }
    
        selectedOption.checked = false;
        currentQuestion++;

        if(currentQuestion == totalQuestions -1) {
            nextButton.textContent = 'Sprawdź wynik';
        }
            
        if(currentQuestion == totalQuestions){
            result.style.display = '';            
            result.innerHTML = "Twój wynik to: " + score + "/" + totalQuestions;
            nextButton.style.visibility = 'hidden';
            setTimeout(function() {
               location.reload();
            }, 5000);
            return;
        }

        questionCounter.setAttribute(countAttri, currentQuestion) //nadajemy nowy numer w atrybucie    
        app.question.loadQuestion(questions, currentQuestion);
    }

    app.quiz = {
        initialize: initialize,
        nextQuestion: nextQuestion
    };
})();