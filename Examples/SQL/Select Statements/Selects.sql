select * 
from timetraveler;

select * 
from timetravellog;

select FirstName, LastName
from timetraveler
where LastName = 'Masters';

select TravelDate
from timetravellog
where TimeTravelerId = 4 and TravelToYear = 1976;

select TimeTravelerId
from timetravellog
where TravelToYear = 2005 or TravelToYear = 1976;