var app = app || {};

(function () {
    function addNewLog(message) {
        var list = document.getElementById('log'); //<ul></ul>
        var newItem = document.createElement('li'); //<li></li>
        newItem.innerText = message;
        list.appendChild(newItem);
    }

    app.log = {
        addNewLog: addNewLog
    };
})();