USE AccountsDB
GO

CREATE PROC MoneyQuery
	(@sumToCompareWith money = 0)
AS
	SELECT p.FirstName + ' ' + p.LastName AS 'Full name', a.Balance
	FROM Persons p
	INNER JOIN Accounts a
		ON
		p.Id = a.PersonId
	WHERE a.Balance > @sumToCompareWith
GO

EXECUTE MoneyQuery 499
