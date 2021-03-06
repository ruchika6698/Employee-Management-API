USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spAdddnewEmployees]    Script Date: 5/23/2020 8:43:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================
ALTER PROCEDURE [dbo].[spAdddnewEmployees]
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
-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; 

	INSERT INTO AddEmployee(ID,EmployeeName,Username,Gender,City,EmailID,Designation,WorkingExperience)
		VALUES(@ID,@EmployeeName,@Username,@Gender,@City,@EmailID,@Designation,@WorkingExperience);
END
