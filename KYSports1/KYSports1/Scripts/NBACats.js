
function GetPlayerData() {
    var qstring = $('#qstring').val();
        $.ajax
            ({
                type: "GET",
                url: "https://api.mysportsfeeds.com/v1.1/pull/nba/current/cumulative_player_stats.json?player=" + qstring,
                dataType: 'json',
                async: false,
                headers: {
                    "Authorization": "Basic " + btoa('gregalantiu2' + ":" + 'MSWildcat1')
                },
                success: function (data) {         
                    var myObj = '';

                    myObj += '<table id="stattable">';
                    myObj += '  <tr>';
                    myObj += '      <th>Jersey#</th>';
                    myObj += '      <th>Player</th>';
                    myObj += '      <th>Team</th>';
                    myObj += '      <th>Games Played</th>';
                    myObj += '      <th>Points</th>';
                    myObj += '      <th>2pt Att</th>';
                    myObj += '      <th>2pt Made</th>';
                    myObj += '      <th>2pt FG%</th>';
                    myObj += '      <th>3pt Att</th>';
                    myObj += '      <th>3pt Made</th>';
                    myObj += '      <th>3pt FG%</th>';
                    myObj += '      <th>FG%</th>';
                    myObj += '      <th>FT Att</th>';
                    myObj += '      <th>FT Made</th>';
                    myObj += '      <th>FT FG%</th>';
                    myObj += '      <th>O-Reb</th>';
                    myObj += '      <th>D-Reb</th>';
                    myObj += '      <th>Total-Reb</th>';
                    myObj += '      <th>Assists</th>';
                    myObj += '      <th>TOV</th>';
                    myObj += '      <th>Steals</th>';
                    myObj += '      <th>Blocks</th>';
                    myObj += '  </tr>';
                    var obj = data.cumulativeplayerstats.playerstatsentry;
                    $.each(obj, function (i,players) {
                        myObj += '   <tr>';
                        myObj += '       <td>' + '#' + obj[i].player.JerseyNumber + '</td>';
                        myObj += '       <td>' + obj[i].player.FirstName + ' ' + obj[i].player.LastName + '</td>';
                        myObj += '       <td>' + obj[i].team.City + ' ' + obj[i].team.Name + '</td>';
                        myObj += '       <td>' + obj[i].stats.GamesPlayed['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.PtsPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.Fg2PtAttPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.Fg2PtMadePerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.Fg2PtPct['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.Fg3PtAttPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.Fg3PtMadePerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.Fg3PtPct['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.FgPct['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.FtAttPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.FtMadePerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.FtPct['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.OffRebPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.DefRebPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.RebPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.AstPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.TovPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.StlPerGame['#text'] + '</td>';
                        myObj += '       <td>' + obj[i].stats.BlkPerGame['#text'] + '</td>';
                        myObj += '  </tr>';
                    });
                    myObj += '</table>';
                    $('#JsonData').append(myObj);

                    console.log(data);
                },
                error: function () {
                    console.log(status);
                }
            });
}




