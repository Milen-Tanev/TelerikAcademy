USE TelerikAcademy

------------------------------------------
-- 24. Employees from sales and finance --
------ hired between 1995 and 2005 -------

  SELECT e.FirstName + ' ' + e.LastName as 'Full name', d.Name as 'Department', e.HireDate as 'Hire date'
  FROM dbo.Employees e, dbo.Departments d
  WHERE (d.DepartmentID = e.DepartmentID)
  AND ((d.Name = 'Sales') OR (d.Name = 'Finance'))
  AND (e.HireDate > '1995') AND (e.HireDate < '2005')