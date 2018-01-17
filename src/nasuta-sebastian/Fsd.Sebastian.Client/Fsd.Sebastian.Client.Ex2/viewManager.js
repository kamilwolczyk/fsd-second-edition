var app = app || {};

(function () {
    function createAnswerFields(count) {
        const answersContainer = document.getElementById('answers');

        for (i = 0; i < count; i++) {
            answersContainer.appendChild(document.createElement('div')).classList.add('answer', 'col-5');
            answersContainer.lastChild.id = `answer${i + 1}`;

            document.querySelectorAll('.answer').forEach(function (item) {
                item.addEventListener('click', app.clickEvents.answerClick);
            });
        };
    };

    function removeAllAnswerFields() {
        document.querySelectorAll('.answer').forEach(function (item) {
            item.remove();
        });
    };

    function printScore(score) {
        leftOnlyQuestionBox();
        document.getElementById('question-text').innerHTML = `Your score is: ${score}`;
    };

    function clearSelect() {
        const selected = document.querySelector('.selected');

        if (selected) {
            selected.classList.remove('selected');
        };
    };

    function leftOnlyQuestionBox() {
        removeAllAnswerFields();
        document.querySelector('button').remove();
        document.getElementById('category').remove();
        document.getElementById('counter').remove();
    };

    app.viewManager = {
        createAnswerFields: createAnswerFields,
        removeAllAnswerFields: removeAllAnswerFields,
        printScore: printScore,
        clearSelect: clearSelect
    };
})();



