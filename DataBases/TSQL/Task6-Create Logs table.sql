USE AccountsDB

CREATE TABLE Logs
(
LogID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
AccountID int NOT NULL,
OldSum money,
NewSum money NOT NULL
)
