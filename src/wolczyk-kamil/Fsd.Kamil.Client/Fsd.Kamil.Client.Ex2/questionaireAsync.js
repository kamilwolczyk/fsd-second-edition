var questionaire = questionaire || {};

(function(){
  var shuffle = function(tab) {
      for (var i = tab.length; i; i--) {
          var j = Math.floor(Math.random() * i);
          [tab[i - 1], tab[j]] = [tab[j], tab[i - 1]];
      }
  }

  var finishRequest = function(json) {
    return json.results.map(item=>{
      var question = {
        text: item.question,
        answers: [{ text: item.correct_answer, isCorrect: true }]
      };
      
      item.incorrect_answers.forEach(incorrect=>{
        question.answers.push({ text: incorrect, isCorrect: false })
      });

      shuffle(question.answers);
      return question;
    });
  } 

  var getQuestions = function(count, callback){
    var apiUrl = 'https://opentdb.com/api.php?amount=' + count;
    var xmlhttp = new XMLHttpRequest();

    xmlhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            var items = finishRequest(JSON.parse(this.responseText));
            callback.call(this, items);
        }
    };
    xmlhttp.open("GET", apiUrl, true);
    xmlhttp.send();
  }

  questionaire.generateAsync = getQuestions;
  questionaire.shuffle = shuffle;
})();