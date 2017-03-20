USE TelerikAcademy

-------------------------------
-- 11. Name starts with "SA' --
-------------------------------


  SELECT FirstName + ' ' + LastName as 'Full name'
  FROM dbo.Employees
  WHERE FirstName LIKE 'SA%'

