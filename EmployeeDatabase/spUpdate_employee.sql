USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spAddnewEntry]    Script Date: 5/16/2020 9:29:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE spUpdate_employee
@flag bit output,-- return 0 for fail,1 for success
@ID int,
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
	UPDATE Employees SET EmployeeName=@EmployeeName,Username=@Username,Password=@Password,Gender=@Gender,City=@City,EmailID=@EmailID,Designation=@Designation,WorkingExperience=@WorkingExperience
		WHERE ID = @ID
	set @flag=1; 
	 
END
GO