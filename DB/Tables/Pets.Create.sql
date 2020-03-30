-- Pets Table ========================
CREATE TABLE Pets (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(300)  NOT NULL,
    DateOfBirth datetime2  NOT NULL,
    Type uniqueidentifier  NOT NULL
);

