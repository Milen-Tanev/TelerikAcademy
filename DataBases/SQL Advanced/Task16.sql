USE TelerikAcademy

--Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
--Test if the view works correctly.
GO
CREATE VIEW LoggedToday AS
SELECT FullName AS 'Full name'
FROM SQLAdvancedHhomework.dbo.Users u
WHERE CAST(u.LastLogin AS DATE) = CAST(GETDATE() AS DATE)
