CREATE TABLE dictionary
(
	[Id] INT NOT NULL PRIMARY KEY,
	[word] NVARCHAR(30) NOT NULL,
	[transcription] NVARCHAR(40),
	[definition] NVARCHAR(100),
	[adding_date] datetime NOT NULL DEFAULT now()
)
