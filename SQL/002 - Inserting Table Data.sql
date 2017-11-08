USE KYSports1
GO

/*Inserting Home or Away tag*/
INSERT INTO [Games].[HomeAway] VALUES (1,'Home');
INSERT INTO [Games].[HomeAway] VALUES (2,'Away');
INSERT INTO [Games].[HomeAway] VALUES (3,'State Farm Champions Classic (Chicago)');
INSERT INTO [Games].[HomeAway] VALUES (4,'Adolph Rupp Classic (Lexington)');
INSERT INTO [Games].[HomeAway] VALUES (5,'Citi Hoops Classic (New York)');
INSERT INTO [Games].[HomeAway] VALUES (6,'CBS Sports Classic (New Orleans)');
INSERT INTO [Games].[HomeAway] VALUES (7,'Big 12/SEC Challenge (Morgantown, W.Va.)');
INSERT INTO [Games].[HomeAway] VALUES (8,'SEC Tournament (St. Louis)');

Select * from [Games].[HomeAway]

/*Inserting Network tags*/
INSERT INTO [Games].[Network] VALUES (1,'ESPN');
INSERT INTO [Games].[Network] VALUES (2,'SEC Network');
INSERT INTO [Games].[Network] VALUES (3,'ESPN U');
INSERT INTO [Games].[Network] VALUES (4,'ESPN2');
INSERT INTO [Games].[Network] VALUES (5,'CBS');

select * from [Games].[Network]



INSERT INTO [Games].[Schedule] VALUES (1,'Utah Valley Wolverines','Friday','11/10/2017','7:00 PM',2,1)
INSERT INTO [Games].[Schedule] VALUES (2,'Vermont Catamounts','Sunday','11/12/2017','3:30 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (3,'Kansas JayHawks','Tuesday','11/14/2017','9:30 PM',1,3)
INSERT INTO [Games].[Schedule] VALUES (4,'E Tenn State Buccaneers','Friday','11/17/2017','7:00 PM',2,4)
INSERT INTO [Games].[Schedule] VALUES (5,'Troy Trojans','Monday','11/20/2017','8:00 PM',2,4)
INSERT INTO [Games].[Schedule] VALUES (6,'Fort Wayne Mastadons','Wednesday','11/22/2017','8:00 PM',2,4)
INSERT INTO [Games].[Schedule] VALUES (7,'Illinois-Chicago Flames','Sunday','11/26/2017','6:00 PM',1,4)
INSERT INTO [Games].[Schedule] VALUES (8,'Harvard Crimson','Saturday','12/2/2017','3:30 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (9,'Monmouth Hawks','Saturday','12/9/2017','12:00 PM',3,5)
INSERT INTO [Games].[Schedule] VALUES (10,'VA Tech Hokies','Saturday','12/16/2017','2:00 PM',4,1)
INSERT INTO [Games].[Schedule] VALUES (11,'UCLA Bruins','Saturday','12/23/2017','4:00 PM',5,6)
INSERT INTO [Games].[Schedule] VALUES (12,'Louisville Cardinals','Friday','12/29/2017','1:00 PM',5,1)
INSERT INTO [Games].[Schedule] VALUES (13,'Georgia Bulldogs','Sunday','12/31/2017','6:00 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (14,'LSU Tigers','Wednesday','01/03/2018','8:30 PM',2,2)
INSERT INTO [Games].[Schedule] VALUES (15,'Tennessee Volunteers','Saturday','01/06/2018','9:00 PM',2,2)
INSERT INTO [Games].[Schedule] VALUES (16,'Texas A&M Aggies','Tuesday','01/09/2018','7:00 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (17,'Vanderbilt Commodores','Saturday','01/13/2018','4:00 PM',1,2)
INSERT INTO [Games].[Schedule] VALUES (18,'S. Carolina GameCocks','Tuesday','01/16/2018','9:00 PM',1,2)
INSERT INTO [Games].[Schedule] VALUES (19,'Florida Gators','Saturday','01/20/2018','8:15 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (20,'Miss. State Bulldogs','Tuesday','01/23/2018','9:00 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (21,'West Virginia Mountaineers','Saturday','01/27/2018','4:30 PM or 7:00 PM',1,2)
INSERT INTO [Games].[Schedule] VALUES (22,'Vanderbilt Commodores','Tuesday','01/30/2018','9:00 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (23,'Missouri Tigers','Saturday','02/03/2018','2:00 PM',5,2)
INSERT INTO [Games].[Schedule] VALUES (24,'Tennessee Volunteers','Tuesday','02/06/2018','2:00 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (25,'Texas A&M Aggies','Saturday','02/10/2018','TBD',1,2)
INSERT INTO [Games].[Schedule] VALUES (26,'Auburn Tigers','Wednesday','02/14/2018','9:00 PM',4,2)
INSERT INTO [Games].[Schedule] VALUES (27,'Alabama Crimson Tide','Saturday','02/17/2018','2:00 PM',5,1)
INSERT INTO [Games].[Schedule] VALUES (28,'Arkansas Razorbacks','Tuesday','02/20/2018','9:00 PM',1,2)
INSERT INTO [Games].[Schedule] VALUES (29,'Missouri Tigers','Saturday','02/24/2018','6:00 PM or 8:00 PM',1,1)
INSERT INTO [Games].[Schedule] VALUES (30,'Ole Miss Rebels','Wednesday','02/28/2018','7:00 PM',4,1)
INSERT INTO [Games].[Schedule] VALUES (31,'Florida Gators','Saturday','03/03/2018','12:00 PM',5,2)

	select * from Games.Schedule

