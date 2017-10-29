var quiz = quiz || {};

(function(){
  var webDocument = {
    getElementsByClassName: function(className){
      return document.getElementsByClassName(className);
    },
    hideElement: function(id) {
      document.getElementById(id).style.display = "none"; 
    },
    showElement: function(id) {
      document.getElementById(id).style.display = "block"; 
    },
    setItemText: function(id, text) {
      document.getElementById(id).innerHTML = text; 
    },
    clearContainer: function(id) {
      document.getElementById(id).innerHTML = null;
    },
    addButtons: function(containerId, items) {
      var container = document.getElementById(containerId);
      items.forEach(function(item){
        var button = document.createElement('button');
        button.setAttribute('data-index', item.index);
        button.setAttribute('onClick', item.onClickAction);
        button.setAttribute('class', item.class);
        button.innerHTML = item.text;
        container.appendChild(button)

        if((item.index + 1) % 2 == 0){
          container.appendChild(document.createElement('br'));
        }
      })
    }
  };

  quiz.ui = {
    hideStartButton: function() {
      webDocument.hideElement('start-button');
    },

    hideResult: function() {
      webDocument.hideElement('result-container');
    },

    showQuestion: function(question, questionNumber, totalQuestionCount) {
      webDocument.showElement('question-container');
      webDocument.setItemText('question-number', 'QUESTION '+ (questionNumber + 1) + '/' + totalQuestionCount);
      webDocument.setItemText('question-text', question.text);
      webDocument.clearContainer('answers-container');
      webDocument.addButtons('answers-container', question.answers.map(function(answer, index){
        return { 
          text: answer.text, 
          index: index,
          class: 'answer-button',
          onClickAction:  'quiz.selectAnswer(' + index +')'
        }
      }));
    },

    hideQuestion: function(question, questionNumber, totalQuestionCount) {
      webDocument.hideElement('question-container');
    },

    showFinalText: function(score) {
      webDocument.setItemText('result', score);
      webDocument.showElement('result-container');
    },

    selectButtonByIndex: function(index){
      var allButtons = webDocument.getElementsByClassName('answer-button');

      for(var i=0; i < allButtons.length; i++){
        var button = allButtons[i];
        button.classList.remove('selected');

        if(button.getAttribute('data-index') == index){
          button.classList.add('selected')
        }
      }
    }

  }
})();