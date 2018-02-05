select p.PersonId, p.FirstName, p.LastName, ps.PersonStatusId, ps.StatusDescription
from Person p
inner join PersonStatus ps
	on p.PersonStatusId = ps.PersonStatusId;
    
select p.PersonId, p.FirstName, p.LastName, ps.PersonStatusId, ps.StatusDescription
from PersonStatus ps
left outer join Person p
	on p.PersonStatusId = ps.PersonStatusId;