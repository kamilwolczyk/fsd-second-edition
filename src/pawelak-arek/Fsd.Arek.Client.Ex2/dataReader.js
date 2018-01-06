var app = app || {};

(function () {
    var questionList = new Array();

    function generateQuestion(numberOfQuestion, callback) {
        $.ajax({
            url: 'https://opentdb.com/api.php?amount=' + numberOfQuestion,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                questionList = mappingObject(data.results);
                callback(questionList);
            }
        })

    };

    var mappingObject = function (params) {

        var question;
        var listQuestion = new Array();
        for (var i = 0; i < params.length; i++) {
            question = {
                category: params[i].category,
                question: params[i].question,
                correct_answer: params[i].correct_answer,
                answer: CreateRandomListQuestion(params[i].correct_answer, params[i].incorrect_answers)
            };
            listQuestion.push(question);
        }
        return listQuestion;
    }

    function CreateRandomListQuestion(listOne, listTwo) {
        var randomSortList = listTwo;
        randomSortList.splice(Math.floor(Math.random() * randomSortList.length + 1), 0, listOne);
        return randomSortList;
    }

    app.dataReader = {
        initialize: generateQuestion,
        mapping: mappingObject
    };
})();