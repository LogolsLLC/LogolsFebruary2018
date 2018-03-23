use assessment;

CREATE TABLE `answer` (
  `AnswerId` int(11) NOT NULL AUTO_INCREMENT,
  `QuestionId` int(11) NOT NULL,
  `Text` varchar(250) DEFAULT NULL,
  `IsCorrect` bit(1) DEFAULT NULL,
  PRIMARY KEY (`AnswerId`),
  KEY `FK_Answer_Question` (`QuestionId`),
  CONSTRAINT `FK_Answer_Question` FOREIGN KEY (`QuestionId`) REFERENCES `question` (`QuestionId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

CREATE TABLE `assessment` (
  `AssessmentId` int(11) NOT NULL AUTO_INCREMENT,
  `LevelNumber` int(11) NOT NULL,
  `SubjectId` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`AssessmentId`),
  KEY `FK_Assessment_LevelNumber` (`LevelNumber`),
  KEY `FK_Assessment_Subject` (`SubjectId`),
  CONSTRAINT `FK_Assessment_LevelNumber` FOREIGN KEY (`LevelNumber`) REFERENCES `level` (`LevelNumber`),
  CONSTRAINT `FK_Assessment_Subject` FOREIGN KEY (`SubjectId`) REFERENCES `subject` (`SubjectId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

CREATE TABLE `level` (
  `LevelNumber` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`LevelNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `question` (
  `QuestionId` int(11) NOT NULL AUTO_INCREMENT,
  `AssessmentId` int(11) NOT NULL,
  `Text` varchar(250) DEFAULT NULL,
  `IsCorrect` bit(1) DEFAULT NULL,
  PRIMARY KEY (`QuestionId`),
  KEY `FK_Question_Assessment` (`AssessmentId`),
  CONSTRAINT `FK_Question_Assessment` FOREIGN KEY (`AssessmentId`) REFERENCES `assessment` (`AssessmentId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

CREATE TABLE `student` (
  `StudentId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  PRIMARY KEY (`StudentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `studentassessment` (
  `StudentAssessmentID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` int(11) NOT NULL,
  `AssessmentID` int(11) NOT NULL,
  `Score` decimal(5,3) DEFAULT NULL,
  `AssessmentDate` datetime DEFAULT NULL,
  PRIMARY KEY (`StudentAssessmentID`),
  KEY `FK_StudentAssessment_Student` (`StudentID`),
  KEY `FK_StudentAssessment_Assessment` (`AssessmentID`),
  CONSTRAINT `FK_StudentAssessment_Assessment` FOREIGN KEY (`AssessmentID`) REFERENCES `assessment` (`AssessmentId`),
  CONSTRAINT `FK_StudentAssessment_Student` FOREIGN KEY (`StudentID`) REFERENCES `student` (`StudentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `subject` (
  `SubjectId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SubjectId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;





