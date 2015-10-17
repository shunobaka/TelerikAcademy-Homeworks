CREATE DATABASE Library;

USE Library;

CREATE TABLE Books (
  id mediumint(8) unsigned NOT NULL auto_increment,
  Title varchar(80) default NULL,
  Author varchar(40) default NULL,
  PublishDate datetime,
  ISBN varchar(36) NOT NULL,
  PRIMARY KEY (id)
) AUTO_INCREMENT=1;

INSERT INTO Books(Title, Author, PublishDate, ISBN) VALUES ("C#", "Some Guy", '2015-12-02', "DASDSDA433243"),
("Javascript is a woman", "Pavel Kolev", '2133-02-20', "EPIC-BOOK"),
("Just", "Another Book", '1995-01-01', "SOME-RANDOM-ISBN"),
("OhLook", "Thatis Book", '1600-04-30', "C57B4BE4-8E4F-E983-171C-4225F33D620D");