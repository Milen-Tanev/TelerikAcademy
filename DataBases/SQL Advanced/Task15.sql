USE TelerikAcademy

-- Please, create database SQLAdvancedHhomework (yes, I noticed the typo) :)

--Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users
(
PersonId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
UserName nvarchar(20) UNIQUE NOT NULL,
[Password] nvarchar(20),
FullName nvarchar(50) NOT NULL,
LastLogin DATETIME,
CHECK (LEN([Password]) >= 5)
)
