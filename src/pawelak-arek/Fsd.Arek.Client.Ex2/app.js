var app = app || {};

(app.start = function () {
    app.dataReader.initialize(function(data){
        app.quizController.initialize(data);
    });
})();