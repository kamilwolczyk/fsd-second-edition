var app = app || {};

(function () {
    var x = 5;
    var y = 6;
    var z = "test";
    var hello = function () {
        console.log("hello, world!");
    };


    var x = {
        prop1: 4,
        prop2: "test string",
        prop3: true
    };

    var text = JSON.stringify(x);

    var objectX = JSON.parse(text);

    app.test = {
        myValue: y,
        sayHello: hello
    };

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {}
    };
    xhttp.open("GET", 'https://anapioficeandfire.com/api/characters/583', true);
    xhttp.send();
})();