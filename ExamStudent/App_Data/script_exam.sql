USE [ExamStudent]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserDetail'

GO
ALTER TABLE [dbo].[Video] DROP CONSTRAINT [FK_Video_Standards]
GO
ALTER TABLE [dbo].[Video] DROP CONSTRAINT [FK_Video_Mediums]
GO
ALTER TABLE [dbo].[Video] DROP CONSTRAINT [FK_Video_BoardType]
GO
ALTER TABLE [dbo].[UserSubject] DROP CONSTRAINT [FK_UserSubject_StandardSecond]
GO
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_UserDetail]
GO
ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK_Teacher_Subjects]
GO
ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK_Teacher_Mediums]
GO
ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK_Teacher_BoardType]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] DROP CONSTRAINT [FK_Tab_User_Info_Temp_State]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] DROP CONSTRAINT [FK_Tab_User_Info_Temp_Standards]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] DROP CONSTRAINT [FK_Tab_User_Info_Temp_Mediums]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] DROP CONSTRAINT [FK_Tab_User_Info_Temp_City]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] DROP CONSTRAINT [FK_Tab_User_Info_Temp_BoardType]
GO
ALTER TABLE [dbo].[Tab_User_Info] DROP CONSTRAINT [FK_Tab_User_Info_State]
GO
ALTER TABLE [dbo].[Tab_User_Info] DROP CONSTRAINT [FK_Tab_User_Info_EmpCourse]
GO
ALTER TABLE [dbo].[Tab_User_Info] DROP CONSTRAINT [FK_Tab_User_Info_City]
GO
ALTER TABLE [dbo].[Subjects] DROP CONSTRAINT [FK_Subjects_Standards1]
GO
ALTER TABLE [dbo].[Subjects] DROP CONSTRAINT [FK_Subjects_Mediums]
GO
ALTER TABLE [dbo].[Subjects] DROP CONSTRAINT [FK_Subjects_BoardType]
GO
ALTER TABLE [dbo].[StandardSecond] DROP CONSTRAINT [FK_StandardSecond_MediumSecond]
GO
ALTER TABLE [dbo].[ScheduleExam] DROP CONSTRAINT [FK_ScheduleExam_Standards]
GO
ALTER TABLE [dbo].[ScheduleExam] DROP CONSTRAINT [FK_ScheduleExam_Mediums]
GO
ALTER TABLE [dbo].[ScheduleExam] DROP CONSTRAINT [FK_ScheduleExam_BoardType]
GO
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_Standards]
GO
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_Mediums]
GO
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_Category]
GO
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_BoardType]
GO
ALTER TABLE [dbo].[PartnerCartItem] DROP CONSTRAINT [FK_PartnerCartItem_PartnerCartItem]
GO
ALTER TABLE [dbo].[MediumSecond] DROP CONSTRAINT [FK_MediumSecond_BoardTypeSecond]
GO
ALTER TABLE [dbo].[ExamResult] DROP CONSTRAINT [FK_ExamResult_User]
GO
ALTER TABLE [dbo].[Employee_Form_Temp] DROP CONSTRAINT [FK_Employee_Form_Temp_ReferalForm]
GO
ALTER TABLE [dbo].[Employee_Form_Temp] DROP CONSTRAINT [FK_Employee_Form_Temp_PostForm]
GO
ALTER TABLE [dbo].[Employee_Form_Temp] DROP CONSTRAINT [FK_Employee_Form_Temp_EmpState]
GO
ALTER TABLE [dbo].[Employee_Form_Temp] DROP CONSTRAINT [FK_Employee_Form_Temp_Emp_City]
GO
ALTER TABLE [dbo].[Employee_Form] DROP CONSTRAINT [FK_Employee_Form_ReferalForm]
GO
ALTER TABLE [dbo].[Employee_Form] DROP CONSTRAINT [FK_Employee_Form_PostForm]
GO
ALTER TABLE [dbo].[Employee_Form] DROP CONSTRAINT [FK_Employee_Form_EmpState]
GO
ALTER TABLE [dbo].[Employee_Form] DROP CONSTRAINT [FK_Employee_Form_Emp_City]
GO
ALTER TABLE [dbo].[Emp_City] DROP CONSTRAINT [FK_Emp_City_EmpState]
GO
ALTER TABLE [dbo].[City_Old] DROP CONSTRAINT [FK_City_State]
GO
ALTER TABLE [dbo].[Choices] DROP CONSTRAINT [FK_Choices_Question]
GO
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [FK_Category_Standards]
GO
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [FK_Category_Mediums]
GO
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [FK_Category_BoardType]
GO
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [FK_Category_Admin]
GO
ALTER TABLE [dbo].[Answer] DROP CONSTRAINT [FK_Answer_Question]
GO
ALTER TABLE [dbo].[Currency] DROP CONSTRAINT [DF__Currency__IsSync__2EDAF651]
GO
ALTER TABLE [dbo].[Currency] DROP CONSTRAINT [DF__Currency__SyncCo__2DE6D218]
GO
ALTER TABLE [dbo].[Currency] DROP CONSTRAINT [DF_Currency_IsDefault]
GO
ALTER TABLE [dbo].[Country] DROP CONSTRAINT [DF__Country__Enabled__2BFE89A6]
GO
ALTER TABLE [dbo].[Country] DROP CONSTRAINT [DF__Country__SortOrd__2B0A656D]
GO
/****** Object:  Index [UQ__Tab_User__C93A4F78A59D4779]    Script Date: 21-06-2021 13:08:08 ******/
ALTER TABLE [dbo].[Tab_User_Info] DROP CONSTRAINT [UQ__Tab_User__C93A4F78A59D4779]
GO
/****** Object:  Table [dbo].[Video]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Video]
GO
/****** Object:  Table [dbo].[UserSubjectSelection]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[UserSubjectSelection]
GO
/****** Object:  Table [dbo].[UserSubject]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[UserSubject]
GO
/****** Object:  Table [dbo].[UserDetail]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[UserDetail]
GO
/****** Object:  Table [dbo].[User]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[User]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Teacher]
GO
/****** Object:  Table [dbo].[TabPayumoneyTransectionLog]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[TabPayumoneyTransectionLog]
GO
/****** Object:  Table [dbo].[Tab_User_Info_Temp]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Tab_User_Info_Temp]
GO
/****** Object:  Table [dbo].[Tab_User_Info]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Tab_User_Info]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Subjects]
GO
/****** Object:  Table [dbo].[StudentBankDetails]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[StudentBankDetails]
GO
/****** Object:  Table [dbo].[State_Old]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[State_Old]
GO
/****** Object:  Table [dbo].[State]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[State]
GO
/****** Object:  Table [dbo].[StandardSecond]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[StandardSecond]
GO
/****** Object:  Table [dbo].[Standards]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Standards]
GO
/****** Object:  Table [dbo].[ScheduleExam]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[ScheduleExam]
GO
/****** Object:  Table [dbo].[ReferalForm]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[ReferalForm]
GO
/****** Object:  Table [dbo].[Refer]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Refer]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Question]
GO
/****** Object:  Table [dbo].[PostForm]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[PostForm]
GO
/****** Object:  Table [dbo].[PartnerCartItem]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[PartnerCartItem]
GO
/****** Object:  Table [dbo].[PartnerCart]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[PartnerCart]
GO
/****** Object:  Table [dbo].[MockQuestionBank]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[MockQuestionBank]
GO
/****** Object:  Table [dbo].[MediumSecond]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[MediumSecond]
GO
/****** Object:  Table [dbo].[Mediums]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Mediums]
GO
/****** Object:  Table [dbo].[MasterSalary]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[MasterSalary]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Image]
GO
/****** Object:  Table [dbo].[Franchies]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Franchies]
GO
/****** Object:  Table [dbo].[ExamResult]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[ExamResult]
GO
/****** Object:  Table [dbo].[EmpState]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[EmpState]
GO
/****** Object:  Table [dbo].[Employee_Form_Temp]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Employee_Form_Temp]
GO
/****** Object:  Table [dbo].[Employee_Form]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Employee_Form]
GO
/****** Object:  Table [dbo].[EmpCourse]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[EmpCourse]
GO
/****** Object:  Table [dbo].[EmpBankDetails]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[EmpBankDetails]
GO
/****** Object:  Table [dbo].[Emp_City]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Emp_City]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Currency]
GO
/****** Object:  Table [dbo].[Coupon]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Coupon]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Country]
GO
/****** Object:  Table [dbo].[City_Old]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[City_Old]
GO
/****** Object:  Table [dbo].[City]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[City]
GO
/****** Object:  Table [dbo].[Choices]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Choices]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[BoardTypeSecond]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[BoardTypeSecond]
GO
/****** Object:  Table [dbo].[BoardType]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[BoardType]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Answer]
GO
/****** Object:  Table [dbo].[AdminRefer]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[AdminRefer]
GO
/****** Object:  Table [dbo].[AdminEmployeeReferSetting]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[AdminEmployeeReferSetting]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 21-06-2021 13:08:08 ******/
DROP TABLE [dbo].[Admin]
GO
/****** Object:  StoredProcedure [dbo].[uspGetCountry]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[uspGetCountry]
GO
/****** Object:  StoredProcedure [dbo].[uspAddProductToCart]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[uspAddProductToCart]
GO
/****** Object:  StoredProcedure [dbo].[usp_UserListRecord]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[usp_UserListRecord]
GO
/****** Object:  StoredProcedure [dbo].[usp_UserList_Bkp]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[usp_UserList_Bkp]
GO
/****** Object:  StoredProcedure [dbo].[usp_UserList]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[usp_UserList]
GO
/****** Object:  StoredProcedure [dbo].[usp_StudentPayment]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[usp_StudentPayment]
GO
/****** Object:  StoredProcedure [dbo].[spUserLogin]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[spUserLogin]
GO
/****** Object:  StoredProcedure [dbo].[spUserDetails]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[spUserDetails]
GO
/****** Object:  StoredProcedure [dbo].[spUserAccount]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[spUserAccount]
GO
/****** Object:  StoredProcedure [dbo].[spAddSubjectCourse]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[spAddSubjectCourse]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckUserOrAdmin]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[sp_CheckUserOrAdmin]
GO
/****** Object:  StoredProcedure [dbo].[PartnerGetCartItems]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[PartnerGetCartItems]
GO
/****** Object:  StoredProcedure [dbo].[PartnerGetCart]    Script Date: 21-06-2021 13:08:08 ******/
DROP PROCEDURE [dbo].[PartnerGetCart]
GO
USE [master]
GO
/****** Object:  Database [ExamStudent]    Script Date: 21-06-2021 13:08:08 ******/
DROP DATABASE [ExamStudent]
GO
/****** Object:  Database [ExamStudent]    Script Date: 21-06-2021 13:08:08 ******/
CREATE DATABASE [ExamStudent]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExamStudent', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESSS\MSSQL\DATA\ExamStudent.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ExamStudent_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESSS\MSSQL\DATA\ExamStudent_log.ldf' , SIZE = 24384KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ExamStudent] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExamStudent].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExamStudent] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExamStudent] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExamStudent] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExamStudent] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExamStudent] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExamStudent] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ExamStudent] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ExamStudent] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExamStudent] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExamStudent] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExamStudent] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExamStudent] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExamStudent] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExamStudent] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExamStudent] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExamStudent] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ExamStudent] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExamStudent] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExamStudent] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExamStudent] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExamStudent] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExamStudent] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ExamStudent] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExamStudent] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ExamStudent] SET  MULTI_USER 
GO
ALTER DATABASE [ExamStudent] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExamStudent] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExamStudent] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExamStudent] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ExamStudent]
GO
/****** Object:  StoredProcedure [dbo].[PartnerGetCart]    Script Date: 21-06-2021 13:08:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PartnerGetCart]    
(    
 @UserID BIGINT    
)    
AS    
BEGIN    
 SELECT    
  CartID,    
  CreatedOn    
 FROM    
  PartnerCart C (NOLOCK)  
 WHERE    
  C.PartnerUserID = @UserID    
END  
GO
/****** Object:  StoredProcedure [dbo].[PartnerGetCartItems]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PartnerGetCartItems]  
(                  
 @CartID INT       
)                  
AS                 
BEGIN  
 SELECT                 
 
 S.SubjectName ProductName,
  CI.CartItemID,

  CI.CartID,

  CI.ProductID, 

  CI.ProductPrice, 

  CI.Quantity

 FROM                  

  PartnerCartItem CI
  INNER JOIN Subjects S ON S.SubjectID = CI.ProductID

 WHERE                  

   CartID = @CartID     
   
              

END 
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckUserOrAdmin]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CheckUserOrAdmin]
(
     @LoginId  int
)
AS

    Declare @LoginType  NVARCHAR(50)


      BEGIN

       	  SELECT @LoginType = LoginType   FROM [dbo].[Login]

		 WHERE  [LoginId] = @LoginId


	  END
GO
/****** Object:  StoredProcedure [dbo].[spAddSubjectCourse]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spAddSubjectCourse]
(

            @SubjectName nvarchar(150)
           ,@SubjectDescription nvarchar(max)
           ,@Medium nvarchar(150)
           ,@BoardType nvarchar(150)
           ,@Class nvarchar(150)
           ,@Notes varbinary(max)

)
AS



        BEGIN

		INSERT INTO [dbo].[Subject]
           ([SubjectName]
           ,[SubjectDescription]
           ,[Medium]
           ,[BoardType]
           ,[Class]
           ,[Notes])
     VALUES
           (@SubjectName
           ,@SubjectDescription
           ,@Medium
           ,@BoardType
           ,@Class
           ,@Notes)


		END
GO
/****** Object:  StoredProcedure [dbo].[spUserAccount]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUserAccount]
(
     @UserId   INT
)

AS


BEGIN

        SELECT 
      [FullName]
      ,[Eamil]
      ,[DOB]
      ,[Gender]
      ,[Password]
      ,[ConfirmPassword]
      ,[ZipCode]
      ,[State]
      ,[City]
      ,[Block]
      ,[MobileNumber]
      ,[BoardType]
      ,[Class]
      ,[Medium]
      ,[Reffral]
      ,[Address]
  FROM [dbo].[User]


  WHERE [UserId]  = @UserId

END
GO
/****** Object:  StoredProcedure [dbo].[spUserDetails]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUserDetails]
(
     @FullName   NVARCHAR(50)
	 , @Eamil   NVARCHAR(50)
	   ,@DOB      DATETIME 
       ,@Gender   NVARCHAR(50)
       ,@Password   NVARCHAR(50)
       ,@ConfirmPassword   NVARCHAR(50)
       ,@ZipCode       NVARCHAR(50)
       ,@State      NVARCHAR(50)
       ,@City       NVARCHAR(50)
      , @Block      nvarchar(50)
      ,@MobileNumber nvarchar(50)
      ,@BoardType   nvarchar(max)
      ,@Class    nvarchar(200)
      ,@Medium    nvarchar(200)
      ,@Reffral     nvarchar(50)
      ,@Address    nvarchar(50)

	


)
AS



     BEGIN

	 
             INSERT INTO [dbo].[User]
                        ([FullName]
                        ,[Eamil]
                        ,[DOB]
                        ,[Gender]
                        ,[Password]
                        ,[ConfirmPassword]
                        ,[ZipCode]
                        ,[State]
                        ,[City]
                        ,[Block]
                        ,[MobileNumber]
                        ,[BoardType]
                        ,[Class]
                        ,[Medium]
                        ,[Reffral]
                        ,[Address])
                  VALUES
                        (@FullName
                        ,@Eamil
                        ,@DOB
                        ,@Gender
                        ,@Password
                        ,@ConfirmPassword
                        ,@ZipCode
                        ,@State
                        ,@City
                        ,@Block
                        ,@MobileNumber
                        ,@BoardType
                        ,@Class
                        ,@Medium
                        ,@Reffral
                        ,@Address)
             
             
	 END
GO
/****** Object:  StoredProcedure [dbo].[spUserLogin]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUserLogin]
(

           
            @LoginName       nvarchar(50)
           ,@LoginPassword    nvarchar(50)
           
)
AS



    BEGIN

	
INSERT INTO [dbo].[Login]
           ([LoginName]
           ,[LoginPassword]
           ,[LoginTime])
     VALUES
           (@LoginName
           ,@LoginPassword
            ,GETDATE())

	END
GO
/****** Object:  StoredProcedure [dbo].[usp_StudentPayment]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_StudentPayment]

AS


    BEGIN

	   SELECT DISTINCT 
           U.Id ,  B.BoardTypeName as BoardType,	M.MediumName as Medium,	S.StandardName as Standard,
           U.Password, U.IsActive, U.CreatedDate, U.ModifiedDate , U.Name  ,U.EmailAddress,U.MobileNumber,
           
           U.DOB , U.ReferID
           
           --U.UserId,B.BoardTypeName,M.MediumName,S.StandardName 
           FROM [dbo].[Tab_User_Info] U INNER JOIN [dbo].[BoardType] B ON U.BoardType = B.BoardTypeID
           INNER JOIN [dbo].[Mediums] M ON M.MediumID = U.Medium
           INNER JOIN [dbo].[Standards] S ON S.StandardID= U.Standard 
           
          



	END
GO
/****** Object:  StoredProcedure [dbo].[usp_UserList]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UserList]

AS


BEGIN

SELECT DISTINCT 
U.UserId, U.UserDetailId, B.BoardTypeName as BoardType,	M.MediumName as Medium,	S.StandardName as Standard,
U.Password, U.IsActive, U.CreatedDate, U.ModifiedDate , UD.FirstName , UD.LastName , UD.MiddleName ,UD.EmailAddress,UD.PhoneNumber,UD.MobileNumber,

UD.DOB , UD.ReferID

--U.UserId,B.BoardTypeName,M.MediumName,S.StandardName 
FROM [dbo].[User] U INNER JOIN [dbo].[BoardType] B ON U.BoardType = B.BoardTypeID
INNER JOIN [dbo].[Mediums] M ON M.MediumID = U.Medium
INNER JOIN [dbo].[Standards] S ON S.StandardID= U.Standard 

INNER JOIN [dbo].[UserDetail] UD ON UD.UserDetailId = U.UserDetailId


END

GO
/****** Object:  StoredProcedure [dbo].[usp_UserList_Bkp]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UserList_Bkp]

AS


BEGIN

SELECT DISTINCT 
U.UserId, U.UserDetailId, B.BoardTypeName as BoardType,	M.MediumName as Medium,	S.StandardName as Standard,
U.Password, U.IsActive, U.CreatedDate, U.ModifiedDate
--U.UserId,B.BoardTypeName,M.MediumName,S.StandardName 
FROM [dbo].[User] U INNER JOIN [dbo].[BoardType] B ON U.BoardType = B.BoardTypeID
INNER JOIN [dbo].[Mediums] M ON M.MediumID = U.Medium
INNER JOIN [dbo].[Standards] S ON S.StandardID= U.Standard

END
GO
/****** Object:  StoredProcedure [dbo].[usp_UserListRecord]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UserListRecord]

AS


    BEGIN

	   SELECT DISTINCT 
           U.Id ,  B.BoardTypeName as BoardType,	M.MediumName as Medium,	S.StandardName as Standard,
           U.Password, U.IsActive, U.CreatedDate, U.ModifiedDate , U.Name  ,U.EmailAddress,U.MobileNumber,
           
           U.DOB , U.ReferID
           
           --U.UserId,B.BoardTypeName,M.MediumName,S.StandardName 
           FROM [dbo].[Tab_User_Info_Temp] U INNER JOIN [dbo].[BoardType] B ON U.BoardType = B.BoardTypeID
           INNER JOIN [dbo].[Mediums] M ON M.MediumID = U.Medium
           INNER JOIN [dbo].[Standards] S ON S.StandardID= U.Standard 
           
          



	END
GO
/****** Object:  StoredProcedure [dbo].[uspAddProductToCart]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[uspAddProductToCart] -- 159,13,1,0          
(            
 @PartnerUserID BIGINT,            
 @ProductID INT,            
 @Quantity INT,        
 @ProductPrice  decimal        
)            
AS            
BEGIN            
 DECLARE @CartID INT            
 DECLARE @CartItemID INT            
      
 SELECT @CartID =  CartID FROM PartnerCart WHERE PartnerUserID = @PartnerUserID          
      
 IF @CartID IS NULL            
 BEGIN            
  INSERT INTO PartnerCart(PartnerUserID,CreatedOn,ModifiedOn)            
  SELECT @PartnerUserID,GETDATE(),NULL            
        
  SET @CartID = SCOPE_IDENTITY()            
 END       
 ELSE            
 BEGIN         
  UPDATE PartnerCart SET ModifiedOn = GETDATE() WHERE CartID = @CartID            
 END            
      
 SELECT @CartItemID = CartItemID FROM PartnerCartItem WHERE CartID = @CartID AND ProductID = @ProductID 
 IF @CartItemID IS NULL            
 BEGIN            
  INSERT INTO PartnerCartItem(CartID, ProductID, Quantity,ProductPrice)            
  SELECT @CartID,@ProductID,@Quantity,@ProductPrice        
 END            
 ELSE            
 BEGIN            
  UPDATE            
   PartnerCartItem            
  SET            
   Quantity = Quantity + @Quantity             
  WHERE            
   CartItemID = @CartItemID                 
 END            
END  








GO
/****** Object:  StoredProcedure [dbo].[uspGetCountry]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[uspGetCountry]    

AS    

BEGIN     

SELECT [CommonName],TelephoneCode as CountryCode FROM dbo.Country (NOLOCK)  Where [Enabled] = 1   

ORDER BY SortOrder     

END  

  

GO
/****** Object:  Table [dbo].[Admin]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AdminEmployeeReferSetting]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminEmployeeReferSetting](
	[AdminEmpReferSettingID] [int] IDENTITY(1,1) NOT NULL,
	[ReferComision] [decimal](18, 2) NULL,
 CONSTRAINT [PK_AdminEmployeeReferSetting] PRIMARY KEY CLUSTERED 
(
	[AdminEmpReferSettingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AdminRefer]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminRefer](
	[AdminSettingID] [int] IDENTITY(1,1) NOT NULL,
	[ReferComision] [decimal](18, 2) NULL,
 CONSTRAINT [PK_AdminRefer] PRIMARY KEY CLUSTERED 
(
	[AdminSettingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Answer]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Answer](
	[AnswerID] [int] IDENTITY(1,1) NOT NULL,
	[AnswerText] [varchar](200) NULL,
	[Question_Id] [int] NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[AnswerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BoardType]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoardType](
	[BoardTypeID] [int] IDENTITY(1,1) NOT NULL,
	[BoardTypeName] [nvarchar](150) NOT NULL,
	[Amount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_BoardType] PRIMARY KEY CLUSTERED 
(
	[BoardTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BoardTypeSecond]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoardTypeSecond](
	[BoardSecondID] [int] IDENTITY(1,1) NOT NULL,
	[BoardName] [nvarchar](150) NULL,
 CONSTRAINT [PK_BoardTypeSecond] PRIMARY KEY CLUSTERED 
(
	[BoardSecondID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Category_ID] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](50) NULL,
	[AdminID] [int] NULL,
	[BoardTypeID] [int] NULL,
	[MediumID] [int] NULL,
	[StandardID] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Choices]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Choices](
	[ChoiceID] [int] IDENTITY(1,1) NOT NULL,
	[ChoiceText] [nvarchar](max) NULL,
	[Question_Id] [int] NULL,
 CONSTRAINT [PK_Choices] PRIMARY KEY CLUSTERED 
(
	[ChoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[City]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NULL,
	[StateID] [int] NULL,
 CONSTRAINT [PK_City_1] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[City_Old]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City_Old](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NULL,
	[StateID] [int] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryCode] [nvarchar](100) NOT NULL,
	[CommonName] [nvarchar](100) NULL,
	[FormalName] [nvarchar](100) NULL,
	[CountryType] [nvarchar](100) NULL,
	[CountrySubType] [nvarchar](100) NULL,
	[Sovereignty] [nvarchar](100) NULL,
	[Capital] [nvarchar](100) NULL,
	[CurrencyCode] [nvarchar](100) NULL,
	[CurrencyName] [nvarchar](100) NULL,
	[TelephoneCode] [nvarchar](100) NULL,
	[CountryCode3] [nvarchar](100) NULL,
	[CountryNumber] [nvarchar](100) NULL,
	[InternetCountryCode] [nvarchar](100) NULL,
	[SortOrder] [int] NULL,
	[Enabled] [bit] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Coupon]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coupon](
	[CouponID] [int] IDENTITY(1,1) NOT NULL,
	[CouponName] [nvarchar](max) NULL,
	[CouponCode] [nvarchar](max) NULL,
	[CouponDiscount] [int] NULL,
	[CreatedOn] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_Coupon] PRIMARY KEY CLUSTERED 
(
	[CouponID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Currency]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Currency](
	[CurrencyId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Code] [varchar](50) NULL,
	[Rate] [float] NOT NULL,
	[Symbol] [varchar](50) NULL,
	[IsDefault] [bit] NOT NULL,
	[CurrencyIcon] [varchar](max) NULL,
	[ModifiedDateTime] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[SyncCode] [varchar](50) NULL,
	[IsSynced] [bit] NOT NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[CurrencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Emp_City]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_City](
	[Emp_CityID] [int] IDENTITY(1,1) NOT NULL,
	[Emp_CityName] [nvarchar](50) NULL,
	[EmpStateID] [int] NOT NULL,
 CONSTRAINT [PK_Emp_City] PRIMARY KEY CLUSTERED 
(
	[Emp_CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmpBankDetails]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpBankDetails](
	[EmpBankDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [nvarchar](50) NULL,
	[IFSCCode] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
	[AccountHolderName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Employee_ID] [int] NULL,
 CONSTRAINT [PK_EmpBankDetails] PRIMARY KEY CLUSTERED 
(
	[EmpBankDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmpCourse]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpCourse](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[Course] [nvarchar](50) NULL,
	[Amount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_EmpCourse_1] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee_Form]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Form](
	[Employee_ID] [int] IDENTITY(1,1) NOT NULL,
	[Employee_Name] [nvarchar](50) NULL,
	[Emp_DOB] [datetime2](7) NOT NULL,
	[Emp_MobileNumber] [nvarchar](50) NULL,
	[Emp_Block] [nvarchar](50) NULL,
	[PostID] [int] NOT NULL,
	[Emp_Password] [nvarchar](50) NULL,
	[Emp_ConfirmPassword] [nvarchar](50) NULL,
	[EmpStateID] [int] NOT NULL,
	[Emp_CityID] [int] NOT NULL,
	[Emp_EmailAddress] [nvarchar](50) NULL,
	[Emp_AppID] [nvarchar](50) NULL,
	[usercode] [nvarchar](50) NULL,
	[RefferalID] [int] NULL,
 CONSTRAINT [PK_Employee_Form] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee_Form_Temp]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Form_Temp](
	[Employee_ID] [int] IDENTITY(1,1) NOT NULL,
	[Employee_Name] [nvarchar](50) NULL,
	[Emp_DOB] [datetime2](7) NOT NULL,
	[Emp_MobileNumber] [nvarchar](50) NULL,
	[Emp_Block] [nvarchar](50) NULL,
	[PostID] [int] NULL,
	[Emp_Password] [nvarchar](50) NULL,
	[Emp_ConfirmPassword] [nvarchar](50) NULL,
	[EmpStateID] [int] NOT NULL,
	[Emp_CityID] [int] NOT NULL,
	[Emp_EmailAddress] [nvarchar](50) NULL,
	[Emp_AppID] [nvarchar](50) NULL,
	[usercode] [nvarchar](50) NULL,
	[RefferalID] [int] NULL,
	[ReferlName] [nvarchar](50) NULL,
	[ResetPasswordCode] [nvarchar](max) NULL,
	[Date] [date] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[SubjectID] [int] NULL,
	[isFeatured] [bit] NULL,
	[FranchiesCode] [nvarchar](200) NULL,
	[Amount] [decimal](18, 2) NULL,
	[IsPaid] [bit] NULL,
	[IsApproved] [bit] NULL,
 CONSTRAINT [PK_Employee_Form_Temp] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmpState]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpState](
	[EmpStateID] [int] IDENTITY(1,1) NOT NULL,
	[Emp_State] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmpState] PRIMARY KEY CLUSTERED 
(
	[EmpStateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExamResult]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamResult](
	[ExamResultID] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ExamDateTime] [datetime] NULL,
	[Percentange] [nvarchar](150) NULL,
	[AnswerCount] [bigint] NULL,
	[AnswerIDs] [nvarchar](max) NULL,
 CONSTRAINT [PK_ExamResult] PRIMARY KEY CLUSTERED 
(
	[ExamResultID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Franchies]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Franchies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](200) NULL,
	[Amount] [decimal](18, 2) NULL,
	[gstPercentage] [decimal](18, 2) NULL,
	[Transpercentage] [decimal](18, 2) NULL,
	[FranchiesName] [nvarchar](300) NULL,
 CONSTRAINT [PK_Franchies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Image]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[ImageUpload] [nvarchar](max) NULL,
	[Employee_ID] [int] NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterSalary]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterSalary](
	[SalaryMasterID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NULL,
	[Salary] [float] NULL,
	[MinRefer] [int] NULL,
	[Comssion] [float] NULL,
 CONSTRAINT [PK_MasterSalary] PRIMARY KEY CLUSTERED 
(
	[SalaryMasterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mediums]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mediums](
	[MediumID] [int] IDENTITY(1,1) NOT NULL,
	[BoardTypeID] [int] NOT NULL,
	[MediumName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Mediums] PRIMARY KEY CLUSTERED 
(
	[MediumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MediumSecond]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediumSecond](
	[MediumSecondID] [int] IDENTITY(1,1) NOT NULL,
	[MediumName] [nvarchar](150) NULL,
	[BoardSecondID] [int] NULL,
 CONSTRAINT [PK_MediumSecond] PRIMARY KEY CLUSTERED 
(
	[MediumSecondID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MockQuestionBank]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MockQuestionBank](
	[MockQuestionID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionID] [int] NOT NULL,
	[OptionIDA] [int] NOT NULL,
	[OptionIDB] [int] NOT NULL,
	[OptionIDC] [int] NOT NULL,
	[OptionIDD] [int] NOT NULL,
 CONSTRAINT [PK_MockQuestionBank] PRIMARY KEY CLUSTERED 
(
	[MockQuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartnerCart]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartnerCart](
	[CartID] [int] IDENTITY(1,1) NOT NULL,
	[PartnerUserID] [bigint] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[CartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartnerCartItem]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartnerCartItem](
	[CartItemID] [int] IDENTITY(1,1) NOT NULL,
	[CartID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[ProductPrice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_PartnerCartItem] PRIMARY KEY CLUSTERED 
(
	[CartItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PostForm]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostForm](
	[PostID] [int] IDENTITY(1,1) NOT NULL,
	[PostName] [nvarchar](50) NULL,
	[Comssion] [float] NULL,
 CONSTRAINT [PK_PostForm] PRIMARY KEY CLUSTERED 
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Question]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Question_Id] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](500) NULL,
	[CorrectOptionId] [nvarchar](100) NULL,
	[Category_ID] [int] NULL,
	[BoardTypeID] [int] NULL,
	[MediumID] [int] NULL,
	[StandardID] [int] NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Question_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Refer]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Refer](
	[ReferID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](50) NULL,
	[RefferLid] [nvarchar](50) NULL,
	[usercode] [nvarchar](50) NULL,
	[ReferalName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Refer] PRIMARY KEY CLUSTERED 
(
	[ReferID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReferalForm]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReferalForm](
	[RefferalID] [int] IDENTITY(1,1) NOT NULL,
	[ReferalName] [nvarchar](50) NULL,
	[RefferLid] [nvarchar](50) NULL,
	[Employee_ID] [nvarchar](50) NULL,
	[usercode] [nvarchar](50) NULL,
	[Date] [date] NULL,
	[ReferEmpID] [int] NULL,
	[ReferEmpCity] [int] NULL,
	[RefereEmpState] [int] NULL,
 CONSTRAINT [PK_ReferalForm] PRIMARY KEY CLUSTERED 
(
	[RefferalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ScheduleExam]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleExam](
	[ExamScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[ScheduleDateTime] [datetime] NULL,
	[BoardTypeID] [int] NULL,
	[MediumID] [int] NULL,
	[StandardID] [int] NULL,
 CONSTRAINT [PK_ScheduleExam] PRIMARY KEY CLUSTERED 
(
	[ExamScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Standards]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Standards](
	[StandardID] [int] IDENTITY(1,1) NOT NULL,
	[MediumID] [int] NOT NULL,
	[StandardName] [nvarchar](150) NOT NULL,
	[Amount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Standards] PRIMARY KEY CLUSTERED 
(
	[StandardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StandardSecond]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StandardSecond](
	[StandardSecondID] [int] IDENTITY(1,1) NOT NULL,
	[MediumSecondID] [int] NULL,
	[StandardName] [nvarchar](150) NULL,
 CONSTRAINT [PK_StandardSecond] PRIMARY KEY CLUSTERED 
(
	[StandardSecondID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[State]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NULL,
	[CountryId] [int] NULL,
 CONSTRAINT [PK_State_1] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[State_Old]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State_Old](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](50) NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentBankDetails]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentBankDetails](
	[StudentBankID] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [nvarchar](50) NULL,
	[IFSCCode] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
	[AccountHolderName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Id] [int] NULL,
 CONSTRAINT [PK_StudentBankDetails] PRIMARY KEY CLUSTERED 
(
	[StudentBankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](50) NOT NULL,
	[StandardID] [int] NOT NULL,
	[BoardTypeID] [int] NOT NULL,
	[MediumID] [int] NOT NULL,
	[subjectDescription] [nvarchar](max) NULL,
	[subjectPrice] [decimal](18, 2) NULL,
	[subjectDiscount] [nvarchar](150) NULL,
	[subjectTotalHour] [nvarchar](50) NULL,
	[ImageURL] [nvarchar](max) NULL,
	[PDFFile] [nvarchar](500) NULL,
	[VideoURL] [nvarchar](2000) NULL,
	[Comment] [nvarchar](250) NULL,
	[CoverFilename] [nvarchar](max) NULL,
	[CoverFilePath] [nvarchar](max) NULL,
	[FileName] [nvarchar](max) NULL,
	[FilePath] [nvarchar](max) NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tab_User_Info]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_User_Info](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationID] [nvarchar](50) NULL,
	[Name] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](100) NOT NULL,
	[MobileNumber] [varchar](20) NULL,
	[DOB] [datetime2](7) NULL,
	[ReferID] [int] NULL,
	[BoardType] [nvarchar](150) NOT NULL,
	[Medium] [nvarchar](150) NOT NULL,
	[Standard] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[ConfirmPassword] [nvarchar](50) NULL,
	[StateID] [int] NULL,
	[CityID] [int] NULL,
	[Block] [nvarchar](50) NULL,
	[EmpID] [int] NULL,
	[usercode] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserInfo_] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tab_User_Info_Temp]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_User_Info_Temp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationID] [nvarchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](100) NOT NULL,
	[MobileNumber] [varchar](20) NULL,
	[DOB] [datetime2](7) NULL,
	[ReferID] [int] NULL,
	[Password] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[ConfirmPassword] [nvarchar](50) NULL,
	[StateID] [int] NULL,
	[CityID] [int] NULL,
	[Block] [nvarchar](50) NULL,
	[usercode] [nvarchar](50) NULL,
	[ReferlName] [nvarchar](50) NULL,
	[EmpID] [int] NULL,
	[BoardTypeID] [int] NULL,
	[MediumID] [int] NULL,
	[StandardID] [int] NULL,
	[ResetPasswordCode] [nvarchar](max) NULL,
	[Date] [datetime] NULL,
	[BoardSecondID] [int] NULL,
	[MediumSecondID] [int] NULL,
	[StandardSecondID] [int] NULL,
	[UserSubjectID] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[IsPaid] [bit] NULL,
	[IsApproved] [bit] NULL,
 CONSTRAINT [PK_Tab_User_Info_Temp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TabPayumoneyTransectionLog]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabPayumoneyTransectionLog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[productInfo] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[TransectionID] [nvarchar](150) NOT NULL,
	[IsPaid] [bit] NULL,
	[ApplicationID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TabPayumoneyTransectionLog_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](50) NULL,
	[BoardTypeID] [int] NOT NULL,
	[MediumID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserDetailId] [bigint] NOT NULL,
	[BoardType] [nvarchar](150) NOT NULL,
	[Medium] [nvarchar](150) NOT NULL,
	[Standard] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[ConfirmPassword] [nvarchar](50) NULL,
	[ApplicationID] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserDetail]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserDetail](
	[UserDetailId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NULL,
	[EmailAddress] [varchar](100) NOT NULL,
	[PhoneNumber] [varchar](20) NULL,
	[MobileNumber] [varchar](20) NULL,
	[DOB] [datetime2](7) NULL,
	[ReferID] [int] NULL,
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[UserDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserSubject]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSubject](
	[UserSubjectID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](250) NULL,
	[Amount] [decimal](18, 2) NULL,
	[StandardSecondID] [int] NULL,
	[UserTempId] [int] NULL,
 CONSTRAINT [PK_UserSubject] PRIMARY KEY CLUSTERED 
(
	[UserSubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserSubjectSelection]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSubjectSelection](
	[UserSubjectSelectionId] [int] IDENTITY(1,1) NOT NULL,
	[UserSubjectID] [int] NULL,
	[UserTempId] [int] NULL,
 CONSTRAINT [PK_UserSubjectSelection] PRIMARY KEY CLUSTERED 
(
	[UserSubjectSelectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Video]    Script Date: 21-06-2021 13:08:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video](
	[VideoID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[UploadVideo] [nvarchar](max) NULL,
	[BoardTypeID] [int] NULL,
	[MediumID] [int] NULL,
	[StandardID] [int] NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[VideoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminID], [Name], [Password]) VALUES (1, N'Admin', N'admin123')
INSERT [dbo].[Admin] ([AdminID], [Name], [Password]) VALUES (2, N'vinay', N'vinay')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[AdminEmployeeReferSetting] ON 

INSERT [dbo].[AdminEmployeeReferSetting] ([AdminEmpReferSettingID], [ReferComision]) VALUES (1, CAST(20.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[AdminEmployeeReferSetting] OFF
SET IDENTITY_INSERT [dbo].[AdminRefer] ON 

INSERT [dbo].[AdminRefer] ([AdminSettingID], [ReferComision]) VALUES (1, CAST(20.00 AS Decimal(18, 2)))
INSERT [dbo].[AdminRefer] ([AdminSettingID], [ReferComision]) VALUES (2, CAST(30.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[AdminRefer] OFF
SET IDENTITY_INSERT [dbo].[BoardType] ON 

INSERT [dbo].[BoardType] ([BoardTypeID], [BoardTypeName], [Amount]) VALUES (1, N'UP Board', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[BoardType] ([BoardTypeID], [BoardTypeName], [Amount]) VALUES (2, N'CBSC Board', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[BoardType] ([BoardTypeID], [BoardTypeName], [Amount]) VALUES (3, N'Bihar Board', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[BoardType] ([BoardTypeID], [BoardTypeName], [Amount]) VALUES (4, N'Rajasthan Board', CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[BoardType] ([BoardTypeID], [BoardTypeName], [Amount]) VALUES (5, N'MP BOARD', CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[BoardType] ([BoardTypeID], [BoardTypeName], [Amount]) VALUES (6, N'House e', CAST(6.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[BoardType] OFF
SET IDENTITY_INSERT [dbo].[BoardTypeSecond] ON 

INSERT [dbo].[BoardTypeSecond] ([BoardSecondID], [BoardName]) VALUES (1, N'UP Board')
INSERT [dbo].[BoardTypeSecond] ([BoardSecondID], [BoardName]) VALUES (2, N'MP Board')
SET IDENTITY_INSERT [dbo].[BoardTypeSecond] OFF
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([CityID], [CityName], [StateID]) VALUES (48358, N'up', 42)
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[City_Old] ON 

INSERT [dbo].[City_Old] ([CityID], [CityName], [StateID]) VALUES (1, N'Prayagraj', 1)
INSERT [dbo].[City_Old] ([CityID], [CityName], [StateID]) VALUES (5, N'Rewa', 2)
INSERT [dbo].[City_Old] ([CityID], [CityName], [StateID]) VALUES (6, N'sfgsdf', 2)
SET IDENTITY_INSERT [dbo].[City_Old] OFF
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AC', N'Ascension', N'', N'Proto Dependency', N'Dependency of Saint Helena', N'United Kingdom', N'Georgetown', N'SHP', N'Pound', N'+247', N'ASC', N'', N'.ac', 14, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AD', N'Andorra', N'Principality of Andorra', N'Independent State', N'', N'', N'Andorra la Vella', N'EUR', N'Euro', N'+376', N'AND', N'020', N'.ad', 6, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AE', N'United Arab Emirates', N'United Arab Emirates', N'Independent State', N'', N'', N'Abu Dhabi', N'AED', N'Dirham', N'+971', N'ARE', N'784', N'.ae', 232, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AF', N'Afghanistan', N'Islamic State of Afghanistan', N'Independent State', N'', N'', N'Kabul', N'AFN', N'Afghani', N'+93', N'AFG', N'004', N'.af', 1, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AG', N'Antigua and Barbuda', N'', N'Independent State', N'', N'', N'Saint John''s', N'XCD', N'Dollar', N'+1-268', N'ATG', N'028', N'.ag', 10, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AI', N'Anguilla', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'The Valley', N'XCD', N'Dollar', N'+1-264', N'AIA', N'660', N'.ai', 8, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AL', N'Albania', N'Republic of Albania', N'Independent State', N'', N'', N'Tirana', N'ALL', N'Lek', N'+355', N'ALB', N'008', N'.al', 3, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AM', N'Armenia', N'Republic of Armenia', N'Independent State', N'', N'', N'Yerevan', N'AMD', N'Dram', N'+374', N'ARM', N'051', N'.am', 12, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AN', N'Netherlands Antilles', N'', N'Proto Dependency', N'', N'Netherlands', N'Willemstad', N'ANG', N'Guilder', N'+599', N'ANT', N'530', N'.an', 158, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AO', N'Angola', N'Republic of Angola', N'Independent State', N'', N'', N'Luanda', N'AOA', N'Kwanza', N'+244', N'AGO', N'024', N'.ao', 7, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AQ', N'Antarctica', N'', N'Disputed Territory', N'', N'Undetermined', N'', N'', N'', N'', N'ATA', N'010', N'.aq', 9, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AR', N'Argentina', N'Argentine Republic', N'Independent State', N'', N'', N'Buenos Aires', N'ARS', N'Peso', N'+54', N'ARG', N'032', N'.ar', 11, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AS', N'American Samoa', N'Territory of American Samoa', N'Dependency', N'Territory', N'United States', N'Pago Pago', N'USD', N'Dollar', N'+1-684', N'ASM', N'016', N'.as', 5, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AT', N'Austria', N'Republic of Austria', N'Independent State', N'', N'', N'Vienna', N'EUR', N'Euro', N'+43', N'AUT', N'040', N'.at', 16, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AU', N'Australia', N'Commonwealth of Australia', N'Independent State', N'', N'', N'Canberra', N'AUD', N'Dollar', N'+61', N'AUS', N'036', N'.au', 15, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AW', N'Aruba', N'', N'Proto Dependency', N'', N'Netherlands', N'Oranjestad', N'AWG', N'Guilder', N'+297', N'ABW', N'533', N'.aw', 13, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AX', N'Aland', N'', N'Proto Dependency', N'', N'Finland', N'Mariehamn', N'EUR', N'Euro', N'+358-18', N'ALA', N'248', N'.ax', 2, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'AZ', N'Azerbaijan', N'Republic of Azerbaijan', N'Independent State', N'', N'', N'Baku', N'AZN', N'Manat', N'+994', N'AZE', N'031', N'.az', 17, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BA', N'Bosnia and Herzegovina', N'', N'Independent State', N'', N'', N'Sarajevo', N'BAM', N'Marka', N'+387', N'BIH', N'070', N'.ba', 29, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BB', N'Barbados', N'', N'Independent State', N'', N'', N'Bridgetown', N'BBD', N'Dollar', N'+1-246', N'BRB', N'052', N'.bb', 21, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BD', N'Bangladesh', N'People''s Republic of Bangladesh', N'Independent State', N'', N'', N'Dhaka', N'BDT', N'Taka', N'+880', N'BGD', N'050', N'.bd', 20, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BE', N'Belgium', N'Kingdom of Belgium', N'Independent State', N'', N'', N'Brussels', N'EUR', N'Euro', N'+32', N'BEL', N'056', N'.be', 23, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BF', N'Burkina Faso', N'', N'Independent State', N'', N'', N'Ouagadougou', N'XOF', N'Franc', N'+226', N'BFA', N'854', N'.bf', 37, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BG', N'Bulgaria', N'Republic of Bulgaria', N'Independent State', N'', N'', N'Sofia', N'BGN', N'Lev', N'+359', N'BGR', N'100', N'.bg', 36, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BH', N'Bahrain', N'Kingdom of Bahrain', N'Independent State', N'', N'', N'Manama', N'BHD', N'Dinar', N'+973', N'BHR', N'048', N'.bh', 19, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BI', N'Burundi', N'Republic of Burundi', N'Independent State', N'', N'', N'Bujumbura', N'BIF', N'Franc', N'+257', N'BDI', N'108', N'.bi', 38, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BJ', N'Benin', N'Republic of Benin', N'Independent State', N'', N'', N'Porto-Novo', N'XOF', N'Franc', N'+229', N'BEN', N'204', N'.bj', 25, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BM', N'Bermuda', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Hamilton', N'BMD', N'Dollar', N'+1-441', N'BMU', N'060', N'.bm', 26, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BN', N'Brunei', N'Negara Brunei Darussalam', N'Independent State', N'', N'', N'Bandar Seri Begawan', N'BND', N'Dollar', N'+673', N'BRN', N'096', N'.bn', 35, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BO', N'Bolivia', N'Republic of Bolivia', N'Independent State', N'', N'', N'La Paz (administrative/legislative) and Sucre (judical)', N'BOB', N'Boliviano', N'+591', N'BOL', N'068', N'.bo', 28, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BR', N'Brazil', N'Federative Republic of Brazil', N'Independent State', N'', N'', N'Brasilia', N'BRL', N'Real', N'+55', N'BRA', N'076', N'.br', 32, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BS', N'Bahamas, The', N'Commonwealth of The Bahamas', N'Independent State', N'', N'', N'Nassau', N'BSD', N'Dollar', N'+1-242', N'BHS', N'044', N'.bs', 18, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BT', N'Bhutan', N'Kingdom of Bhutan', N'Independent State', N'', N'', N'Thimphu', N'BTN', N'Ngultrum', N'+975', N'BTN', N'064', N'.bt', 27, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BV', N'Bouvet Island', N'', N'Dependency', N'Territory', N'Norway', N'', N'', N'', N'', N'BVT', N'074', N'.bv', 31, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BW', N'Botswana', N'Republic of Botswana', N'Independent State', N'', N'', N'Gaborone', N'BWP', N'Pula', N'+267', N'BWA', N'072', N'.bw', 30, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BY', N'Belarus', N'Republic of Belarus', N'Independent State', N'', N'', N'Minsk', N'BYR', N'Ruble', N'+375', N'BLR', N'112', N'.by', 22, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'BZ', N'Belize', N'', N'Independent State', N'', N'', N'Belmopan', N'BZD', N'Dollar', N'+501', N'BLZ', N'084', N'.bz', 24, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CA', N'Canada', N'', N'Independent State', N'', N'', N'Ottawa', N'CAD', N'Dollar', N'+1', N'CAN', N'124', N'.ca', 41, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CC', N'Cocos (Keeling) Islands', N'Territory of Cocos (Keeling) Islands', N'Dependency', N'External Territory', N'Australia', N'West Island', N'AUD', N'Dollar', N'+61', N'CCK', N'166', N'.cc', 50, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CD', N'Congo ? Kinshasa', N'Democratic Republic of the Congo', N'Independent State', N'', N'', N'Kinshasa', N'CDF', N'Franc', N'+243', N'COD', N'180', N'.cd', 54, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CF', N'Central African Republic', N'', N'Independent State', N'', N'', N'Bangui', N'XAF', N'Franc', N'+236', N'CAF', N'140', N'.cf', 44, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CG', N'Congo ? Brazzaville', N'Republic of the Congo', N'Independent State', N'', N'', N'Brazzaville', N'XAF', N'Franc', N'+242', N'COG', N'178', N'.cg', 53, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CH', N'Switzerland', N'Swiss Confederation', N'Independent State', N'', N'', N'Bern', N'CHF', N'Franc', N'+41', N'CHE', N'756', N'.ch', 213, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CI', N'Cote d''Ivoire (Ivory Coast)', N'Republic of Cote d''Ivoire', N'Independent State', N'', N'', N'Yamoussoukro', N'XOF', N'Franc', N'+225', N'CIV', N'384', N'.ci', 57, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CK', N'Cook Islands', N'', N'Dependency', N'Self-Governing in Free Association', N'New Zealand', N'Avarua', N'NZD', N'Dollar', N'+682', N'COK', N'184', N'.ck', 55, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CL', N'Chile', N'Republic of Chile', N'Independent State', N'', N'', N'Santiago (administrative/judical) and Valparaiso (legislative)', N'CLP', N'Peso', N'+56', N'CHL', N'152', N'.cl', 46, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CM', N'Cameroon', N'Republic of Cameroon', N'Independent State', N'', N'', N'Yaounde', N'XAF', N'Franc', N'+237', N'CMR', N'120', N'.cm', 40, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CN', N'China, People''s Republic of', N'People''s Republic of China', N'Independent State', N'', N'', N'Beijing', N'CNY', N'Yuan Renminbi', N'+86', N'CHN', N'156', N'.cn', 47, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CO', N'Colombia', N'Republic of Colombia', N'Independent State', N'', N'', N'Bogota', N'COP', N'Peso', N'+57', N'COL', N'170', N'.co', 51, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CR', N'Costa Rica', N'Republic of Costa Rica', N'Independent State', N'', N'', N'San Jose', N'CRC', N'Colon', N'+506', N'CRI', N'188', N'.cr', 56, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CS', N'Kosovo', N'', N'Disputed Territory', N'', N'Administrated by the UN', N'Pristina', N'CSD and EUR', N'Dinar and Euro', N'+381', N'SCG', N'891', N'.cs and .yu', 119, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CU', N'Cuba', N'Republic of Cuba', N'Independent State', N'', N'', N'Havana', N'CUP', N'Peso', N'+53', N'CUB', N'192', N'.cu', 59, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CV', N'Cape Verde', N'Republic of Cape Verde', N'Independent State', N'', N'', N'Praia', N'CVE', N'Escudo', N'+238', N'CPV', N'132', N'.cv', 42, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CX', N'Christmas Island', N'Territory of Christmas Island', N'Dependency', N'External Territory', N'Australia', N'The Settlement (Flying Fish Cove)', N'AUD', N'Dollar', N'+61', N'CXR', N'162', N'.cx', 49, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CY', N'Cyprus', N'Republic of Cyprus', N'Independent State', N'', N'', N'Nicosia', N'CYP', N'Pound', N'+357', N'CYP', N'196', N'.cy', 60, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'CZ', N'Czech Republic', N'', N'Independent State', N'', N'', N'Prague', N'CZK', N'Koruna', N'+420', N'CZE', N'203', N'.cz', 61, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'DE', N'Germany', N'Federal Republic of Germany', N'Independent State', N'', N'', N'Berlin', N'EUR', N'Euro', N'+49', N'DEU', N'276', N'.de', 84, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'DJ', N'Djibouti', N'Republic of Djibouti', N'Independent State', N'', N'', N'Djibouti', N'DJF', N'Franc', N'+253', N'DJI', N'262', N'.dj', 63, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'DK', N'Denmark', N'Kingdom of Denmark', N'Independent State', N'', N'', N'Copenhagen', N'DKK', N'Krone', N'+45', N'DNK', N'208', N'.dk', 62, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'DM', N'Dominica', N'Commonwealth of Dominica', N'Independent State', N'', N'', N'Roseau', N'XCD', N'Dollar', N'+1-767', N'DMA', N'212', N'.dm', 64, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'DO', N'Dominican Republic', N'', N'Independent State', N'', N'', N'Santo Domingo', N'DOP', N'Peso', N'+1-809 and 1-829', N'DOM', N'214', N'.do', 65, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'DZ', N'Algeria', N'People''s Democratic Republic of Algeria', N'Independent State', N'', N'', N'Algiers', N'DZD', N'Dinar', N'+213', N'DZA', N'012', N'.dz', 4, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'EC', N'Ecuador', N'Republic of Ecuador', N'Independent State', N'', N'', N'Quito', N'USD', N'Dollar', N'+593', N'ECU', N'218', N'.ec', 66, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'EE', N'Estonia', N'Republic of Estonia', N'Independent State', N'', N'', N'Tallinn', N'EEK', N'Kroon', N'+372', N'EST', N'233', N'.ee', 71, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'EG', N'Egypt', N'Arab Republic of Egypt', N'Independent State', N'', N'', N'Cairo', N'EGP', N'Pound', N'+20', N'EGY', N'818', N'.eg', 67, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'EH', N'Western Sahara', N'', N'Disputed Territory', N'', N'Administrated by Morocco', N'El-Aaiun', N'MAD', N'Dirham', N'+212', N'ESH', N'732', N'.eh', 242, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ER', N'Eritrea', N'State of Eritrea', N'Independent State', N'', N'', N'Asmara', N'ERN', N'Nakfa', N'+291', N'ERI', N'232', N'.er', 70, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ES', N'Spain', N'Kingdom of Spain', N'Independent State', N'', N'', N'Madrid', N'EUR', N'Euro', N'+34', N'ESP', N'724', N'.es', 205, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ET', N'Ethiopia', N'Federal Democratic Republic of Ethiopia', N'Independent State', N'', N'', N'Addis Ababa', N'ETB', N'Birr', N'+251', N'ETH', N'231', N'.et', 72, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'FI', N'Finland', N'Republic of Finland', N'Independent State', N'', N'', N'Helsinki', N'EUR', N'Euro', N'+358', N'FIN', N'246', N'.fi', 76, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'FJ', N'Fiji', N'Republic of the Fiji Islands', N'Independent State', N'', N'', N'Suva', N'FJD', N'Dollar', N'+679', N'FJI', N'242', N'.fj', 75, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'FK', N'Falkland Islands', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Stanley', N'FKP', N'Pound', N'+500', N'FLK', N'238', N'.fk', 73, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'FM', N'Micronesia', N'Federated States of Micronesia', N'Independent State', N'', N'', N'Palikir', N'USD', N'Dollar', N'+691', N'FSM', N'583', N'.fm', 145, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'FO', N'Faroe Islands', N'', N'Proto Dependency', N'', N'Denmark', N'Torshavn', N'DKK', N'Krone', N'+298', N'FRO', N'234', N'.fo', 74, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'FR', N'France', N'French Republic', N'Independent State', N'', N'', N'Paris', N'EUR', N'Euro', N'+33', N'FRA', N'250', N'.fr', 77, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GA', N'Gabon', N'Gabonese Republic', N'Independent State', N'', N'', N'Libreville', N'XAF', N'Franc', N'+241', N'GAB', N'266', N'.ga', 81, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GB', N'United Kingdom', N'United Kingdom of Great Britain and Northern Ireland', N'Independent State', N'', N'', N'London', N'GBP', N'Pound', N'+44', N'GBR', N'826', N'.uk', 233, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GD', N'Grenada', N'', N'Independent State', N'', N'', N'Saint George''s', N'XCD', N'Dollar', N'+1-473', N'GRD', N'308', N'.gd', 89, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GE', N'Georgia', N'Republic of Georgia', N'Independent State', N'', N'', N'Tbilisi', N'GEL', N'Lari', N'+995', N'GEO', N'268', N'.ge', 83, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GF', N'French Guiana', N'Overseas Region of Guiana', N'Proto Dependency', N'Overseas Region', N'France', N'Cayenne', N'EUR', N'Euro', N'+594', N'GUF', N'254', N'.gf', 78, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GG', N'Guernsey', N'Bailiwick of Guernsey', N'Dependency', N'Crown Dependency', N'United Kingdom', N'Saint Peter Port', N'GGP', N'Pound', N'+44', N'GGY', N'831', N'.gg', 92, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GH', N'Ghana', N'Republic of Ghana', N'Independent State', N'', N'', N'Accra', N'GHC', N'Cedi', N'+233', N'GHA', N'288', N'.gh', 85, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GI', N'Gibraltar', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Gibraltar', N'GIP', N'Pound', N'+350', N'GIB', N'292', N'.gi', 86, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GL', N'Greenland', N'', N'Proto Dependency', N'', N'Denmark', N'Nuuk (Godthab)', N'DKK', N'Krone', N'+299', N'GRL', N'304', N'.gl', 88, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GM', N'Gambia, The', N'Republic of The Gambia', N'Independent State', N'', N'', N'Banjul', N'GMD', N'Dalasi', N'+220', N'GMB', N'270', N'.gm', 82, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GN', N'Guinea', N'Republic of Guinea', N'Independent State', N'', N'', N'Conakry', N'GNF', N'Franc', N'+224', N'GIN', N'324', N'.gn', 93, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GQ', N'Equatorial Guinea', N'Republic of Equatorial Guinea', N'Independent State', N'', N'', N'Malabo', N'XAF', N'Franc', N'+240', N'GNQ', N'226', N'.gq', 69, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GR', N'Greece', N'Hellenic Republic', N'Independent State', N'', N'', N'Athens', N'EUR', N'Euro', N'+30', N'GRC', N'300', N'.gr', 87, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GS', N'South Georgia Island', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'', N'', N'', N'', N'SGS', N'239', N'.gs', 204, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GT', N'Guatemala', N'Republic of Guatemala', N'Independent State', N'', N'', N'Guatemala', N'GTQ', N'Quetzal', N'+502', N'GTM', N'320', N'.gt', 91, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GU', N'Guam', N'Territory of Guam', N'Dependency', N'Territory', N'United States', N'Hagatna', N'USD', N'Dollar', N'+1-671', N'GUM', N'316', N'.gu', 90, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GW', N'Guinea-Bissau', N'Republic of Guinea-Bissau', N'Independent State', N'', N'', N'Bissau', N'XOF', N'Franc', N'+245', N'GNB', N'624', N'.gw', 94, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'GY', N'Guyana', N'Co-operative Republic of Guyana', N'Independent State', N'', N'', N'Georgetown', N'GYD', N'Dollar', N'+592', N'GUY', N'328', N'.gy', 95, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'HK', N'Hong Kong', N'Hong Kong Special Administrative Region', N'Proto Dependency', N'Special Administrative Region', N'China', N'', N'HKD', N'Dollar', N'+852', N'HKG', N'344', N'.hk', 99, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'HM', N'Heard and McDonald Islands', N'Territory of Heard Island and McDonald Islands', N'Dependency', N'External Territory', N'Australia', N'', N'', N'', N'', N'HMD', N'334', N'.hm', 97, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'HN', N'Honduras', N'Republic of Honduras', N'Independent State', N'', N'', N'Tegucigalpa', N'HNL', N'Lempira', N'+504', N'HND', N'340', N'.hn', 98, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'HR', N'Croatia', N'Republic of Croatia', N'Independent State', N'', N'', N'Zagreb', N'HRK', N'Kuna', N'+385', N'HRV', N'191', N'.hr', 58, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'HT', N'Haiti', N'Republic of Haiti', N'Independent State', N'', N'', N'Port-au-Prince', N'HTG', N'Gourde', N'+509', N'HTI', N'332', N'.ht', 96, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'HU', N'Hungary', N'Republic of Hungary', N'Independent State', N'', N'', N'Budapest', N'HUF', N'Forint', N'+36', N'HUN', N'348', N'.hu', 100, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ID', N'Indonesia', N'Republic of Indonesia', N'Independent State', N'', N'', N'Jakarta', N'IDR', N'Rupiah', N'+62', N'IDN', N'360', N'.id', 103, 1)
GO
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IE', N'Ireland', N'', N'Independent State', N'', N'', N'Dublin', N'EUR', N'Euro', N'+353', N'IRL', N'372', N'.ie', 106, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IL', N'Israel', N'State of Israel', N'Independent State', N'', N'', N'Jerusalem', N'ILS', N'Shekel', N'+972', N'ISR', N'376', N'.il', 108, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IM', N'Isle of Man', N'', N'Dependency', N'Crown Dependency', N'United Kingdom', N'Douglas', N'IMP', N'Pound', N'+44', N'IMN', N'833', N'.im', 107, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IN', N'India', N'Republic of India', N'Independent State', N'', N'', N'New Delhi', N'INR', N'Rupee', N'+91', N'IND', N'356', N'.in', 102, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IO', N'British Indian Ocean Territory', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'', N'', N'', N'+246', N'IOT', N'086', N'.io', 33, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IQ', N'Iraq', N'Republic of Iraq', N'Independent State', N'', N'', N'Baghdad', N'IQD', N'Dinar', N'+964', N'IRQ', N'368', N'.iq', 105, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IR', N'Iran', N'Islamic Republic of Iran', N'Independent State', N'', N'', N'Tehran', N'IRR', N'Rial', N'+98', N'IRN', N'364', N'.ir', 104, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IS', N'Iceland', N'Republic of Iceland', N'Independent State', N'', N'', N'Reykjavik', N'ISK', N'Krona', N'+354', N'ISL', N'352', N'.is', 101, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'IT', N'Italy', N'Italian Republic', N'Independent State', N'', N'', N'Rome', N'EUR', N'Euro', N'+39', N'ITA', N'380', N'.it', 109, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'JE', N'Jersey', N'Bailiwick of Jersey', N'Dependency', N'Crown Dependency', N'United Kingdom', N'Saint Helier', N'JEP', N'Pound', N'+44', N'JEY', N'832', N'.je', 112, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'JM', N'Jamaica', N'', N'Independent State', N'', N'', N'Kingston', N'JMD', N'Dollar', N'+1-876', N'JAM', N'388', N'.jm', 110, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'JO', N'Jordan', N'Hashemite Kingdom of Jordan', N'Independent State', N'', N'', N'Amman', N'JOD', N'Dinar', N'+962', N'JOR', N'400', N'.jo', 113, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'JP', N'Japan', N'', N'Independent State', N'', N'', N'Tokyo', N'JPY', N'Yen', N'+81', N'JPN', N'392', N'.jp', 111, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KE', N'Kenya', N'Republic of Kenya', N'Independent State', N'', N'', N'Nairobi', N'KES', N'Shilling', N'+254', N'KEN', N'404', N'.ke', 115, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KG', N'Kyrgyzstan', N'Kyrgyz Republic', N'Independent State', N'', N'', N'Bishkek', N'KGS', N'Som', N'+996', N'KGZ', N'417', N'.kg', 121, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KH', N'Cambodia', N'Kingdom of Cambodia', N'Independent State', N'', N'', N'Phnom Penh', N'KHR', N'Riels', N'+855', N'KHM', N'116', N'.kh', 39, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KI', N'Kiribati', N'Republic of Kiribati', N'Independent State', N'', N'', N'Tarawa', N'AUD', N'Dollar', N'+686', N'KIR', N'296', N'.ki', 116, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KM', N'Comoros', N'Union of Comoros', N'Independent State', N'', N'', N'Moroni', N'KMF', N'Franc', N'+269', N'COM', N'174', N'.km', 52, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KN', N'Saint Kitts and Nevis', N'Federation of Saint Kitts and Nevis', N'Independent State', N'', N'', N'Basseterre', N'XCD', N'Dollar', N'+1-869', N'KNA', N'659', N'.kn', 187, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KP', N'Korea(North Korea)', N'Democratic People''s Republic of Korea', N'Independent State', N'', N'', N'Pyongyang', N'KPW', N'Won', N'+850', N'PRK', N'408', N'.kp', 117, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KR', N'Korea(South Korea)', N'Republic of Korea', N'Independent State', N'', N'', N'Seoul', N'KRW', N'Won', N'+82', N'KOR', N'410', N'.kr', 118, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KW', N'Kuwait', N'State of Kuwait', N'Independent State', N'', N'', N'Kuwait', N'KWD', N'Dinar', N'+965', N'KWT', N'414', N'.kw', 120, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KY', N'Cayman Islands', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'George Town', N'KYD', N'Dollar', N'+1-345', N'CYM', N'136', N'.ky', 43, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'KZ', N'Kazakhstan', N'Republic of Kazakhstan', N'Independent State', N'', N'', N'Astana', N'KZT', N'Tenge', N'+7', N'KAZ', N'398', N'.kz', 114, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LA', N'Laos', N'Lao People''s Democratic Republic', N'Independent State', N'', N'', N'Vientiane', N'LAK', N'Kip', N'+856', N'LAO', N'418', N'.la', 122, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LB', N'Lebanon', N'Lebanese Republic', N'Independent State', N'', N'', N'Beirut', N'LBP', N'Pound', N'+961', N'LBN', N'422', N'.lb', 124, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LC', N'Saint Lucia', N'', N'Independent State', N'', N'', N'Castries', N'XCD', N'Dollar', N'+1-758', N'LCA', N'662', N'.lc', 188, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LI', N'Liechtenstein', N'Principality of Liechtenstein', N'Independent State', N'', N'', N'Vaduz', N'CHF', N'Franc', N'+423', N'LIE', N'438', N'.li', 128, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LK', N'Sri Lanka', N'Democratic Socialist Republic of Sri Lanka', N'Independent State', N'', N'', N'Colombo (administrative/judical) and Sri Jayewardenepura Kotte (legislative)', N'LKR', N'Rupee', N'+94', N'LKA', N'144', N'.lk', 206, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LR', N'Liberia', N'Republic of Liberia', N'Independent State', N'', N'', N'Monrovia', N'LRD', N'Dollar', N'+231', N'LBR', N'430', N'.lr', 126, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LS', N'Lesotho', N'Kingdom of Lesotho', N'Independent State', N'', N'', N'Maseru', N'LSL', N'Loti', N'+266', N'LSO', N'426', N'.ls', 125, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LT', N'Lithuania', N'Republic of Lithuania', N'Independent State', N'', N'', N'Vilnius', N'LTL', N'Litas', N'+370', N'LTU', N'440', N'.lt', 129, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LU', N'Luxembourg', N'Grand Duchy of Luxembourg', N'Independent State', N'', N'', N'Luxembourg', N'EUR', N'Euro', N'+352', N'LUX', N'442', N'.lu', 130, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LV', N'Latvia', N'Republic of Latvia', N'Independent State', N'', N'', N'Riga', N'LVL', N'Lat', N'+371', N'LVA', N'428', N'.lv', 123, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'LY', N'Libya', N'Great Socialist People''s Libyan Arab Jamahiriya', N'Independent State', N'', N'', N'Tripoli', N'LYD', N'Dinar', N'+218', N'LBY', N'434', N'.ly', 127, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MA', N'Morocco', N'Kingdom of Morocco', N'Independent State', N'', N'', N'Rabat', N'MAD', N'Dirham', N'+212', N'MAR', N'504', N'.ma', 151, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MC', N'Monaco', N'Principality of Monaco', N'Independent State', N'', N'', N'Monaco', N'EUR', N'Euro', N'+377', N'MCO', N'492', N'.mc', 147, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MD', N'Moldova', N'Republic of Moldova', N'Independent State', N'', N'', N'Chisinau', N'MDL', N'Leu', N'+373', N'MDA', N'498', N'.md', 146, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ME', N'Montenegro', N'Republic of Montenegro', N'Independent State', N'', N'', N'Podgorica', N'EUR', N'Euro', N'+382', N'MNE', N'499', N'.me and .yu', 149, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MG', N'Madagascar', N'Republic of Madagascar', N'Independent State', N'', N'', N'Antananarivo', N'MGA', N'Ariary', N'+261', N'MDG', N'450', N'.mg', 133, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MH', N'Marshall Islands', N'Republic of the Marshall Islands', N'Independent State', N'', N'', N'Majuro', N'USD', N'Dollar', N'+692', N'MHL', N'584', N'.mh', 139, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MK', N'Macedonia', N'Republic of Macedonia', N'Independent State', N'', N'', N'Skopje', N'MKD', N'Denar', N'+389', N'MKD', N'807', N'.mk', 132, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ML', N'Mali', N'Republic of Mali', N'Independent State', N'', N'', N'Bamako', N'XOF', N'Franc', N'+223', N'MLI', N'466', N'.ml', 137, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MM', N'Myanmar (Burma)', N'Union of Myanmar', N'Independent State', N'', N'', N'Naypyidaw', N'MMK', N'Kyat', N'+95', N'MMR', N'104', N'.mm', 153, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MN', N'Mongolia', N'', N'Independent State', N'', N'', N'Ulaanbaatar', N'MNT', N'Tugrik', N'+976', N'MNG', N'496', N'.mn', 148, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MO', N'Macau', N'Macau Special Administrative Region', N'Proto Dependency', N'Special Administrative Region', N'China', N'Macau', N'MOP', N'Pataca', N'+853', N'MAC', N'446', N'.mo', 131, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MP', N'Northern Mariana Islands', N'Commonwealth of The Northern Mariana Islands', N'Dependency', N'Commonwealth', N'United States', N'Saipan', N'USD', N'Dollar', N'+1-670', N'MNP', N'580', N'.mp', 166, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MQ', N'Martinique', N'Overseas Region of Martinique', N'Proto Dependency', N'Overseas Region', N'France', N'Fort-de-France', N'EUR', N'Euro', N'+596', N'MTQ', N'474', N'.mq', 140, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MR', N'Mauritania', N'Islamic Republic of Mauritania', N'Independent State', N'', N'', N'Nouakchott', N'MRO', N'Ouguiya', N'+222', N'MRT', N'478', N'.mr', 141, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MS', N'Montserrat', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Plymouth', N'XCD', N'Dollar', N'+1-664', N'MSR', N'500', N'.ms', 150, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MT', N'Malta', N'Republic of Malta', N'Independent State', N'', N'', N'Valletta', N'MTL', N'Lira', N'+356', N'MLT', N'470', N'.mt', 138, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MU', N'Mauritius', N'Republic of Mauritius', N'Independent State', N'', N'', N'Port Louis', N'MUR', N'Rupee', N'+230', N'MUS', N'480', N'.mu', 142, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MV', N'Maldives', N'Republic of Maldives', N'Independent State', N'', N'', N'Male', N'MVR', N'Rufiyaa', N'+960', N'MDV', N'462', N'.mv', 136, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MW', N'Malawi', N'Republic of Malawi', N'Independent State', N'', N'', N'Lilongwe', N'MWK', N'Kwacha', N'+265', N'MWI', N'454', N'.mw', 134, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MX', N'Mexico', N'United Mexican States', N'Independent State', N'', N'', N'Mexico', N'MXN', N'Peso', N'+52', N'MEX', N'484', N'.mx', 144, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MY', N'Malaysia', N'', N'Independent State', N'', N'', N'Kuala Lumpur (legislative/judical) and Putrajaya (administrative)', N'MYR', N'Ringgit', N'+60', N'MYS', N'458', N'.my', 135, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'MZ', N'Mozambique', N'Republic of Mozambique', N'Independent State', N'', N'', N'Maputo', N'MZM', N'Meticail', N'+258', N'MOZ', N'508', N'.mz', 152, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NA', N'Namibia', N'Republic of Namibia', N'Independent State', N'', N'', N'Windhoek', N'NAD', N'Dollar', N'+264', N'NAM', N'516', N'.na', 154, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NC', N'New Caledonia', N'', N'Dependency', N'Sui generis Collectivity', N'France', N'Noumea', N'XPF', N'Franc', N'+687', N'NCL', N'540', N'.nc', 159, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NE', N'Niger', N'Republic of Niger', N'Independent State', N'', N'', N'Niamey', N'XOF', N'Franc', N'+227', N'NER', N'562', N'.ne', 162, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NF', N'Norfolk Island', N'Territory of Norfolk Island', N'Dependency', N'External Territory', N'Australia', N'Kingston', N'AUD', N'Dollar', N'+672', N'NFK', N'574', N'.nf', 165, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NG', N'Nigeria', N'Federal Republic of Nigeria', N'Independent State', N'', N'', N'Abuja', N'NGN', N'Naira', N'+234', N'NGA', N'566', N'.ng', 163, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NI', N'Nicaragua', N'Republic of Nicaragua', N'Independent State', N'', N'', N'Managua', N'NIO', N'Cordoba', N'+505', N'NIC', N'558', N'.ni', 161, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NL', N'Netherlands', N'Kingdom of the Netherlands', N'Independent State', N'', N'', N'Amsterdam (administrative) and The Hague (legislative/judical)', N'EUR', N'Euro', N'+31', N'NLD', N'528', N'.nl', 157, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NO', N'Norway', N'Kingdom of Norway', N'Independent State', N'', N'', N'Oslo', N'NOK', N'Krone', N'+47', N'NOR', N'578', N'.no', 167, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NP', N'Nepal', N'', N'Independent State', N'', N'', N'Kathmandu', N'NPR', N'Rupee', N'+977', N'NPL', N'524', N'.np', 156, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NR', N'Nauru', N'Republic of Nauru', N'Independent State', N'', N'', N'Yaren', N'AUD', N'Dollar', N'+674', N'NRU', N'520', N'.nr', 155, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NU', N'Niue', N'', N'Dependency', N'Self-Governing in Free Association', N'New Zealand', N'Alofi', N'NZD', N'Dollar', N'+683', N'NIU', N'570', N'.nu', 164, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'NZ', N'New Zealand', N'', N'Independent State', N'', N'', N'Wellington', N'NZD', N'Dollar', N'+64', N'NZL', N'554', N'.nz', 160, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'OM', N'Oman', N'Sultanate of Oman', N'Independent State', N'', N'', N'Muscat', N'OMR', N'Rial', N'+968', N'OMN', N'512', N'.om', 168, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PA', N'Panama', N'Republic of Panama', N'Independent State', N'', N'', N'Panama', N'PAB', N'Balboa', N'+507', N'PAN', N'591', N'.pa', 172, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PE', N'Peru', N'Republic of Peru', N'Independent State', N'', N'', N'Lima', N'PEN', N'Sol', N'+51', N'PER', N'604', N'.pe', 175, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PF', N'French Polynesia', N'Overseas Country of French Polynesia', N'Dependency', N'Overseas Collectivity', N'France', N'Papeete', N'XPF', N'Franc', N'+689', N'PYF', N'258', N'.pf', 79, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PG', N'Papua New Guinea', N'Independent State of Papua New Guinea', N'Independent State', N'', N'', N'Port Moresby', N'PGK', N'Kina', N'+675', N'PNG', N'598', N'.pg', 173, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PH', N'Philippines', N'Republic of the Philippines', N'Independent State', N'', N'', N'Manila', N'PHP', N'Peso', N'+63', N'PHL', N'608', N'.ph', 176, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PK', N'Pakistan', N'Islamic Republic of Pakistan', N'Independent State', N'', N'', N'Islamabad', N'PKR', N'Rupee', N'+92', N'PAK', N'586', N'.pk', 169, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PL', N'Poland', N'Republic of Poland', N'Independent State', N'', N'', N'Warsaw', N'PLN', N'Zloty', N'+48', N'POL', N'616', N'.pl', 178, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PM', N'Saint Pierre and Miquelon', N'Territorial Collectivity of Saint Pierre and Miquelon', N'Dependency', N'Overseas Collectivity', N'France', N'Saint-Pierre', N'EUR', N'Euro', N'+508', N'SPM', N'666', N'.pm', 189, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PN', N'Pitcairn Islands', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Adamstown', N'NZD', N'Dollar', N'', N'PCN', N'612', N'.pn', 177, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PR', N'Puerto Rico', N'Commonwealth of Puerto Rico', N'Dependency', N'Commonwealth', N'United States', N'San Juan', N'USD', N'Dollar', N'+1-787 and 1-939', N'PRI', N'630', N'.pr', 180, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PS', N'Palestinian Territories', N'', N'Disputed Territory', N'', N'Administrated by Israel', N'Gaza City (Gaza Strip) and Ramallah (West Bank)', N'ILS', N'Shekel', N'+970', N'PSE', N'275', N'.ps', 171, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PT', N'Portugal', N'Portuguese Republic', N'Independent State', N'', N'', N'Lisbon', N'EUR', N'Euro', N'+351', N'PRT', N'620', N'.pt', 179, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PW', N'Palau', N'Republic of Palau', N'Independent State', N'', N'', N'Melekeok', N'USD', N'Dollar', N'+680', N'PLW', N'585', N'.pw', 170, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'PY', N'Paraguay', N'Republic of Paraguay', N'Independent State', N'', N'', N'Asuncion', N'PYG', N'Guarani', N'+595', N'PRY', N'600', N'.py', 174, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'QA', N'Qatar', N'State of Qatar', N'Independent State', N'', N'', N'Doha', N'QAR', N'Rial', N'+974', N'QAT', N'634', N'.qa', 181, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'RE', N'Reunion', N'Overseas Region of Reunion', N'Proto Dependency', N'Overseas Region', N'France', N'Saint-Denis', N'EUR', N'Euro', N'+262', N'REU', N'638', N'.re', 182, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'RO', N'Romania', N'', N'Independent State', N'', N'', N'Bucharest', N'RON', N'Leu', N'+40', N'ROU', N'642', N'.ro', 183, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'RS', N'Serbia', N'Republic of Serbia', N'Independent State', N'', N'', N'Belgrade', N'RSD', N'Dinar', N'+381', N'SRB', N'688', N'.rs and .yu', 195, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'RU', N'Russia', N'Russian Federation', N'Independent State', N'', N'', N'Moscow', N'RUB', N'Ruble', N'+7', N'RUS', N'643', N'.ru and .su', 184, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'RW', N'Rwanda', N'Republic of Rwanda', N'Independent State', N'', N'', N'Kigali', N'RWF', N'Franc', N'+250', N'RWA', N'646', N'.rw', 185, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SA', N'Saudi Arabia', N'Kingdom of Saudi Arabia', N'Independent State', N'', N'', N'Riyadh', N'SAR', N'Rial', N'+966', N'SAU', N'682', N'.sa', 193, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SB', N'Solomon Islands', N'', N'Independent State', N'', N'', N'Honiara', N'SBD', N'Dollar', N'+677', N'SLB', N'090', N'.sb', 201, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SC', N'Seychelles', N'Republic of Seychelles', N'Independent State', N'', N'', N'Victoria', N'SCR', N'Rupee', N'+248', N'SYC', N'690', N'.sc', 196, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SD', N'Sudan', N'Republic of the Sudan', N'Independent State', N'', N'', N'Khartoum', N'SDD', N'Dinar', N'+249', N'SDN', N'736', N'.sd', 208, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SE', N'Sweden', N'Kingdom of Sweden', N'Independent State', N'', N'', N'Stockholm', N'SEK', N'Kronoa', N'+46', N'SWE', N'752', N'.se', 212, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SG', N'Singapore', N'Republic of Singapore', N'Independent State', N'', N'', N'Singapore', N'SGD', N'Dollar', N'+65', N'SGP', N'702', N'.sg', 198, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SH', N'Saint Helena', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Jamestown', N'SHP', N'Pound', N'+290', N'SHN', N'654', N'.sh', 186, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SI', N'Slovenia', N'Republic of Slovenia', N'Independent State', N'', N'', N'Ljubljana', N'EUR', N'Euro', N'+386', N'SVN', N'705', N'.si', 200, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SJ', N'Svalbard', N'', N'Proto Dependency', N'', N'Norway', N'Longyearbyen', N'NOK', N'Krone', N'+47', N'SJM', N'744', N'.sj', 210, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SK', N'Slovakia', N'Slovak Republic', N'Independent State', N'', N'', N'Bratislava', N'SKK', N'Koruna', N'+421', N'SVK', N'703', N'.sk', 199, 1)
GO
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SL', N'Sierra Leone', N'Republic of Sierra Leone', N'Independent State', N'', N'', N'Freetown', N'SLL', N'Leone', N'+232', N'SLE', N'694', N'.sl', 197, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SM', N'San Marino', N'Republic of San Marino', N'Independent State', N'', N'', N'San Marino', N'EUR', N'Euro', N'+378', N'SMR', N'674', N'.sm', 191, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SN', N'Senegal', N'Republic of Senegal', N'Independent State', N'', N'', N'Dakar', N'XOF', N'Franc', N'+221', N'SEN', N'686', N'.sn', 194, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SO', N'Somalia', N'', N'Independent State', N'', N'', N'Mogadishu', N'SOS', N'Shilling', N'+252', N'SOM', N'706', N'.so', 202, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SR', N'Suriname', N'Republic of Suriname', N'Independent State', N'', N'', N'Paramaribo', N'SRD', N'Dollar', N'+597', N'SUR', N'740', N'.sr', 209, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ST', N'Sao Tome and Principe', N'Democratic Republic of Sao Tome and Principe', N'Independent State', N'', N'', N'Sao Tome', N'STD', N'Dobra', N'+239', N'STP', N'678', N'.st', 192, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SV', N'El Salvador', N'Republic of El Salvador', N'Independent State', N'', N'', N'San Salvador', N'USD', N'Dollar', N'+503', N'SLV', N'222', N'.sv', 68, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SY', N'Syria', N'Syrian Arab Republic', N'Independent State', N'', N'', N'Damascus', N'SYP', N'Pound', N'+963', N'SYR', N'760', N'.sy', 214, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'SZ', N'Swaziland', N'Kingdom of Swaziland', N'Independent State', N'', N'', N'Mbabane (administrative) and Lobamba (legislative)', N'SZL', N'Lilangeni', N'+268', N'SWZ', N'748', N'.sz', 211, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TA', N'Tristan da Cunha', N'', N'Proto Dependency', N'Dependency of Saint Helena', N'United Kingdom', N'Edinburgh', N'SHP', N'Pound', N'+290', N'TAA', N'', N'', 223, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TC', N'Turks and Caicos Islands', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Grand Turk', N'USD', N'Dollar', N'+1-649', N'TCA', N'796', N'.tc', 227, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TD', N'Chad', N'Republic of Chad', N'Independent State', N'', N'', N'N''Djamena', N'XAF', N'Franc', N'+235', N'TCD', N'148', N'.td', 45, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TF', N'French Southern Territories', N'Territory of the French Southern and Antarctic Lands', N'Dependency', N'Overseas Territory', N'France', N'Martin-de-Vivi?s', N'', N'', N'', N'ATF', N'260', N'.tf', 80, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TG', N'Togo', N'Togolese Republic', N'Independent State', N'', N'', N'Lome', N'XOF', N'Franc', N'+228', N'TGO', N'768', N'.tg', 219, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TH', N'Thailand', N'Kingdom of Thailand', N'Independent State', N'', N'', N'Bangkok', N'THB', N'Baht', N'+66', N'THA', N'764', N'.th', 217, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TJ', N'Tajikistan', N'Republic of Tajikistan', N'Independent State', N'', N'', N'Dushanbe', N'TJS', N'Somoni', N'+992', N'TJK', N'762', N'.tj', 215, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TK', N'Tokelau', N'', N'Dependency', N'Territory', N'New Zealand', N'', N'NZD', N'Dollar', N'+690', N'TKL', N'772', N'.tk', 220, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TL', N'Timor-Leste (East Timor)', N'Democratic Republic of Timor-Leste', N'Independent State', N'', N'', N'Dili', N'USD', N'Dollar', N'+670', N'TLS', N'626', N'.tp and .tl', 218, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TM', N'Turkmenistan', N'', N'Independent State', N'', N'', N'Ashgabat', N'TMM', N'Manat', N'+993', N'TKM', N'795', N'.tm', 226, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TN', N'Tunisia', N'Tunisian Republic', N'Independent State', N'', N'', N'Tunis', N'TND', N'Dinar', N'+216', N'TUN', N'788', N'.tn', 224, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TO', N'Tonga', N'Kingdom of Tonga', N'Independent State', N'', N'', N'Nuku''alofa', N'TOP', N'Pa''anga', N'+676', N'TON', N'776', N'.to', 221, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TR', N'Turkey', N'Republic of Turkey', N'Independent State', N'', N'', N'Ankara', N'TRY', N'Lira', N'+90', N'TUR', N'792', N'.tr', 225, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TT', N'Trinidad and Tobago', N'Republic of Trinidad and Tobago', N'Independent State', N'', N'', N'Port-of-Spain', N'TTD', N'Dollar', N'+1-868', N'TTO', N'780', N'.tt', 222, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TV', N'Tuvalu', N'', N'Independent State', N'', N'', N'Funafuti', N'AUD', N'Dollar', N'+688', N'TUV', N'798', N'.tv', 228, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TW', N'China, Republic of (Taiwan)', N'Republic of China', N'Proto Independent State', N'', N'', N'Taipei', N'TWD', N'Dollar', N'+886', N'TWN', N'158', N'.tw', 48, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'TZ', N'Tanzania', N'United Republic of Tanzania', N'Independent State', N'', N'', N'Dar es Salaam (administrative/judical) and Dodoma (legislative)', N'TZS', N'Shilling', N'+255', N'TZA', N'834', N'.tz', 216, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'UA', N'Ukraine', N'', N'Independent State', N'', N'', N'Kiev', N'UAH', N'Hryvnia', N'+380', N'UKR', N'804', N'.ua', 231, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'UG', N'Uganda', N'Republic of Uganda', N'Independent State', N'', N'', N'Kampala', N'UGX', N'Shilling', N'+256', N'UGA', N'800', N'.ug', 230, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'US', N'United States', N'United States of America', N'Independent State', N'', N'', N'Washington', N'USD', N'Dollar', N'+1', N'USA', N'840', N'.us', 0, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'UY', N'Uruguay', N'Oriental Republic of Uruguay', N'Independent State', N'', N'', N'Montevideo', N'UYU', N'Peso', N'+598', N'URY', N'858', N'.uy', 235, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'UZ', N'Uzbekistan', N'Republic of Uzbekistan', N'Independent State', N'', N'', N'Tashkent', N'UZS', N'Som', N'+998', N'UZB', N'860', N'.uz', 236, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'VA', N'Vatican City', N'State of the Vatican City', N'Independent State', N'', N'', N'Vatican City', N'EUR', N'Euro', N'+379', N'VAT', N'336', N'.va', 238, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'VC', N'St. Vincent and the Grenadines', N'', N'Independent State', N'', N'', N'Kingstown', N'XCD', N'Dollar', N'+1-784', N'VCT', N'670', N'.vc', 207, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'VE', N'Venezuela', N'Bolivarian Republic of Venezuela', N'Independent State', N'', N'', N'Caracas', N'VEB', N'Bolivar', N'+58', N'VEN', N'862', N'.ve', 239, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'VG', N'British Virgin Islands', N'', N'Dependency', N'Overseas Territory', N'United Kingdom', N'Road Town', N'USD', N'Dollar', N'+1-284', N'VGB', N'092', N'.vg', 34, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'VI', N'U.S. Virgin Islands', N'United States Virgin Islands', N'Dependency', N'Territory', N'United States', N'Charlotte Amalie', N'USD', N'Dollar', N'+1-340', N'VIR', N'850', N'.vi', 229, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'VN', N'Vietnam', N'Socialist Republic of Vietnam', N'Independent State', N'', N'', N'Hanoi', N'VND', N'Dong', N'+84', N'VNM', N'704', N'.vn', 240, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'VU', N'Vanuatu', N'Republic of Vanuatu', N'Independent State', N'', N'', N'Port-Vila', N'VUV', N'Vatu', N'+678', N'VUT', N'548', N'.vu', 237, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'WF', N'Wallis and Futuna', N'Collectivity of the Wallis and Futuna Islands', N'Dependency', N'Overseas Collectivity', N'France', N'Mata''utu', N'XPF', N'Franc', N'+681', N'WLF', N'876', N'.wf', 241, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'WS', N'Samoa', N'Independent State of Samoa', N'Independent State', N'', N'', N'Apia', N'WST', N'Tala', N'+685', N'WSM', N'882', N'.ws', 190, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'YE', N'Yemen', N'Republic of Yemen', N'Independent State', N'', N'', N'Sanaa', N'YER', N'Rial', N'+967', N'YEM', N'887', N'.ye', 243, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'YT', N'Mayotte', N'Departmental Collectivity of Mayotte', N'Dependency', N'Overseas Collectivity', N'France', N'Mamoudzou', N'EUR', N'Euro', N'+262', N'MYT', N'175', N'.yt', 143, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ZA', N'South Africa', N'Republic of South Africa', N'Independent State', N'', N'', N'Pretoria (administrative), Cape Town (legislative), and Bloemfontein (judical)', N'ZAR', N'Rand', N'+27', N'ZAF', N'710', N'.za', 203, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ZM', N'Zambia', N'Republic of Zambia', N'Independent State', N'', N'', N'Lusaka', N'ZMK', N'Kwacha', N'+260', N'ZMB', N'894', N'.zm', 244, 1)
INSERT [dbo].[Country] ([CountryCode], [CommonName], [FormalName], [CountryType], [CountrySubType], [Sovereignty], [Capital], [CurrencyCode], [CurrencyName], [TelephoneCode], [CountryCode3], [CountryNumber], [InternetCountryCode], [SortOrder], [Enabled]) VALUES (N'ZW', N'Zimbabwe', N'Republic of Zimbabwe', N'Independent State', N'', N'', N'Harare', N'ZWD', N'Dollar', N'+263', N'ZWE', N'716', N'.zw', 245, 1)
SET IDENTITY_INSERT [dbo].[Currency] ON 

INSERT [dbo].[Currency] ([CurrencyId], [Name], [Code], [Rate], [Symbol], [IsDefault], [CurrencyIcon], [ModifiedDateTime], [ModifiedBy], [SyncCode], [IsSynced]) VALUES (1, N'EUR-Euro', NULL, 45, N'EUR', 0, N'\images\euro.png', CAST(0x0000A0AF00DA70E1 AS DateTime), 1, N'ATRST101', 1)
INSERT [dbo].[Currency] ([CurrencyId], [Name], [Code], [Rate], [Symbol], [IsDefault], [CurrencyIcon], [ModifiedDateTime], [ModifiedBy], [SyncCode], [IsSynced]) VALUES (2, N'Dirhams', NULL, 1, N'AED', 1, N'\images\euro.png', CAST(0x0000A0AF00DA70E1 AS DateTime), 1, N'ATRST102', 1)
INSERT [dbo].[Currency] ([CurrencyId], [Name], [Code], [Rate], [Symbol], [IsDefault], [CurrencyIcon], [ModifiedDateTime], [ModifiedBy], [SyncCode], [IsSynced]) VALUES (3, N'Indian Rupee', NULL, 15, N'Rs', 0, N'\images\euro.png', CAST(0x0000A0AF00DA70E1 AS DateTime), 1, N'ATRST103', 1)
INSERT [dbo].[Currency] ([CurrencyId], [Name], [Code], [Rate], [Symbol], [IsDefault], [CurrencyIcon], [ModifiedDateTime], [ModifiedBy], [SyncCode], [IsSynced]) VALUES (4, N'US Dollar', NULL, 3.68, N'$', 0, N'\images\euro.png', CAST(0x0000A0AF00DA70E1 AS DateTime), 1, N'ATRST104', 1)
INSERT [dbo].[Currency] ([CurrencyId], [Name], [Code], [Rate], [Symbol], [IsDefault], [CurrencyIcon], [ModifiedDateTime], [ModifiedBy], [SyncCode], [IsSynced]) VALUES (5, N'EURO', N'EUR', 3.5, N'EURO', 0, N'DMA logo color.png', CAST(0x0000A42F013F78D4 AS DateTime), 1, N'0000000020150129T192309674806E71A733BD4BDFBFA95608', 0)
INSERT [dbo].[Currency] ([CurrencyId], [Name], [Code], [Rate], [Symbol], [IsDefault], [CurrencyIcon], [ModifiedDateTime], [ModifiedBy], [SyncCode], [IsSynced]) VALUES (6, N'Japaneesee Yen', N'JPY', 234.2323, N'JPY', 0, N'2 Green Lizard5e8c1527-c9d3-41af-bd89-ce00bfda719a.png', CAST(0x0000A432010D3807 AS DateTime), 1, N'0000000020150201T1616155335597568471FE4CBDA2B44208', 0)
INSERT [dbo].[Currency] ([CurrencyId], [Name], [Code], [Rate], [Symbol], [IsDefault], [CurrencyIcon], [ModifiedDateTime], [ModifiedBy], [SyncCode], [IsSynced]) VALUES (7, N'WATER SLIDE CURRENCY', N'imix code currency', 1000, N'$', 1, N'chicago.jpg', CAST(0x0000A47400C4C48B AS DateTime), 1, N'0000000020150408T115624545C32518B4FBC84A429ACC4508', 0)
SET IDENTITY_INSERT [dbo].[Currency] OFF
SET IDENTITY_INSERT [dbo].[Emp_City] ON 

INSERT [dbo].[Emp_City] ([Emp_CityID], [Emp_CityName], [EmpStateID]) VALUES (653, N'ALLAHABAD', 42)
INSERT [dbo].[Emp_City] ([Emp_CityID], [Emp_CityName], [EmpStateID]) VALUES (654, N'JARI', 42)
INSERT [dbo].[Emp_City] ([Emp_CityID], [Emp_CityName], [EmpStateID]) VALUES (655, N'Chakghat', 43)
SET IDENTITY_INSERT [dbo].[Emp_City] OFF
SET IDENTITY_INSERT [dbo].[EmpBankDetails] ON 

INSERT [dbo].[EmpBankDetails] ([EmpBankDetailsID], [AccountNumber], [IFSCCode], [BankName], [AccountHolderName], [Address], [Employee_ID]) VALUES (7, N'7907986678543578', N'DF1234', N'SBII', N'VINAY TIWARI', N'JARII', 2036)
INSERT [dbo].[EmpBankDetails] ([EmpBankDetailsID], [AccountNumber], [IFSCCode], [BankName], [AccountHolderName], [Address], [Employee_ID]) VALUES (1007, N'111232432412', N'FDS2311', N'SBI', N'VINAY TIWARI', N'SDFSA', 2028)
SET IDENTITY_INSERT [dbo].[EmpBankDetails] OFF
SET IDENTITY_INSERT [dbo].[EmpCourse] ON 

INSERT [dbo].[EmpCourse] ([EmpID], [Course], [Amount]) VALUES (1, N'(Default)', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[EmpCourse] ([EmpID], [Course], [Amount]) VALUES (2, N'PMT', CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[EmpCourse] ([EmpID], [Course], [Amount]) VALUES (3, N'SSC', CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[EmpCourse] ([EmpID], [Course], [Amount]) VALUES (4, N'UPSC', CAST(400.00 AS Decimal(18, 2)))
INSERT [dbo].[EmpCourse] ([EmpID], [Course], [Amount]) VALUES (5, N'AIEEE', CAST(2100.00 AS Decimal(18, 2)))
INSERT [dbo].[EmpCourse] ([EmpID], [Course], [Amount]) VALUES (6, N'JEE MAINS', CAST(34.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[EmpCourse] OFF
SET IDENTITY_INSERT [dbo].[Employee_Form_Temp] ON 

INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2074, N'User Head', CAST(0x070000000000000000 AS DateTime2), N'7905872284', NULL, 4, N'1111', N'1111', 43, 655, N'Head@gmail.com', N'd010e110-f80c-46aa-8ca4-3b54ba813ed2', N'qinMT51zJF8', NULL, NULL, NULL, CAST(0xA2420B00 AS Date), CAST(0x07842515E153A2420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2075, N'User DC', CAST(0x070000000000000000 AS DateTime2), N'1234321234', NULL, 1, N'111', N'111', 42, 654, N'dc@gmail.com', N'45dd1704-daac-4688-a3bb-36529af3077c', N'WkGaNEoic7L', NULL, N'User Head', NULL, CAST(0xA2420B00 AS Date), CAST(0x07C3967C5D54A2420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2077, N'Head2', CAST(0x070000000000000000 AS DateTime2), N'7905872284', NULL, 4, N'222', N'222', 42, 653, N'head2@gmail.com', N'c7a17b9c-3661-4ea5-be62-1417087d99d4', N'9QbJygLaTzH', NULL, N'User Head', NULL, CAST(0xA3420B00 AS Date), CAST(0x070BCC9DE9B3A3420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2078, N'Head 3', CAST(0x070000000000000000 AS DateTime2), N'7905872284', NULL, 4, N'444', N'444', 42, 654, N'head3@gmail.com', N'723f26bd-37db-4326-9229-ac870b260758', N'etWGR1NwDjf', NULL, N'User Head', NULL, CAST(0xA3420B00 AS Date), CAST(0x07BAF6F467B4A3420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2079, N'Head 4', CAST(0x070000000000000000 AS DateTime2), N'1234321234', NULL, 4, N'1', N'1', 43, 655, N'head4@gmail.com', N'da866b88-7ffd-43e7-8046-8c03435ddc53', N'TErualIRCMk', NULL, N'Head 3', NULL, CAST(0xA4420B00 AS Date), CAST(0x07884BA018B3A4420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2080, N'RefeerBy DC', CAST(0x070000000000000000 AS DateTime2), N'7905872284', NULL, 1, N'2', N'2', 42, 653, N'referdc@gmail.com', N'000a756c-dc3d-4b4e-8885-3c1974397e8e', N'RxZQMLlUsbC', NULL, NULL, NULL, CAST(0xA4420B00 AS Date), CAST(0x0788A3D049B3A4420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2081, N'Refer By BC', CAST(0x070000000000000000 AS DateTime2), N'7905872284', NULL, 2, N'11', N'11', 43, 655, N'ref@gmail.com', N'f5d0b35e-5ad1-43ef-bf13-8068375c881f', N'o57CVZWhRS8', NULL, N'Head 3', NULL, CAST(0xA4420B00 AS Date), CAST(0x07711A3698B3A4420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2082, N'ref By Frnch', CAST(0x070000000000000000 AS DateTime2), N'7905872284', NULL, 0, N'111', N'111', 42, 653, N'fran@gmail.com', N'8f408d40-43d6-4d12-b60b-27f0db2ec0d2', N'rcR92IfaJjg', NULL, N'Head 3', NULL, CAST(0xA4420B00 AS Date), CAST(0x07CA4758C9B3A4420B AS DateTime2), NULL, NULL, N'004', NULL, 0, 1)
INSERT [dbo].[Employee_Form_Temp] ([Employee_ID], [Employee_Name], [Emp_DOB], [Emp_MobileNumber], [Emp_Block], [PostID], [Emp_Password], [Emp_ConfirmPassword], [EmpStateID], [Emp_CityID], [Emp_EmailAddress], [Emp_AppID], [usercode], [RefferalID], [ReferlName], [ResetPasswordCode], [Date], [CreatedDate], [SubjectID], [isFeatured], [FranchiesCode], [Amount], [IsPaid], [IsApproved]) VALUES (2083, N'bcc', CAST(0x070000000000000000 AS DateTime2), N'7905872284', NULL, 2, N'22', N'22', 43, 655, N'bcc@gmail.com', N'c1dc5377-77bb-4edb-89f1-7f8af66b79a3', N'OzU86Ssjh9p', NULL, N'User DC', NULL, CAST(0xA4420B00 AS Date), CAST(0x07CC801506B7A4420B AS DateTime2), NULL, NULL, NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Employee_Form_Temp] OFF
SET IDENTITY_INSERT [dbo].[EmpState] ON 

INSERT [dbo].[EmpState] ([EmpStateID], [Emp_State]) VALUES (42, N'Utter Pradesh')
INSERT [dbo].[EmpState] ([EmpStateID], [Emp_State]) VALUES (43, N'M P')
SET IDENTITY_INSERT [dbo].[EmpState] OFF
SET IDENTITY_INSERT [dbo].[Franchies] ON 

INSERT [dbo].[Franchies] ([Id], [Code], [Amount], [gstPercentage], [Transpercentage], [FranchiesName]) VALUES (1, N'001', CAST(1500000.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'Head')
INSERT [dbo].[Franchies] ([Id], [Code], [Amount], [gstPercentage], [Transpercentage], [FranchiesName]) VALUES (2, N'002', CAST(100000.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'E C')
INSERT [dbo].[Franchies] ([Id], [Code], [Amount], [gstPercentage], [Transpercentage], [FranchiesName]) VALUES (3, N'003', CAST(50000.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'B C')
INSERT [dbo].[Franchies] ([Id], [Code], [Amount], [gstPercentage], [Transpercentage], [FranchiesName]) VALUES (4, N'004', CAST(1.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), N'Associate')
SET IDENTITY_INSERT [dbo].[Franchies] OFF
SET IDENTITY_INSERT [dbo].[Image] ON 

INSERT [dbo].[Image] ([ImageID], [ImageUpload], [Employee_ID]) VALUES (1014, N'/Imagess/1026.jpg', 1026)
INSERT [dbo].[Image] ([ImageID], [ImageUpload], [Employee_ID]) VALUES (1015, N'/Imagess/1026.jpg', 1026)
INSERT [dbo].[Image] ([ImageID], [ImageUpload], [Employee_ID]) VALUES (1016, N'/Imagess/2062.jpg', 2062)
SET IDENTITY_INSERT [dbo].[Image] OFF
SET IDENTITY_INSERT [dbo].[MasterSalary] ON 

INSERT [dbo].[MasterSalary] ([SalaryMasterID], [PostID], [Salary], [MinRefer], [Comssion]) VALUES (3, 4, 1200, 1, 2)
INSERT [dbo].[MasterSalary] ([SalaryMasterID], [PostID], [Salary], [MinRefer], [Comssion]) VALUES (4, 1, 1100, 1, 1)
INSERT [dbo].[MasterSalary] ([SalaryMasterID], [PostID], [Salary], [MinRefer], [Comssion]) VALUES (5, 3, 120, 11, 2)
INSERT [dbo].[MasterSalary] ([SalaryMasterID], [PostID], [Salary], [MinRefer], [Comssion]) VALUES (6, 2, 1, 3, 1)
INSERT [dbo].[MasterSalary] ([SalaryMasterID], [PostID], [Salary], [MinRefer], [Comssion]) VALUES (8, 0, 0, 0, 23)
SET IDENTITY_INSERT [dbo].[MasterSalary] OFF
SET IDENTITY_INSERT [dbo].[Mediums] ON 

INSERT [dbo].[Mediums] ([MediumID], [BoardTypeID], [MediumName]) VALUES (18, 1, N'Hindi Medium')
INSERT [dbo].[Mediums] ([MediumID], [BoardTypeID], [MediumName]) VALUES (19, 2, N'English Medium')
SET IDENTITY_INSERT [dbo].[Mediums] OFF
SET IDENTITY_INSERT [dbo].[MediumSecond] ON 

INSERT [dbo].[MediumSecond] ([MediumSecondID], [MediumName], [BoardSecondID]) VALUES (1, N'Hindi Medium', 1)
INSERT [dbo].[MediumSecond] ([MediumSecondID], [MediumName], [BoardSecondID]) VALUES (2, N'English Medium', 1)
INSERT [dbo].[MediumSecond] ([MediumSecondID], [MediumName], [BoardSecondID]) VALUES (3, N'English Medium', 2)
SET IDENTITY_INSERT [dbo].[MediumSecond] OFF
SET IDENTITY_INSERT [dbo].[PartnerCart] ON 

INSERT [dbo].[PartnerCart] ([CartID], [PartnerUserID], [CreatedOn], [ModifiedOn]) VALUES (1, 12, CAST(0x0000ABFF008227B3 AS DateTime), CAST(0x0000AC410169F3C1 AS DateTime))
INSERT [dbo].[PartnerCart] ([CartID], [PartnerUserID], [CreatedOn], [ModifiedOn]) VALUES (2, 0, CAST(0x0000ABFF0083CA6D AS DateTime), CAST(0x0000ACF60100809E AS DateTime))
INSERT [dbo].[PartnerCart] ([CartID], [PartnerUserID], [CreatedOn], [ModifiedOn]) VALUES (3, 11, CAST(0x0000ABFF008CC706 AS DateTime), CAST(0x0000AC0500FD6BC6 AS DateTime))
INSERT [dbo].[PartnerCart] ([CartID], [PartnerUserID], [CreatedOn], [ModifiedOn]) VALUES (4, 5, CAST(0x0000AC500175C830 AS DateTime), NULL)
INSERT [dbo].[PartnerCart] ([CartID], [PartnerUserID], [CreatedOn], [ModifiedOn]) VALUES (5, 48, CAST(0x0000AC6B00E3B86C AS DateTime), NULL)
INSERT [dbo].[PartnerCart] ([CartID], [PartnerUserID], [CreatedOn], [ModifiedOn]) VALUES (6, 49, CAST(0x0000AC6B00E996C7 AS DateTime), NULL)
INSERT [dbo].[PartnerCart] ([CartID], [PartnerUserID], [CreatedOn], [ModifiedOn]) VALUES (7, 2054, CAST(0x0000ACF600E40B65 AS DateTime), CAST(0x0000ACF600E87CAB AS DateTime))
SET IDENTITY_INSERT [dbo].[PartnerCart] OFF
SET IDENTITY_INSERT [dbo].[PartnerCartItem] ON 

INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (1, 1, 1, 1, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (2, 2, 1, 10, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (3, 2, 0, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (4, 3, 21, 6, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (5, 1, 18, 24, CAST(599 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (6, 2, 21, 1, CAST(567 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (7, 1, 24, 3, CAST(12 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (8, 1, 23, 1, CAST(25 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (9, 1, 25, 8, CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (10, 2, 25, 1, CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (11, 4, 23, 1, CAST(25 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (12, 5, 29, 1, CAST(230 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (13, 6, 29, 1, CAST(230 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (14, 7, 28, 1, CAST(460 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (15, 7, 29, 1, CAST(230 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (16, 7, 30, 2, CAST(2342 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (17, 2, 28, 2, CAST(460 AS Decimal(18, 0)))
INSERT [dbo].[PartnerCartItem] ([CartItemID], [CartID], [ProductID], [Quantity], [ProductPrice]) VALUES (18, 2, 29, 1, CAST(230 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[PartnerCartItem] OFF
SET IDENTITY_INSERT [dbo].[PostForm] ON 

INSERT [dbo].[PostForm] ([PostID], [PostName], [Comssion]) VALUES (0, N'Select Post', NULL)
INSERT [dbo].[PostForm] ([PostID], [PostName], [Comssion]) VALUES (1, N'District Coordinator', 1)
INSERT [dbo].[PostForm] ([PostID], [PostName], [Comssion]) VALUES (2, N'Block Coordinator', 2)
INSERT [dbo].[PostForm] ([PostID], [PostName], [Comssion]) VALUES (3, N'Teacher', 40)
INSERT [dbo].[PostForm] ([PostID], [PostName], [Comssion]) VALUES (4, N'Head', 0.01)
SET IDENTITY_INSERT [dbo].[PostForm] OFF
SET IDENTITY_INSERT [dbo].[Refer] ON 

INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (3, NULL, NULL, NULL, NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (5, NULL, NULL, NULL, NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (6, NULL, NULL, NULL, NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (7, N'28', N'26', N'ahNtGD7Uskn', NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (8, N'29', N'28', N'xt3AyNJQuV1', NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (9, N'31', N'30', N'zgkhTND1flJ', NULL)
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (10, N'33', NULL, NULL, N'keystd1  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (11, N'34', NULL, NULL, N'STU  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (12, N'35', NULL, NULL, N'df  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (13, N'36', NULL, NULL, N'vinaNY  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (14, N'37', NULL, NULL, N'vinay tiwari  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (15, N'39', N'38', N'g1eRoAExH5K', N'sir ji   ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (16, N'40', N'39', N'DP7CoESV6qx', N'dileep   ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (17, N'41', N'40', N'4MWp5ZTiFvd', N'smith  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (18, N'42', N'41', N'KoydCl5nWuq', N'dfg  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (19, N'44', N'43', N'2YbTur7h1nz', N'smith  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (20, N'47', N'46', N'fEPLmIv3VSW', N'babu  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (21, N'50', N'49', N'PvBylnJCrpg', N'book   ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (22, N'52', N'51', N'j621nIBZiSX', N'null  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (1022, N'1052', N'1051', N'RrfWvCkNbA4', N'test123  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (1023, N'3059', N'10', N'9gcia8mVXp0', N'teachewr  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (2023, N'5071', N'2061', N'yUzXbs5twm4', N'student  ')
INSERT [dbo].[Refer] ([ReferID], [UserID], [RefferLid], [usercode], [ReferalName]) VALUES (2024, N'5072', N'2062', N'uRBxa4wENSz', N'bcStudent  ')
SET IDENTITY_INSERT [dbo].[Refer] OFF
SET IDENTITY_INSERT [dbo].[ReferalForm] ON 

INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (11, N'Associate', N'2062', N'2063', N'uRBxa4wENSz', CAST(0x96420B00 AS Date), 2063, 655, 43)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (12, N'Jhmo', N'2062', N'2064', N'uRBxa4wENSz', CAST(0x98420B00 AS Date), 2064, 655, 43)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (13, N'Jhon Smith', N'2062', N'2065', N'uRBxa4wENSz', CAST(0x98420B00 AS Date), 2065, 653, 42)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (14, N'DC', N'2062', N'2066', N'uRBxa4wENSz', CAST(0x98420B00 AS Date), 2066, 655, 43)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (15, N'Bc from Head', N'2062', N'2071', N'uRBxa4wENSz', CAST(0xA0420B00 AS Date), 2071, 654, 42)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (16, N'ali ji ', N'2063', N'2072', N'yGVnfJM9ag2', CAST(0xA1420B00 AS Date), 2072, 654, 42)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (17, N'User DC', N'2074', N'2075', N'qinMT51zJF8', CAST(0xA2420B00 AS Date), 2075, 654, 42)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (19, N'Head2', N'2074', N'2077', N'qinMT51zJF8', CAST(0xA3420B00 AS Date), 2077, 653, 42)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (20, N'Head 3', N'2074', N'2078', N'qinMT51zJF8', CAST(0xA3420B00 AS Date), 2078, 654, 42)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (21, N'Head 4', N'2078', N'2079', N'etWGR1NwDjf', CAST(0xA4420B00 AS Date), 2079, 655, 43)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (22, N'Refer By BC', N'2078', N'2081', N'etWGR1NwDjf', CAST(0xA4420B00 AS Date), 2081, 655, 43)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (23, N'ref By Frnch', N'2078', N'2082', N'etWGR1NwDjf', CAST(0xA4420B00 AS Date), 2082, 653, 42)
INSERT [dbo].[ReferalForm] ([RefferalID], [ReferalName], [RefferLid], [Employee_ID], [usercode], [Date], [ReferEmpID], [ReferEmpCity], [RefereEmpState]) VALUES (24, N'bcc', N'2075', N'2083', N'WkGaNEoic7L', CAST(0xA4420B00 AS Date), 2083, 655, 43)
SET IDENTITY_INSERT [dbo].[ReferalForm] OFF
SET IDENTITY_INSERT [dbo].[Standards] ON 

INSERT [dbo].[Standards] ([StandardID], [MediumID], [StandardName], [Amount]) VALUES (22, 18, N'One', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[Standards] ([StandardID], [MediumID], [StandardName], [Amount]) VALUES (23, 19, N'two', CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Standards] OFF
SET IDENTITY_INSERT [dbo].[StandardSecond] ON 

INSERT [dbo].[StandardSecond] ([StandardSecondID], [MediumSecondID], [StandardName]) VALUES (1, 1, N'One')
INSERT [dbo].[StandardSecond] ([StandardSecondID], [MediumSecondID], [StandardName]) VALUES (2, 1, N'Two')
INSERT [dbo].[StandardSecond] ([StandardSecondID], [MediumSecondID], [StandardName]) VALUES (3, 2, N'Two')
INSERT [dbo].[StandardSecond] ([StandardSecondID], [MediumSecondID], [StandardName]) VALUES (4, 2, N'One')
INSERT [dbo].[StandardSecond] ([StandardSecondID], [MediumSecondID], [StandardName]) VALUES (5, 3, N'Three')
SET IDENTITY_INSERT [dbo].[StandardSecond] OFF
SET IDENTITY_INSERT [dbo].[State] ON 

INSERT [dbo].[State] ([StateID], [StateName], [CountryId]) VALUES (42, N'Andhra Pradesh', NULL)
SET IDENTITY_INSERT [dbo].[State] OFF
SET IDENTITY_INSERT [dbo].[State_Old] ON 

INSERT [dbo].[State_Old] ([StateID], [StateName]) VALUES (1, N'  Uttar Pradesh')
INSERT [dbo].[State_Old] ([StateID], [StateName]) VALUES (2, N'Madhya Pradesh')
SET IDENTITY_INSERT [dbo].[State_Old] OFF
SET IDENTITY_INSERT [dbo].[StudentBankDetails] ON 

INSERT [dbo].[StudentBankDetails] ([StudentBankID], [AccountNumber], [IFSCCode], [BankName], [AccountHolderName], [Address], [Id]) VALUES (22, N'21321423542345143', N'Q1234', N'BOBB', N'SMITH aNU', N'JARI DG', 2058)
INSERT [dbo].[StudentBankDetails] ([StudentBankID], [AccountNumber], [IFSCCode], [BankName], [AccountHolderName], [Address], [Id]) VALUES (23, NULL, NULL, NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[StudentBankDetails] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [StandardID], [BoardTypeID], [MediumID], [subjectDescription], [subjectPrice], [subjectDiscount], [subjectTotalHour], [ImageURL], [PDFFile], [VideoURL], [Comment], [CoverFilename], [CoverFilePath], [FileName], [FilePath]) VALUES (1033, N'Hindi', 22, 1, 18, N'dsa', CAST(1.00 AS Decimal(18, 2)), N'1', N'13:28', NULL, N'PHPNotesForProfessionals.pdf', NULL, N'gdsf', NULL, N'E:\Online Exam Protal ASP.NET MVC 5 Project\My Project ExamStudent\29-05-21 with GST Payment\ExamStudent\ExamStudent\CoverDoc\human-clipart-office-person-5.png', NULL, NULL)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [StandardID], [BoardTypeID], [MediumID], [subjectDescription], [subjectPrice], [subjectDiscount], [subjectTotalHour], [ImageURL], [PDFFile], [VideoURL], [Comment], [CoverFilename], [CoverFilePath], [FileName], [FilePath]) VALUES (1034, N'en', 22, 1, 18, N'enfvna', CAST(1.00 AS Decimal(18, 2)), N'1', N'22:18', NULL, NULL, NULL, N'bhgffd', N'human-clipart-office-person-5.png', N'E:\Online Exam Protal ASP.NET MVC 5 Project\My Project ExamStudent\29-05-21 with GST Payment\ExamStudent\ExamStudent\CoverDoc\human-clipart-office-person-5.png', N'PHPNotesForProfessionals.pdf', N'E:\Online Exam Protal ASP.NET MVC 5 Project\My Project ExamStudent\29-05-21 with GST Payment\ExamStudent\ExamStudent\MainDoc\PHPNotesForProfessionals.pdf')
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [StandardID], [BoardTypeID], [MediumID], [subjectDescription], [subjectPrice], [subjectDiscount], [subjectTotalHour], [ImageURL], [PDFFile], [VideoURL], [Comment], [CoverFilename], [CoverFilePath], [FileName], [FilePath]) VALUES (1035, N'urdu', 22, 1, 18, NULL, CAST(1.00 AS Decimal(18, 2)), N'1', N'12:03', NULL, NULL, NULL, NULL, N'student-849825_1920.jpg', N'E:\Online Exam Protal ASP.NET MVC 5 Project\My Project ExamStudent\29-05-21 with GST Payment\ExamStudent\ExamStudent\CoverDoc\student-849825_1920.jpg', N'bootstrap-interview-questions-answers.pdf', N'E:\Online Exam Protal ASP.NET MVC 5 Project\My Project ExamStudent\29-05-21 with GST Payment\ExamStudent\ExamStudent\MainDoc\bootstrap-interview-questions-answers.pdf')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
SET IDENTITY_INSERT [dbo].[Tab_User_Info] ON 

INSERT [dbo].[Tab_User_Info] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [EmpID], [usercode]) VALUES (1, N'735a2caf-bf5a-40c6-82e2-28c5cb91136b', N'VINAY TIWARI  ', N'vinaytiwari264@gmail.com', N'7905872284', CAST(0x070000000000A2410B AS DateTime2), 1, N'5', N'10', N'15', N'123', 1, CAST(0x07F4DAE46760A2410B AS DateTime2), NULL, N'123', 1, 1, N'JARI', 5, NULL)
INSERT [dbo].[Tab_User_Info] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [EmpID], [usercode]) VALUES (2, N'd5258f3b-30c8-4651-a871-efd4edd0f403', N'vinay smith  ', N'smith01@gmail.com', N'7905872284', CAST(0x070000000000A2410B AS DateTime2), 1, N'6', N'8', N'13', N'123', 1, CAST(0x0772F6CD37B4A2410B AS DateTime2), NULL, N'123', 1, 1, N'jari market', 5, NULL)
INSERT [dbo].[Tab_User_Info] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [EmpID], [usercode]) VALUES (3, N'14f35fb0-028f-4b0a-876f-64bb04994f3f', N'Ruhi tiwari  ', N'tiwari@gmail.com', N'7905872284', CAST(0x070000000000A2410B AS DateTime2), 5, N'5', N'10', N'15', N'123', 1, CAST(0x073CE34BA9BDA2410B AS DateTime2), NULL, N'123', 1, 1, N'hj', 6, NULL)
INSERT [dbo].[Tab_User_Info] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [EmpID], [usercode]) VALUES (4, N'05983be9-890c-4769-9b5e-5d0a4379429f', N'Babu Tiwari  ', N'Babutiwari012@gmail.com', N'7905872284', CAST(0x070000000000AA410B AS DateTime2), 2, N'3', N'7', N'11', N'123', 1, CAST(0x07431A47533EAA410B AS DateTime2), NULL, N'123', 1, 1, N'jari market', 5, NULL)
INSERT [dbo].[Tab_User_Info] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [EmpID], [usercode]) VALUES (5, N'5be94b8b-5809-488b-a5fd-00d6f8b8a1ce', N'Delip success  ', N'delipsuc987@gmail.com', N'7905872284', CAST(0x070000000000AB410B AS DateTime2), 1, N'2', N'3', N'7', N'123', 1, CAST(0x07B9FA6DB876AB410B AS DateTime2), NULL, N'123', 2, 5, N'jhgt', 5, NULL)
SET IDENTITY_INSERT [dbo].[Tab_User_Info] OFF
SET IDENTITY_INSERT [dbo].[Tab_User_Info_Temp] ON 

INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5071, N'629a372e-0165-483f-a35f-d88265f0aaa6', N'student  ', N'stu@gmail.com', N'1234321234', NULL, 0, N'1', 1, CAST(0x0741467EC74496420B AS DateTime2), NULL, N'1', 42, 48358, NULL, N'123', N'yUzXbs5twm4', NULL, 1, 18, 22, NULL, CAST(0x0000AD3B008739BE AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5072, N'772c6003-cb0d-4584-af1f-eec97cf6291c', N'bcStudent  ', N'bcstd@gmail.com', N'2129893566', NULL, 0, N'321', 1, CAST(0x07CB8049ED6896420B AS DateTime2), NULL, N'321', 42, 48358, NULL, N'123', N'BC', NULL, 1, 18, 22, NULL, CAST(0x0000AD3B00CE4B71 AS DateTime), NULL, NULL, NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5073, N'aa4cf6a7-0313-462d-a782-070157b96722', N'stu  ', N'stu12@gmail.com', N'2129893566', NULL, 0, N'44', 1, CAST(0x07034603CA6D9A420B AS DateTime2), NULL, N'44', 42, 48358, NULL, N'5JajxKgeAFu', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F00D7DAAC AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5074, N'e964024b-5357-4c75-ab9d-e5f5754d67b3', N'vs tiwari  ', N'vinaytiwari264@gmail.com', N'7905872284', NULL, 0, N'444', 1, CAST(0x07E59CBFC7B29A420B AS DateTime2), NULL, N'444', 42, 48358, NULL, N'HO3kWG7BjLn', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F015F7F0E AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5075, N'9a9ffedf-7ac9-4b29-abe1-8e338477f22b', N'this  ', N'this@gmail.com', N'7905872284', NULL, 0, N'333', 1, CAST(0x0732A0C40DB69A420B AS DateTime2), NULL, N'333', 42, 48358, NULL, N'Pe2pdVhIz9A', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F0165EEAB AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5076, N'c78a405d-ec09-45d3-86e4-08dcd06c57b5', N'vt  ', N'vt@gmail.com', N'7905872284', NULL, 0, N'444', 1, CAST(0x075C4BAB15B89A420B AS DateTime2), NULL, N'444', 42, 48358, NULL, N'KgqC0ULSDx3', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F0169ECD6 AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5077, N'12507e16-8069-4a3c-96a6-b9fe018174d3', N'Jhonsmith smith  ', N'smithjhon@gmail.com', N'7905872284', NULL, 0, N'444', 1, CAST(0x0787126728BC9A420B AS DateTime2), NULL, N'444', 42, 48358, NULL, N'ITGikrADs4a', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F0171EEEF AS DateTime), NULL, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5078, N'5b431c8d-bb04-472c-bf74-ba46a329a4c5', N'manish  ', N'manish@gmail.com', N'7905872284', NULL, 0, N'555', 1, CAST(0x07DAB52F19BE9A420B AS DateTime2), NULL, N'555', 42, 48358, NULL, N'VC3XcWO6k17', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F0175BFA6 AS DateTime), NULL, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5079, N'9afd9e6a-f6ce-4483-94ba-0e97c8a62a5e', N'bill  ', N'bill@gmail.com', N'7905872284', NULL, 0, N'55', 1, CAST(0x07DF5D3BE1BF9A420B AS DateTime2), NULL, N'55', 42, 48358, NULL, N'N6iWrsqA249', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F01794046 AS DateTime), NULL, NULL, NULL, NULL, CAST(1.21 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5081, N'19ac4234-74f8-4be8-9275-c1bfd64de6b7', N'not pay  ', N'notpay@gmail.com', N'7905872284', NULL, 0, N'1', 1, CAST(0x0748D7E1F5C79A420B AS DateTime2), NULL, N'1', 42, 48358, NULL, N'y3Q9n6qe2Rm', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD3F01892367 AS DateTime), NULL, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5082, N'c5d69472-05d1-4615-80c2-4c626ac8ef28', N'not succ  ', N'vnot@gmail.com', N'7905872284', NULL, 0, N'33', 1, CAST(0x07AA2A4E59B09B420B AS DateTime2), NULL, N'33', 42, 48358, NULL, N'pxCvROTqmS4', NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000AD40015AB748 AS DateTime), 2, 3, 5, NULL, CAST(12.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5083, N'97126db7-4bf5-4b16-933a-93bbc5f669a9', N'laho  ', N'laho@gmail.com', N'2129893566', NULL, 0, N'11', 1, CAST(0x070433EB8AB19B420B AS DateTime2), NULL, N'11', 42, 48358, NULL, N'9rSBHf1Vjx4', NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000AD40015D1024 AS DateTime), NULL, NULL, NULL, NULL, CAST(2100.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5084, N'7072d833-96b2-4f1e-a274-fee11cc93f89', N'ha  ', N'ha@gmail.com', N'7905872284', NULL, 0, N'2', 1, CAST(0x07DE737DECB19B420B AS DateTime2), NULL, N'2', 42, 48358, NULL, N'meN3iwaXjOh', NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000AD40015DCFFA AS DateTime), NULL, NULL, NULL, NULL, CAST(2100.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5085, N'b59f8e35-4b1b-4235-b3ee-54da73677925', N'success  ', N'success@gmail.com', N'7905872284', NULL, 0, N'321', 1, CAST(0x0798A62924B59B420B AS DateTime2), NULL, N'321', 42, 48358, NULL, N'IelbQc46kaU', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD4001642362 AS DateTime), NULL, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5086, N'2cf271e0-4d6e-466a-9faa-a31d95caac26', N'ms  ', N'vinaytiwari264@gmail.com', N'7905872284', NULL, 0, N'66', 1, CAST(0x07B5060619B69B420B AS DateTime2), NULL, N'66', 42, 48358, NULL, N'PkblrF6iJoz', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD40016604CC AS DateTime), NULL, NULL, NULL, NULL, CAST(1.21 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5088, N'19ff091f-da71-4e35-accb-0b85061e9f04', N'class1  ', N'class@gmail.com', N'7905872284', NULL, 0, N'11', 1, CAST(0x076E09404CB39C420B AS DateTime2), NULL, N'11', 42, 48358, NULL, N'SkHB0FMquX8', NULL, NULL, 1, 18, 22, NULL, CAST(0x0000AD4101608390 AS DateTime), NULL, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5089, N'13fa4614-142c-42b6-8049-e88d3c0f6914', N'New Student  ', N'newstudent@gmail.com', N'2129893566', NULL, 0, N'44', 1, CAST(0x07CF5D963F049E420B AS DateTime2), NULL, N'44', 42, 48358, NULL, N'h2QmcHkstPR', NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000AD4300085A49 AS DateTime), 2, 3, 5, NULL, CAST(12.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Tab_User_Info_Temp] ([Id], [ApplicationID], [Name], [EmailAddress], [MobileNumber], [DOB], [ReferID], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [StateID], [CityID], [Block], [usercode], [ReferlName], [EmpID], [BoardTypeID], [MediumID], [StandardID], [ResetPasswordCode], [Date], [BoardSecondID], [MediumSecondID], [StandardSecondID], [UserSubjectID], [Amount], [IsPaid], [IsApproved]) VALUES (5090, N'9c331e12-49e3-40c8-9609-ac921f6dbe7a', N'demo  ', N'demo123@gmail.com', N'7905872284', NULL, 0, N'1', 1, CAST(0x07402C72D476A7420B AS DateTime2), NULL, N'1', 42, 48358, NULL, N'mTDZdUEjy7b', NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000AD4C00E9A108 AS DateTime), 1, 1, 1, NULL, CAST(20.00 AS Decimal(18, 2)), 0, 1)
SET IDENTITY_INSERT [dbo].[Tab_User_Info_Temp] OFF
SET IDENTITY_INSERT [dbo].[TabPayumoneyTransectionLog] ON 

INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (2096, CAST(0x52420B00 AS Date), N'vinay smith', CAST(2099.00 AS Decimal(18, 2)), N'0', N'smith011@gmail.com', N'2129893566', N'e7047cecb8860285e20f', 0, N'40c24618-daf8-4f00-a4a3-84d4ff7a88eb')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (2097, CAST(0x52420B00 AS Date), N'tryq', CAST(2099.00 AS Decimal(18, 2)), N'0', N'try@gmail.com', N'1234321234', N'3d3c01f14895dd227dfd', 0, N'2f278b79-1631-4941-a8ca-802bf686d591')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (2098, CAST(0x53420B00 AS Date), N'name', CAST(2099.00 AS Decimal(18, 2)), N'0', N'name@gmaIL.COM', N'1234321234', N'098689824998f540098e', 0, N'db647c33-3b49-4daf-921f-ea3fe482cb89')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (2099, CAST(0x5A420B00 AS Date), N'vinay', CAST(2099.00 AS Decimal(18, 2)), N'0', N'babu01232@gmail.com', N'1234321234', N'ad982c79b25c1ad34796', 0, N'cdea5eba-0d27-4bf7-9ba5-2b0b0c26de60')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (3099, CAST(0x7D420B00 AS Date), N'sir ji ', CAST(1.00 AS Decimal(18, 2)), N'0', N'sirji@gmail.com', N'1234321234', N'23a1f242a2a02d15df10', 0, N'4d0d80e1-c61f-4c91-a0d3-e38812ed6c56')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (3100, CAST(0x7D420B00 AS Date), N's', CAST(0.00 AS Decimal(18, 2)), N'0', N's@gmail.com', N'1234321234', N'2b59d85558b65ba2be68', 0, N'32111b63-caee-4dd1-8c5f-8585d040bbd0')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (3101, CAST(0x7D420B00 AS Date), N'vc', CAST(1.00 AS Decimal(18, 2)), N'0', N'vc@gmail.com', N'1234321234', N'63c7cec8446aaf69393a', 0, N'01593c55-1e2b-4622-a9c9-44b3bd10dc1a')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4099, CAST(0x80420B00 AS Date), N'date', CAST(1.00 AS Decimal(18, 2)), N'0', N'sate@gmail.com', N'0000000000', N'83ce7e953e0e8ba0c0a5', 0, N'458e51de-8735-40de-8d6e-4c0dd8c5be7b')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4100, CAST(0x82420B00 AS Date), N'board1', CAST(1.00 AS Decimal(18, 2)), N'0', N'1@gmail.com', N'1234321234', N'c76b7e699921d44567e7', 0, N'74e6201d-d814-47c0-bcbe-9865f990f30c')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4101, CAST(0x82420B00 AS Date), N'board2', CAST(1.00 AS Decimal(18, 2)), N'0', N'2@gmail.com', N'1234321234', N'ef145f7caf61d39a2ef5', 0, N'dde92e1c-4682-495f-af72-d140001fdb39')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4102, CAST(0x82420B00 AS Date), N'board21', CAST(70.00 AS Decimal(18, 2)), N'0', N'21@gmail.com', N'1234321234', N'dec5f48f10216b008c18', 0, N'805bb106-9346-46d1-aa4f-e8b3655758d9')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4103, CAST(0x82420B00 AS Date), N't', CAST(1.00 AS Decimal(18, 2)), N'0', N't@gmail.com', N'1234321234', N'b155354e678e29d786f0', 0, N'b4f4a0af-a67c-438e-902a-47d2d9fd6901')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4104, CAST(0x83420B00 AS Date), N'emp', CAST(2100.00 AS Decimal(18, 2)), N'0', N'emp@gmail.com', N'1234321234', N'8613a3912c60beb2785d', 0, N'b57ef4d3-41ee-4e27-a8af-c8e4f86d4966')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4105, CAST(0x86420B00 AS Date), N'dmo', CAST(71.00 AS Decimal(18, 2)), N'0', N'demo21@gmail.com', N'2129893566', N'2cc8a98c2dd91bf19f78', 0, N'edb0d9e7-28b3-4391-9555-4311a9ca15a1')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4106, CAST(0x86420B00 AS Date), N'sir', CAST(71.00 AS Decimal(18, 2)), N'0', N'sirji@gmail.com', N'1234321234', N'108b53a0dac162a0de55', 0, N'48cda988-7306-4e11-a331-d4afdea2b195')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4107, CAST(0x86420B00 AS Date), N'demo4', CAST(71.00 AS Decimal(18, 2)), N'0', N'demo4@gmail.com', N'1234321234', N'9a0ae82c1e84f91e9cbe', 0, N'381bb82d-8145-457c-a744-26ac575dd874')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (4108, CAST(0x86420B00 AS Date), N'if', CAST(71.00 AS Decimal(18, 2)), N'0', N'if@gmail.com', N'1234321234', N'b798d64034499bce57ce', 0, N'570e18de-39df-4af9-9ec2-e155c7c2e56a')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5105, CAST(0x8C420B00 AS Date), N'sta', CAST(1300.00 AS Decimal(18, 2)), N'0', N'sta', N'2129893566', N'ddeb28fbaaacc4f62c7c', 0, N'bdf75e5c-f3e6-4c97-a051-d3e40599fbd2')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5106, CAST(0x8C420B00 AS Date), N'sd', CAST(1200.00 AS Decimal(18, 2)), N'0', N'sdf@gmail.com', N'1234321234', N'fc30e4c588f4f80ecb05', 0, N'a0e485f9-a9a7-4e0e-bd69-89a7325d0d3a')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5107, CAST(0x8C420B00 AS Date), N'ruji', CAST(1200.00 AS Decimal(18, 2)), N'0', N'vinay@gmail.com', N'1234321234', N'616b18b736f13c8335f4', 0, N'5eaa0d10-2d0e-4077-9912-1ce4541a5f22')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5108, CAST(0x8C420B00 AS Date), N'demo', CAST(1200.00 AS Decimal(18, 2)), N'0', N'demo1234@gmail.com', N'1234321234', N'd353ebf4f2e92ede56eb', 0, N'5de6b16e-7dd0-44c8-8071-0b765e56c82f')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5109, CAST(0x8C420B00 AS Date), N'demo2', CAST(12.00 AS Decimal(18, 2)), N'0', N'demo21@gmail.com', N'1234321234', N'1fa730dea057140e9ae8', 0, N'7b9eb09e-480e-45be-9de6-e680d2dd6a7c')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5110, CAST(0x8C420B00 AS Date), N'vinay smith', CAST(20.00 AS Decimal(18, 2)), N'0', N'vinaysmith@gmail.com', N'2129893566', N'dd3a35bf487f2ec1be26', 0, N'1da0f238-5be2-4504-98c7-cbfe9346797c')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5111, CAST(0x8C420B00 AS Date), N'sdf', CAST(1200.00 AS Decimal(18, 2)), N'0', N'SMITH@GMAIL.COM', N'1234321234', N'fb82241a503a6e507ec3', 0, N'170fdc13-f8d8-447e-9647-fbd9b610e37d')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5112, CAST(0x91420B00 AS Date), N'vinay Pay', CAST(1.00 AS Decimal(18, 2)), N'0', N'pay@gmail.com', N'7905872284', N'e1ef60d476d44fcf7283', 0, N'bd1a9a70-d03c-4bb1-9ad9-0651e5acea2c')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5113, CAST(0x91420B00 AS Date), N'PAYMENT', CAST(1.00 AS Decimal(18, 2)), N'0', N'PAYMENT@GMAIL.COM', N'7905872284', N'7249b1574c923f4be17a', 0, N'eddabf4e-900b-4cf5-b780-64a1c486786f')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5114, CAST(0x91420B00 AS Date), N'P', CAST(1.00 AS Decimal(18, 2)), N'0', N'P@GMAIL.COM', N'7905872284', N'98b454b26cad79ce21aa', 0, N'52548cdc-7c75-4fc7-bc60-c58f2b22c8ff')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5115, CAST(0x91420B00 AS Date), N'V', CAST(1.00 AS Decimal(18, 2)), N'0', N'V@GMAIL.COM', N'7905872284', N'03323d497b08d51783bb', 1, N'22b54b50-12de-445c-b04c-e2afdfe6075e')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5116, CAST(0x91420B00 AS Date), N's', CAST(1.00 AS Decimal(18, 2)), N'0', N's@gmail.com', N'7905872284', N'c239651388efda89f0ef', 1, N'2e1711b5-8b65-40d8-895a-df17647be248')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5117, CAST(0x91420B00 AS Date), N'Anu', CAST(1.00 AS Decimal(18, 2)), N'0', N'anu@gmail.com', N'7905872284', N'29044cc4ddc62901e043', 1, N'cf2d8f6f-b231-479d-bdf8-116ecd8f2833')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5118, CAST(0x92420B00 AS Date), N'babu', CAST(10.00 AS Decimal(18, 2)), N'0', N'babu@gmail.com', N'7905872284', N'b26f664dc654b2686c2c', 0, N'55b2e1bc-db01-4260-bb85-5429519db176')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5119, CAST(0x92420B00 AS Date), N'tes', CAST(1000.00 AS Decimal(18, 2)), N'0', N'tes@gmail.com', N'7905872284', N'b2ce8b05a16b798f0186', 0, N'e4192a36-9666-4c73-ad32-3c399acffde1')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5120, CAST(0x92420B00 AS Date), N'demo', CAST(1000.00 AS Decimal(18, 2)), N'0', N'demo@gmail.com', N'7905872284', N'149c701a2b8c3e6c3269', 0, N'7131a674-270f-4eaf-ba36-ef115e00383d')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5121, CAST(0x92420B00 AS Date), N'r', CAST(1.21 AS Decimal(18, 2)), N'0', N'r@gmail.com', N'7905872284', N'b99b613d1e511584b517', 0, N'2570a672-2997-4215-bcc5-baff71f5f730')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5122, CAST(0x92420B00 AS Date), N'trse', CAST(12100.00 AS Decimal(18, 2)), N'0', N'`tes@gmail.com', N'7905872284', N'9261daed4574c1165027', 0, N'26f0a162-9dcb-4d32-afde-ccbda20987f5')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5123, CAST(0x92420B00 AS Date), N'tew', CAST(1.21 AS Decimal(18, 2)), N'0', N'vinay@gmail.com', N'7905872284', N'eb8906ed095f0ab700bc', 1, N'2a9f3934-5bce-47e6-96d2-81050bc6d430')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5124, CAST(0x92420B00 AS Date), N'f', CAST(12100.00 AS Decimal(18, 2)), N'0', N'f@gmail.com', N'7905872284', N'e58fa4744d61c62f7105', 0, N'617e1a16-f17b-4270-864a-e036338150eb')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5125, CAST(0x94420B00 AS Date), N'this', CAST(5600.00 AS Decimal(18, 2)), N'0', N'this@gmail.copm', N'1234321234', N'73f7f2c57ed7c5a538f1', 0, N'c38519e8-f620-4713-b4e2-6158cbc8b7ec')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5126, CAST(0x94420B00 AS Date), N'thhis', CAST(12100.00 AS Decimal(18, 2)), N'0', N'thia@gmail.com', N'7905872284', N'9a55ac5e59daa3d19ac6', 0, N'aa7fccba-9c26-4166-8f63-ae4605856762')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5127, CAST(0x94420B00 AS Date), N'c', CAST(183000.00 AS Decimal(18, 2)), N'0', N'C@GMAIL.COM', N'7905872284', N'0e6062018a1b70a5abf5', 0, N'c4ebb57f-f529-4fae-a996-9d27f6108d94')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5128, CAST(0x96420B00 AS Date), N'student', CAST(1200.00 AS Decimal(18, 2)), N'0', N'stu@gmail.com', N'1234321234', N'4f1b2d6d6d00caf68103', 0, N'629a372e-0165-483f-a35f-d88265f0aaa6')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5129, CAST(0x96420B00 AS Date), N'bcStudent', CAST(1200.00 AS Decimal(18, 2)), N'0', N'bcstd@gmail.com', N'2129893566', N'd09a99372791bfdd7ad5', 0, N'772c6003-cb0d-4584-af1f-eec97cf6291c')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5130, CAST(0x98420B00 AS Date), N'Jhmo', CAST(12100.00 AS Decimal(18, 2)), N'0', N'jhon@gmail.com', N'2129893566', N'c17d74429ddbacda5809', 0, N'0703138a-a503-4e02-899f-2184a9bc6927')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5131, CAST(0x9A420B00 AS Date), N'stu', CAST(1200.00 AS Decimal(18, 2)), N'0', N'stu12@gmail.com', N'2129893566', N'7723b8709fe873578705', 0, N'aa4cf6a7-0313-462d-a782-070157b96722')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5132, CAST(0x9A420B00 AS Date), N'demo', CAST(1.21 AS Decimal(18, 2)), N'0', N'vd@gmail.com', N'7905872284', N'2832a914d32d2b5b2b9b', 0, N'ba3c1a11-1121-4b02-9ae6-d1eadf80d8c2')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5133, CAST(0x9A420B00 AS Date), N'vs tiwari', CAST(1.00 AS Decimal(18, 2)), N'0', N'vinaytiwari264@gmail.com', N'7905872284', N'e166d77b5694c44ccd8f', 0, N'e964024b-5357-4c75-ab9d-e5f5754d67b3')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5134, CAST(0x9A420B00 AS Date), N'this', CAST(1.21 AS Decimal(18, 2)), N'0', N'this@gmail.com', N'7905872284', N'cae5a8fd9c693173b04b', 1, N'9a9ffedf-7ac9-4b29-abe1-8e338477f22b')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5135, CAST(0x9A420B00 AS Date), N'this2', CAST(1.21 AS Decimal(18, 2)), N'0', N'this2@gmail.com', N'7905872284', N'fdb707a8f8ca8ba829d5', 1, N'6a4857c5-0ed5-454a-831d-7776c21137c7')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5136, CAST(0x9A420B00 AS Date), N'vt', CAST(1.21 AS Decimal(18, 2)), N'0', N'vt@gmail.com', N'7905872284', N'9c35928d42c603fc4adc', 1, N'c78a405d-ec09-45d3-86e4-08dcd06c57b5')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5137, CAST(0x9A420B00 AS Date), N'Jhonsmith smith', CAST(1.21 AS Decimal(18, 2)), N'0', N'smithjhon@gmail.com', N'7905872284', N'93e1b0265a317518e7c1', 1, N'12507e16-8069-4a3c-96a6-b9fe018174d3')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5138, CAST(0x9A420B00 AS Date), N'manish', CAST(1.21 AS Decimal(18, 2)), N'0', N'manish@gmail.com', N'7905872284', N'f00b83ac8e2fb1833ae6', 1, N'5b431c8d-bb04-472c-bf74-ba46a329a4c5')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5139, CAST(0x9A420B00 AS Date), N'bill', CAST(1.21 AS Decimal(18, 2)), N'0', N'bill@gmail.com', N'7905872284', N'6a757771c3d47a9b18fb', 1, N'9afd9e6a-f6ce-4483-94ba-0e97c8a62a5e')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5140, CAST(0x9A420B00 AS Date), N'Not Pay', CAST(2.14 AS Decimal(18, 2)), N'0', N'notpay@gmail.com', N'7905872284', N'879ca45ecb13955041b9', 0, N'4b00cacf-80c5-4777-a51d-86fea2ed4493')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5141, CAST(0x9B420B00 AS Date), N'ha', CAST(2541.00 AS Decimal(18, 2)), N'0', N'ha@gmail.com', N'7905872284', N'b32bf307c119936f0ff7', 0, N'7072d833-96b2-4f1e-a274-fee11cc93f89')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5142, CAST(0x9B420B00 AS Date), N'success', CAST(1.21 AS Decimal(18, 2)), N'0', N'success@gmail.com', N'7905872284', N'91c78ed3428451f877f0', 0, N'b59f8e35-4b1b-4235-b3ee-54da73677925')
INSERT [dbo].[TabPayumoneyTransectionLog] ([ID], [Date], [FirstName], [Amount], [productInfo], [EmailAddress], [PhoneNumber], [TransectionID], [IsPaid], [ApplicationID]) VALUES (5143, CAST(0x9B420B00 AS Date), N'ms', CAST(1.21 AS Decimal(18, 2)), N'0', N'vinaytiwari264@gmail.com', N'7905872284', N'60b2a48a3cab708c7740', 1, N'2cf271e0-4d6e-466a-9faa-a31d95caac26')
SET IDENTITY_INSERT [dbo].[TabPayumoneyTransectionLog] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserDetailId], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [ApplicationID]) VALUES (11, 19, N'4', N'9', N'14', N'12345678', 1, CAST(0x07B78633D84C3A410B AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserDetailId], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [ApplicationID]) VALUES (12, 20, N'5', N'10', N'15', N'6163', 1, CAST(0x07FF17C4E6453C410B AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserDetailId], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [ApplicationID]) VALUES (13, 21, N'1', N'2', N'5', N'123', 1, CAST(0x07B95F32555E68410B AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserDetailId], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [ApplicationID]) VALUES (14, 22, N'5', N'10', N'15', N'123', 1, CAST(0x075288887BB79C410B AS DateTime2), NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserDetailId], [BoardType], [Medium], [Standard], [Password], [IsActive], [CreatedDate], [ModifiedDate], [ConfirmPassword], [ApplicationID]) VALUES (15, 23, N'1', N'2', N'5', N'123456', 1, CAST(0x07896070D2C19C410B AS DateTime2), NULL, N'123456', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[UserDetail] ON 

INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (3, N'vinay t', N'tiwari', N'kumar', N'vinay@gmail.com', N'1234321234', N'1234321234', NULL, NULL)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (6, N'NEW', N'DA', N'SDFS', N'NEW@gmail.com', N'1029384756', N'1029384756', CAST(0x0700000000003C410B AS DateTime2), NULL)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (8, N'fsdf', N'dsf', N'dfs', N'vinay@gmail.comm', N'1234321234', N'7965787764', CAST(0x07000000000029410B AS DateTime2), NULL)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (9, N'vinay try', N'tiwari', N'try', N'tiwari@gmail.com', N'7869576668', N'1234321234', CAST(0x07000000000029410B AS DateTime2), NULL)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (10, N'tiwari123', N'tiwari', N'tiwari', N'tiwari123@gmail.com', N'1234321234', N'1234321234', CAST(0x07000000000028410B AS DateTime2), NULL)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (12, N'Ruhi  ji', N'tiwari', N'tiwari', N'ruhi@gmail.com', N'7968675645', N'7968675640', CAST(0x0700000000003C410B AS DateTime2), NULL)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (16, N'vins', N'Salunke', N'l', N'vinsmahi@gmail.com', N'8652814657', N'38493408234234', CAST(0x07000000000019120B AS DateTime2), 1)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (17, N'vins', N'Salunke', N'L', N'vinsmahi@gmail.com', N'4567890321', N'8652814657', CAST(0x07000000000019120B AS DateTime2), 1)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (18, N'vins', N'Salunke', N'L', N'vinsmahi@gmail.com', N'8087979829', N'8652814657', CAST(0x070000000000BD110B AS DateTime2), 1)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (19, N'vins', N'Salunke', N'L', N'vinsmahi@gmail.com', N'78978978', N'8652814657', CAST(0x07000000000019120B AS DateTime2), 1)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (20, N'Ruhi ', N'Kumari', N'tiwari', N'ruhi@gmail.com', N'7968675645', N'7968675640', CAST(0x0700000000003C410B AS DateTime2), NULL)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (21, N'vipin ', N'Tiwari', N'Kumar', N'vipin@gmail.com', N'8978675645', N'8978675645', CAST(0x070000000000341C0B AS DateTime2), 2)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (22, N'vinay ', N'dfsdf', N'tiwari', N'vinay@gmail.com', N'1234321234', N'1234567898', CAST(0x07000000000062410B AS DateTime2), 1)
INSERT [dbo].[UserDetail] ([UserDetailId], [FirstName], [LastName], [MiddleName], [EmailAddress], [PhoneNumber], [MobileNumber], [DOB], [ReferID]) VALUES (23, N'dfds', N'SMITH', N'ddfdsf', N'SMITH@GMAIL.COM', NULL, N'1234321234', CAST(0x0700000000009E410B AS DateTime2), 2)
SET IDENTITY_INSERT [dbo].[UserDetail] OFF
SET IDENTITY_INSERT [dbo].[UserSubject] ON 

INSERT [dbo].[UserSubject] ([UserSubjectID], [SubjectName], [Amount], [StandardSecondID], [UserTempId]) VALUES (1, N'Hindi', CAST(20.00 AS Decimal(18, 2)), 1, NULL)
INSERT [dbo].[UserSubject] ([UserSubjectID], [SubjectName], [Amount], [StandardSecondID], [UserTempId]) VALUES (2, N'Math', CAST(30.00 AS Decimal(18, 2)), 2, NULL)
INSERT [dbo].[UserSubject] ([UserSubjectID], [SubjectName], [Amount], [StandardSecondID], [UserTempId]) VALUES (3, N'English', CAST(12.00 AS Decimal(18, 2)), 3, NULL)
INSERT [dbo].[UserSubject] ([UserSubjectID], [SubjectName], [Amount], [StandardSecondID], [UserTempId]) VALUES (4, N'Urdu', CAST(70.00 AS Decimal(18, 2)), 4, NULL)
INSERT [dbo].[UserSubject] ([UserSubjectID], [SubjectName], [Amount], [StandardSecondID], [UserTempId]) VALUES (5, N'urdu2', CAST(1.00 AS Decimal(18, 2)), 4, NULL)
INSERT [dbo].[UserSubject] ([UserSubjectID], [SubjectName], [Amount], [StandardSecondID], [UserTempId]) VALUES (6, N'udru3', CAST(12.00 AS Decimal(18, 2)), 5, NULL)
SET IDENTITY_INSERT [dbo].[UserSubject] OFF
SET IDENTITY_INSERT [dbo].[UserSubjectSelection] ON 

INSERT [dbo].[UserSubjectSelection] ([UserSubjectSelectionId], [UserSubjectID], [UserTempId]) VALUES (1, 4, 4067)
INSERT [dbo].[UserSubjectSelection] ([UserSubjectSelectionId], [UserSubjectID], [UserTempId]) VALUES (2, 5, 4067)
INSERT [dbo].[UserSubjectSelection] ([UserSubjectSelectionId], [UserSubjectID], [UserTempId]) VALUES (1002, 6, 5068)
INSERT [dbo].[UserSubjectSelection] ([UserSubjectSelectionId], [UserSubjectID], [UserTempId]) VALUES (1003, 1, 5069)
INSERT [dbo].[UserSubjectSelection] ([UserSubjectSelectionId], [UserSubjectID], [UserTempId]) VALUES (1004, 6, 5082)
INSERT [dbo].[UserSubjectSelection] ([UserSubjectSelectionId], [UserSubjectID], [UserTempId]) VALUES (1005, 6, 5089)
INSERT [dbo].[UserSubjectSelection] ([UserSubjectSelectionId], [UserSubjectID], [UserTempId]) VALUES (1006, 1, 5090)
SET IDENTITY_INSERT [dbo].[UserSubjectSelection] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Tab_User__C93A4F78A59D4779]    Script Date: 21-06-2021 13:08:11 ******/
ALTER TABLE [dbo].[Tab_User_Info] ADD  CONSTRAINT [UQ__Tab_User__C93A4F78A59D4779] UNIQUE NONCLUSTERED 
(
	[ApplicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Country] ADD  DEFAULT ('0') FOR [SortOrder]
GO
ALTER TABLE [dbo].[Country] ADD  DEFAULT ('1') FOR [Enabled]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_IsDefault]  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[Currency] ADD  DEFAULT (NULL) FOR [SyncCode]
GO
ALTER TABLE [dbo].[Currency] ADD  DEFAULT ((0)) FOR [IsSynced]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Question] FOREIGN KEY([Question_Id])
REFERENCES [dbo].[Question] ([Question_Id])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Question]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Admin] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Admin] ([AdminID])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Admin]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_BoardType] FOREIGN KEY([BoardTypeID])
REFERENCES [dbo].[BoardType] ([BoardTypeID])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_BoardType]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Mediums] FOREIGN KEY([MediumID])
REFERENCES [dbo].[Mediums] ([MediumID])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Mediums]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Standards] FOREIGN KEY([StandardID])
REFERENCES [dbo].[Standards] ([StandardID])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Standards]
GO
ALTER TABLE [dbo].[Choices]  WITH CHECK ADD  CONSTRAINT [FK_Choices_Question] FOREIGN KEY([Question_Id])
REFERENCES [dbo].[Question] ([Question_Id])
GO
ALTER TABLE [dbo].[Choices] CHECK CONSTRAINT [FK_Choices_Question]
GO
ALTER TABLE [dbo].[City_Old]  WITH CHECK ADD  CONSTRAINT [FK_City_State] FOREIGN KEY([StateID])
REFERENCES [dbo].[State_Old] ([StateID])
GO
ALTER TABLE [dbo].[City_Old] CHECK CONSTRAINT [FK_City_State]
GO
ALTER TABLE [dbo].[Emp_City]  WITH CHECK ADD  CONSTRAINT [FK_Emp_City_EmpState] FOREIGN KEY([EmpStateID])
REFERENCES [dbo].[EmpState] ([EmpStateID])
GO
ALTER TABLE [dbo].[Emp_City] CHECK CONSTRAINT [FK_Emp_City_EmpState]
GO
ALTER TABLE [dbo].[Employee_Form]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_Emp_City] FOREIGN KEY([Emp_CityID])
REFERENCES [dbo].[Emp_City] ([Emp_CityID])
GO
ALTER TABLE [dbo].[Employee_Form] CHECK CONSTRAINT [FK_Employee_Form_Emp_City]
GO
ALTER TABLE [dbo].[Employee_Form]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_EmpState] FOREIGN KEY([EmpStateID])
REFERENCES [dbo].[EmpState] ([EmpStateID])
GO
ALTER TABLE [dbo].[Employee_Form] CHECK CONSTRAINT [FK_Employee_Form_EmpState]
GO
ALTER TABLE [dbo].[Employee_Form]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_PostForm] FOREIGN KEY([PostID])
REFERENCES [dbo].[PostForm] ([PostID])
GO
ALTER TABLE [dbo].[Employee_Form] CHECK CONSTRAINT [FK_Employee_Form_PostForm]
GO
ALTER TABLE [dbo].[Employee_Form]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_ReferalForm] FOREIGN KEY([RefferalID])
REFERENCES [dbo].[ReferalForm] ([RefferalID])
GO
ALTER TABLE [dbo].[Employee_Form] CHECK CONSTRAINT [FK_Employee_Form_ReferalForm]
GO
ALTER TABLE [dbo].[Employee_Form_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_Temp_Emp_City] FOREIGN KEY([Emp_CityID])
REFERENCES [dbo].[Emp_City] ([Emp_CityID])
GO
ALTER TABLE [dbo].[Employee_Form_Temp] CHECK CONSTRAINT [FK_Employee_Form_Temp_Emp_City]
GO
ALTER TABLE [dbo].[Employee_Form_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_Temp_EmpState] FOREIGN KEY([EmpStateID])
REFERENCES [dbo].[EmpState] ([EmpStateID])
GO
ALTER TABLE [dbo].[Employee_Form_Temp] CHECK CONSTRAINT [FK_Employee_Form_Temp_EmpState]
GO
ALTER TABLE [dbo].[Employee_Form_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_Temp_PostForm] FOREIGN KEY([PostID])
REFERENCES [dbo].[PostForm] ([PostID])
GO
ALTER TABLE [dbo].[Employee_Form_Temp] CHECK CONSTRAINT [FK_Employee_Form_Temp_PostForm]
GO
ALTER TABLE [dbo].[Employee_Form_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Form_Temp_ReferalForm] FOREIGN KEY([RefferalID])
REFERENCES [dbo].[ReferalForm] ([RefferalID])
GO
ALTER TABLE [dbo].[Employee_Form_Temp] CHECK CONSTRAINT [FK_Employee_Form_Temp_ReferalForm]
GO
ALTER TABLE [dbo].[ExamResult]  WITH CHECK ADD  CONSTRAINT [FK_ExamResult_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[ExamResult] CHECK CONSTRAINT [FK_ExamResult_User]
GO
ALTER TABLE [dbo].[MediumSecond]  WITH CHECK ADD  CONSTRAINT [FK_MediumSecond_BoardTypeSecond] FOREIGN KEY([BoardSecondID])
REFERENCES [dbo].[BoardTypeSecond] ([BoardSecondID])
GO
ALTER TABLE [dbo].[MediumSecond] CHECK CONSTRAINT [FK_MediumSecond_BoardTypeSecond]
GO
ALTER TABLE [dbo].[PartnerCartItem]  WITH CHECK ADD  CONSTRAINT [FK_PartnerCartItem_PartnerCartItem] FOREIGN KEY([CartID])
REFERENCES [dbo].[PartnerCart] ([CartID])
GO
ALTER TABLE [dbo].[PartnerCartItem] CHECK CONSTRAINT [FK_PartnerCartItem_PartnerCartItem]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_BoardType] FOREIGN KEY([BoardTypeID])
REFERENCES [dbo].[BoardType] ([BoardTypeID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_BoardType]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Category] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Category] ([Category_ID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Category]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Mediums] FOREIGN KEY([MediumID])
REFERENCES [dbo].[Mediums] ([MediumID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Mediums]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Standards] FOREIGN KEY([StandardID])
REFERENCES [dbo].[Standards] ([StandardID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Standards]
GO
ALTER TABLE [dbo].[ScheduleExam]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleExam_BoardType] FOREIGN KEY([BoardTypeID])
REFERENCES [dbo].[BoardType] ([BoardTypeID])
GO
ALTER TABLE [dbo].[ScheduleExam] CHECK CONSTRAINT [FK_ScheduleExam_BoardType]
GO
ALTER TABLE [dbo].[ScheduleExam]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleExam_Mediums] FOREIGN KEY([MediumID])
REFERENCES [dbo].[Mediums] ([MediumID])
GO
ALTER TABLE [dbo].[ScheduleExam] CHECK CONSTRAINT [FK_ScheduleExam_Mediums]
GO
ALTER TABLE [dbo].[ScheduleExam]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleExam_Standards] FOREIGN KEY([StandardID])
REFERENCES [dbo].[Standards] ([StandardID])
GO
ALTER TABLE [dbo].[ScheduleExam] CHECK CONSTRAINT [FK_ScheduleExam_Standards]
GO
ALTER TABLE [dbo].[StandardSecond]  WITH CHECK ADD  CONSTRAINT [FK_StandardSecond_MediumSecond] FOREIGN KEY([MediumSecondID])
REFERENCES [dbo].[MediumSecond] ([MediumSecondID])
GO
ALTER TABLE [dbo].[StandardSecond] CHECK CONSTRAINT [FK_StandardSecond_MediumSecond]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_BoardType] FOREIGN KEY([BoardTypeID])
REFERENCES [dbo].[BoardType] ([BoardTypeID])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_BoardType]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_Mediums] FOREIGN KEY([MediumID])
REFERENCES [dbo].[Mediums] ([MediumID])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_Mediums]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_Standards1] FOREIGN KEY([StandardID])
REFERENCES [dbo].[Standards] ([StandardID])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_Standards1]
GO
ALTER TABLE [dbo].[Tab_User_Info]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City_Old] ([CityID])
GO
ALTER TABLE [dbo].[Tab_User_Info] CHECK CONSTRAINT [FK_Tab_User_Info_City]
GO
ALTER TABLE [dbo].[Tab_User_Info]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_EmpCourse] FOREIGN KEY([EmpID])
REFERENCES [dbo].[EmpCourse] ([EmpID])
GO
ALTER TABLE [dbo].[Tab_User_Info] CHECK CONSTRAINT [FK_Tab_User_Info_EmpCourse]
GO
ALTER TABLE [dbo].[Tab_User_Info]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_State] FOREIGN KEY([StateID])
REFERENCES [dbo].[State_Old] ([StateID])
GO
ALTER TABLE [dbo].[Tab_User_Info] CHECK CONSTRAINT [FK_Tab_User_Info_State]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_Temp_BoardType] FOREIGN KEY([BoardTypeID])
REFERENCES [dbo].[BoardType] ([BoardTypeID])
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] CHECK CONSTRAINT [FK_Tab_User_Info_Temp_BoardType]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_Temp_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] CHECK CONSTRAINT [FK_Tab_User_Info_Temp_City]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_Temp_Mediums] FOREIGN KEY([MediumID])
REFERENCES [dbo].[Mediums] ([MediumID])
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] CHECK CONSTRAINT [FK_Tab_User_Info_Temp_Mediums]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_Temp_Standards] FOREIGN KEY([StandardID])
REFERENCES [dbo].[Standards] ([StandardID])
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] CHECK CONSTRAINT [FK_Tab_User_Info_Temp_Standards]
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp]  WITH CHECK ADD  CONSTRAINT [FK_Tab_User_Info_Temp_State] FOREIGN KEY([StateID])
REFERENCES [dbo].[State] ([StateID])
GO
ALTER TABLE [dbo].[Tab_User_Info_Temp] CHECK CONSTRAINT [FK_Tab_User_Info_Temp_State]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_BoardType] FOREIGN KEY([BoardTypeID])
REFERENCES [dbo].[BoardType] ([BoardTypeID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_BoardType]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Mediums] FOREIGN KEY([MediumID])
REFERENCES [dbo].[Mediums] ([MediumID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Mediums]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Subjects]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserDetail] FOREIGN KEY([UserDetailId])
REFERENCES [dbo].[UserDetail] ([UserDetailId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserDetail]
GO
ALTER TABLE [dbo].[UserSubject]  WITH CHECK ADD  CONSTRAINT [FK_UserSubject_StandardSecond] FOREIGN KEY([StandardSecondID])
REFERENCES [dbo].[StandardSecond] ([StandardSecondID])
GO
ALTER TABLE [dbo].[UserSubject] CHECK CONSTRAINT [FK_UserSubject_StandardSecond]
GO
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [FK_Video_BoardType] FOREIGN KEY([BoardTypeID])
REFERENCES [dbo].[BoardType] ([BoardTypeID])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [FK_Video_BoardType]
GO
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [FK_Video_Mediums] FOREIGN KEY([MediumID])
REFERENCES [dbo].[Mediums] ([MediumID])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [FK_Video_Mediums]
GO
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [FK_Video_Standards] FOREIGN KEY([StandardID])
REFERENCES [dbo].[Standards] ([StandardID])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [FK_Video_Standards]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This table saves User details.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserDetail'
GO
USE [master]
GO
ALTER DATABASE [ExamStudent] SET  READ_WRITE 
GO
