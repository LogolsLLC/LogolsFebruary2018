select
	PersonId
    ,FirstName
    ,LastName
    ,PersonStatusId
from Person;

select
	PersonId
    ,FirstName
    ,LastName
    ,PersonStatusId
from Person
where PersonStatusId = 4;

select
	PersonId
    ,FirstName
    ,LastName
    ,PersonStatusId
from Person
where PersonStatusId = 1
	or PersonStatusId = 4;
    
select
	PersonId
    ,FirstName
    ,LastName
    ,PersonStatusId
from Person
where PersonStatusId = 1
	and FirstName = 'Tom';