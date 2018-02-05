CREATE TABLE Person (
  PersonId int(11) NOT NULL AUTO_INCREMENT,
  FirstName varchar(100) NOT NULL,
  LastName varchar(100) NOT NULL,
  PersonStatusId int(11) NOT NULL,
  PRIMARY KEY (`PersonId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE PersonStatus (
  PersonStatusId int(11) NOT NULL,
  StatusDescription varchar(100) NOT NULL,
  PRIMARY KEY (`PersonStatusId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

