USE [master]
GO
/****** Object:  Database [Biblioteca]    Script Date: 17/10/2015 01:35:20 p.m. ******/
CREATE DATABASE [Biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Biblioteca.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Biblioteca_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Biblioteca] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteca] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteca] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Biblioteca]
GO
/****** Object:  StoredProcedure [dbo].[proc_alta]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_alta]
(
	@Tabla nvarchar(50),
	@Descripcion nvarchar(50)

)
as
declare @sentencia nvarchar(200)
set @sentencia='Insert into '+ @Tabla + '(Descripcion) Values ('''+@Descripcion+''')' 
execute(@sentencia)



GO
/****** Object:  StoredProcedure [dbo].[proc_alta_libro]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_alta_libro]
(
	@ISBN nvarchar(50),
	@Titulo nvarchar(50),
	@esEspañol bit,
	@Genero int,
	@Editorial int,
	@Autor int
)
as
Insert Libros
Values (@ISBN,
		@Titulo,
		@esEspañol,
		@Genero,
		@Autor,
		@Editorial )



GO
/****** Object:  StoredProcedure [dbo].[proc_buscar]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_buscar]
( @Campo nvarchar(20),
  @Filtro nvarchar(20)
)
as
declare @sentencia nvarchar(100)
set @sentencia ='Select * from v_libros where '+@Campo+' like '''+@filtro+'%'''
execute (@sentencia)



GO
/****** Object:  StoredProcedure [dbo].[proc_modi_libro]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_modi_libro]
(
	@Isbn nvarchar(50),
	@Titulo nvarchar(100),
	@Autor int
)
as
update Libros 
set Titulo=@Titulo ,Autor=@Autor
where Isbn=@Isbn


GO
/****** Object:  StoredProcedure [dbo].[proc_modifica_autor]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/******************************************
Stored Procedure para Modificar Autores
Realizado x Curso prog net 
Fecha : 19/09/2015
*******************************************/
create procedure [dbo].[proc_modifica_autor]
(
	/* argumentos */
	@IdAutor int,
	@Apellido nvarchar(50),
	@Nombre nvarchar(50),
	@FechaNacimiento datetime,
	@PaisOrigen nvarchar(50)
)
/* cuerpo principal de procedure */
as
update Autores set Apellido=@Apellido,
				   Nombre =@Nombre,
				   FechaNacimiento=@FechaNacimiento,
				   PaisOrigen =@PaisOrigen
where idAutor=@IdAutor





GO
/****** Object:  Table [dbo].[Autores]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[IdAutor] [int] NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [datetime] NULL,
	[PaisOrigen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[IdAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Editoriales]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editoriales](
	[IdEditorial] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Editoriales] PRIMARY KEY CLUSTERED 
(
	[IdEditorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Generos]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[IdGenero] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[IdGenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Libros]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[Isbn] [nvarchar](50) NOT NULL,
	[Titulo] [nvarchar](100) NOT NULL,
	[esEspañol] [bit] NOT NULL,
	[Genero] [int] NOT NULL,
	[Autor] [int] NOT NULL,
	[Editorial] [int] NOT NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_libros]    Script Date: 17/10/2015 01:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_libros]
as
select l.Isbn,l.Titulo,l.esEspañol,
a.Apellido+', '+a.Nombre as Autor,
g.Descripcion as Genero,
e.Descripcion as Editorial
from Libros as l
join Autores a on a.IdAutor=l.Autor
join Generos g on g.IdGenero=l.Genero
join Editoriales e on e.IdEditorial=l.Editorial


GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [PaisOrigen]) VALUES (12, N'Borges', N'Jorge Luis', CAST(0x000021CE00E4807C AS DateTime), N'Argentina')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [PaisOrigen]) VALUES (13, N'Cortazar', N'Julo', CAST(0x000048AF00000000 AS DateTime), N'Argentina')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [PaisOrigen]) VALUES (18, N'Pigna', N'Felipe', CAST(0x00005DC200BA00CC AS DateTime), N'Argentina')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [PaisOrigen]) VALUES (19, N'Neruda', N'Pablo', CAST(0x00002E6700BA00CC AS DateTime), N'Chile')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [PaisOrigen]) VALUES (20, N'Garcia Marquez', N'Gabriel', CAST(0x0000274400BA00CC AS DateTime), N'Colombia')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [PaisOrigen]) VALUES (21, N'Bioy Casares', N'Adolfo', CAST(0x000036F600BA00CC AS DateTime), N'Argentina')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [PaisOrigen]) VALUES (222, N'Romanazzi', N'Pedro', CAST(0x0000A52600A94726 AS DateTime), N'Argentina')
GO
SET IDENTITY_INSERT [dbo].[Editoriales] ON 

GO
INSERT [dbo].[Editoriales] ([IdEditorial], [Descripcion]) VALUES (1, N'Sudamericana')
GO
INSERT [dbo].[Editoriales] ([IdEditorial], [Descripcion]) VALUES (2, N'Planeta')
GO
INSERT [dbo].[Editoriales] ([IdEditorial], [Descripcion]) VALUES (3, N'Atlantida')
GO
SET IDENTITY_INSERT [dbo].[Editoriales] OFF
GO
SET IDENTITY_INSERT [dbo].[Generos] ON 

GO
INSERT [dbo].[Generos] ([IdGenero], [Descripcion]) VALUES (1, N'Cuentos')
GO
INSERT [dbo].[Generos] ([IdGenero], [Descripcion]) VALUES (2, N'Novela')
GO
INSERT [dbo].[Generos] ([IdGenero], [Descripcion]) VALUES (3, N'Ciencia Ficcion')
GO
SET IDENTITY_INSERT [dbo].[Generos] OFF
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'123322', N'El Mensaje de los sabios', 1, 2, 12, 1)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'123333', N'APRENDA C# EN 15 CLASES', 1, 3, 222, 2)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'1234', N'Rayuela', 1, 2, 13, 2)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'1235', N'Cien años de Soledad', 1, 2, 20, 1)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'123555', N'El Aleph', 1, 1, 12, 1)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'1236', N'El Tunel', 1, 1, 21, 2)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'1238', N'20 Poemas de Amor', 1, 1, 19, 1)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'1239', N'Los Mitos de la Argentina', 1, 2, 18, 1)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'12666', N'La casa robada', 1, 1, 13, 1)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'334555', N'El nombre de la rosa', 0, 3, 21, 2)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'342234', N'La Biblia', 1, 1, 19, 2)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'444', N'la Biblia de Visual Basic 6.0', 0, 3, 222, 3)
GO
INSERT [dbo].[Libros] ([Isbn], [Titulo], [esEspañol], [Genero], [Autor], [Editorial]) VALUES (N'544554', N'Casi una Historia', 1, 2, 222, 1)
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Autores] FOREIGN KEY([Autor])
REFERENCES [dbo].[Autores] ([IdAutor])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Autores]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Editoriales] FOREIGN KEY([Editorial])
REFERENCES [dbo].[Editoriales] ([IdEditorial])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Editoriales]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Generos] FOREIGN KEY([Genero])
REFERENCES [dbo].[Generos] ([IdGenero])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Generos]
GO
USE [master]
GO
ALTER DATABASE [Biblioteca] SET  READ_WRITE 
GO
