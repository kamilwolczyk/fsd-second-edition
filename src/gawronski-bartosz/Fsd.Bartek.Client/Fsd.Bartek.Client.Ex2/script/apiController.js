var app = app || {};

(function(){
    var xhttp = new XMLHttpRequest();
    var question;
    var _number = 0;
    
    function initialize(answerController) {
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                var date = xhttp.responseText;                
                question = JSON.parse(date);
                answerController();
            }
        };
        xhttp.open("GET", 'https://opentdb.com/api.php?amount=10', true);
        xhttp.send();

    }

    function getQuestion () { 
        return (app.mapping.question(question.results[_number], _number++));        
    }

    app.apiController = {
        initialize: initialize,
        getQuestion: getQuestion
    }
}());