var quiz = quiz || {};

(function(){
  var points;
  var questionNumber;
  var questions;
  var selectedIndex;

  function verifyAnswer() {    
    if(questions[questionNumber].answers[selectedIndex].isCorrect){
      points += 1;
    }
  }

  function showScore() {
    quiz.ui.hideQuestion();
    quiz.ui.showFinalText(points);
  }

  function showQuestion() {
    selectedIndex = null;
    quiz.ui.showQuestion(questions[questionNumber], questionNumber, questions.length);
  }

  function nextQuestion() {
    if(selectedIndex == null){
      return;
    }

    verifyAnswer();

    if(questionNumber == questions.length - 1) {
      return showScore();
    }

    questionNumber += 1;
    showQuestion();
  }
    
  function selectAnswer (index) {
    selectedIndex = index;
    quiz.ui.selectButtonByIndex(index);
  }

  function runQuiz(questionArray){
    if(!questionArray || !questionArray.length){
      throw new Error('Questions have not been found');
    }

    questions = questionArray;
    questionNumber = 0;
    points = 0;

    quiz.ui.hideStartButton();
    quiz.ui.hideResult();
    showQuestion();
  }

  quiz.start = runQuiz;
  quiz.selectAnswer = selectAnswer;
  quiz.nextQuestion = nextQuestion;
})();