USE TelerikAcademy

--Write a SQL query to display the average employee salary by department and job title.

SELECT AVG(e.Salary), d.Name, e.JobTitle
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID
GROUP BY e.DepartmentID, e.JobTitle, d.Name
ORDER BY AVG(e.Salary) DESC

--Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

SELECT MIN(e.Salary) as [MinimumSalary], d.Name as [DepartmentName], e.JobTitle, (
	SELECT TOP(1) em.FirstName + ' ' + em.LastName
	FROM Employees em
	WHERE em.Salary = MIN(e.Salary)) as [Employee]
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID
GROUP BY e.DepartmentID, e.JobTitle, d.Name
ORDER BY AVG(e.Salary) DESC

--Write a SQL query to display the town where maximal number of employees work.

SELECT ts.Name as [Most Common Town]
FROM Towns ts
WHERE ts.TownID = (
	SELECT TOP(1) a.TownID
	FROM Employees e
		JOIN Addresses a
			ON a.AddressID = e.AddressID
		JOIN Towns t
			ON a.TownID = t.TownID
	GROUP BY a.TownID, t.Name
	ORDER BY COUNT(*) DESC)

--Write a SQL query to display the number of managers from each town.

SELECT TOP(1) t.Name as [TownName], COUNT(*) as [ManagersCount]
FROM Employees e, Addresses a, Towns t
WHERE e.EmployeeID IN (
	SELECT m.ManagerID
	FROM Employees m) AND
	e.AddressID = a.AddressID AND
	a.TownID = t.TownID
GROUP BY t.Name 
ORDER BY COUNT(*) DESC