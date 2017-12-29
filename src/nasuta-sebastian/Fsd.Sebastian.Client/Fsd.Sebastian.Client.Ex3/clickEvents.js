var app = app || {};

(function () {
    function tileClick(event) {
        const tile = event.target;
        const tileColor = tile.classList.item(1);
        const selected = document.getElementById('selected');
        const previewClassList = document.querySelector('.preview-field').classList;
        const previewColor = previewClassList.item(1);

        if (selected) {
            selected.removeAttribute('id');
        };
        tile.id = "selected";

        if (previewColor) {
            previewClassList.remove(previewColor);
        };
        previewClassList.add(tileColor);

        document.getElementById('name-of-selected').textContent = `Color selected: ${tileColor}`;
    };

    app.clickEvents = {
        tileClick: tileClick
    };
})();