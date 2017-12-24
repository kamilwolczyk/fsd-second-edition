var app = app || {};

(function () { 
    app.apiControler.initialize();
    setTimeout(function(){
        app.answerControler.initialize();
    },750);
}());