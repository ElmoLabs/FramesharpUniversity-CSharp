CREATE TABLE [dbo].[Student]
(
	[StudentId]			INT				NOT NULL IDENTITY,
	[DocumentNumber]	BIGINT			NOT NULL,
	[EnrollmentDate]	SMALLDATETIME	NOT NULL,
	 
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId]),
	CONSTRAINT [FK_Student_Person] FOREIGN KEY ([DocumentNumber]) REFERENCES [dbo].[Person] ([DocumentNumber])

)
