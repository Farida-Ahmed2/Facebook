CREATE TABLE [dbo].[friends] (
    [userID]   INT          NOT NULL,
    [friendID] INT          NOT NULL,
    [FriendShip]   VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_friends] PRIMARY KEY CLUSTERED ([friendID] ASC, [userID] ASC),
    FOREIGN KEY ([userID]) REFERENCES [dbo].[users] ([userID]),
    FOREIGN KEY ([friendID]) REFERENCES [dbo].[users] ([userID])
);

