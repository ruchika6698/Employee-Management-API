USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateemployee]    Script Date: 5/17/2020 8:56:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for delete employee
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE spDeleteEmployeeRcord
@ID int
AS 
BEGIN
    DELETE from Employees 
    WHERE ID = @ID
END
