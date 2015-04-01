CREATE TABLE [dbo].[Person]
(
	[DocumentNumber]	BIGINT			NOT NULL,
	[Name]				VARCHAR(200)	NOT NULL,
	[Gender]			CHAR (1)		NOT NULL, 

	CONSTRAINT [PK_Person] PRIMARY KEY ([DocumentNumber]),
	CONSTRAINT [CK_Person_Gender] CHECK ([Gender] IN ('M', 'F'))
)