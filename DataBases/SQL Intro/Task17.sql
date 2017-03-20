USE TelerikAcademy

-------------------------
-- 17. TOP 5 best paid --
-------------------------

  SELECT TOP 5 FirstName + ' ' + LastName as 'Full name', Salary
  FROM dbo.Employees
  ORDER BY Salary DESC