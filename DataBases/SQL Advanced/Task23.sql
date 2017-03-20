USE TelerikAcademy

--Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.

UPDATE Users
SET [Password] = NULL
WHERE CONVERT(datetime, lastlogin, 1) < CONVERT(datetime, '03/10/10', 1) OR lastlogin IS NULL