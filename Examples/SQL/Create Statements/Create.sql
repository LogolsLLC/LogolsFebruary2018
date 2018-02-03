USE Assessment;
CREATE TABLE TimeTraveler (
  TimeTravelerId int(11) NOT NULL AUTO_INCREMENT,
  FirstName varchar(100) NOT NULL,
  LastName varchar(100) NOT NULL,
  PRIMARY KEY (`TimeTravelerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE TimeTravelLog (
  TimeTravelLogId int(11) NOT NULL AUTO_INCREMENT,
  TimeTravelerId int(11) NOT NULL,
  TravelToYear int(11) NOT NULL,
  TravelDate datetime DEFAULT NULL,
  PRIMARY KEY (`TimeTravelLogId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

