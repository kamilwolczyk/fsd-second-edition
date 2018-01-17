var app = app || {};

(function () {
    function getObjectFromApi(apiUrl, callbackFunction) {
        var xhttp = new XMLHttpRequest();

        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                callbackFunction(JSON.parse(this.responseText));
            };
        };
        
        xhttp.open("GET", apiUrl, true);
        xhttp.send();
    };

    app.ajaxReader = {
        getObjectFromApi: getObjectFromApi
    };
})();