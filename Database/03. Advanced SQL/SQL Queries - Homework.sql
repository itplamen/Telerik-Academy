-- 01. Write a SQL query to find the names and salaries of
-- the employees that take the minimal salary in the
-- company. Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS [Employee], Salary
FROM [TelerikAcademy].[dbo].[Employees]
WHERE Salary = 
	(SELECT MIN(Salary) FROM [TelerikAcademy].[dbo].[Employees])


-- 02. Write a SQL query to find the names and salaries of
-- the employees that have a salary that is up to 10%
-- higher than the minimal salary for the company.

SELECT FirstName + ' ' + LastName AS [Employee], Salary
FROM [TelerikAcademy].[dbo].[Employees]
WHERE Salary = 
	(Select MIN(Salary) + (MIN(Salary) * 0.1) FROM [TelerikAcademy].[dbo].[Employees])


-- 03. Write a SQL query to find the full name, salary and
-- department of the employees that take the minimal
-- salary in their department. Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName AS [Employee], e.Salary, d.Name AS [Department]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = 
	(SELECT MIN(em.Salary) FROM [TelerikAcademy].[dbo].[Employees] em
	WHERE em.DepartmentID = d.DepartmentID)
	 
 
-- 04. Write a SQL query to find the average salary in the
-- department #1

SELECT e.DepartmentID, d.Name AS [Department],  AVG(e.Salary) AS [Average salary]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.DepartmentID, d.Name
HAVING e.DepartmentID = 1
	 
 
-- 05.  Write a SQL query to find the average salary in the
-- "Sales" department.

SELECT e.DepartmentID, d.Name AS [Department],  AVG(e.Salary) AS [Average salary]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.DepartmentID, d.Name
HAVING d.name = 'Sales'
	 
 
-- 06. Write a SQL query to find the number of employees
-- in the "Sales" department.

SELECT e.DepartmentID, d.Name AS [Department],  COUNT(e.EmployeeID) AS [Number of employees]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.DepartmentID, d.Name
HAVING d.name = 'Sales'
	 
 
-- 07.  Write a SQL query to find the number of all
-- employees that have manager.

SELECT COUNT(ManagerID) AS [Number of managers]
FROM [TelerikAcademy].[dbo].[Employees]
	 
 
-- 08. Write a SQL query to find the number of all
-- employees that have no manager.

SELECT COUNT(EmployeeID) AS [Employees with no manager]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE ManagerID IS NULL
	 
 
-- 09. Write a SQL query to find all departments and the
-- average salary for each of them.

SELECT d.Name AS [Department],  AVG(e.Salary) AS [Average salary]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name


-- 10. Write a SQL query to find the count of all employees
-- in each department and for each town.

SELECT d.Name AS [Department], t.Name AS [Town], COUNT(e.EmployeeID) AS [Number of employees]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
	JOIN [TelerikAcademy].[dbo].[Addresses] a
		ON e.AddressID = a.AddressID
	JOIN [TelerikAcademy].[dbo].[Towns] t
		ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name


-- 11. Write a SQL query to find all managers that have
-- exactly 5 employees. Display their first name and
-- last name.

SELECT e.EmployeeID AS [ManagerID], e.FirstName + ' ' + e.LastName AS [Manager], 
		COUNT(e.EmployeeID) AS [Number of employees]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Employees] m
		ON m.ManagerID = e.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(e.EmployeeID) = 5


-- 12. Write a SQL query to find all employees along with
-- their managers. For employees that do not have
-- manager display the value "(no manager)".

SELECT e.FirstName + ' ' + e.LastName AS [Employee],  
		ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') AS [Manager]
FROM [TelerikAcademy].[dbo].[Employees] e
	LEFT JOIN [TelerikAcademy].[dbo].[Employees] m
		ON e.ManagerID = m.EmployeeID
ORDER BY Manager 
 

-- 13. Write a SQL query to find the names of all
-- employees whose last name is exactly 5 characters
-- long. Use the built-in LEN(str) function.

SELECT FirstName + ' ' + LastName AS [Employee]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE LEN(LastName) = 5
 

-- 14. Write a SQL query to display the current date and
-- time in the following format "day.month.year
-- hour:minutes:seconds:milliseconds". Search in
-- Google to find how to format dates in SQL Server.

SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff') AS [Current date]	


-- 15. Write a SQL statement to create a table Users.
-- Users should have username, password, full name
-- and last login time. Choose appropriate data types
-- for the table fields. Define a primary key column
-- with a primary key constraint. Define the primary
-- key column as identity to facilitate inserting records.
-- Define unique constraint to avoid repeating
-- usernames. Define a check constraint to ensure the
-- password is at least 5 characters long.

CREATE TABLE Users (
	UserID int IDENTITY,
	Username nvarchar(50) NOT NULL CHECK(LEN(Username) > 3),
	Password nvarchar(50) NOT NULL CHECK(LEN(Password) > 8),
	FullName nvarchar(50) NOT NULL CHECK(LEN(FullName) > 3),
	LastLoginTime DATETIME,
	CONSTRAINT PK_Users PRIMARY KEY(UserID),
    CONSTRAINT UQ_Username UNIQUE(Username),
) 
GO


-- 16. Write a SQL statement to create a view that displays
-- the users from the Users table that have been in the
-- system today. Test if the view works correctly.

CREATE VIEW [Users in the system today] AS
SELECT * 
FROM Users
WHERE DATEPART(DAY, LastLoginTime) = DATEPART(DAY, GETDATE())


-- 17. Write a SQL statement to create a table Groups.
-- Groups should have unique name (use unique
-- constraint). Define primary key and identity column.

CREATE TABLE Groups (
	GroupID int IDENTITY,
	Name nvarchar(50) NOT NULL CHECK(LEN(Name) > 3),
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
	CONSTRAINT UQ_Name UNIQUE(Name),
)
GO


-- 18. Write a SQL statement to add a column GroupID to
-- the table Users. Fill some data in this new column
-- and as well in the Groups table. Write a SQL
-- statement to add a foreign key constraint between
-- tables Users and Groups tables.

ALTER TABLE Users
ADD GroupID int
GO

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY(GroupID)
	REFERENCES Groups(GroupID)
GO


-- 19. Write SQL statements to insert several records in
-- the Users and Groups tables.

INSERT INTO Groups VALUES
('Php intro'),
('Programming with JAVA'),
('C# Part 2'),
('JavaScript OOP'),
('Database'),
('ASP MVC')

INSERT INTO Users VALUES
('username1', 'password1', 'Ivan Ivanov', GETDATE(), 1),
('username2', 'password2', 'Kiril Kirilov', GETDATE(), 2),
('username3', 'password3', 'Grigor Grigorov', GETDATE(), 3),
('username4', 'password4', 'Maria Mitkova', GETDATE(), 4),
('username5', 'password5', 'Desislava Hristova', GETDATE(), 5),
('username6', 'password6', 'Nikolay Dimitrov', GETDATE(), 6)


-- 20. Write SQL statements to update some of the
-- records in the Users and Groups tables.

UPDATE Users
SET Password = (Password + ' (updated)')
WHERE UserID = 6


-- 21. Write SQL statements to delete some of the records
-- from the Users and Groups tables.

DELETE FROM Users
WHERE UserID = 6

DELETE FROM Groups
WHERE GroupID = 6

 
-- 22. Write SQL statements to insert in the Users table
-- the names of all employees from the Employees
-- table. Combine the first and last names as a full
-- name. For username use the first letter of the first
-- name + the last name (in lowercase). Use the same
-- for the password, and NULL for last login time.


INSERT INTO Users (Username, Password, FullName, LastLoginTime)
	(SELECT CONCAT('user', e.EmployeeID, '_') + LOWER(LEFT(e.FirstName, 1) + LEFT(e.LastName, 1)), 
			CONCAT('password_', LOWER(LEFT(e.FirstName, 1) + LEFT(e.LastName, 1))),
			e.FirstName + ' ' + e.LastName, 
			NULL
	FROM [TelerikAcademy].[dbo].[Employees] e)
GO


-- 23. Write a SQL statement that changes the password
-- to NULL for all users that have not been in the
-- system since 10.03.2010.
 
UPDATE Users
SET Password = NULL
WHERE LastLoginTime > '20100310' 


