USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[spSpecificEmployeeRcord]    Script Date: 5/23/2020 9:25:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for get specific employee details
-- =============================================CREATE PROCEDURE SP_EmpLoyee_Update
ALTER PROCEDURE [dbo].[spSpecificEmployeeRcord]
@ID int
AS 
BEGIN
    Select * from AddEmployee  
    WHERE ID = @ID
END
