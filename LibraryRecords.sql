Use master
IF DB_ID('LibraryRecords') IS NOT NULL
DROP Database LibraryRecords
GO
-- Cration of database named "LibraryRecords" with custom properties and default database location.
Use master
DECLARE @location_path nvarchar(255);
SET @location_path = (SELECT SUBSTRING(physical_name, 1, CHARINDEX(N'master.mdf', LOWER(physical_name)) - 1)
      FROM master.sys.master_files
      WHERE database_id = 1 AND file_id = 1);
EXECUTE ('CREATE DATABASE LibraryRecords
ON PRIMARY(NAME = LibraryRecords_data, FILENAME = ''' + @location_path + 'LibraryRecords_data.mdf'', SIZE = 12MB, MAXSIZE = 128MB, FILEGROWTH = 2MB)
LOG ON (NAME = LibraryRecords_log, FILENAME = ''' + @location_path + 'LibraryRecords_log.ldf'', SIZE = 10MB, MAXSIZE = 100MB, FILEGROWTH = 1MB)'
);
GO

Use LibraryRecords
ALTER DATABASE LibraryRecords MODIFY FILE(Name='LibraryRecords_data', Size=16MB, MaxSize=512MB, FileGrowth=5%);
GO
ALTER DATABASE LibraryRecords MODIFY FILE(Name='LibraryRecords_log', Size=12MB, MaxSize=128MB, FileGrowth=2MB);
GO

--Table Creation

-- Creating BookCategories table

Use LibraryRecords
CREATE TABLE BookCategories
(
  CategoryID	int NOT NULL PRIMARY KEY,
  Category		varchar(30) NOT NULL
); 
GO
-- Creating Books table

CREATE TABLE Books
(
  BookID		int PRIMARY KEY IDENTITY(100,1) ,
  Title		varchar(100) NOT NULL,
  Author		varchar(120) NOT NULL,
  Description	varchar(140) SPARSE NULL,
  CategoryID	int	FOREIGN KEY REFERENCES BookCategories(CategoryID) ON DELETE SET NULL,
  AddedTime		datetime NOT NULL DEFAULT GETDATE()
); 
GO
--Creating Members table
CREATE TABLE Members
(
	MemberID	int NOT NULL PRIMARY KEY IDENTITY(500,1) ,
	MemberName	varchar(30) NOT NULL,
	MemberStatus varchar(15) -- Student Or Teacher
);
GO
-- Creating Groups table

CREATE TABLE StudentGroup
(
  GroupID		int	PRIMARY KEY,
  GroupName		varchar(15)  NOT NULL
);
GO
-- Creating Students table

CREATE TABLE Students
(
  StudentID	int PRIMARY KEY IDENTITY,
  GroupID		int FOREIGN KEY REFERENCES StudentGroup(GroupID) ON DELETE SET NULL,
  MemberID	int FOREIGN KEY REFERENCES Members(MemberID) ON DELETE CASCADE,
  StudentName	varchar(30) NOT NULL,
  Gender		nvarchar(1) NOT NULL,--'M' for male and 'F' for female
  Email		varchar(50) NOT NULL CHECK (Email LIKE '%@%')
);
GO

CREATE TABLE Teachers
(
  TeacherID		int PRIMARY KEY IDENTITY,
  MemberID		int FOREIGN KEY REFERENCES Members(MemberID) ON DELETE CASCADE,
  TeacherName	varchar(30) NOT NULL,
  Gender		nvarchar(1) NOT NULL, --'M' for male and 'F' for female
  PhoneNumber	varchar(15) NOT NULL CHECK(PhoneNumber LIKE '01%' ),
  Email			varchar(50) NOT NULL CHECK (Email LIKE '%@%')
);

GO
--Creating Liberian table
CREATE TABLE Liberian
(
	 LiberianID	int PRIMARY KEY,
	 LiberianName	varchar(30)

);
GO
-- Creating BookIssue table

CREATE TABLE BookIssue 
(
  IssueID			int PRIMARY KEY IDENTITY,
  BookID			int FOREIGN KEY REFERENCES Books(BookID),
  MemberID		int FOREIGN KEY REFERENCES Members(MemberID),
  IssuedTime		date NOT NULL DEFAULT CURRENT_TIMESTAMP,
  LiberianID		int FOREIGN KEY REFERENCES Liberian(LiberianID)
);
GO
--Creating ReservedBook table
CREATE TABLE ReservedBook
(
	  CategoryID		int FOREIGN KEY REFERENCES BookCategories(CategoryID),
	  AddedTime		date NOT NULL DEFAULT CURRENT_TIMESTAMP,
	  NumberOfBooks		int NOT NULL default 0 
);
GO
--Creating BookIssueLog table

CREATE TABLE BookIssueLog
(
  ID			int,
  MemberID		int FOREIGN KEY REFERENCES Members(MemberID), 
  IssueID			int FOREIGN KEY REFERENCES BookIssue(IssueID),
  IssuedTime		date	NOT NULL, 
  ReturnTime		date	DEFAULT SYSDATETIME()
);
GO
CREATE TABLE FineRecords
(
	 MemberID		int FOREIGN KEY REFERENCES Members(MemberID) ON DELETE CASCADE,
	 StudentID		int SPARSE NULL FOREIGN KEY REFERENCES Students(StudentID),
	 TeacherID		int SPARSE NULL FOREIGN KEY REFERENCES Teachers(TeacherID),
	 FineAmount		money default 0

);
GO
--##Temporary Table Variable##
--Temporary Table variable will run under one batch

DECLARE @TempBook TABLE
(
	TempBookID		 int PRIMARY KEY IDENTITY(30,1) ,
	TempBookTitle		 varchar(100) NOT NULL,
	TempBookAuthor		 varchar(100) NOT NULL,
	TempBookAddedTime	 datetime NULL DEFAULT GETDATE()
)

INSERT INTO @TempBook VALUES('Current News', 'Jashim Uddin',NULL)
SELECT * FROM @TempBook 

GO 

--Local Table

CREATE TABLE #LocalBook
(
		LocalBookID	int PRIMARY KEY IDENTITY,
		LocalBookName	varchar(100)  SPARSE NULL
);

INSERT INTO #LocalBook VALUES('Current Affairs');
SELECT * From #LocalBook
GO
--Global Table

CREATE TABLE ##GlobalBook
(
	GlobalBookID		int PRIMARY KEY IDENTITY,
	GlobalBookName		varchar(100)  SPARSE NULL
);
INSERT INTO ##GlobalBook VALUES('Current Affairs');

SELECT * FROM ##GlobalBook 
GO

--TRUNCATE TABLE ##GlobalBook --We can reuse deleted identity with the Keyword 
--DELETE ##GlobalBook -- This command will delete all the values within the ##GlobalBook table
--DROP TABLE ##GlobalBook --This Command completely delete the ##GlobalBook table
--GO

------------------------------------------------------------------------------
		--Data Entry
------------------------------------------------------------------------------
Use master
Go
Use LibraryRecords
GO

--Custom Message and System Message
SELECT * FROM master.sys.messages --To show all the system messages
GO

--Adding a custom message
sp_addmessage 
@msgnum=50025, --Giving message number.The number must be greater than 50000. 
@severity=11,
@msgtext ='Message From C#, Round-46, IsDB-BISEW'
RAISERROR (50025,11,11,'IDB R46-C#') --Defining error level and state.
GO

 --Retriving the custom error message 
SELECT * FROM master.sys.messages Where message_id = 50025

EXEC sp_dropmessage 50025 --Droping the custom message using message number.
GO 


EXEC sp_help Books --To show all the information of the table "Books"
GO 


--Inserting data in the tables

INSERT INTO  BookCategories (CategoryID,Category) VALUES(1,'References Book'),(2,'Academic Books'),(3,'Novel'),(4,'Magazine');
GO
INSERT Books
(
	Title,			
	Author,		
	Description,	
	CategoryID,	
	AddedTime		
)
VALUES('Business Statistics', 'Manindra Roy','For Business Graduates.',1,'2012/01/01'),
		('Business Mathmatics', 'S.P Gupta','For Business Graduates.',1,'2013/07/01'),
			('Business Finance', 'Hasan Rahman','For Business Graduates.',1,'2013/09/01'),
			('Financial Management', 'Abdur Rahman','For Business Graduates.',2,'2019/03/01'),
			('Business Law', 'Manindra Roy','For Business Graduates.',1,'2018/05/01'),
			('Research Journal', 'Morshedur Rahman','For Business Graduates.',4,'2013/06/01'),
			('Advanced Statistics', 'Manindra Roy','For Business Graduates.',1,'2017/10/01'),
			('Intermediate Accounting', 'Jashim Uddin','For Business Graduates.',1,'2014/11/15'),
			('Business Programming', 'Foysal Wahid','For Business Graduates.',1,'1996/12/31'),
			('Entrepreneurship Cases', 'Jahid Hasan','For Business Graduates.',3,'2021/01/31');

GO 

INSERT INTO StudentGroup VALUES(1,'BBA'),(2,'MBA');
GO

INSERT Members VALUES('Hasan','Student'),	('Bakul','Student'),	('Badol','Student'),	('Farjana','Teacher'),
					 ('Kalam','Student'),	('Hasnahena','Student'), ('Bidhan','Student'),	('Setu','Teacher'),
					 ('Babul','Student'),	('Akash','Student'),	('Bikash','Student'),	('Polash','Teacher'),
					 ('Rafique','Student'), ('Badsha','Student'),	 ('Jashim','Student'),	('Foyjul','Teacher'),
					 ('Bulbul','Student'),	('Tutul','Student'),	('Joynal','Student'),	('Tarek','Teacher'),
					 ('Nishan','Student'),	('Sujan','Student'),	('Khan','Student'),		('Belal','Teacher'),
					 ('Rahim','Student'),	('Foysal','Student'),	('Sadiya','Student'),	('Kashem','Teacher');
GO
INSERT Students
(
	 GroupID,		
	 MemberID,		
	 StudentName,	
	 Gender,		
	 Email	
)
VALUES
(1,500,'Hasan','M','hasan@yahoo.com'),(1,501,'Bakul','M','bakul@yahoo.com'),(1,502,'Badol','M','badol@yahoo.com'),(1,503,'Farjana','F','farjana@yahoo.com'),
(1,504 ,'Kalam','M','kalam@yahoo.com'),(1,505 ,'Hasnahena','F','hasnahena@yahoo.com'),(1,506 ,'Bidhan','M','bidhan@hotmail.com'),(1,508 ,'Babul','M','babul@hotmail.com'),
(1,509 ,'Akash','M','akash@gmail.com'),(1,510 ,'Bikash','M','bikash@mail.ru.com'),(1,512 ,'Rafique','M','rafique@hotmail.com'),(1,513 ,'Badsha','M','badsha@outlook.com'),
(1,514 ,'Jashim','M','jashim@gmail.com'),(1,516 ,'Bulbul','M','bulbul@outlook.com'),(1,517 ,'Tutul','M','tutul@yahoo.com'),(1,518 ,'Joynal','M','joynal@yahoo.com'),
(1,520 ,'Nishan','M','nishan@mail.ru.com'),(1,521 ,'Sujan','M','sujan@yahoo.com'),(1,522 ,'Khan','M','khan@outlook.com'),(1,524 ,'Rahim','M','Rahim@gmail.com'),
(1,525 ,'Foysal','M','foysal@idb-bisew.net'),(1,526 ,'Sadiya','F','sadiya@outlook.com'),

(2,500,'Hasan','M','hasan2@yahoo.com'),
(2,504 ,'Kalam','M','kalam2@yahoo.com'),
(2,509 ,'Akash','M','akash2@gmail.com'),
(2,514 ,'Jashim','M','jashim2@gmail.com'),
(2,520 ,'Nishan','M','nishan2@mail.ru.com'),
(2,525 ,'Foysal','M','foysal2@idb-bisew.net');

GO
INSERT Teachers
(
	MemberID,		
	TeacherName,	
	Gender,		
	PhoneNumber,	
	Email			
)
VALUES
	(503,'Farjana','F','01736709090','farjana@gmail.com' ),
	(507,'Setu','M','01736709091','setu@outlook.com' ),
	(511,'Polash','M','01836709092','polash@gmail.com' ),
	(515,'Foyjul','M','01836709093','foyjul@gmail.com' ),
	(519,'Tarek','M','01936709094','tarek@mail.ru.com' ),
	(523,'Belal','M','01536709095','belal@hotmail.com' ),
	(527,'Kashem','M','01336709096','kashem@hotmail.com' );
GO

INSERT INTO  Liberian (LiberianID, LiberianName)
VALUES(1,'Farhana'),(2,'Motin'),(3,'Yakub'),(4,'Rahima');
GO
INSERT INTO BookIssue
(
	BookID,	
	MemberID,	
	IssuedTime,
	LiberianID
)
VALUES
	( 100,511,'2021/02/02',1), 
	( 104,502,'2021/02/10',3),
	( 102,522,'2021/02/07',4),
	( 101,500,'2021/02/07',2);
GO
INSERT ReservedBook (CategoryID,AddedTime,NumberOfBooks) 
VALUES
	(1,'2020/02/02',100),
	(2,'2020/02/02',350),
	(3,'2020/02/02',700),
	(4,'2020/02/02',75);
GO
INSERT BookIssueLog 
(
	ID,
	MemberID,	
	IssueID,	
	ReturnTime,
	IssuedTime
)
VALUES(1000,511,1,'2021/02/07','2021/02/08'),
		(1001,502,2,'2021/02/07','2021/02/09'),
			(1002,522,3,'2021/02/07','2021/02/09'),
				(1003,500,4,'2021/02/7','2021/02/10');
GO
INSERT FineRecords(MemberID,StudentID,TeacherID,FineAmount)
VALUES(500,1,NULL,10),(502,3,NULL,25),(511,NULL,3,20),(522,19,NULL,20);
GO

--Retriving Data From Tables
SELECT * FROM BookCategories
SELECT * FROM Books
SELECT * FROM Members
SELECT * FROM StudentGroup
SELECT * FROM Students
SELECT * FROM Teachers
SELECT * FROM Liberian
SELECT * FROM BookIssue
SELECT * FROM ReservedBook
SELECT * FROM BookIssueLog
SELECT * FROM FineRecords

GO 

--Update Table Operation
UPDATE BookIssueLog
SET IssuedTime='2021/02/01'
WHERE IssueID=1 AND MemberID=511
GO

 --Some clauses

 --A query to find out total number of students and teachers
SELECT MemberStatus, COUNT(*) AS Total FROM Members GROUP BY MemberStatus WITH CUBE ;
GO
 --A query to display total number of students. 
SELECT MemberName, MemberStatus FROM Members WHERE MemberStatus ='Student';
GO
 --A query to display total number of teachers. 
SELECT MemberName, MemberStatus FROM Members WHERE MemberStatus ='Teacher';
GO

 --A query to display members with a range of MemberID. 
SELECT * FROM Members WHERE MemberID BETWEEN 500 AND 515;
GO

--Display the total number of members in each category in the order of total number.

SELECT MemberStatus, COUNT(MemberStatus) AS [Total Member]
FROM Members GROUP BY MemberStatus ORDER BY 1;
--Order by 1 indicate that the result will be ordered by "Memberstatus"
GO
 

--Uses of all basic six clauses in a single query. The clauses are used in the following order:
--SELECT>FROM>WHERE>GROUP BY> HAVING>ORDER BY

SELECT MemberStatus, COUNT(MemberStatus) AS [Total Member]
FROM Members
WHERE MemberStatus IN ('Student','Teacher')
GROUP BY MemberStatus 
HAVING COUNT(MemberStatus) >=1
ORDER BY 1
GO

--Subquery/Conditional Retrive
SELECT SUM (FineAmount) AS [Total Fine Amount], AVG(FineAmount) AS [Averge Fine Amount]
FROM FineRecords
WHERE MemberID IN (SELECT MemberID FROM Members WHERE MemberStatus IN('Student','Teacher'))
GO

SELECT * FROM
(SELECT * FROM Members WHERE (MemberStatus ='Student' AND MemberID <=520))
MemberName
GO 

 --Creation of Index
CREATE CLUSTERED INDEX IX_IndexMemberID
ON FineRecords(MemberID)
GO
CREATE NONCLUSTERED INDEX IX_NonClsIndexFineAmount
ON FineRecords(FineAmount)
GO


 --VIEW CREATION--

 --Creating View to show all related book information to take a decision to borrow books.
 --Only books that have been issued 7 days or earlier will be shown since we are assuming that
 --the maximum allowed time for a book is only one week.

CREATE VIEW vw_BookInfo AS

SELECT 

	BC.CategoryID,
	BC.Category,
	B.BookID,		
	B.Title,			
	B.Author,					
	BIS.IssuedTime,
	BIS.LiberianID
	
FROM BookCategories AS BC
JOIN Books AS B
	ON BC.CategoryID=B.CategoryID
JOIN BookIssue AS BIS
	ON B.BookID=BIS.BookID

WHERE BIS.IssuedTime <= GETDATE()-7 

GO

SELECT * FROM vw_BookInfo 
GO

--Creating View to show all book issue and availability related information.

CREATE VIEW vw_BookLog AS

SELECT 

	BIG.ID,		
	BIG.MemberID,	
	BIG.IssueID,	
	BIG.IssuedTime,
	BIG.ReturnTime,
	BIS.BookID,		
	BIS.LiberianID

FROM BookIssue AS BIS
JOIN BookIssueLog AS BIG
	ON BIS.IssueID=BIG.IssueID

WHERE BIG.ReturnTime <= GETDATE() 

GO

SELECT * FROM vw_BookLog 
GO


--Creating View to show information of Students along with fine if any.

CREATE VIEW vw_StudentFine AS

SELECT 

	S.StudentID,		
	S.StudentName,			
	S.Email,
	SG.GroupID,	
	SG.GroupName,
	FR.MemberID,
	M.MemberName,	
	M.MemberStatus, 	
	FR.FineAmount

FROM Students AS S
JOIN StudentGroup AS SG
	ON S.GroupID=SG.GroupID
JOIN Members AS M
	ON M.MemberID=S.MemberID
JOIN FineRecords AS FR
	ON FR.MemberID = S.MemberID
WHERE M.MemberStatus<>'Teacher'

GO

SELECT * FROM vw_StudentFine 
GO

--Merge

MERGE BookIssueLog AS t
USING BookIssue AS s
ON (s.IssueID= t.IssueID)

	WHEN MATCHED 
	   THEN UPDATE SET t.IssueID = s.IssueID, t.MemberID=s.MemberID,
					t.IssuedTime = s.IssuedTime
	WHEN NOT MATCHED BY TARGET
	   THEN INSERT (IssueID, MemberID, IssuedTime) VALUES (s.IssueID, s.MemberID,s.IssuedTime)
	WHEN NOT MATCHED BY SOURCE
   THEN DELETE;

GO

SELECT * FROM BookIssueLog
SELECT * FROM BookIssue
GO

-- Common Table Expression (CTE) to find out the issued books 
WITH lbBookIssued
AS
(
	SELECT BookID, IssuedTime FROM BookIssue WHERE IssuedTime<=GETDATE()
)
SELECT * FROM lbBookIssued
GO



--Creating a store procedure to insert record in BookIssue table
CREATE PROC sp_BookIssue
@bookid			int, 
@memberid		int, 
@issuedtime		date,
@liberianid		int, 

@comment varchar(255) output --to show a message that the book is issued successfully
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO BookIssue (BookID,MemberID,IssuedTime,LiberianID)
			VALUES(@bookid,@memberid,@issuedtime,@liberianid)
			SET @comment='Issued successfully!!!'
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION		
		PRINT 'Please provide valid information.'
	END CATCH
END
GO


SELECT * FROM BookIssue
GO

EXEC sp_BookIssue 103,503,'2021/02/09',3,'Jashim'
GO
--To show the comment as output
DECLARE @comment varchar(255)
EXEC sp_BookIssue 105,505,'2021/02/09',1, @comment output
SELECT @comment
GO

--Creating Trigger

CREATE TRIGGER trg_BookData ON dbo.BookIssue
FOR INSERT,UPDATE
AS
DECLARE
	@issueid		int, 
	@bookid			int, 	
	@memberid		int, 	
	@issuedtime		date,		
	@liberianid		int,
	@activity		varchar(200)

SELECT @issueid=i.IssueID FROM INSERTED i;		
SELECT @bookid=i.BookID FROM INSERTED i;		
SELECT @memberid=i.MemberID FROM INSERTED i;
SELECT @issuedtime=i.IssuedTime FROM INSERTED i;		
SELECT @liberianid=i.LiberianID FROM INSERTED i;

SET @activity='Record Placed. After Insert,Update Trigger Fired!!!'	

INSERT INTO BookIssueLog(ID,MemberID,IssueID,IssuedTime,ReturnTime)
VALUES(@issueid,@memberid,@issueid,@issuedtime,GETDATE() );
					
PRINT'After Insert,Update Trigger Fired!!!'
GO


INSERT INTO BookIssue (BookID,MemberID,IssuedTime,LiberianID) VALUES( 100,521,'2021/02/09',1);
GO

UPDATE BookIssue
SET MemberID=501
WHERE IssueID=7
GO

--Enabling and Disabling Trigger 
ALTER Table BookIssue DISABLE TRIGGER trg_BookData
GO
ALTER Table BookIssue ENABLE TRIGGER trg_BookData
GO

--Instead of Trigger 
CREATE TRIGGER trg_InstedOfDeleteBookData ON dbo.BookIssue 
--error occoured because the dbo.BookIssue' table has a FOREIGN KEY with cascading DELETE or UPDATE.
INSTEAD OF DELETE
AS
DECLARE
	@issueid		int, 
	@bookid			int, 	
	@memberid		int, 	
	@issuedtime		date,		
	@liberianid		int,
	@activity		varchar(200)

SELECT @issueid=i.IssueID FROM DELETED i;		
SELECT @bookid=i.BookID FROM DELETED i;		
SELECT @memberid=i.MemberID FROM DELETED i;
SELECT @issuedtime=i.IssuedTime FROM DELETED i;		
SELECT @liberianid=i.LiberianID FROM DELETED i;

SET @activity='Record DELETED. After Instead of DELETE Trigger Fired!!!'	

	   
BEGIN
	BEGIN TRAN
			SET NOCOUNT ON
			IF(@liberianid<=0)
				BEGIN
						RAISERROR('Can not DELETE.',16,1)
						ROLLBACK
				END
			ELSE
				BEGIN
						
					DELETE FROM BookIssue
					WHERE IssueID=@issueid

					INSERT INTO BookIssueLog(ID,MemberID,IssueID,IssuedTime,ReturnTime)
					VALUES(@@IDENTITY,@memberid,@issueid,@issuedtime,GETDATE() );

				END

	COMMIT TRAN
	PRINT'Instead of DELETE Trigger Fired!!!'
END

GO

SELECT * FROM BookIssue
SELECT * FROM BookIssueLog
GO

--CAST and Convert

SELECT 'Today is : ' + CAST(GETDATE() AS varchar) --CAST Function
SELECT 'Today is: ' + CONVERT(varchar, GETDATE()) --Convert Function

--CONVERT and CAST both functions are used to change data type from another data type.
--With Convert() function, we can use customised style
--Notes

		--1 or 101 For American Style
		--2 or 102 For ANSI Style
		--3 or 103 For British Or French Style
		--4 or 104 For German Style
		--5 or 105 For Italy Style

GO

--Creating Sequence
USE LibraryRecords
CREATE SEQUENCE seq_Liberian
AS Bigint
START WITH 5
INCREMENT BY 1
GO

SELECT * FROM Liberian
INSERT INTO Liberian(LiberianID,LiberianName) VALUES
		(NEXT VALUE FOR seq_Liberian, 'Jashim');
SELECT * FROM Liberian
GO


--DATEDIFF Function

SELECT DATEDIFF(yy,CAST('01/15/2019' AS datetime), GETDATE()) AS YEARS

SELECT DATEDIFF(MM,CAST('01/15/2020' AS datetime), GETDATE())%12 AS Months

SELECT DATEDIFF(DD,CAST('01/10/2021' AS datetime), GETDATE())%30 AS Days

GO

---Creating Function
--Creating a function to calculate the amount of fine.

CREATE FUNCTION fn_FineAmountOfStudent
( @issuedate date, @returndate date)
RETURNS int
AS
BEGIN
RETURN ((DATEDIFF(dd,@issuedate,@returndate)-7))*10
END
GO
SELECT dbo.fn_FineAmountOfStudent('2021/01/01','2021/01/11') 
GO 
CREATE FUNCTION fn_FineAmountOfTeacher
(@issuedate date, @returndate date)
RETURNS int
AS
BEGIN
RETURN ((DATEDIFF(dd,@issuedate,@returndate)-10))*5 
END
GO
SELECT dbo.fn_FineAmountOfTeacher('2021/01/01','2021/01/21') 
GO

--Store Procedure for Multiple Table for Multiple Operation
CREATE PROC sp_BookIssueReturn
	
	@issueid			int, 
	@bookid			int, 
	@memberid		int, 
	@issuedtime		date,
	@liberianid		int,
	
	@id			int,
	@returntime		date,
	
	@tablename		varchar(25),
	@operationname		varchar(25)

AS
BEGIN
		IF(@tablename='BookIssue' AND @operationname='INSERT')

		BEGIN
			Insert BookIssue values(@bookid,@memberid,@issuedtime,@liberianid)
			SELECT * FROM vw_BookLog 
		END							

		IF(@tablename='BookIssue' AND @operationname='UPDATE')

		BEGIN
			UPDATE BookIssue 
			SET BookID=@bookid,MemberID=@memberid, IssuedTime=@issuedtime, LiberianID=@liberianid
			WHERE IssueID=@issueid
			SELECT * FROM vw_BookLog 
		END

		IF(@tablename='BookIssue' AND @operationname='DELETE')

		BEGIN
			DELETE FROM BookIssue
			WHERE IssueID=@issueid
			SELECT * FROM vw_BookLog 
		END
--BookIssueLog Table
		IF(@tablename='BookIssueLog' AND @operationname='INSERT')

		BEGIN
			Insert BookIssueLog values(@id,@memberid,@issueid,@issuedtime,@returntime)
			SELECT * FROM vw_BookLog 
		END							

		IF(@tablename='BookIssueLog' AND @operationname='UPDATE')

		BEGIN
			UPDATE BookIssueLog 
			SET MemberID=@memberid,IssueID=@issueid,IssuedTime=@issuedtime,ReturnTime=@returntime
			WHERE ID=@id
			SELECT * FROM vw_BookLog 
		END

		IF(@tablename='BookIssueLog' AND @operationname='DELETE')

		BEGIN
			DELETE FROM BookIssueLog
			WHERE ID=@id
			SELECT * FROM vw_BookLog 
		END


END 
GO

SELECT * FROM BookIssue 
SELECT * FROM BookIssueLog
GO

EXEC sp_BookIssueReturn 11,101,515,'2021/02/07',1,5000,'2021/02/10','BookIssue','INSERT'

GO 



------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------