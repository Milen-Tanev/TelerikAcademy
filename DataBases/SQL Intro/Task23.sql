USE TelerikAcademy

--------------------------------------
-- 23. Employees and their managers --
--------------------------------------

------------- LEFT OUTER -------------
  SELECT e.FirstName + ' ' + e.LastName as 'Employee name', m.FirstName + ' ' + m.LastName as 'Manager name'
  FROM dbo.Employees e
  LEFT OUTER JOIN dbo.Employees m
  ON (e.ManagerID = m.EmployeeID)

  ------------- RIGHT OUTER -------------
  SELECT e.FirstName + ' ' + e.LastName as 'Employee name', m.FirstName + ' ' + m.LastName as 'Manager name'
  FROM dbo.Employees m
  RIGHT OUTER JOIN dbo.Employees e
  ON (e.ManagerID = m.EmployeeID)
  