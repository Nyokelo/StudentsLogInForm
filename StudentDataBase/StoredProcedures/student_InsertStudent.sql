CREATE PROCEDURE [dbo].[student_InsertStudent]
	       @FirstName nvarchar(50),
           @LastName nvarchar(50),
           @Admin int,
           @MobileNumber nvarchar(15),
           @Gender nvarchar(10),
           @City nvarchar(20),
           @County nvarchar(20),
           @Id INT = 0 OUTPUT 
           AS

INSERT INTO [dbo].[Student]
           ([FirstName]
           ,[LastName]
           ,[Admin]
           ,[MobileNumber]
           ,[Gender]
           ,[City]
           ,[County])
     VALUES(
           @FirstName,
           @LastName, 
           @Admin,
           @MobileNumber,
           @Gender, 
           @City, 
           @County )

           SELECT @Id = SCOPE_IDENTITY();
GO

