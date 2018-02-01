function HideSubmit() {
    $('#SubmitName').hide();
}

function ButtonSwap() {
    $('#SubmitName').show();
    $('#CheckData').hide();
}
function CheckPlayerName() {
    var qstring = $('#nameinput').val();
    var replaced = qstring.replace(/\s+/g, '-');
    $.ajax
        ({
            type: "GET",
            url: "https://api.mysportsfeeds.com/v1.1/pull/nba/current/cumulative_player_stats.json?player=" + replaced,
            dataType: 'json',
            async: false,
            headers: {
                "Authorization": "Basic " + btoa('gregalantiu2' + ":" + 'MSWildcat1')
            },
            success: function (data) {
                if (data.cumulativeplayerstats.playerstatsentry != null)
                {
                    ButtonSwap();
                }
                else 
                {
                    alert("Try again - Name did not return any data");
                    $('#ResetForm').click();
                }
            },
            error: function () {
                console.log(status);
            }
        });
}
function SuccessMessage() {
    alert($('#nameinput').val() + ' ' + 'has been added to the table');
}
