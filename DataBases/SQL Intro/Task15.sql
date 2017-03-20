USE TelerikAcademy

-----------------------------------
-- 15. Employees without manager --
-----------------------------------

  SELECT FirstName + ' ' + LastName as 'Full name'
  FROM dbo.Employees
  WHERE ManagerID IS NULL
