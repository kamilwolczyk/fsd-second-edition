var app = app || {};

(function () {
    function generateRow(value) {
        return $('<tr></tr>');
    }

    function generateCell(value) {
        return  $('<td></td>').text(value);
    }

    function createAndFillRow(values) {
        var row = generateRow();

        values.forEach(cellValue => {
            row.append(generateCell(cellValue));
        });

        return row;
    }

    app.grid = {
        createAndFillRow: createAndFillRow
    };
})();