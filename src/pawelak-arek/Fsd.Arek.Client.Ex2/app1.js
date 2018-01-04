function showQuestion(text) {
    $('#question').html(text);
}

function showAnswer(text) {
    if ($('.answer-box').length != 0) {
        $('.answer-box').remove();
    }

    for (var i = 0; i < text.length; i++) {
        $('#answer').append('<div class="answer-box">' + text[i] + '</div>');
    }
}


function CreateListQuestion(listOne, listTwo) {
    var randomSortList = listOne;
    randomSortList.splice(Math.floor(Math.random() * randomSortList.length + 1), 0, listTwo);
    return randomSortList;
}

function successCallBack(returnData) {
    return returnData;
}

function myCallback(result) {
    // Code that depends on 'result'

    var a = result[0];
    console.log(a);
    return a;
}


function GetData() {
    var asd;
    $.ajax({
        url: 'https://opentdb.com/api.php?amount=10',
        type: 'GET',
        dataType: 'json',
    })
    .done(ret => {
        asd = ret.results;
        console.log(ret.results);
    });
    //     success: function (data) {
    //         callBack(data.results);
    //     },
    //     error: function (xhr, textStatus, errorThrown) {
    //         console.log('Error in Database');
    //     },
    // });

    return asd;
};


$(document).ready(function () {

    var res = foo();
     console.log(res);

});

// $(document).ready(function () {
//     $.ajax({
//         url: 'https://opentdb.com/api.php?amount=10',
//         type: 'GET',
//         dataType: 'json',
//         success: function (data, textStatus, xhr) {

//             var i = 0;
//             // var listAnswers = CreateListQuestion(data.results[0].incorrect_answers, data.results[0].correct_answer)
//             var incorrect_answers = data.results[0].incorrect_answers;
//             var correct_answer = data.results[0].correct_answer;
//             showQuestion(data.results[0].question);
//             var listAnswers = CreateListQuestion(incorrect_answers, correct_answer);
//             showAnswer(listAnswers);
//             var count = 10;
//             $('#next-question').click(
//                 function () {
//                     i++;
//                     if (i < 10) {
//                         showQuestion(data.results[i].question);
//                         showAnswer(CreateListQuestion(data.results[i].incorrect_answers, data.results[i].correct_answer));
//                     } else {
//                         console.log("koniec");
//                         return;
//                     }
//                 }
//             );
//             count--;

//         },
//         error: function (xhr, textStatus, errorThrown) {
//             console.log('Error in Database');
//             // -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - >  
//             // if any error caught  
//         }
//     });
// });