CREATE TABLE [dbo].[student_info] (
    [Id]                    INT          IDENTITY (1, 1) NOT NULL,
    [student_name]          VARCHAR (50) NULL,
    [student_image]         VARCHAR (50) NULL,
    [student_enrollment_no] VARCHAR (50) NULL,
    [student_department]    VARCHAR (50) NULL,
    [student_semester]      VARCHAR (50) NULL,
    [student_contact]       VARCHAR (50) NULL,
    [student_email]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

