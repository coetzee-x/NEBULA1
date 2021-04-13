USE MyDatabase

UPDATE Employees SET email = (SELECT CONCAT(SUBSTRING(email, 1, (CHARINDEX('@', email) - 1)), '@company', SUBSTRING(SUBSTRING(email, (CHARINDEX('@', email) + 1), LEN(email)), CHARINDEX('.', SUBSTRING(email, (CHARINDEX('@', email) + 1), LEN(email))), LEN(SUBSTRING(email, (CHARINDEX('@', email) + 1), LEN(email))))))
FROM Employees
