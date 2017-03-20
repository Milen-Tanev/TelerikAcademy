USE TelerikAcademy

--Select only the funciton you wish to execute

--Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
--Use a nested SELECT statement.
SELECT FirstName + ' ' + LastName AS 'Full name', Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary)
	FROM Employees)

--Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT FirstName + ' ' + LastName AS 'Full name', Salary
FROM Employees
WHERE Salary <= 1.1 *
	(SELECT MIN(Salary)
	FROM Employees)

--Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
--Use a nested SELECT statement.
SELECT firstName + ' ' + lastName as 'Full name', Salary, d.Name as 'Department'
FROM Employees, Departments d
WHERE Salary =
	(SELECT MIN(e.Salary)
	FROM Employees e, Departments d
	WHERE e.DepartmentID = d.DepartmentID)
ORDER BY d.Name

--Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) AS 'Average salary', d.Name AS 'Department'
FROM Employees e, Departments d
WHERE d.DepartmentID = 1
GROUP BY d.Name

--Write a SQL query to find the average salary in the "Sales" department.
SELECT AVG(Salary) as 'Average salary', d.Name as 'Department'
FROM Employees, Departments d
WHERE d.NAME = 'Sales'
GROUP BY d.Name

--Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) as 'Number of employees'
FROM Employees e
WHERE e.DepartmentID = 
	(SELECT d.DepartmentID
	FROM Departments d
	WHERE d.Name = 'Sales')

--Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*) AS 'Not managers'
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) AS 'Managers'
FROM Employees e
WHERE e.ManagerID IS NULL

--Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name AS 'Department', AVG(e.Salary) as 'Average salary'
FROM Departments d, Employees e
GROUP BY d.Name

--Write a SQL query to find the count of all employees in each department and for each town.
SELECT COUNT(*) as 'Employees', d.Name as 'Department', t.Name as 'Town'
FROM Employees e, Departments d, Towns t, Addresses a
WHERE e.DepartmentID = d.DepartmentID AND e.AddressID = a.AddressID AND a.TownID = t.TownID
GROUP BY d.Name, t.Name

--Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.firstName + ' '+ m.lastName as 'Full name'
FROM Employees m
WHERE m.EmployeeID IN
	(SELECT e.ManagerID
	FROM Employees e
	GROUP BY e.ManagerID
	HAVING COUNT(*) = 5)

--Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT e.firstName + ' ' + e.lastName as 'Employee',
	ISNULL(m.firstName + ' ' + m.lastName, ('no manager')) as 'Manager'
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

--Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT e.firstName + ' ' + e.lastName as 'Full name'
FROM Employees e
WHERE LEN(e.lastName) = 5

--Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
--Search in Google to find how to format dates in SQL Server.
SELECT CONVERT(VARCHAR(8),GETDATE(),4) + ' ' + CONVERT(VARCHAR(12), GETDATE(), 14) AS 'Current time'
