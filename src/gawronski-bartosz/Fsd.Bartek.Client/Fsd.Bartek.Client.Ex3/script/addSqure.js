var app = app || {};

(function(){    
    var squre = [
        {
            id:1,
            color: '#5be679',
            name: 'limon'
        },
        {
            id:2,
            color: '#c64652',
            name: 'dark-orange'
        },
        {
            id:3,
            color: '#f80dab',
            name: 'pink'
        },
        {
            id:4,
            color: '#f87dab',
            name: 'skin'
        },
        {
            id:5,
            color: '#f0491a',
            name: 'orange'
        },
        {
            id:6,
            color: '#3384db',
            name: 'blue'
        },
        {
            id:7,
            color: '#574f7f',
            name: 'purple'
        },
        {
            id:8,
            color: '#f9fe9c',
            name: 'yellow'
        },
        {
            id:9,
            color: '#cfbd5c',
            name: 'dark-yellow'
        },
    ];

    function initialize(){
        var squres = $('.squres');

        squre.forEach(function(one, index){
            squres.append(`<div class="squre" id="${one.id}"></div>`);
            $(`#${one.id}`).css('background-color', one.color);
        });
    }
    
    app.addSqure = {
        init: initialize,
        squres: squre
    };
})();