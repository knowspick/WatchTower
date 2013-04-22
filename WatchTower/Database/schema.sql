CREATE TABLE [Episodes] ([EpisodeId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [SeriesId] INTEGER NOT NULL REFERENCES [Series] ([SeriesId]), [Name] VARCHAR (255) NOT NULL, [SeasonNo] INTEGER NOT NULL, [EpisodeNo] INTEGER NOT NULL, [FileFullPath] VARCHAR (255) NOT NULL DEFAULT(''), [DateAddedToCollection] DATETIME NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [ProfileSeriesRel] ([ProfileSeriesRelId] INTEGER PRIMARY KEY AUTOINCREMENT, [ProfileId] INTEGER, [SeriesId] INTEGER, [WantToWatch] BOOLEAN DEFAULT(0), [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [Profiles] ([ProfileId] INTEGER PRIMARY KEY AUTOINCREMENT, [Name] CHAR (300) NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [Series] ([SeriesId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [Name] VARCHAR (255) NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE UNIQUE INDEX [idx_ProfileSeriesRel] ON [ProfileSeriesRel] ( [ProfileId] ASC , [SeriesId] ASC );
CREATE TRIGGER Episodes_LastUpdated AFTER UPDATE ON [Episodes] BEGIN UPDATE Episodes SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE EpisodeId = NEW . EpisodeId ; END;
CREATE TRIGGER [Profiles_LastUpdated] AFTER UPDATE ON [Profiles] BEGIN UPDATE Profiles SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE ProfileId = NEW . ProfileId ; END;
CREATE TRIGGER Serieses_LastUpdated AFTER UPDATE ON [Series] BEGIN UPDATE Serieses SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE SeriesId = NEW . SeriesId ; END;
CREATE TABLE [Episodes] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [SeriesId] INTEGER NOT NULL REFERENCES [Series] ([Id]), [Name] VARCHAR (255) NOT NULL, [SeasonNo] INTEGER NOT NULL, [EpisodeNo] INTEGER NOT NULL, [FileFullPath] VARCHAR (255) NOT NULL DEFAULT(''), [DateAddedToCollection] DATETIME NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [ProfileEpisodeRels] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [ProfileId] INTEGER, [EpisodeId] INTEGER, [Watched] BOOLEAN DEFAULT(0), [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [ProfileSeriesRels] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [ProfileId] INTEGER, [SeriesId] INTEGER, [WantToWatch] BOOLEAN, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [Profiles] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [Name] CHAR (300) NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [Series] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [Name] VARCHAR (255) NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TRIGGER [Episodes_LastUpdated] AFTER UPDATE ON [Episodes] BEGIN UPDATE Episodes SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
CREATE TRIGGER ProfileEpisodeRels_LastUpdated AFTER UPDATE ON [ProfileEpisodeRels] BEGIN UPDATE ProfileEpisodeRels SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
CREATE TRIGGER ProfileSeriesRels_LastUpdated
       AFTER UPDATE ON ProfileSeriesRels
BEGIN
    UPDATE ProfileSeriesRels
       SET LastUpdated = datetime( 'now', 'localtime' )
     WHERE Id = NEW.Id;
END;
CREATE TRIGGER [Profiles_LastUpdated] AFTER UPDATE ON [Profiles] BEGIN UPDATE Profiles SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
CREATE TRIGGER [Serieses_LastUpdated] AFTER UPDATE ON [Series] BEGIN UPDATE Serieses SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
CREATE TABLE [Episodes] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [SeriesId] INTEGER NOT NULL REFERENCES [Series] ([Id]), [Name] VARCHAR (255) NOT NULL, [SeasonNo] INTEGER NOT NULL, [EpisodeNo] INTEGER NOT NULL, [FileFullPath] VARCHAR (255) NOT NULL DEFAULT(''), [DateAddedToCollection] DATETIME NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [ProfileEpisodeRels] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [ProfileId] INTEGER, [EpisodeId] INTEGER, [Watched] BOOLEAN DEFAULT(0), [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [ProfileSeriesRels] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [ProfileId] INTEGER, [SeriesId] INTEGER, [WantToWatch] BOOLEAN, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [Profiles] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [Name] CHAR (300) NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TABLE [Serieses] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [Name] VARCHAR (255) NOT NULL, [DateCreated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )), [LastUpdated] DATETIME NOT NULL DEFAULT(datetime ( 'now' , 'localtime' )));
CREATE TRIGGER [Episodes_LastUpdated] AFTER UPDATE ON [Episodes] BEGIN UPDATE Episodes SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
CREATE TRIGGER ProfileEpisodeRels_LastUpdated AFTER UPDATE ON [ProfileEpisodeRels] BEGIN UPDATE ProfileEpisodeRels SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
CREATE TRIGGER ProfileSeriesRels_LastUpdated
       AFTER UPDATE ON ProfileSeriesRels
BEGIN
    UPDATE ProfileSeriesRels
       SET LastUpdated = datetime( 'now', 'localtime' )
     WHERE Id = NEW.Id;
END;
CREATE TRIGGER [Profiles_LastUpdated] AFTER UPDATE ON [Profiles] BEGIN UPDATE Profiles SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
CREATE TRIGGER [Serieses_LastUpdated] AFTER UPDATE ON [Serieses] BEGIN UPDATE Serieses SET LastUpdated = datetime ( 'now' , 'localtime' ) WHERE Id = NEW . Id ; END;
