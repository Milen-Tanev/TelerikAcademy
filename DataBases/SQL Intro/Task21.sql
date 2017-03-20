USE TelerikAcademy

-----------------------------------------------
-- 21. Employees with managers and addresses --
-----------------------------------------------

  SELECT e.FirstName + ' ' + e.LastName as 'Employee name',
  m.FirstName + ' ' + m.LastName as 'Manager name', a.AddressText as 'Full Address'
  FROM dbo.Employees e
  LEFT OUTER JOIN dbo.Employees m
  ON (e.ManagerID = m.EmployeeID)
  INNER JOIN dbo.Addresses a
  ON (e.AddressID = a.AddressID)
  