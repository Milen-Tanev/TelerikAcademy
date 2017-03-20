USE TelerikAcademy

--Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE username = 'Mitko'

DELETE FROM Groups
WHERE Id = 1