USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spAllEmployeeDetail]    Script Date: 5/23/2020 9:24:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for get all employee details
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE [dbo].[spAllEmployeeDetail]
AS 
BEGIN
    SELECT * FROM AddEmployee  WHERE ID=+ID
END