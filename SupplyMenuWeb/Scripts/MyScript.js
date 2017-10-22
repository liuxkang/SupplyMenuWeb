$(document).ready(function () {
    $("button").on("click", function () {
        if ($(this).hasClass("active"))
        {
            $("button#all").addClass("active");
            $(this).removeClass("active");
        }
        else
        {
            $("button").removeClass("active");
            $(this).addClass("active");
        }
    });
});