USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteEmployeeRcord]    Script Date: 5/29/2020 11:13:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE [dbo].[spDeleteEmployeeRcord]
@ID int
AS 
BEGIN
    DELETE from EmployeeList
    WHERE ID = @ID
END
