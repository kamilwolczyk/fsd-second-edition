var app = app || {};

function GetData(){
    var xhttp = new XMLHttpRequest();
    var question;
    var _number = 0;
    
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                var date = xhttp.responseText;                
                question = JSON.parse(date);
                console.log(question);
            }
        };
        xhttp.open("GET", 'https://opentdb.com/api.php?amount=10', true);
        xhttp.send();
        
};

$(document).ready(function () {

    GetData();

});