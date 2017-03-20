USE AccountsDB
GO

CREATE PROC usp_WithdrawMoney
	@accountID int,
	@amount money
AS
	BEGIN TRANSACTION
		UPDATE Accounts
		SET Balance =
			(SELECT Balance
			FROM Accounts
			WHERE Id = @accountID
			) - @amount
		WHERE Id = @accountID
	COMMIT
GO

EXEC usp_WithdrawMoney 2, 10

SELECT * FROM Accounts a