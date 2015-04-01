CREATE TABLE [dbo].[Course]
(
	[CourseId]		INT				NOT NULL IDENTITY,
	[Name]			VARCHAR (50)	NOT NULL,
	[Description]	VARCHAR (200)	NOT NULL,

	CONSTRAINT [PK_Course] PRIMARY KEY ([CourseId])
)
