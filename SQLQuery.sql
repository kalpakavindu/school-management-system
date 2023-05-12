CREATE TABLE [dbo].[SubjectTable] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
)
GO

CREATE TABLE [dbo].[TeacherTable] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [name]           VARCHAR (100) NOT NULL,
    [gender]         VARCHAR (20)  NOT NULL,
    [dob]            VARCHAR (20)  NOT NULL,
    [contact_number] VARCHAR (20)  NOT NULL,
    [email_address]  VARCHAR (100) NOT NULL,
    [home_address]   VARCHAR (100) NOT NULL,
    [password]       VARCHAR (300) NULL,
    [degree]         VARCHAR (100) NOT NULL,
    [university]     VARCHAR (100) NOT NULL,
    [subject]        INT           NOT NULL,
    [status]         VARCHAR (20)  DEFAULT ('PENDING') NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TeacherTable_ToSubjectTable] FOREIGN KEY ([subject]) REFERENCES [dbo].[SubjectTable] ([id])
)
GO

CREATE TABLE [dbo].[ClassTable] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [name]          VARCHAR (20)  NOT NULL,
    [class_teacher] INT           NOT NULL,
    [details]       VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_ClassTable_ToTeacherTable] FOREIGN KEY ([class_teacher]) REFERENCES [dbo].[TeacherTable] ([id])
)
GO

CREATE TABLE [dbo].[StudentTable] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [name]           VARCHAR (100) NOT NULL,
    [gender]         VARCHAR (20)  NOT NULL,
    [dob]            VARCHAR (20)  NOT NULL,
    [contact_number] VARCHAR (20)  NOT NULL,
    [email_address]  VARCHAR (100) NOT NULL,
    [home_address]   VARCHAR (100) NOT NULL,
    [father_name]    VARCHAR (100) NOT NULL,
    [father_work]    VARCHAR (100) NOT NULL,
    [father_contact] VARCHAR (20)  NOT NULL,
    [mother_name]    VARCHAR (100) NOT NULL,
    [mother_work]    VARCHAR (100) NOT NULL,
    [mother_contact] VARCHAR (20)  NOT NULL,
    [class]          INT           NOT NULL,
    [password]       VARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_StudentTable_ToClassTable] FOREIGN KEY ([class]) REFERENCES [dbo].[ClassTable] ([id])
)
GO

CREATE TABLE [dbo].[AssignmentTable] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [teacher_id]  INT           NOT NULL,
    [title]       VARCHAR (100) NOT NULL,
    [description] VARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_AssignmentTable_ToTeacherTable] FOREIGN KEY ([teacher_id]) REFERENCES [dbo].[TeacherTable] ([id])
)
GO

CREATE TABLE [dbo].[AnswerTable] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [assignment_id] INT           NOT NULL,
    [student_id]    INT           NOT NULL,
    [grade]         VARCHAR (2)   NULL,
    [answers]       VARCHAR (300) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_AnswerTable_ToAssignmentTable] FOREIGN KEY ([assignment_id]) REFERENCES [dbo].[AssignmentTable] ([id]),
    CONSTRAINT [FK_AnswerTable_ToStudentTable] FOREIGN KEY ([student_id]) REFERENCES [dbo].[StudentTable] ([id])
)
GO