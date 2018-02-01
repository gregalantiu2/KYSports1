function MakeCard() {
    for (var i = 0; i < 25; i++)
    {
        var box = '';
        box += '<div onclick="checkmark()" class="col-sm-2 square" id="grid' + i + '">';
        box += '</div>';
        $('#Card').append(box);
    }
    
}
function checkmark() {
    $(".square").click(function () {
        var id = '#' + $(this).attr("id");
        $(id).removeClass("square");
        $(id).addClass("squareclick");
    });
}
