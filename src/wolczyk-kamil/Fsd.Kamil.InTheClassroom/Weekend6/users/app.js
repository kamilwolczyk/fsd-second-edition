var app = app || {};

(function () {
    $(document).ready(() => {
        app.alertManager.initialize();
        app.userGrid.initialize();
        app.userEditor.initialize();
    });
})();