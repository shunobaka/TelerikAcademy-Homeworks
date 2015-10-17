USE TelerikAcademy

-- Task 04.
-- Write a SQL query to find all information about all departments. --

SELECT *
FROM Departments

-- Task 05.
-- Write a SQL query to find all department names. --

SELECT Name AS [Department Name]
FROM Departments

-- Task 06.
-- Write a SQL query to find the salary of each employee. --

SELECT Salary
FROM Employees

-- Task 07.
-- Write a SQL to find the full name of each employee. --

SELECT (FirstName + ' ' + LastName) AS [FullName]
FROM Employees

-- Task 08.
-- Write a SQL query to find the email addresses of each employee (by his first and last name).
-- Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com".
-- The produced column should be named "Full Email Addresses".

SELECT FirstName, LastName, (FirstName + '.' + LastName + '@telerik.com') AS [Full Email Addresses]
FROM Employees

-- Task 09.
-- Write a SQL query to find all different employee salaries.

SELECT DISTINCT Salary
FROM Employees

-- Task 10.
-- Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

SELECT *
FROM Employees e
WHERE e.JobTitle = 'Sales Representative'

-- Task 11.
-- Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT FirstName, LastName
FROM Employees e
WHERE e.FirstName LIKE 'SA%'

-- Task 12.
-- Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT FirstName, LastName
FROM Employees e
WHERE e.LastName LIKE '%ei%'

-- Task 13.
-- Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT FirstName, LastName, Salary
FROM Employees e
WHERE e.Salary BETWEEN 20000 AND 30000

-- Task 14.
-- Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT FirstName, LastName, Salary
FROM Employees e
WHERE e.Salary = 25000 OR e.Salary = 14000 OR e.Salary = 12500 OR e.Salary = 23600

-- Task 15.
-- Write a SQL query to find all employees that do not have manager.

SELECT *
FROM Employees e
WHERE e.ManagerID IS NULL

-- Task 16.
-- Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

SELECT FirstName, LastName, Salary
FROM Employees e
WHERE e.Salary > 50000
ORDER BY e.Salary DESC

-- Task 17.
-- Write a SQL query to find the top 5 best paid employees.

SELECT TOP 5 FirstName, LastName, Salary
FROM Employees e
ORDER BY e.Salary DESC

-- Task 18.
-- Write a SQL query to find all employees along with their address. Use inner join with ON clause.

SELECT FirstName, LastName, AddressText
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID

-- Task 19.
-- Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).

SELECT FirstName, LastName, AddressText
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

-- Task 20.
-- Write a SQL query to find all employees along with their manager.

SELECT e.FirstName, e.LastName, (m.FirstName + ' ' + m.LastName) AS [Manager Full Name]
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID

-- Task 21.
-- Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

SELECT e.FirstName, e.LastName, a.AddressText, (m.FirstName + ' ' + m.LastName) AS [Manager Full Name]
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON e.AddressID = a.AddressID

-- Task 22.
-- Write a SQL query to find all departments and all town names as a single list. Use UNION.

SELECT Name
FROM Departments
UNION
SELECT Name
FROM Towns

-- Task 23.
-- Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager.
-- Use right outer join.

SELECT (e.FirstName + ' ' + e.LastName) AS [Employee Full Name], (m.FirstName + ' ' + m.LastName) AS [Manager Full Name]
FROM Employees e
RIGHT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

-- Rewrite the query to use left outer join.

SELECT (e.FirstName + ' ' + e.LastName) AS [Employee Full Name], (m.FirstName + ' ' + m.LastName) AS [Manager Full Name]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

-- Task 24.
-- Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

SELECT FirstName, LastName, d.Name AS [Department Name], HireDate
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance')
AND (YEAR(e.HireDate) BETWEEN 1995 AND 2005)