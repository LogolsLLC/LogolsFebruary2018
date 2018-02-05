insert into PersonStatus
(
	PersonStatusID
	,StatusDescription
)
VALUES
(
	1,'Alive'
)
,(
	2, 'Zombie'
)
,(
	3, 'Dead'
)
,(
	4, 'Unknown'
);


insert into Person (
  FirstName
  ,LastName
  ,PersonStatusId
)
VALUES
('Tom', 'Bowman', 2)
,('Tim', 'Toom', 3)
,('Bob', 'Markle', 1)
,('Fred', 'Stoops', 2)
,('Carlos', 'Smith', 4)
,('Jim', 'Franks', 1);