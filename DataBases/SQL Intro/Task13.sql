USE TelerikAcademy

------------------------------
-- 13. Salary 20000 - 30000 --
------------------------------

  SELECT FirstName + ' ' + LastName as 'Full name', Salary
  FROM dbo.Employees
  WHERE (Salary > 20000) AND (Salary < 30000)
