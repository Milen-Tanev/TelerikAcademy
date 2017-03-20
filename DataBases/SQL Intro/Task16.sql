USE TelerikAcademy

----------------------------
-- 16. Order decreasingly---
--- where salary > 50000 ---
----------------------------

  SELECT FirstName + ' ' + LastName as 'Full name', Salary
  FROM dbo.Employees
  WHERE Salary > 50000
  ORDER BY Salary DESC