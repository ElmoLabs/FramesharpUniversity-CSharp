CREATE TABLE [dbo].[Instructor]
(
	[InstructorId]		INT				NOT NULL IDENTITY,
	[DocumentNumber]	BIGINT			NOT NULL,
	[AdmissionDate]		SMALLDATETIME	NOT NULL, 

    CONSTRAINT [PK_Instructor] PRIMARY KEY ([InstructorId]),
	CONSTRAINT [FK_Instructor_Person] FOREIGN KEY ([DocumentNumber]) REFERENCES [dbo].[Person] ([DocumentNumber])

)
