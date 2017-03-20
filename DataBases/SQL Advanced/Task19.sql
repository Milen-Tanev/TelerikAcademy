USE TelerikAcademy

--Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Users (username, [Password], FullName)
	VALUES
	('Ivan', '123qwe', 'Ivan Ivanov'),
	('Mitko', '321qwe', 'Dimitar Dimitrov'),
	('Tosho', 'password', 'Todor Todorov')

INSERT INTO Groups (GroupName)
	VALUES('Group1'),
		('Group2')