USE TelerikAcademy

----------------------------
-- 19. Employee addresses --
----------------------------

  SELECT FirstName + ' ' + LastName as 'Full name', AddressText
  FROM dbo.Employees n, dbo.Addresses s
  WHERE (n.AddressID = s.AddressID)