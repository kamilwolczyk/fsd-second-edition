
    $('#page-content').load('index2.html')



$('.navbar-button').click((e) => {
    changeInside(e.currentTarget.id);
    console.log(e.currentTarget.id);
})