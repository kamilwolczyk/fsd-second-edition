var app = app|| {};

(function(){
    function schuffle(){
        var a = [1,2,3,4];

        for (let i = a.length - 1; i > 0; i--) {
            const j = Math.floor(Math.random() * (i + 1));
            [a[i], a[j]] = [a[j], a[i]];
        }
        return a;     
    }

    app.helpers = {
        schuffle: schuffle
    }
}());