USE KYSports1
GO

DROP PROCEDURE[Games].[GetNextGame]
GO

CREATE PROCEDURE [Games].[GetNextGame]
AS

DECLARE @CurrentDate DATETIME
SET		@CurrentDate = GETDATE()

SELECT	 TOP 1 *
		,Opponent
		,[DayofWeek]
		,GameTime
		,Network
		,GameLocation
FROM		Games.Schedule
INNER JOIN	Games.Network ON Games.Network.NetworkID = Games.Schedule.NetworkID
INNER JOIN	Games.HomeAway ON Games.HomeAway.HomeAwayID = Games.Schedule.HomeAwayID
WHERE		Games.Schedule.GameDate > DATEADD(Minute,-120,GETDATE())
OR			Games.Schedule.GameDate = DATEADD(Minute,-120,GETDATE())

GO