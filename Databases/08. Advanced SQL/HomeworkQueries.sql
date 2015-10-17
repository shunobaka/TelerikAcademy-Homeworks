USE TelerikAcademy

-- Task 01.
-- Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
--		Use a nested SELECT statement.

SELECT FirstName, LastName, Salary
FROM Employees e
WHERE e.Salary = (SELECT MIN(Salary) FROM Employees)

-- Task 02.
-- Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

SELECT FirstName, LastName, Salary
FROM Employees e
WHERE e.Salary 
	BETWEEN (SELECT MIN(Salary) FROM Employees)
	AND (SELECT MIN(Salary) FROM Employees) * 1.1

-- Task 03.
-- Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
--		Use a nested SELECT statement.

SELECT (e.FirstName + ' ' + e.LastName) AS [FullName], e.Salary, d.Name 
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = (SELECT MIN(Salary) FROM Employees e
					WHERE e.DepartmentID = d.DepartmentID)

-- Task 04.
-- Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS [Average Salary]
FROM Employees e
WHERE e.DepartmentID = 1

-- Task 05.
-- Write a SQL query to find the average salary in the "Sales" department.

SELECT AVG(Salary) AS [Average Sales Salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Task 06.
-- Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(*) AS [Employees in Sales]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Task 07.
-- Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(ManagerId) AS [Employees with Manager]
FROM Employees

-- Task 08.
-- Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(*) AS [Employees without Manager]
FROM Employees e
WHERE e.ManagerID IS NULL

-- Task 09.
-- Write a SQL query to find all departments and the average salary for each of them.

SELECT DISTINCT d.Name, AVG(e.Salary) AS [Average Salary]
FROM Departments d
JOIN Employees e
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- Task 10.
-- Write a SQL query to find the count of all employees in each department and for each town.

SELECT COUNT(e.EmployeeID) AS [Employees count], t.Name AS [Town Name], d.Name AS [Department Name] 
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY d.Name, t.Name

-- Task 11.
-- Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT m.FirstName AS [Manager FirstName], m.LastName AS [Manager LastName], COUNT(e.EmployeeID) AS [Number of Employees]
FROM Employees m
JOIN Employees e
ON e.ManagerID = m.EmployeeID
GROUP BY m.EmployeeID, m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) = 5

-- Task 12.
-- Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

SELECT (e.FirstName + ' ' + e.LastName) AS [Employee], COALESCE(m.FirstName + ' ' + m.LastName, '(no manager)') AS [Manager]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

-- Task 13.
-- Write a SQL query to find the names of all employees whose last name is exactly 5 characters long.
-- Use the built-in LEN(str) function.

SELECT FirstName, LastName
FROM Employees e
WHERE LEN(e.LastName) = 5

-- Task 14.
-- Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".

SELECT FORMAT(GETDATE(),'dd.MM.yyyy HH:mm:ss:fff') AS [Current Date and Time]

-- Task 15.
-- Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--		Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--		Define the primary key column as identity to facilitate inserting records.
--		Define unique constraint to avoid repeating usernames.
--		Define a check constraint to ensure the password is at least 5 characters long.

CREATE TABLE Users(
	UserId int IDENTITY,
	Username nvarchar(30) UNIQUE NOT NULL,
	Password nvarchar(30),
	FullName nvarchar(50) NOT NULL,
	LastLogin datetime DEFAULT(Null),
	CHECK(LEN(Password) > 4),
	CONSTRAINT PK_Users PRIMARY KEY(UserId)
)

-- Task 16.
-- Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
--		Test if the view works correctly.

CREATE VIEW [Recent Users] AS
SELECT UserId, Username, FullName
FROM Users
WHERE DATEDIFF(DAY, LastLogin, GETDATE()) = 0

-- Task 17.
-- Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--		Define primary key and identity column.

CREATE TABLE Groups(
	GroupId int IDENTITY Primary Key,
	Name nvarchar(25) UNIQUE
)

