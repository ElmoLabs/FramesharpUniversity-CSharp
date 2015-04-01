CREATE TABLE [dbo].[CourseEnrollment]
(
	[CourseScheduleId]	INT	NOT NULL,
	[StudentId]			INT	NOT NULL,

	CONSTRAINT [PK_CourseStudent] PRIMARY KEY ([StudentId], [CourseScheduleId]),
	CONSTRAINT [FK_CourseStudent_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]),
	CONSTRAINT [FK_CourseStudent_CourseSchedule] FOREIGN KEY ([CourseScheduleId]) REFERENCES [dbo].[CourseSchedule] ([CourseScheduleId])
)
