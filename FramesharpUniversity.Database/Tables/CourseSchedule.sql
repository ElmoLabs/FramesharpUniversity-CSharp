CREATE TABLE [dbo].[CourseSchedule]
(
	[CourseScheduleId]	INT		NOT NULL IDENTITY,
	[CourseId]			INT		NOT NULL,
	[InstructorId]		INT		NOT NULL,
	[ClassroomId]		INT		NOT NULL,
	[StartingHour]		TINYINT	NOT NULL,
	[StartingMinute]	TINYINT	NOT NULL,
	[FinshingHour]		TINYINT	NOT NULL,
	[FinshingMinute]	TINYINT	NOT NULL,

	CONSTRAINT [PK_Schedule] PRIMARY KEY ([CourseScheduleId]),
	CONSTRAINT [FK_Schedule_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId]),
	CONSTRAINT [FK_Schedule_Instruttor] FOREIGN KEY ([InstructorId]) REFERENCES [dbo].[Instructor] ([InstructorId]),
	CONSTRAINT [FK_Schedule_Classroom] FOREIGN KEY ([ClassroomId]) REFERENCES [dbo].[Classroom] ([ClassroomId]),

	CONSTRAINT [UK_Schedule] UNIQUE 
	(
		 [CourseId]		
		,[InstructorId]	
		,[ClassroomId]	
		,[StartingHour]	
		,[StartingMinute]
		,[FinshingHour]	
		,[FinshingMinute]
	)
)