-- Task 18.
-- Write a SQL statement to add a column GroupID to the table Users.
--		Fill some data in this new column and as well in the `Groups table.
--		Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

ALTER TABLE Users
ADD GroupId int

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups FOREIGN KEY (GroupId)
REFERENCES Groups(GroupId)

-- Task 19.
-- Write SQL statements to insert several records in the Users and Groups tables.

INSERT INTO Users(Username, Password, FullName, LastLogin)
	VALUES ('goshkoooo', 'azsumgosho', 'Gosho Ivanov', GETDATE())
INSERT INTO Users(Username, Password, FullName, LastLogin)
	VALUES ('pesho', 'peshka', 'Pesho Gosho', GETDATE())
INSERT INTO Users(Username, Password, FullName, LastLogin)
	VALUES ('gergan', 'hubaveca', 'Gergi Nikol', GETDATE())
INSERT INTO Groups(Name) VALUES ('A')
INSERT INTO Groups(Name) VALUES ('B')

-- Task 20.
-- Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Users
SET FullName = 'Kutiq Taini'
WHERE FullName = 'Gergi Nikol'

UPDATE Groups
SET Name = 'Stupid'
WHERE Name = 'A'

-- Task 21.
-- Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users
WHERE FullName = 'Kutiq Taini'

DELETE FROM Groups
WHERE Name = 'B'

-- Task 22.
-- Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--		Combine the first and last names as a full name.
--		For username use the first letter of the first name + the last name (in lowercase).
--		Use the same for the password, and NULL for last login time.

INSERT INTO Users (Username, Password, FullName, LastLogin)
	(SELECT LEFT(FirstName, 1) + LOWER(LastName) + CAST(EmployeeID AS nvarchar(3)),
	LEFT(FirstName, 1) + LOWER(LastName) + CAST(EmployeeID AS nvarchar(3)),
	FirstName + ' ' + LastName,
	NULL
	FROM Employees)
GO

-- Task 23.
-- Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.

UPDATE Users
SET Password = NULL
WHERE LastLogin < DATEFROMPARTS(2010, 10, 03)

-- Task 24.
-- Write a SQL statement that deletes all users without passwords (NULL password).

DELETE FROM Users
WHERE Password IS NULL

-- Task 25.
-- Write a SQL query to display the average employee salary by department and job title.

SELECT AVG(Salary) AS [Average Salary], Name AS [Department], JobTitle
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

-- Task 26.
-- Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

SELECT MIN(Salary) AS [Average Salary],
	   MIN(FirstName + ' ' + LastName) AS [Employee],
	   Name AS [Department],
	   JobTitle
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

-- Task 27.
-- Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 t.Name, COUNT(*) AS [Employee Count]
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Employee Count] Desc

-- Task 28.
-- Write a SQL query to display the number of managers from each town.

SELECT COUNT(DISTINCT e.ManagerID) AS [Count of Managers], t.Name AS [Town]
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
on e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY t.Name

-- Task 29.
-- Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
--		Don't forget to define identity, primary key and appropriate foreign key.
--		Issue few SQL statements to insert, update and delete of some data in the table.
--		Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--		For each change keep the old record data, the new record data and the command (insert / update / delete).

-- Creating WorkHours Table

CREATE TABLE WorkHours(
	Id int IDENTITY PRIMARY KEY,
	EmployeeId int,
	OnDate datetime,
	Task nvarchar(50),
	HoursOfWork int,
	Comments nvarchar(150),
	CONSTRAINT FK_Employees_WorkHours
		FOREIGN KEY (EmployeeId)
		REFERENCES Employees(EmployeeId)
)
GO

-- Inserting data into WorkHours

INSERT INTO WorkHours(EmployeeId, OnDate, Task, HoursOfWork) VALUES (15, GETDATE(), 'Do nothing', 15)
INSERT INTO WorkHours(EmployeeId, OnDate, Task, HoursOfWork) VALUES (15, GETDATE(), 'Scroll 9gag', 24)
INSERT INTO WorkHours(EmployeeId, OnDate, Task, HoursOfWork) VALUES (15, GETDATE(), 'Be productive', 1)
INSERT INTO WorkHours(EmployeeId, OnDate, Task, HoursOfWork) VALUES (35, GETDATE(), 'omg', 2)
INSERT INTO WorkHours(EmployeeId, OnDate, Task, HoursOfWork) VALUES (40, GETDATE(), 'wtf', 5)

-- Updating data from WorkHours

UPDATE WorkHours
	SET EmployeeId = 20
	WHERE Task = 'Do nothing'
UPDATE WorkHours
	SET Comments = 'This was fun'
	WHERE Task = 'Scroll 9gag'

-- Deleteing some data from WorkHours

DELETE FROM WorkHours
	WHERE EmployeeId = 20

-- Creating WorkHoursLogs Table

CREATE TABLE WorkHoursLogs(
	Id int IDENTITY PRIMARY KEY,
	EmployeeId int,
	OnDate datetime,
	Task nvarchar(50),
	HoursOfWork int,
	Comments nvarchar(150),
	Command nvarchar(15) NOT NULL,
	CONSTRAINT FK_Employees_WorkHoursLogs
		FOREIGN KEY (EmployeeId)
		REFERENCES Employees(EmployeeId)
)
GO

-- Creating triggers for Update, Delete, Insert

CREATE TRIGGER tr_InsertWorkHours ON WorkHours
FOR INSERT AS
	INSERT INTO WorkHoursLogs(EmployeeId, OnDate, Task, HoursOfWork, Comments, Command)
		SELECT EmployeeId, OnDate, Task, HoursOfWork, Comments, 'Insert'
		FROM inserted
GO

CREATE TRIGGER tr_DeleteWorkHours ON WorkHours
FOR DELETE AS
	INSERT INTO WorkHoursLogs(EmployeeId, OnDate, Task, HoursOfWork, Comments, Command)
		SELECT EmployeeId, OnDate, Task, HoursOfWork, Comments, 'Delete'
		FROM deleted
GO

CREATE TRIGGER tr_UpdateWorkHours ON WorkHours
FOR UPDATE AS
	INSERT INTO WorkHoursLogs(EmployeeId, OnDate, Task, HoursOfWork, Comments, Command)
		SELECT EmployeeId, OnDate, Task, HoursOfWork, Comments, 'UpdateDelete'
		FROM deleted
	INSERT INTO WorkHoursLogs(EmployeeId, OnDate, Task, HoursOfWork, Comments, Command)
		SELECT EmployeeId, OnDate, Task, HoursOfWork, Comments, 'UpdateInsert'
		FROM inserted
GO

-- Testing triggers

UPDATE WorkHours
SET EmployeeId = 21
WHERE EmployeeId = 20

DELETE FROM WorkHours
WHERE EmployeeId = 21

INSERT INTO WorkHours(EmployeeId, OnDate, Task, HoursOfWork) VALUES (192, GETDATE(), 'idk', 23)

-- Task 30.
-- Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
--		At the end rollback the transaction.

BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees

ALTER TABLE WorkHoursLogs
DROP CONSTRAINT FK_Employees_WorkHoursLogs

DELETE e
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

ROLLBACK TRAN

-- Task 31.
-- Start a database transaction and drop the table EmployeesProjects.
--		Now how you could restore back the lost table data?

BEGIN TRAN

DROP TABLE EmployeesProjects

ROLLBACK TRAN

-- Task 32.
-- Find how to use temporary tables in SQL Server.
--		Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.

BEGIN TRANSACTION

    SELECT * 
        INTO #TempEmployeesProjects
        FROM EmployeesProjects

    DROP TABLE EmployeesProjects

    SELECT * 
        INTO EmployeesProjects
        FROM #TempEmployeesProjects

    DROP TABLE #TempEmployeesProjects

ROLLBACK TRANSACTION