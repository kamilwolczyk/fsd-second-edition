var app = app || {};

let questionCounter = document.getElementById('quiz');
let answersCount = 4;
var answers = [];

(function () {
    function initialize(questions, number) {
       loadQuestion(questions, number);
    };

    function loadQuestion (questions, number) {
        questionCounter.innerHTML = questions[number].question;
        //można textContent, ale wtedy czasem zanikało formatowanie
        showAnswers(questions[number]);
    };
   
    function showAnswers(questionNumber) {
        answers.push(questionNumber.correct_answer); // dodanie elementu do tablicy
        answers = answers.concat(questionNumber.incorrect_answers);

        for (i = 0; i < answersCount; i++   ) {
            var randAnswer = answers[Math.floor(Math.random() * answers.length)]; //funkcja z internetu, losowy string z tablicy
            document.getElementById('opt'.concat(i + 1)).innerHTML = randAnswer; //musimy dodać 1, bo tablica od 0
            answers.splice(answers.indexOf(randAnswer), 1); //usuwamy to co właśnie zostało wpisane, samo 'i' nie działało, trzeba pobrać indeks
        };
    };

    app.question = {
        initialize: initialize,
        loadQuestion: loadQuestion,
        showAnswers: showAnswers
    };
})();

//do testów wcześniej, bez JSONa
// var questions = [{
//     "question" : "Kto tam?",
//     "option1": "Ja",
//     "option2": "Ty",
//     "option3": "Nikt",
//     "option4": 'Tamten',
//     "correct_answer": "Nikt"
// },
// {
//     "question" : "Kto tu?",
//     "option1": "Oni",
//     "option2": "My",
//     "option3": "Tamci",
//     "option4": "Żodyn",
//     "correct_answer": "My"
// }]