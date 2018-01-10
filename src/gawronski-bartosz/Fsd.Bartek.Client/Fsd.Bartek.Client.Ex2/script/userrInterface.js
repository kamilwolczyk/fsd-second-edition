var app = app || {};

(function(){
    const buttons = document.querySelectorAll('.answer');
    const questionDiv = document.getElementById('question');
    const questionNumber = document.getElementById('number-question');
    const nextquestion = document.getElementById('next-question');

    function innerTexts(button, text){
        button.innerText = text;
    }

    function changeButton( next, button, correct){
        if(next){
            document.querySelectorAll('.answer').forEach(function(item){
                if(item.classList.contains('btn-warning')){
                    item.classList.remove('btn-warning');
                }                
                item.classList.add('btn-primary');
            });
        }else{
            document.querySelectorAll('.answer').forEach(function(item){
                if(item.classList.contains('btn-warning')){
                    item.classList.remove('btn-warning');
                    item.classList.add('btn-primary');
                }                
                button.classList.remove('btn-primary');
                button.classList.add('btn-warning');
            });
        }
    }

    function elementText(questionNumberString, questionString, questionAnswer){
        var indexs = app.helpers.schuffle(questionAnswer);

        innerTexts(questionNumber,questionNumberString);
        innerTexts(questionDiv,questionString);           
        buttons.forEach(function(button, index){innerTexts(button, indexs[index])});
    }

    function summaryDisplay(correctAnswer){
        innerTexts(questionNumber,'Summary');
        innerTexts(questionDiv,`Your's Correct Answer ${correctAnswer}/10`);
        buttons.forEach(function(button){
            button.classList.add('display-none');
        });
        nextquestion.classList.add('display-none');
    }

    app.userInterface = {
        elementText: elementText,
        changeButton: changeButton,
        summaryDisplay: summaryDisplay
    };
}());