USE TelerikAcademy

----------------------------------
-- 14. Salary = specific values --
----------------------------------

  SELECT FirstName + ' ' + LastName as 'Full name', Salary
  FROM dbo.Employees
  WHERE (Salary = 25000) OR (Salary = 14000) OR (Salary = 12500) OR (Salary = 23600)
