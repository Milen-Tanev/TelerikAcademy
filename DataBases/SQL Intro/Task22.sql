USE TelerikAcademy

----------------------------------------------
-- 22. Departments and towns in single list --
----------------------------------------------

  Select Name as 'Towns and departments'
  FROM dbo.Departments
  UNION 
  SELECT Name
  FROM dbo.Towns
