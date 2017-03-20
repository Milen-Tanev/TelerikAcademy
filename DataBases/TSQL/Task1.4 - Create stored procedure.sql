USE AccountsDB
GO

CREATE PROC AllPersons
AS
	SELECT FirstName + ' ' + LastName AS 'Full name'
	FROM Persons
GO

--TEST--
EXECUTE AllPersons