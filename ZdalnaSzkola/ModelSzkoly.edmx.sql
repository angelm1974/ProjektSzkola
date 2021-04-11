
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/07/2021 12:08:46
-- Generated from EDMX file: C:\Users\mariu\source\repos\ZdalnaSzkola\ZdalnaSzkola\ModelSzkoly.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [szkolaZdalna];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_studentOcenaStudenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OcenaStudentaSet] DROP CONSTRAINT [FK_studentOcenaStudenta];
GO
IF OBJECT_ID(N'[dbo].[FK_PrzedmiotOcenaStudenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OcenaStudentaSet] DROP CONSTRAINT [FK_PrzedmiotOcenaStudenta];
GO
IF OBJECT_ID(N'[dbo].[FK_nauczycielOcenaStudenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OcenaStudentaSet] DROP CONSTRAINT [FK_nauczycielOcenaStudenta];
GO
IF OBJECT_ID(N'[dbo].[FK_student_inherits_czlowiek]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[czlowiekSet_student] DROP CONSTRAINT [FK_student_inherits_czlowiek];
GO
IF OBJECT_ID(N'[dbo].[FK_nauczyciel_inherits_czlowiek]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[czlowiekSet_nauczyciel] DROP CONSTRAINT [FK_nauczyciel_inherits_czlowiek];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[czlowiekSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[czlowiekSet];
GO
IF OBJECT_ID(N'[dbo].[PrzedmiotSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PrzedmiotSet];
GO
IF OBJECT_ID(N'[dbo].[OcenaStudentaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OcenaStudentaSet];
GO
IF OBJECT_ID(N'[dbo].[czlowiekSet_student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[czlowiekSet_student];
GO
IF OBJECT_ID(N'[dbo].[czlowiekSet_nauczyciel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[czlowiekSet_nauczyciel];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'czlowiekSet'
CREATE TABLE [dbo].[czlowiekSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Imie] nvarchar(max)  NOT NULL,
    [Nazwisko] nvarchar(max)  NOT NULL,
    [Wiek] smallint  NOT NULL
);
GO

-- Creating table 'PrzedmiotSet'
CREATE TABLE [dbo].[PrzedmiotSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nazwa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OcenaStudentaSet'
CREATE TABLE [dbo].[OcenaStudentaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ocena] decimal(2,1)  NOT NULL,
    [DataWstawienia] datetime  NOT NULL,
    [Semestr] smallint  NOT NULL,
    [Termin] smallint  NOT NULL,
    [student_Id] int  NOT NULL,
    [Przedmiot_Id] int  NOT NULL,
    [nauczyciel_Id] int  NOT NULL
);
GO

-- Creating table 'czlowiekSet_student'
CREATE TABLE [dbo].[czlowiekSet_student] (
    [RokStudiow] smallint  NOT NULL,
    [NrAlbumu] smallint  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'czlowiekSet_nauczyciel'
CREATE TABLE [dbo].[czlowiekSet_nauczyciel] (
    [RokZatrudnienia] smallint  NOT NULL,
    [StazPracy] smallint  NOT NULL,
    [OcenaSemestralna] decimal(4,2)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'czlowiekSet'
ALTER TABLE [dbo].[czlowiekSet]
ADD CONSTRAINT [PK_czlowiekSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PrzedmiotSet'
ALTER TABLE [dbo].[PrzedmiotSet]
ADD CONSTRAINT [PK_PrzedmiotSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OcenaStudentaSet'
ALTER TABLE [dbo].[OcenaStudentaSet]
ADD CONSTRAINT [PK_OcenaStudentaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'czlowiekSet_student'
ALTER TABLE [dbo].[czlowiekSet_student]
ADD CONSTRAINT [PK_czlowiekSet_student]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'czlowiekSet_nauczyciel'
ALTER TABLE [dbo].[czlowiekSet_nauczyciel]
ADD CONSTRAINT [PK_czlowiekSet_nauczyciel]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [student_Id] in table 'OcenaStudentaSet'
ALTER TABLE [dbo].[OcenaStudentaSet]
ADD CONSTRAINT [FK_studentOcenaStudenta]
    FOREIGN KEY ([student_Id])
    REFERENCES [dbo].[czlowiekSet_student]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_studentOcenaStudenta'
CREATE INDEX [IX_FK_studentOcenaStudenta]
ON [dbo].[OcenaStudentaSet]
    ([student_Id]);
GO

-- Creating foreign key on [Przedmiot_Id] in table 'OcenaStudentaSet'
ALTER TABLE [dbo].[OcenaStudentaSet]
ADD CONSTRAINT [FK_PrzedmiotOcenaStudenta]
    FOREIGN KEY ([Przedmiot_Id])
    REFERENCES [dbo].[PrzedmiotSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrzedmiotOcenaStudenta'
CREATE INDEX [IX_FK_PrzedmiotOcenaStudenta]
ON [dbo].[OcenaStudentaSet]
    ([Przedmiot_Id]);
GO

-- Creating foreign key on [nauczyciel_Id] in table 'OcenaStudentaSet'
ALTER TABLE [dbo].[OcenaStudentaSet]
ADD CONSTRAINT [FK_nauczycielOcenaStudenta]
    FOREIGN KEY ([nauczyciel_Id])
    REFERENCES [dbo].[czlowiekSet_nauczyciel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_nauczycielOcenaStudenta'
CREATE INDEX [IX_FK_nauczycielOcenaStudenta]
ON [dbo].[OcenaStudentaSet]
    ([nauczyciel_Id]);
GO

-- Creating foreign key on [Id] in table 'czlowiekSet_student'
ALTER TABLE [dbo].[czlowiekSet_student]
ADD CONSTRAINT [FK_student_inherits_czlowiek]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[czlowiekSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'czlowiekSet_nauczyciel'
ALTER TABLE [dbo].[czlowiekSet_nauczyciel]
ADD CONSTRAINT [FK_nauczyciel_inherits_czlowiek]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[czlowiekSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------