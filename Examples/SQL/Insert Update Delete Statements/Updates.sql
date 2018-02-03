USE Assessment;
update timetraveler
	set FirstName = 'Tim'
where TimeTravelerId = 2;

select * 
from timetraveler;

update timetravellog
	set TimeTravelerId = 1
    ,TravelToYear = 1977
where TimeTravelerId = 2
	and TravelToYear = 1976;

select * 
from timetravellog

