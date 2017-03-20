USE AccountsDB

CREATE TABLE Persons
(
Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
FirstName varchar(30) NOT NULL,
LastName varchar(30) NOT NULL,
SSN char(9) NOT NULL
)

CREATE TABLE Accounts
(
Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
PersonId int FOREIGN KEY REFERENCES Persons(Id) NOT NULL,
Balance money
)