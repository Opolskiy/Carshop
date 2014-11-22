$(document).ready(function() {
        var cont_left = $("#container").position().left;
        $("a img").hover(function() {
            // приближение
            $(this).parent().parent().css("z-index", 1);
            $(this).animate({
               height: "350",
               width: "430",
               left: "-=75",
               top: "-=85"
            }, "fast");
        }, function() {
            // отдаление
            $(this).parent().parent().css("z-index", 0);
            $(this).animate({
                height: "200",
                width: "240",
                left: "+=75",
                top: "+=85"
            }, "fast");
        });
        
        $(".img").each(function(index) {
            var left = (index * 160) + cont_left;
            $(this).css("left", left + "px");
        });
    });