$(document).ready(function () {
    //console.log($('#title'))
    
    $('#page-title').click(function () { 
        alert('Saya klik page title');
    });

    $('#submitButton').click(function (e) { 
        e.preventDefault()

        let username = $('#username').val();
        alert("Halo, " + username);
    });

    $('.page-box:first').addClass("btn-danger")
});