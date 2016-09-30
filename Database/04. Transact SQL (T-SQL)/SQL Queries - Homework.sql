-- 01. Create a database with two tables:
-- Persons(Id(PK), FirstName, LastName, SSN) and
-- Accounts(Id(PK), PersonId(FK), Balance).
-- Insert few records for testing. Write a stored
-- procedure that selects the full names of all persons.

CREATE DATABASE Bank
GO

USE Bank
GO

CREATE TABLE Persons(
	PersonID int IDENTITY PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN nvarchar(50) NOT NULL,
	CONSTRAINT UQ_SSN UNIQUE(SSN)
)
GO

CREATE TABLE Accounts(
	AccountID int IDENTITY PRIMARY KEY,
	PersonID int NOT NULL,
	Balance money,
	CONSTRAINT FK_Accounts_Persons
		FOREIGN KEY (PersonID)
		REFERENCES Persons(PersonID)
)
GO

INSERT INTO Persons VALUES
('Ivan', 'Georgiev', '573-123-122'),
('Hristo', 'Petkov', '123-123-123'),
('Kosta', 'Kostov', '022-331-231'),
('Cvetan', 'Cvetanov', '099-123-091'),
('Madlen', 'Stefanova', '888-888-888'),
('Kristina', 'Spasova', '458-744-337'),
('Dimitar', 'Dimitrov', '699-001-233')

INSERT INTO Accounts(PersonID, Balance)
	(SELECT p.PersonID, p.PersonID * 100
	FROM Persons p)
GO

-- Stored procedure
CREATE PROCEDURE usp_SelectFullNameOfPersons AS
	SELECT FirstName + ' ' + LastName AS [FullName]
	FROM Persons
GO

EXECUTE usp_SelectFullNameOfPersons


-- 02. Create a stored procedure that accepts a number as
-- a parameter and returns all persons who have more
-- money in their accounts than the supplied number.

CREATE PROCEDURE usp_SelectPersonsWithBalanceBiggerThanGivenNumber(@number money) AS
	SELECT p.FirstName + ' ' + p.LastName AS [Full name], a.Balance
	FROM Persons p
		JOIN Accounts a
			ON p.PersonID = a.PersonID
	WHERE a.Balance > @number
	ORDER BY a.Balance
GO

EXECUTE usp_SelectPersonsWithBalanceBiggerThanGivenNumber 300


-- 03. Create a function that accepts as parameters – sum,
-- yearly interest rate and number of months. It should
-- calculate and return the new sum. Write a SELECT to
-- test whether the function works as expected.

CREATE FUNCTION dbo.ufn_CalculateBonus (@sum money, @yearlyInterestRate float, @numberOfMonths int)
	RETURNS money	
AS
BEGIN
	RETURN @sum * @yearlyInterestRate * @numberOfMonths
END
GO

SELECT FirstName + ' ' + LastName AS [Employee], dbo.ufn_CalculateBonus(Salary, 0.2, 3) AS [Bonus]
FROM [TelerikAcademy].[dbo].[Employees] 


-- 04. Create a stored procedure that uses the function
-- from the previous example to give an interest to a
-- person's account for one month. It should take the
-- AccountId and the interest rate as parameters.

CREATE PROCEDURE usp_CalculateBonusForOneMonth(@accountID int, @interestRate float) AS
	SELECT FirstName + ' ' + LastName AS [Employee], dbo.ufn_CalculateBonus(Salary, @interestRate, 1) AS [Bonus for one month]
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE EmployeeID = @accountID
GO

EXECUTE usp_CalculateBonusForOneMonth 2, 0.2


-- 05. Add two more stored procedures WithdrawMoney(
-- AccountId, money) and DepositMoney
-- (AccountId, money) that operate in transactions.

CREATE PROCEDURE usp_WithdrawMoney(@accountID int, @money money) AS
	DECLARE @personBalance money;
	 
	SELECT @personBalance = a.Balance
	FROM Persons p
		JOIN Accounts a
		ON p.PersonID = a.PersonID
	WHERE a.AccountID = @accountID

	BEGIN TRANSACTION
		IF(@money <= 0 OR @personBalance < @money)
			BEGIN
				RAISERROR('Cannot withdraw negative money or more money than have in balance!', 16, 1)
				ROLLBACK TRANSACTION
			END
		ELSE
			BEGIN
				UPDATE Accounts
				SET Balance -= @money
				WHERE AccountID = @accountID
				COMMIT TRANSACTION
			END
GO


