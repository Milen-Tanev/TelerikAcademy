USE TelerikAcademy

-----------------------------
-- 8. Emails of employees: --
-----------------------------
SELECT FirstName + ' ' + LastName
as 'Full names', FirstName + '.' + LastName + '@telerik.com'
as 'Full Email Addresses'
FROM dbo.Employees
