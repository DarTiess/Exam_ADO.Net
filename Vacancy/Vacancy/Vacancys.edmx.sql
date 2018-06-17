
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2018 11:32:06
-- Generated from EDMX file: C:\Users\ТиесоваД\Source\Repos\Exam_ADO.Net\Vacancy\Vacancy\Vacancys.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MCS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[VacanciesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VacanciesSet];
GO
IF OBJECT_ID(N'[dbo].[VacancyTableSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VacancyTableSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'VacancyTableSet'
CREATE TABLE [dbo].[VacancyTableSet] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL,
    [linkCategory] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VacanciesSet'
CREATE TABLE [dbo].[VacanciesSet] (
    [VacancyId] int IDENTITY(1,1) NOT NULL,
    [VacancyName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [pubDate] datetime  NOT NULL,
    [CategodyId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CategoryId] in table 'VacancyTableSet'
ALTER TABLE [dbo].[VacancyTableSet]
ADD CONSTRAINT [PK_VacancyTableSet]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [VacancyId] in table 'VacanciesSet'
ALTER TABLE [dbo].[VacanciesSet]
ADD CONSTRAINT [PK_VacanciesSet]
    PRIMARY KEY CLUSTERED ([VacancyId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------