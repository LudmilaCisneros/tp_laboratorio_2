USE [master]
GO
/****** Object:  Database [Showroom]    Script Date: 25/11/2020 14:56:45 ******/
CREATE DATABASE [Showroom]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Stock.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Stock_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Showroom] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Showroom].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Showroom] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Showroom] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Showroom] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Showroom] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Showroom] SET ARITHABORT OFF 
GO
ALTER DATABASE [Showroom] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Showroom] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Showroom] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Showroom] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Showroom] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Showroom] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Showroom] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Showroom] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Showroom] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Showroom] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Showroom] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Showroom] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Showroom] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Showroom] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Showroom] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Showroom] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Showroom] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Showroom] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Showroom] SET  MULTI_USER 
GO
ALTER DATABASE [Showroom] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Showroom] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Showroom] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Showroom] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Showroom] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Showroom] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Showroom] SET QUERY_STORE = OFF
GO
USE [Showroom]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 25/11/2020 14:56:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[Código] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Subtipo] [nvarchar](50) NOT NULL,
	[Stock] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[Código] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Stock] ON 

INSERT [dbo].[Stock] ([Código], [Nombre], [Precio], [Color], [Tipo], [Subtipo], [Stock]) VALUES (CAST(1 AS Numeric(18, 0)), N'paris                                             ', 100, N'rosa                                              ', N'accesorios', N'pulsera', CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[Stock] ([Código], [Nombre], [Precio], [Color], [Tipo], [Subtipo], [Stock]) VALUES (CAST(2 AS Numeric(18, 0)), N'labial eiffel                                     ', 300, N'nude                                              ', N'maquillaje', N'labios', CAST(30 AS Numeric(18, 0)))
INSERT [dbo].[Stock] ([Código], [Nombre], [Precio], [Color], [Tipo], [Subtipo], [Stock]) VALUES (CAST(3 AS Numeric(18, 0)), N'neon                                              ', 50, N'verde                                             ', N'accesorios', N'collar', CAST(40 AS Numeric(18, 0)))
INSERT [dbo].[Stock] ([Código], [Nombre], [Precio], [Color], [Tipo], [Subtipo], [Stock]) VALUES (CAST(4 AS Numeric(18, 0)), N'iluminador                                        ', 500, N'blanco                                            ', N'maquillaje', N'otros', CAST(50 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Stock] OFF
GO
USE [master]
GO
ALTER DATABASE [Showroom] SET  READ_WRITE 
GO
