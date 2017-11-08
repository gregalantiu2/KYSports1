USE KYSports1
GO

/*Inserting Home or Away tag*/
INSERT INTO [Games].[HomeAway]
VALUES (1,'Home');

INSERT INTO [Games].[HomeAway]
VALUES (2,'Away');

Select * from [Games].[HomeAway]

/*Inserting Network tags*/
INSERT INTO [Games].[Network]
VALUES (1,'ESPN');
INSERT INTO [Games].[Network]
VALUES (2,'SEC Network');
INSERT INTO [Games].[Network]
VALUES (3,'ESPN U');
INSERT INTO [Games].[Network]
VALUES (4,'ESPN2');
INSERT INTO [Games].[Network]
VALUES (5,'CBS');

select * from [Games].[Network]


INSERT INTO [Games].[Schedule]
VALUES (1,'Utah Valley Wolverines','Friday','11/10/2017','7:00 PM'