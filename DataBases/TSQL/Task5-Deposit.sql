USE AccountsDB
GO

CREATE PROC usp_DepositMoney
	@accountID int,
	@amount money
AS
	BEGIN TRANSACTION
		UPDATE Accounts
		SET Balance =
			(SELECT Balance
			FROM Accounts
			WHERE Id = @accountID
			) + @amount
		WHERE Id = @accountID
	COMMIT
GO

EXEC usp_DepositMoney 2, 4.50

SELECT * FROM Accounts a