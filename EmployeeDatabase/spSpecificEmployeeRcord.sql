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
-- Description:	Store procedure for get specific employee details
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE spSpecificEmployeeRcord
@ID int
AS 
BEGIN
    Select * from Employees 
    WHERE ID = @id
END
GO
