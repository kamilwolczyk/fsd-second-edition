var app = app|| {};

(function(){
    function question(question, number){
        if(question == undefined){
            return undefined;
        }
        
        return new Question(
            question.question, 
            number, 
            [
                question.correct_answer,
                question.incorrect_answers[0],
                question.incorrect_answers[1],
                question.incorrect_answers[2]
            ]
        );
    }

    app.mapping = {
        question: question
    }
}());   