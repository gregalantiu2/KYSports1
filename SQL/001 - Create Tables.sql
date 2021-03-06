USE KYSports1
GO

CREATE SCHEMA [Games]
GO

DROP TABLE [Games].[HomeAway]
GO

CREATE TABLE [Games].[HomeAway]
	(
		 HomeAwayID		INT PRIMARY KEY NOT NULL
		,GameLocation	VARCHAR(150)
	)	


DROP TABLE [Games].[Network]
GO

CREATE TABLE [Games].[Network]
	(
		 NetworkID		INT PRIMARY KEY NOT NULL
		,Network		VARCHAR(100)NOT NULL
	)

DROP TABLE [Games].[Schedule]	
GO

CREATE TABLE [Games].[Schedule]	
	(
		 ScheduleID		INT PRIMARY KEY NOT NULL
		,Opponent		VARCHAR(100)
		,[DayOfWeek]	VARCHAR(20)
		,GameDate		DATETIME
		,GameTime		VARCHAR(30)
		,NetworkID		INT
		,FOREIGN KEY	(NetworkID) REFERENCES [Games].[Network](NetworkID)
		,HomeAwayID		INT
		,FOREIGN KEY	(HomeAwayID) REFERENCES [Games].[HomeAway](HomeAwayID)
	)


	select * from Games.Schedule

