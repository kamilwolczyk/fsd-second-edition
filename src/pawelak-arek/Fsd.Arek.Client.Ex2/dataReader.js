var app = app || {};

(function () {
    var questionList = [];

    function generateQuestion(numberOfQuestion, callback) {
        $.ajax({
            url: 'https://opentdb.com/api.php?amount=' + numberOfQuestion,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                questionList = createQuestionModelList(data.results);
                callback(questionList);
            }
        })
    };

    var createQuestionModelList = function (params) {
        var question;
        var listQuestion = [];

        for (var i = 0; i < params.length; i++) {
            question = {
                category: params[i].category,
                question: params[i].question,
                correct_answer: params[i].correct_answer,
                answer: createRandomListQuestion(params[i].correct_answer, params[i].incorrect_answers)
            };
            listQuestion.push(question);
        }
        return listQuestion;
    }

    function createRandomListQuestion(listOne, listTwo) {
        var randomSortList = listTwo;
        randomSortList.splice(Math.floor(Math.random() * randomSortList.length + 1), 0, listOne);
        return randomSortList;
    }

    app.dataReader = {
        initialize: generateQuestion,
        createQuestionModelList: createQuestionModelList
    };
})();