USE [master]
GO
/****** Object:  Database [task_manager]    Script Date: 06-May-19 4:48:32 PM ******/
CREATE DATABASE [task_manager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'task_manager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\task_manager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'task_manager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\task_manager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [task_manager] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [task_manager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [task_manager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [task_manager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [task_manager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [task_manager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [task_manager] SET ARITHABORT OFF 
GO
ALTER DATABASE [task_manager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [task_manager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [task_manager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [task_manager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [task_manager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [task_manager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [task_manager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [task_manager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [task_manager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [task_manager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [task_manager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [task_manager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [task_manager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [task_manager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [task_manager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [task_manager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [task_manager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [task_manager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [task_manager] SET  MULTI_USER 
GO
ALTER DATABASE [task_manager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [task_manager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [task_manager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [task_manager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [task_manager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [task_manager] SET QUERY_STORE = OFF
GO
USE [task_manager]
GO
/****** Object:  Table [dbo].[tblKredencijal]    Script Date: 06-May-19 4:48:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKredencijal](
	[id_korisnik] [int] IDENTITY(1,1) NOT NULL,
	[korisnickoIme] [nvarchar](20) NULL,
	[lozinka] [nvarchar](50) NULL,
	[aktiven] [bit] NULL,
 CONSTRAINT [PK_tblKredencijal] PRIMARY KEY CLUSTERED 
(
	[id_korisnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOddel]    Script Date: 06-May-19 4:48:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOddel](
	[id_oddel] [int] IDENTITY(1,1) NOT NULL,
	[oddel] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblOddel] PRIMARY KEY CLUSTERED 
(
	[id_oddel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPozicija]    Script Date: 06-May-19 4:48:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPozicija](
	[id_pozicija] [int] IDENTITY(1,1) NOT NULL,
	[pozicija] [nvarchar](25) NULL,
 CONSTRAINT [PK_tblPozicija] PRIMARY KEY CLUSTERED 
(
	[id_pozicija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProekt]    Script Date: 06-May-19 4:48:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProekt](
	[id_proekt] [int] IDENTITY(1,1) NOT NULL,
	[proekt_ime] [nvarchar](50) NULL,
 CONSTRAINT [PK_proekt] PRIMARY KEY CLUSTERED 
(
	[id_proekt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStatus]    Script Date: 06-May-19 4:48:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatus](
	[id_status] [int] IDENTITY(1,1) NOT NULL,
	[opis] [nvarchar](15) NULL,
 CONSTRAINT [PK_tblStatus] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVraboten]    Script Date: 06-May-19 4:48:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVraboten](
	[id_vraboten] [int] IDENTITY(1,1) NOT NULL,
	[id_pozicija] [int] NOT NULL,
	[id_oddel] [int] NOT NULL,
	[id_kredencijali] [int] NOT NULL,
	[ime] [nvarchar](20) NULL,
	[prezime] [nvarchar](50) NULL,
	[telefonski_br] [nvarchar](12) NULL,
	[adresa] [nvarchar](30) NULL,
	[grad] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblVraboten_1] PRIMARY KEY CLUSTERED 
(
	[id_vraboten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblZadaca]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblZadaca](
	[id_zadaca] [int] IDENTITY(1,1) NOT NULL,
	[id_vraboten] [int] NOT NULL,
	[id_status] [int] NOT NULL,
	[id_proekt] [int] NOT NULL,
	[naslov] [nvarchar](20) NULL,
	[opis] [nvarchar](70) NULL,
	[odobrena] [bit] NULL,
	[estimacija] [int] NULL,
	[datum_kreiranje] [date] NULL,
	[datum_posledna_promena] [date] NULL,
 CONSTRAINT [PK_tblZadaca_1] PRIMARY KEY CLUSTERED 
(
	[id_zadaca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblKredencijal] ADD  CONSTRAINT [df_aktiven]  DEFAULT (N'0') FOR [aktiven]
GO
ALTER TABLE [dbo].[tblZadaca] ADD  CONSTRAINT [df_odobrena]  DEFAULT (N'0') FOR [odobrena]
GO
/****** Object:  StoredProcedure [dbo].[spAddKorisnici]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spAddKorisnici]
@korisnickoIme nvarchar(20),
@lozinka nvarchar(50),
@aktiven bit
as
begin
DECLARE @id_korisnik int;
insert into tblKredencijal(
korisnickoIme,
lozinka)
values(
@korisnickoIme,
@lozinka)
set @id_korisnik=SCOPE_IDENTITY()
select
id_korinsik=@id_korisnik,
korisnickoIme=@korisnickoIme,
lozinka=@lozinka,
aktiven=@aktiven
from tblKredencijal
where id_korisnik=@id_korisnik
end
GO
/****** Object:  StoredProcedure [dbo].[spAddOddel]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spAddOddel]
@oddel nvarchar(20)
as
begin
DECLARE @id_oddel int;
insert into tblOddel(
oddel)
values(
@oddel)
set @id_oddel=SCOPE_IDENTITY()
select
id_oddel=@id_oddel,
oddel=@oddel
from tblOddel
where id_oddel=@id_oddel
end
GO
/****** Object:  StoredProcedure [dbo].[spAddPozicija]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spAddPozicija]
@pozicija nvarchar(25)
as
begin
DECLARE @id_pozicija int;
insert into tblPozicija(
pozicija)
values(
@pozicija)
set @id_pozicija=SCOPE_IDENTITY()
select
id_pozicija=@id_pozicija,
pozicija=@pozicija
from tblPozicija
where id_pozicija=@id_pozicija
end
GO
/****** Object:  StoredProcedure [dbo].[spAddProekt]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spAddProekt]
@proekt_ime nvarchar(25)
as
begin
DECLARE @id_proekt int;
insert into tblProekt(
proekt_ime)
values(
@proekt_ime)
set @id_proekt=SCOPE_IDENTITY()
select
id_proekt=@id_proekt,
proekt_ime=@proekt_ime
from tblProekt
where id_proekt=@id_proekt
end
GO
/****** Object:  StoredProcedure [dbo].[spAddStatus]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spAddStatus]
@opis nvarchar(25)
as
begin
DECLARE @id_status int;
insert into tblStatus(
opis)
values(
@opis)
set @id_status=SCOPE_IDENTITY()
select
id_status=@id_status,
opis=@opis
from tblstatus
where id_status=@id_status
end
GO
/****** Object:  StoredProcedure [dbo].[spAddTask]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spAddTask]
@id_vraboten int,
@id_status int,
@naslov nvarchar(20),
@opis nvarchar(70),
@id_proekt int,
@odobrena bit,
@estimacija int,
@datum_kreiranje date,
@datum_posledna_promena date
as
begin
DECLARE @id_zadaca int;
insert into tblZadaca(
id_vraboten,
id_status,
naslov,
opis,
id_proekt,
estimacija,
odobrena,
datum_kreiranje,
datum_posledna_promena)
values(
@id_vraboten ,
@id_status ,
@naslov ,
@opis ,
@id_proekt,
@estimacija ,
@odobrena ,
@datum_kreiranje ,
@datum_posledna_promena)
set @id_zadaca=SCOPE_IDENTITY()
select
id_zadaca,
id_vraboten,
id_status,
naslov,
opis,
id_proekt,
estimacija,
odobrena,
datum_kreiranje,
datum_posledna_promena
from tblZadaca
where id_zadaca=@id_zadaca
end
GO
/****** Object:  StoredProcedure [dbo].[spAddVraboteni]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spAddVraboteni]
@id_pozicija int,
@id_kredencijali int,
@id_oddel int,
@ime nvarchar(20),
@prezime nvarchar(50),
@telefonski_br nvarchar(12),
@adresa  nvarchar(30),
@grad nvarchar(20)
as
begin
DECLARE @id_vraboten int;
insert into tblVraboten(
ime,
prezime,
telefonski_br,
adresa,
grad,
id_oddel,
id_pozicija,
id_kredencijali)
values(
@ime,
@prezime,
@telefonski_br,
@adresa,
@grad,
@id_oddel,
@id_pozicija,
@id_kredencijali)
set @id_vraboten=SCOPE_IDENTITY()
select
id_vraboten=@id_vraboten,
ime=@ime,
prezime=@prezime,
telefonski_br=@telefonski_br,
adresa=@adresa,
grad=@grad,
id_oddel=@id_oddel,
id_pozicija=@id_pozicija,
id_kredencijali=@id_kredencijali
from tblVraboten
where id_vraboten=@id_vraboten
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteKorisnici]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeleteKorisnici]
@id_korisnik int
as
begin
delete
from tblKredencijal
where id_korisnik=@id_korisnik
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteOddel]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeleteOddel]
@id_oddel int
as
begin
delete
from tblOddel
where id_oddel=@id_oddel
end
GO
/****** Object:  StoredProcedure [dbo].[spDeletePozicija]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeletePozicija]
@id_pozicija int
as
begin
delete
from tblPozicija
where id_pozicija=@id_pozicija
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteProekt]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spDeleteProekt]
@id_proekt int
as
begin
delete
from tblProekt
where id_proekt=@id_proekt
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteStatus]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeleteStatus]
@id_status int
as
begin
delete
from tblstatus
where id_status=@id_status
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteTask]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeleteTask]
@id_zadaca int
as
begin
delete
from tblZadaca
where (id_zadaca=@id_zadaca)
end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteVraboteni]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeleteVraboteni]
@id_vraboten int
as
begin
delete
from tblVraboten
where id_vraboten=@id_vraboten
end
GO
/****** Object:  StoredProcedure [dbo].[spFiltriranje]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFiltriranje]
	@naslov nvarchar(20) = NULL,
	@status_id nvarchar(15) = NULL,
	@proekt_id nvarchar(50) = NULL,
	@ime nvarchar(20) = NULL,
	@prezime nvarchar(50) = NULL,
	@vraboten_id int
AS
DECLARE @pozicija NVARCHAR(50)

SELECT @pozicija = pozicija
FROM tblVraboten v INNER JOIN tblPozicija p on v.id_pozicija = p.id_pozicija
WHERE id_vraboten = @vraboten_id

IF @pozicija = 'TeamMember'
	SELECT ime,prezime,proekt_ime,naslov,s.opis
	FROM  tblZadaca z
	INNER JOIN tblStatus s ON z.id_status = s.id_status
	INNER JOIN tblVraboten v ON v.id_vraboten = z.id_vraboten
	INNER JOIN tblProekt p ON p.id_proekt = z.id_proekt
	WHERE z.id_vraboten = @vraboten_id 
		AND (z.id_status = @status_id OR @status_id IS NULL) 
		AND (z.id_proekt = @proekt_id OR @proekt_id IS NULL)
		AND (z.naslov = @naslov OR @naslov IS NULL) 
		AND (v.ime=@ime OR @ime IS NULL)
		AND (v.prezime=@prezime OR @prezime IS NULL)	
ELSE IF @pozicija = 'TeamLeader'
	SELECT ime,prezime,proekt_ime,naslov,s.opis
	FROM  tblVraboten v INNER JOIN tblZadaca z ON v.id_vraboten = z.id_vraboten
	INNER JOIN tblStatus s ON z.id_status = s.id_status
	INNER JOIN tblProekt p ON p.id_proekt = z.id_proekt
	WHERE v.id_oddel IN (SELECT id_oddel FROM tblVraboten WHERE id_vraboten = @vraboten_id)
		AND (z.id_status = @status_id OR @status_id IS NULL) 
		AND (z.id_proekt = @proekt_id OR @proekt_id IS NULL)
		AND (z.naslov = @naslov OR @naslov IS NULL) 
		AND(v.ime=@ime OR @ime IS NULl)
		AND(v.prezime=@prezime OR @prezime IS NULL)	
ELSE
	SELECT  ime,prezime,proekt_ime,naslov,s.opis
	FROM  tblVraboten v INNER JOIN tblZadaca z ON v.id_vraboten = z.id_vraboten
	INNER JOIN tblStatus s ON z.id_status = s.id_status
	INNER JOIN tblProekt p ON p.id_proekt = z.id_proekt
	WHERE  (z.id_status = @status_id OR @status_id IS NULL) 
		AND (z.id_proekt = @proekt_id OR @proekt_id IS NULL)
		AND (z.naslov = @naslov OR @naslov IS NULL) 
		AND (v.ime=@ime OR @ime IS NULL)
		AND (v.prezime=@prezime OR @prezime IS NULL)	
GO
/****** Object:  StoredProcedure [dbo].[spGetAllKorisnici]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllKorisnici]
as
begin
select id_korisnik,korisnickoIme,lozinka,aktiven
from tblKredencijal
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllOddel]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllOddel]
as
begin
select id_oddel,oddel
from tblOddel
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllPozicija]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllPozicija]
as
begin
select id_pozicija,pozicija
from tblPozicija
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllProekt]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllProekt]
as
begin
select id_proekt,proekt_ime
from tblProekt
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllStatus]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllStatus]
as
begin
select id_status,opis
from tblstatus
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllVraboteni]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllVraboteni]
as
begin
select id_vraboten,ime,prezime,grad,adresa,telefonski_br
from tblVraboten
end
GO
/****** Object:  StoredProcedure [dbo].[spGetKorisnici]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetKorisnici]
@id_korisnik int
as
begin
select id_korisnik,korisnickoIme,lozinka,aktiven
from tblKredencijal
where id_korisnik=@id_korisnik
end
GO
/****** Object:  StoredProcedure [dbo].[spGetOddel]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetOddel]
@id_oddel int
as
begin
select id_oddel,oddel
from tblOddel
where id_oddel=@id_oddel
end
GO
/****** Object:  StoredProcedure [dbo].[spGetPozicija]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetPozicija]
@id_pozicija int
as
begin
select id_pozicija,pozicija
from tblPozicija
where id_pozicija=@id_pozicija
end
GO
/****** Object:  StoredProcedure [dbo].[spGetProekt]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetProekt]
@id_proekt int
as
begin
select id_proekt,proekt_ime
from tblProekt
where id_proekt=@id_proekt
end
GO
/****** Object:  StoredProcedure [dbo].[spGetStatus]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetStatus]
@id_status int
as
begin
select id_status,opis
from tblstatus
where id_status=@id_status
end
GO
/****** Object:  StoredProcedure [dbo].[spGetTask]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetTask]
@id_zadaca int
as
begin
select id_zadaca,naslov,opis,datum_kreiranje,datum_posledna_promena,estimacija,odobrena
from tblZadaca
where (id_zadaca=@id_zadaca)
end
GO
/****** Object:  StoredProcedure [dbo].[spGetVraboteni]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetVraboteni]
@id_vraboten int
as
begin
select id_vraboten,ime,prezime,grad,adresa,telefonski_br
from tblVraboten
where (id_vraboten=@id_vraboten)
end
GO
/****** Object:  StoredProcedure [dbo].[spReport]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*  Za da raboti, vo tblPozicija treba da bidat vneseni slednive vrednosti. 
	Ako se vneseni drugi vrednosti, soodvetno treba da se izmenat i vo procedurata
	[dbo].[tblPozicija]
	id_pozicija	pozicija
			1	TeamMember
			2	TeamLead
			3	Manager
*/
CREATE PROC [dbo].[spReport]
	@vraboten_id INT
AS
DECLARE @pozicija NVARCHAR(50)

SELECT @pozicija = pozicija
FROM tblVraboten v INNER JOIN tblPozicija p on v.id_pozicija = p.id_pozicija
WHERE id_vraboten = @vraboten_id

IF @pozicija = 'TeamMember'
	SELECT s.opis AS [Status], COUNT(s.id_status) AS [Count]
	FROM  tblZadaca z
	INNER JOIN tblStatus s ON z.id_status = s.id_status
	WHERE z.id_vraboten = @vraboten_id 
	GROUP BY s.opis		
ELSE IF @pozicija = 'TeamLeader'
	SELECT s.opis AS [Status], COUNT(s.id_status) AS [Count]
	FROM  tblVraboten v INNER JOIN tblZadaca z ON v.id_vraboten = z.id_vraboten
	INNER JOIN tblStatus s ON z.id_status = s.id_status
	WHERE v.id_oddel IN (SELECT id_oddel FROM tblVraboten WHERE id_vraboten = @vraboten_id)
	GROUP BY s.opis	
ELSE
	SELECT s.opis AS [Status], count(s.id_status) AS [Count]
	FROM  tblVraboten v INNER JOIN tblZadaca z ON v.id_vraboten = z.id_vraboten
	INNER JOIN tblStatus s ON z.id_status = s.id_status
	GROUP BY s.opis	

GO
/****** Object:  StoredProcedure [dbo].[spUpdateKorisnici]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spUpdateKorisnici]
@id_korisnik int,
@korisnickoIme nvarchar(20),
@lozinka nvarchar(50),
@aktiven bit
as
begin

update tblKredencijal
set korisnickoIme=@korisnickoIme, 
lozinka=@lozinka,
aktiven=@aktiven
where id_korisnik=@id_korisnik
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateOddel]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spUpdateOddel]
@id_oddel int,
@oddel nvarchar(20)
as
begin
update tblOddel
set oddel=@oddel
where id_oddel=@id_oddel
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdatePozicija]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spUpdatePozicija]

@id_pozicija int,
@pozicija nvarchar(25)
as
begin
update tblPozicija
set pozicija=@pozicija
where id_pozicija=@id_pozicija
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProekt]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spUpdateProekt]
@id_proekt int,
@proekt_ime nvarchar(25)
as
begin
update tblProekt
set proekt_ime=@proekt_ime
where id_proekt=@id_proekt
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateStatus]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spUpdateStatus]
@id_status int,
@opis nvarchar(25)
as
begin
update tblstatus
set opis=@opis
where id_status=@id_status
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTask]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spUpdateTask]

@id_vraboten int,
@id_zadaca int,
@id_status int,
@id_proekt int,
@naslov nvarchar(20),
@opis nvarchar(70),
@odobrena bit,
@estimacija int,
@datum_kreiranje date,
@datum_posledna_promena date
as
begin
update tblZadaca
set id_vraboten=@id_vraboten,
id_proekt=@id_proekt,
id_status=@id_status,
naslov=@naslov,
opis=@opis,
estimacija=@estimacija,
datum_kreiranje=@datum_kreiranje,
datum_posledna_promena=@datum_posledna_promena
where id_zadaca=@id_zadaca
end
GO
/****** Object:  StoredProcedure [dbo].[spUpdateVraboteni]    Script Date: 06-May-19 4:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spUpdateVraboteni]
@id_vraboten int,
@id_pozicija int,
@id_kredencijali int,
@id_oddel int,
@ime nvarchar(20),
@prezime nvarchar(50),
@telefonski_br nvarchar(12),
@adresa  nvarchar(30),
@grad nvarchar(20)
as
begin
update tblVraboten
set ime=@ime,
prezime=@prezime,
telefonski_br=@telefonski_br,
adresa=@adresa,
grad=@grad
where id_vraboten=@id_vraboten
end
GO
USE [master]
GO
ALTER DATABASE [task_manager] SET  READ_WRITE 
GO
