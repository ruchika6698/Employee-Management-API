USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spAllEmployeeDetail]    Script Date: 5/29/2020 11:24:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for get all employee details
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
CREATE PROCEDURE spAllEmployees
AS 
BEGIN
    SELECT * FROM EmployeeList
END