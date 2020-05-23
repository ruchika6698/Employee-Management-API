USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateemployeedetails]    Script Date: 5/23/2020 9:27:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE [dbo].[spUpdateemployeedetails]
@ID int,
@City varchar(50),
@Designation varchar(50),
@WorkingExperience varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE AddEmployee SET City=@City,Designation=@Designation,WorkingExperience=@WorkingExperience
		WHERE ID = @ID
END