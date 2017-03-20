USE TelerikAcademy

--Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--Define primary key and identity column.

CREATE TABLE Groups (
	Id int NOT NULL IDENTITY PRIMARY KEY,
	GroupName nvarchar(30) UNIQUE
	)