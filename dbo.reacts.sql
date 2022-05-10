CREATE TABLE [dbo].[reacts] (
    [postID]      INT          NOT NULL,
    [userID]      INT          NOT NULL,
    [typeOfReact] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_reacts] PRIMARY KEY CLUSTERED ([postID] ASC, [userID] ASC),
    FOREIGN KEY ([postID]) REFERENCES [dbo].[posts] ([postID]),
    FOREIGN KEY ([userID]) REFERENCES [dbo].[users] ([userID])
);

