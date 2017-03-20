USE AccountsDB

GO

CREATE TRIGGER tr_OnBalanceChange
ON Accounts
AFTER UPDATE
AS
BEGIN
	DECLARE @oldSum money,
			@newSum money,
			@accountId int;
	SET @oldSum = 
		(SELECT Balance
		FROM deleted
		)
	SET @newSum = 
		(SELECT Balance
		FROM inserted
		)
	SET @accountId = 
		(SELECT Id
		FROM inserted
		)
	INSERT INTO Logs(AccountID, OldSum, NewSum)
		VALUES(@accountId, @oldSum, @newSum)
END

