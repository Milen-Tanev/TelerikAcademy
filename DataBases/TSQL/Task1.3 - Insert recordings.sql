USE AccountsDB

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Pesho', 'Peshov', '123456789'),
	  ('Gosho', 'Goshov', '98754329'),
	  ('Tosho', 'Toshov', '321234560')

INSERT INTO Accounts(PersonId, Balance)
VALUES(1, 500),
	  (2, 1000),
	  (3, NULL)