CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Admin] INT NOT NULL, 
    [MobileNumber] NVARCHAR(15) NULL, 
    [Gender] NVARCHAR(10) NOT NULL, 
    [City] NVARCHAR(20) NULL, 
    [County] NVARCHAR(20) NULL
)
