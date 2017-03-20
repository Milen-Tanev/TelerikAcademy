USE TelerikAcademy

--------------------------------------
-- 20. Employees and their managers --
--------------------------------------

  SELECT e.FirstName + ' ' + e.LastName as 'Employee name', m.FirstName + ' ' + m.LastName as 'Manager name'
  FROM dbo.Employees e
  LEFT OUTER JOIN dbo.Employees m
  ON (e.ManagerID = m.EmployeeID)
  