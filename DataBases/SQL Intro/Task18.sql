USE TelerikAcademy

----------------------------
-- 18. Employee addresses --
----------------------------

  SELECT FirstName + ' ' + LastName as 'Full name', AddressText
  FROM dbo.Employees n
  INNER JOIN dbo.Addresses s
  ON (n.AddressID = s.AddressID)