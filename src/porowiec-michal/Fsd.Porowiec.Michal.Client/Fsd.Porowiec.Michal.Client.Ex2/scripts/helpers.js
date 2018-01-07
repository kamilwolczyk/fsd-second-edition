var app = app || {};

(function(){
    var putText = function(id, text) {
        return (document.getElementById(id).innerText = text)
    }

    var shuffle = function (arr) {
        for (let i = arr.length - 1; i > 0; i--) {
            const j = Math.floor(Math.random() * (i + 1));
            [arr[i], arr[j]] = [arr[j], arr[i]];
        }
        return arr;
    } 
    
    app.helpers = {
        putText: putText,
        shuffle: shuffle
    }
}())