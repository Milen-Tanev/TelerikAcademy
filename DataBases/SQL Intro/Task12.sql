USE TelerikAcademy

-------------------------------
-- 12. Name contains 'ei' --
-------------------------------


  SELECT FirstName + ' ' + LastName as 'Full name'
  FROM dbo.Employees
  WHERE LastName LIKE '%ei%'
