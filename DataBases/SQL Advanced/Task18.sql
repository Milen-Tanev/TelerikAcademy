USE TelerikAcademy

--Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.

ALTER TABLE Users 
	ADD GroupId int

--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

ALTER TABLE Users	
	ADD CONSTRAINT FK_USERS_GROUPS
		FOREIGN KEY(GroupId)
		REFERENCES Groups(id)