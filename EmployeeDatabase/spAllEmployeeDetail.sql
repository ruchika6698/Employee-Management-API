USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spSpecificEmployeeRcord]    Script Date: 5/17/2020 3:33:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for get all employee details
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE spAllEmployeeDetail
AS 
BEGIN
    Select * from Employees 
END