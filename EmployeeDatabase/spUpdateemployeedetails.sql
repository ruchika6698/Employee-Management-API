USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateemployeedetails]    Script Date: 5/19/2020 6:39:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
CREATE PROCEDURE spUpdateemployee_details
@ID int,
@EmployeeName varchar(50),
@Username varchar(50),
@Gender varchar(50),
@City varchar(50),
@EmailID varchar(50),
@Designation varchar(50),
@WorkingExperience varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Employees SET EmployeeName=@EmployeeName,Username=@Username,Gender=@Gender,City=@City,EmailID=@EmailID,Designation=@Designation,WorkingExperience=@WorkingExperience
		WHERE ID = @ID
END