-- 24. Write a SQL statement that deletes all users without
-- passwords (NULL password).
 
DELETE FROM Users
WHERE Password = NULL 


-- 25. Write a SQL query to display the average employee
-- salary by department and job title.

SELECT d.Name AS [Department], e.JobTitle, AVG(e.Salary) AS [Average Salary]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name


-- 26. Write a SQL query to display the minimal employee
-- salary by department and job title along with the
-- name of some of the employees that take it.

SELECT d.Name AS [Department], e.JobTitle, MIN(e.FirstName + ' ' + e.LastName) AS [Employee], MIN(e.Salary) AS [Minimal Salary]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, FirstName
ORDER BY d.Name


-- 27. Write a SQL query to display the town where
-- maximal number of employees work.

SELECT TOP(1) t.Name AS [Town], COUNT(e.EmployeeID) AS [Employees]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Addresses] a
		ON e.AddressID = a.AddressID
	JOIN [TelerikAcademy].[dbo].[Towns] t
		ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY Employees DESC


-- 28. Write a SQL query to display the number of
-- managers from each town.

SELECT t.Name AS [Town], COUNT(e.ManagerID) AS [Managers]
FROM [TelerikAcademy].[dbo].[Employees] e
	JOIN [TelerikAcademy].[dbo].[Addresses] a
		ON e.AddressID = a.AddressID
	JOIN [TelerikAcademy].[dbo].[Towns] t
		ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY Managers DESC


-- 29. Write a SQL to create table WorkHours to store
-- work reports for each employee (employee id, date,
-- task, hours, comments). Don't forget to define
-- identity, primary key and appropriate foreign key.

-- Issue few SQL statements to insert, update and
-- delete of some data in the table.

-- Define a table WorkHoursLogs to track all changes
-- in the WorkHours table with triggers. For each
-- change keep the old record data, the new record
-- data and the command (insert / update / delete).

CREATE TABLE WorkHours(
	WorkReportID int IDENTITY,
	EmployeeID int NOT NULL,
	Date DATETIME NOT NULL,
	Task nvarchar(200) NOT NULL,
	Hours int NOT NULL CHECK(Hours > 0),
	Comments nvarchar(200) NOT NULL
	CONSTRAINT PK_WorkHours PRIMARY KEY(WorkReportID)
	CONSTRAINT FR_WorkHours_Employees
		FOREIGN KEY(EmployeeID)
		REFERENCES Employees(EmployeeID)
)
GO

-- Insert data
INSERT INTO WorkHours(EmployeeID, Date, Task, Hours, Comments)
	(SELECT e.EmployeeID, GETDATE(), 'Programming', 8, 'Excellent work!'
	FROM [TelerikAcademy].[dbo].[Employees] e
	WHERE e.EmployeeID <= 50)
GO

-- Update data
UPDATE WorkHours
SET Hours = 6, Comments = 'Very good work!'
WHERE EmployeeID <= 10

-- Delete data
DELETE WorkHours
WHERE EmployeeID > 20

CREATE TABLE WorkHoursLogs(
	WorkLogID int IDENTITY,
	EmployeeID int NOT NULL,
	Date DATETIME NOT NULL,
	Task nvarchar(200) NOT NULL,
	Hours int NOT NULL CHECK(Hours > 0),
	Comments nvarchar(200) NOT NULL,
	Command nvarchar(50) NOT NULL CHECK(Command IN('INSERT', 'UPDATE', 'DELETE'))
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(WorkLogID)
	CONSTRAINT FK_WorkHoursLogs_Employees
		FOREIGN KEY(EmployeeID)
		REFERENCES Employees(EmployeeID)
)
GO

-- Trigger for insert
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT AS
BEGIN
	INSERT INTO WorkHoursLogs(EmployeeID, Date, Task, Hours, Comments, Command)
		SELECT EmployeeID, Date, Task, Hours, Comments, 'INSERT'
		FROM INSERTED
	PRINT 'Trigger fired. New inserted data in table WorkHours.'
END
GO

