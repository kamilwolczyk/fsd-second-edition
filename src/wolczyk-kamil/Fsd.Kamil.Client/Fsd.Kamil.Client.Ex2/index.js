var app = app || {};

app.start = function() {
  if(questionaire == null){
    alert('Questionaire library has not been found!');
  }
  
  questionaire.generateAsync(2, function(questions){
    quiz.start(questions);
  });  
}