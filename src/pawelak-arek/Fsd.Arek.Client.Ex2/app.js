var app = app || {};

app.start = (function () {
    var numberOfQuestion = 4;
    app.dataReader.initialize(numberOfQuestion, function (data) {
        app.quizController.initialize(data);
    });
})();