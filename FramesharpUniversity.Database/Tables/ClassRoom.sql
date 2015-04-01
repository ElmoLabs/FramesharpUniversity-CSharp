CREATE TABLE [dbo].[Classroom]
(
	[ClassroomId]	INT				NOT NULL IDENTITY,
	[Name]			VARCHAR (50)	NOT NULL,

	CONSTRAINT [PK_Classroom] PRIMARY KEY ([ClassroomId])
)
