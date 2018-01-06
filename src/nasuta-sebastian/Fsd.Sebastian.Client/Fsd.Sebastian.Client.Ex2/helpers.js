var app = app || {};

(function () {
    function createAnswerFields(count) {
        const ANSWERS_CONTAINER = document.getElementById('answers');
        for (i = 0; i < count; i++) {
            ANSWERS_CONTAINER.appendChild(document.createElement('div')).classList.add('answer', 'col-5');
            ANSWERS_CONTAINER.lastChild.id = `answer${i + 1}`;

            document.querySelectorAll('.answer').forEach(function (item) {
                item.addEventListener('click', app.clickEvents.answerClick);
            });
        };
    };

    function printScore(score) {
        leftOnlyQuestionBox();

        document.getElementById('question-text').innerHTML = `Your score is: ${score}`;
    };

    function clearSelect() {
        const SELECTED = document.querySelector('.selected');
        if (SELECTED) {
            SELECTED.classList.remove('selected');
        };
    };

    function leftOnlyQuestionBox() {
        document.querySelectorAll('.answer').forEach(function (item) {
            item.remove();
        });
        document.querySelector('button').remove();
        document.getElementById('category').remove();
        document.getElementById('counter').remove();
    };

    app.helpers = {
        createAnswerFields: createAnswerFields,
        printScore: printScore,
        clearSelect: clearSelect
    };
})();



