CREATE TABLE [dbo].[CourseInstructor]
(
	[CourseId]		INT	NOT NULL,
	[InstructorId]	INT	NOT NULL,

	CONSTRAINT [PK_CourseInstructor] PRIMARY KEY ([CourseId], [InstructorId]),
	CONSTRAINT [FK_CourseInstructor_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId]),
	CONSTRAINT [FK_CourseInstructor_Instructor] FOREIGN KEY ([InstructorId]) REFERENCES [dbo].[Instructor] ([InstructorId])

)
