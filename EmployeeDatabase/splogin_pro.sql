USE [EmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[splogin_pro]    Script Date: 5/22/2020 8:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================
ALTER procedure [dbo].[splogin_pro]

(

        @Username varchar(50),

        @Password varchar(50)

)

AS
BEGIN

SET NOCOUNT ON
	DECLARE @Status int
	IF EXISTS(SELECT * FROM [dbo].[Employees] WHERE [Username] = @Username AND [Password] = @Password)
		SET @Status = 1
	ELSE
		SET @Status = 0
	SELECT @Status
END