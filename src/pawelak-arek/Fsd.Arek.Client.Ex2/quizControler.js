var app = app || {};

(function () {
    var questionData;
    var indexQuestion = 0;
    var correct_answer = 0;
    var quizStatus = true;

    var createQuiz = function (data) {
        questionData = data;
        showQuestion();
        showAnswer();
        checkClickedBox();

        $('#next-question').click(
            function () {
                if (quizStatus) {
                    indexQuestion++;

                    if (indexQuestion < questionData.length) {
                        showQuestion();
                        showAnswer();
                        checkClickedBox();
                    } else {
                        console.log(correct_answer);
                        $("#next-question").text("Play Again?");
                        showScore();
                    }
                }
            }
        );
    };

    function checkClickedBox() {
        $('.answer-box').click(function (event) {
            checkAnswer(event);
        });
    }

    function showQuestion() {
        $('#question').html(questionData[indexQuestion].question);
    };

    function showAnswer() {
        if ($('.answer-box').length != 0) {
            $('.answer-box').remove();
        }

        for (var i = 0; i < questionData[indexQuestion].answer.length; i++) {
            $('#answer').append('<div class="answer-box">' + questionData[indexQuestion].answer[i] + '</div>');
        }
    };

    function checkAnswer(event) {
        $('.answer-box').css('background-color', 'rgb(173, 173, 20)');
        $(event.target).css('background-color', 'red');
        text = $(event.target).text();

        if (questionData[indexQuestion].correct_answer === text)
        {
            correct_answer++;
            //tutaj zrobić true false
            console.log(correct_answer);
        }
    }

    function showScore() {
        $('.answer-box').remove();
        $('#question').html(correct_answer);
    }

    app.quizController = {
        initialize: createQuiz
    };
})();