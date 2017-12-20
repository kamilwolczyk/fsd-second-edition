var app = app || {};

(function(){
    function innerTexts(button, text){
        button.innerText = text;
    }

    function changeButton( next, button){
        if(next){
            document.querySelectorAll('.answer').forEach(function(item){
                if(item.classList.contains('btn-success')){
                    item.classList.remove('btn-success');
                }
                if(item.classList.contains('btn-danger')){
                    item.classList.remove('btn-danger');
                }                
                item.classList.add('btn-primary');
            });
        }else{
            document.querySelectorAll('.answer').forEach(function(item){
                item.classList.remove('btn-primary');
                item.classList.add('btn-danger');
            });
    
            if(button != null){
                button.classList.remove("btn-danger");
                button.classList.add('btn-success')
            }
        }
    }

    app.userInterface = {
        innerTexts: innerTexts,
        changeButton: changeButton
    };
}());