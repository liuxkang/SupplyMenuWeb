$(document).ready(function () {
    $("button").on("click", function () {
        if ($(this).hasClass("active"))
        {
            $(this).removeClass("active")
            $("#all").addClass("active")
        }
        else
        {
            $(this).addClass("active");
        }
    });
});