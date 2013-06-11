ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [ImpactaCSharp1], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

