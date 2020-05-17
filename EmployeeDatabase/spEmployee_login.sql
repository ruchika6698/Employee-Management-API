USE [EmployeeDetails]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ruchika
-- Create date: 14/5/2020
-- Description:	Store procedure for employee Register
-- =============================================
CREATE procedure spEmployee_login
(

        @Username varchar(50),

        @Password varchar(50)
)

as

declare @status int

if exists(select * from Employees where Username=@Username and Password=@Password)

       set @status=1

else

       set @status=0

select @status
