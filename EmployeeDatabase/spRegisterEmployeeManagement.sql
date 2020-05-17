USE [EmployeeDetails] 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================
ALTER PROCEDURE spRegisterEmployeeManagement
@EmployeeName varchar(50),
@Username varchar(50),
@Password varchar(50),
@Gender varchar(50),
@City varchar(50),
@EmailID varchar(50),
@Designation varchar(50),
@WorkingExperience varchar(50)
AS
BEGIN
	SET NOCOUNT ON; 

	INSERT INTO Employees(EmployeeName,Username,Password,Gender,City,EmailID,Designation,WorkingExperience)
		VALUES(@EmployeeName,@Username,@Password,@Gender,@City,@EmailID,@Designation,@WorkingExperience);
END
GO