-- Trigger for update
CREATE TRIGGER tr_UpdateWorkRepotrs ON WorkHours FOR UPDATE AS
BEGIN
	INSERT INTO WorkHoursLogs(EmployeeID, Date, Task, Hours, Comments, Command)
		SELECT EmployeeID, Date, Task, Hours, Comments, 'UPDATE'
		FROM INSERTED
	
	INSERT INTO WorkHoursLogs(EmployeeID, Date, Task, Hours, Comments, Command)
		SELECT EmployeeID, Date, Task, Hours, Comments, 'UPDATE'
		FROM DELETED

	PRINT 'Trigger fired. New updated data from table WorkHours.'
END
GO

-- Trigger for delete
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE AS
BEGIN
	INSERT INTO WorkHoursLogs(EmployeeID, Date, Task, Hours, Comments, Command)
		SELECT EmployeeID, Date, Task, Hours, Comments, 'DELETE'
		FROM DELETED
	PRINT 'Trigger fired. New deleted data from table WorkHours.'
END
GO

-- Tests triggers
INSERT INTO WorkHours (EmployeeID, Date, Task, Hours, Comments)
	(SELECT e.EmployeeID, GETDATE(), 'Testing', 4, 'Good!'
	FROM [TelerikAcademy].[dbo].[Employees] e
	WHERE EmployeeID > 20 AND EmployeeID <= 25)
GO

UPDATE WorkHours
SET Task = 'Designing', Hours = 9, Comments = 'Perfect work!'
WHERE EmployeeID > 20 AND EmployeeID <= 25

DELETE FROM WorkHours
WHERE EmployeeID > 20 AND EmployeeID <= 25


-- 30. Start a database transaction, delete all employees
-- from the 'Sales' department along with all
-- dependent records from the pother tables. At the
-- end rollback the transaction.

BEGIN TRANSACTION

	ALTER TABLE [TelerikAcademy].[dbo].[Departments]
	DROP CONSTRAINT FK_Departments_Employees
	GO

	DELETE e FROM [TelerikAcademy].[dbo].[Employees] e
		JOIN [TelerikAcademy].[dbo].[Departments] d
			ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

ROLLBACK TRANSACTION
-- COMMIT TRANSACTION


-- 31. Start a database transaction and drop the table
-- EmployeesProjects. Now how you could restore
-- back the lost table data?

BEGIN TRANSACTION

	DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects]

ROLLBACK TRANSACTION
-- COMMIT TRANSACTION


-- 32. Find how to use temporary tables in SQL Server.
-- Using temporary tables backup all records from
-- EmployeesProjects and restore them back after
-- dropping and re-creating the table.

-- VERSION 1 --

-- Temporaty table which will be automatically dropped 
-- when the session is closed.
 CREATE TABLE #EmployeesProjects(
	EmployeeID int NOT NULL,
	ProjectID int NOT NULL
)

ALTER TABLE #EmployeesProjects
ADD
	CONSTRAINT FK_EmployeesProjects_Employees
		FOREIGN KEY(EmployeeID)
		REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_EmployeesProjects_Projects
		FOREIGN KEY(ProjectID)
		REFERENCES Projects(ProjectID)
GO

INSERT INTO #EmployeesProjects (EmployeeID, ProjectID)
	(SELECT *  
FROM [TelerikAcademy].[dbo].[EmployeesProjects])

SELECT * FROM #EmployeesProjects

-- Drop table EmployeesProjects
BEGIN TRANSACTION

	DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects]

COMMIT TRANSACTION

 CREATE TABLE EmployeesProjects(
	EmployeeID int NOT NULL,
	ProjectID int NOT NULL
	CONSTRAINT FK_EmployeesProjects_Employees
		FOREIGN KEY(EmployeeID)
		REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_EmployeesProjects_Projects
		FOREIGN KEY(ProjectID)
		REFERENCES Projects(ProjectID)
)

INSERT INTO EmployeesProjects (EmployeeID, ProjectID)
	(SELECT * FROM #EmployeesProjects)

SELECT * FROM EmployeesProjects


-- VERSION 2 --

BEGIN TRANSACTION

SELECT * 
INTO #EmployeesProjects 
FROM [TelerikAcademy].[dbo].[EmployeesProjects]

DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects]

SELECT * 
INTO [TelerikAcademy].[dbo].[EmployeesProjects]
FROM #EmployeesProjects;

COMMIT TRANSACTION
