function Get(yourUrl) {
    var Httpreq = new XMLHttpRequest(); // a new request
    Httpreq.open("GET", yourUrl, false);
    Httpreq.send(null);
    return Httpreq.responseText;
}
Get('https://opentdb.com/api.php?amount=10')

var myObj = JSON.parse(Get('https://opentdb.com/api.php?amount=10'));
console.log("this is the author name: " + myObj.results[1]);

var hitPoints = [];
var misPoints = [];
var digits = [1, 2, 3, 4];
var questionCounter = 0; 
function shuffle(array) {
    var currentIndex = array.length,
        temporaryValue, randomIndex;
    while (0 !== currentIndex) {
        randomIndex = Math.floor(Math.random() * currentIndex);
        currentIndex -= 1;
        temporaryValue = array[currentIndex];
        array[currentIndex] = array[randomIndex];
        array[randomIndex] = temporaryValue;
    }
    return array;
}

var quizCategory = myObj.results[questionCounter].category + " : ";
var quizQuestion = myObj.results[questionCounter].question;
var correctAnswer = myObj.results[questionCounter].correct_answer;
var incorectAnswer = myObj.results[questionCounter].incorrect_answers[0];
var incorectAnswer2 = myObj.results[questionCounter].incorrect_answers[1];
var incorectAnswer3 = myObj.results[questionCounter].incorrect_answers[2];

function firstStringChange() {
    quizCategory = myObj.results[questionCounter].category + " : ";
    quizQuestion = myObj.results[questionCounter].question;
    correctAnswer = myObj.results[questionCounter].correct_answer;
    incorectAnswer = myObj.results[questionCounter].incorrect_answers[0];
    incorectAnswer2 = myObj.results[questionCounter].incorrect_answers[1];
    incorectAnswer3 = myObj.results[questionCounter].incorrect_answers[2];
}

function game() {
    firstStringChange();
    shuffle(digits);
    document.getElementById("category").innerHTML = quizCategory;
    document.getElementById("qustion").innerHTML = quizQuestion;
    document.getElementById(digits[0]).innerHTML = correctAnswer;
    document.getElementById(digits[1]).innerHTML = incorectAnswer;
    document.getElementById(digits[2]).innerHTML = incorectAnswer2;
    document.getElementById(digits[3]).innerHTML = incorectAnswer3;
    questionCounter++;
    document.getElementById("questonCounter").innerHTML = "question " + questionCounter + " from " + myObj.results.length;
    if (questionCounter == 10) {
        document.getElementById("summation").innerHTML = "number of correct answers: " + hitPoints.length + " number of wrong answers: " + misPoints.length;
        document.getElementById("1").style.visibility = "hidden";
        document.getElementById("2").style.visibility = "hidden";
        document.getElementById("3").style.visibility = "hidden";
        document.getElementById("4").style.visibility = "hidden";
        document.getElementById("category").style.visibility = "hidden";
        document.getElementById("qustion").style.visibility = "hidden";
        document.getElementById("order").style.visibility = "hidden";
        document.getElementById("questonCounter").style.visibility = "hidden";
    }
}
game();

function countPoints(buttonId) {
    var answerTester = document.getElementById(buttonId).innerHTML;
    if (answerTester == correctAnswer) {
        hitPoints.push(1);
    } else {
        misPoints.push(1);
    }
}