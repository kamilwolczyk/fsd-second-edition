var app = app || {};

let questionCounter = document.getElementById('quiz');
let answersCount = 2;

(function () {
    function initialize(questions, number) {
       loadQuestion(questions, number);
    };

    function loadQuestion (questions, number) //(questionIndex)
    {
        //tu nie zdążyłem jeszcze, ale można chyba dorobić odpowiedzi w losowej kolejności
        //bo tak to chyba średnio mądry quiz :)
        questionCounter.innerHTML = questions[number].question;
        opt1.innerHTML = questions[number].incorrect_answers[0]// do poprawy [randomIntFromInterval(0,answersCount)]; //
        opt2.innerHTML = questions[number].correct_answer;
        opt3.innerHTML = questions[number].incorrect_answers[1];
        opt4.innerHTML = questions[number].incorrect_answers[2];
        //można textContent, ale wtedy czasem zanikało formatowanie przy pytaniach (apostrof, itp.), tylko do tekstu
    };

    function randomIntFromInterval(min,max) //spróbuję wykorzystać tę funkcję z internetu
    {
        return Math.floor(Math.random()*(max - min + 1) + min);
    }

    app.question = {
        initialize: initialize,
        loadQuestion: loadQuestion
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