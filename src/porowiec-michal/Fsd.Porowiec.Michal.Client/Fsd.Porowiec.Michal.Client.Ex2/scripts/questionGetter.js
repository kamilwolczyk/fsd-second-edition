var app = app || {};

(function() {
    var itemsMapper = function( json ) {
        var arr = [];

        json.results.map( el => {
            var temporaryObject = {
                question: el.question,
                correctAnswer: el.correct_answer,
                incorrectAnswers: el.incorrect_answers
            }
            arr.push(temporaryObject)
        })
        return arr;
    }

    var questionGetter = function(numberOfQuestions, callback){
        var url = 'https://opentdb.com/api.php?amount=' + numberOfQuestions;
        var xmlhttp = new XMLHttpRequest();

        xmlhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
                var items = itemsMapper(JSON.parse(this.responseText));
                callback.call(this, items);
            }
        };
        xmlhttp.open("GET", url, true);
        xmlhttp.send();
    }

    app.questionGetter = {
        getQuestions: questionGetter
    }
}())