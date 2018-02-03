select ttl.TimeTravelLogId, ttl.TravelToYear, ttl.TravelDate, tt.FirstName, tt.LastName
from timetravellog ttl
inner join timetraveler tt
	on ttl.TimeTravelerId = tt.TimeTravelerId;

select ttl.TimeTravelLogId, ttl.TravelToYear, ttl.TravelDate, tt.FirstName, tt.LastName
from timetravellog ttl
left outer join timetraveler tt
	on ttl.TimeTravelerId = tt.TimeTravelerId;
    
select ttl.TimeTravelLogId, ttl.TravelToYear, ttl.TravelDate, tt.FirstName, tt.LastName
from timetravellog ttl
right outer join timetraveler tt
	on ttl.TimeTravelerId = tt.TimeTravelerId;
    
select ttl.TimeTravelLogId, ttl.TravelToYear, ttl.TravelDate, tt.FirstName, tt.LastName
from timetraveler tt
left outer join timetravellog ttl
	on ttl.TimeTravelerId = tt.TimeTravelerId;