CREATE PROCEDURE usp_DepositMoney(@accountID int, @money money) AS
	BEGIN TRANSACTION
		IF(@money <= 0)
			BEGIN
				RAISERROR('Cannot deposit negative or zero money!', 16, 1)
				ROLLBACK TRANSACTION
			END
		ELSE
			BEGIN
				UPDATE Accounts
				SET Balance += @money
				WHERE AccountID = @accountID
				COMMIT TRANSACTION
			END
GO

EXECUTE usp_WithdrawMoney 6, 300
EXECUTE usp_DepositMoney 6, 699

SELECT AccountID, Balance
FROM Accounts
WHERE AccountID = 6

EXECUTE usp_WithdrawMoney 6, 12000


-- 06. Create another table – Logs(LogID, AccountID,
-- OldSum, NewSum). Add a trigger to the Accounts
-- table that enters a new entry into the Logs table
-- every time the sum on an account changes.

CREATE TABLE Logs(
	LogID int IDENTITY PRIMARY KEY,
	AccountID int NOT NULL,
	OldSum money NOT NULL,
	NewSum money NOT NULL,
	CONSTRAINT FK_Logs_Accounts
		FOREIGN KEY (AccountID)
		REFERENCES Accounts(AccountID)
)
GO

CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
	DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountID, OldSum, NewSum)
        SELECT AccountId, @oldSum, Balance
        FROM inserted
GO

EXECUTE usp_WithdrawMoney 6, 300
EXECUTE usp_DepositMoney 6, 699

SELECT * FROM Logs


-- 07. Define a function in the database TelerikAcademy
-- that returns all Employee's names (first or middle or
-- last name) and all town's names that are comprised
-- of given set of letters. Example 'oistmiahf' will
-- return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

CREATE PROCEDURE dbo.usp_GetEmployeesFirstName(@letters nvarchar(50))
AS
	SELECT FirstName
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE dbo.ufn_ContainsLetters(FirstName, @letters) = 1
GO

CREATE PROCEDURE dbo.usp_GetTowns(@letters nvarchar(50))
AS
	SELECT Name AS [Town]
	FROM [TelerikAcademy].[dbo].[Towns]
	WHERE dbo.ufn_ContainsLetters(Name, @letters) = 1
GO

CREATE FUNCTION dbo.ufn_ContainsLetters(@name nvarchar(50), @letters nvarchar(50))
	RETURNS bit
AS
BEGIN
	DECLARE @counter int, @contains bit
	SET @counter = 1
	SET @contains = 1

	WHILE(@counter <= LEN(@name))
		BEGIN
			IF (CHARINDEX(SUBSTRING(@name, @counter, 1), @letters) = 0)
				BEGIN
					SET @contains = 0
				END
			SET @counter += 1
		END
	RETURN @contains
END
GO

EXECUTE dbo.usp_GetEmployeesFirstName 'oistmiahf'
EXECUTE dbo.usp_GetTowns 'oistmiahf'


-- 08. Using database cursor write a T-SQL script that
-- scans all employees and their addresses and prints
-- all pairs of employees that live in the same town.

DECLARE employeeAndAdressCursor CURSOR READ_ONLY FOR
    SELECT emp1.FirstName, emp1.LastName, emp2.FirstName, emp2.LastName, t1.Name
    FROM Employees emp1
		JOIN Addresses a1
			ON emp1.AddressID = a1.AddressID
		JOIN Towns t1
			ON a1.TownID = t1.TownID,
	Employees emp2
        JOIN Addresses a2
            ON emp2.AddressID = a2.AddressID
        JOIN Towns t2
            ON a2.TownID = t2.TownID
    WHERE t1.TownID = t2.TownID AND emp1.EmployeeID != emp2.EmployeeID
    ORDER BY emp1.FirstName, emp2.FirstName

OPEN employeeAndAdressCursor

DECLARE @emp1FirstName nvarchar(50), 
        @emp1LastName nvarchar(50),
        @emp2FirstName nvarchar(50),
        @emp2LastName nvarchar(50),
		@townName nvarchar(50)

FETCH NEXT FROM employeeAndAdressCursor INTO @emp1FirstName, @emp1LastName, @emp2FirstName, @emp2LastName, @townName

WHILE (@@FETCH_STATUS) = 0
	BEGIN
		PRINT @emp1FirstName + ' ' + @emp1LastName + ', ' + @emp2FirstName + ' ' + @emp2LastName + ' -> ' + @townName
		FETCH NEXT FROM employeeAndAdressCursor INTO @emp1FirstName, @emp1LastName, @emp2FirstName, @emp2LastName, @townName
	END

CLOSE employeeAndAdressCursor
DEALLOCATE employeeAndAdressCursor