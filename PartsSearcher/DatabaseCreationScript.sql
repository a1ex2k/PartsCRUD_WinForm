USE [master]
GO
/****** Object:  Database [PartsDatabase]    Script Date: 04.03.2023 20:55:28 ******/
CREATE DATABASE [PartsDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PartsDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV2019\MSSQL\DATA\PartsDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PartsDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEV2019\MSSQL\DATA\PartsDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PartsDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PartsDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PartsDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PartsDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PartsDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PartsDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PartsDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [PartsDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PartsDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PartsDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PartsDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PartsDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PartsDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PartsDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PartsDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PartsDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PartsDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PartsDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PartsDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PartsDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PartsDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PartsDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PartsDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PartsDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PartsDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [PartsDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [PartsDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PartsDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PartsDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PartsDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PartsDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PartsDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PartsDatabase', N'ON'
GO
ALTER DATABASE [PartsDatabase] SET QUERY_STORE = OFF
GO
USE [PartsDatabase]
GO
/****** Object:  User [aleks07d]    Script Date: 04.03.2023 20:55:28 ******/
CREATE USER [aleks07d] FOR LOGIN [aleks07d] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [aleks07d]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [aleks07d]
GO
/****** Object:  Table [dbo].[Flanges]    Script Date: 04.03.2023 20:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flanges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SoftDeleted] [bit] NULL,
	[Oboznachenie] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
	[DiametrOtverstijaPodPodshipnik] [decimal](9, 4) NULL,
	[RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik] [decimal](9, 4) NULL,
	[DiametrCentrirujushhegoPojaska] [decimal](9, 4) NULL,
	[VysotaCentrirujushhegoPojaska] [decimal](9, 4) NULL,
	[DiametrCentrirujushhejProtochki] [decimal](9, 4) NULL,
	[GlubinaCentrirujushhejProtochki] [decimal](9, 4) NULL,
	[RasstojanieMezhduKanavkamiPodStopornyeKolca] [decimal](9, 4) NULL,
	[NaruzhnyjRazmerFrezerovkiProushin] [decimal](9, 4) NULL,
	[VnutrennijRazmerFrezerovkiProushin] [decimal](9, 4) NULL,
	[KolichestvoKrepjozhnyhOtverstij] [decimal](9, 4) NULL,
	[DiametrKrepjozhnyhOtverstij] [decimal](9, 4) NULL,
	[DiametrRaspolozhenijaKrepjozhnyhOtverstij] [decimal](9, 4) NULL,
	[LinejnyjRazmerMezhduKrepjozhnymiOtverstijami] [decimal](9, 4) NULL,
	[UglovojRazmerMezhduKrepjozhnymiOtverstijami] [decimal](9, 4) NULL,
	[TiporazmerPoIso12667] [nvarchar](max) NULL,
	[DiametrOboda] [decimal](9, 4) NULL,
	[TolshhinaOboda] [decimal](9, 4) NULL,
	[DiametrTelaVrashhenijaPoObodu] [decimal](9, 4) NULL,
	[RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha] [decimal](9, 4) NULL,
	[DiametrVnutrennejRastochkiOboda] [decimal](9, 4) NULL,
	[GlubinaVnutrennejRastochkiOboda] [decimal](9, 4) NULL,
 CONSTRAINT [PK_Flanges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrCentrirujushhegoPojaska]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrCentrirujushhegoPojaska] ON [dbo].[Flanges]
(
	[DiametrCentrirujushhegoPojaska] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrCentrirujushhejProtochki]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrCentrirujushhejProtochki] ON [dbo].[Flanges]
(
	[DiametrCentrirujushhejProtochki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrKrepjozhnyhOtverstij]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrKrepjozhnyhOtverstij] ON [dbo].[Flanges]
(
	[DiametrKrepjozhnyhOtverstij] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrOboda]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrOboda] ON [dbo].[Flanges]
(
	[DiametrOboda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrOtverstijaPodPodshipnik]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrOtverstijaPodPodshipnik] ON [dbo].[Flanges]
(
	[DiametrOtverstijaPodPodshipnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrRaspolozhenijaKrepjozhnyhOtverstij]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrRaspolozhenijaKrepjozhnyhOtverstij] ON [dbo].[Flanges]
(
	[DiametrRaspolozhenijaKrepjozhnyhOtverstij] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrTelaVrashhenijaPoObodu]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrTelaVrashhenijaPoObodu] ON [dbo].[Flanges]
(
	[DiametrTelaVrashhenijaPoObodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiametrVnutrennejRastochkiOboda]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_DiametrVnutrennejRastochkiOboda] ON [dbo].[Flanges]
(
	[DiametrVnutrennejRastochkiOboda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GlubinaCentrirujushhejProtochki]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_GlubinaCentrirujushhejProtochki] ON [dbo].[Flanges]
(
	[GlubinaCentrirujushhejProtochki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GlubinaVnutrennejRastochkiOboda]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_GlubinaVnutrennejRastochkiOboda] ON [dbo].[Flanges]
(
	[GlubinaVnutrennejRastochkiOboda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_KolichestvoKrepjozhnyhOtverstij]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_KolichestvoKrepjozhnyhOtverstij] ON [dbo].[Flanges]
(
	[KolichestvoKrepjozhnyhOtverstij] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LinejnyjRazmerMezhduKrepjozhnymiOtverstijami]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_LinejnyjRazmerMezhduKrepjozhnymiOtverstijami] ON [dbo].[Flanges]
(
	[LinejnyjRazmerMezhduKrepjozhnymiOtverstijami] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_NaruzhnyjRazmerFrezerovkiProushin]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_NaruzhnyjRazmerFrezerovkiProushin] ON [dbo].[Flanges]
(
	[NaruzhnyjRazmerFrezerovkiProushin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RasstojanieMezhduKanavkamiPodStopornyeKolca]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_RasstojanieMezhduKanavkamiPodStopornyeKolca] ON [dbo].[Flanges]
(
	[RasstojanieMezhduKanavkamiPodStopornyeKolca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha] ON [dbo].[Flanges]
(
	[RasstojanieOtOsiKrepjozhnogoOtverstijaDoTelaUha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik] ON [dbo].[Flanges]
(
	[RasstojanieOtPosadochnojPoverhnostiDoOsiOtverstijaPodPodshipnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SoftDeleted]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_SoftDeleted] ON [dbo].[Flanges]
(
	[SoftDeleted] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TolshhinaOboda]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_TolshhinaOboda] ON [dbo].[Flanges]
(
	[TolshhinaOboda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UglovojRazmerMezhduKrepjozhnymiOtverstijami]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_UglovojRazmerMezhduKrepjozhnymiOtverstijami] ON [dbo].[Flanges]
(
	[UglovojRazmerMezhduKrepjozhnymiOtverstijami] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VnutrennijRazmerFrezerovkiProushin]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_VnutrennijRazmerFrezerovkiProushin] ON [dbo].[Flanges]
(
	[VnutrennijRazmerFrezerovkiProushin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VysotaCentrirujushhegoPojaska]    Script Date: 04.03.2023 20:55:28 ******/
CREATE NONCLUSTERED INDEX [IX_VysotaCentrirujushhegoPojaska] ON [dbo].[Flanges]
(
	[VysotaCentrirujushhegoPojaska] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Flanges] ADD  DEFAULT ((0)) FOR [SoftDeleted]
GO
USE [master]
GO
ALTER DATABASE [PartsDatabase] SET  READ_WRITE 
GO
