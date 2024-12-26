# MoviesApi


Here is the Database Used SQL Server

CREATE DATABASE Film_Studio;
USE Film_Studio;


create table actor (
	act_id int Not Null identity, 
	act_fname nvarchar(20), 
	act_lname nvarchar(20), 
	act_gender nvarchar(1)
);

create table director (
	dir_id int Not Null identity, 
	dir_fname nvarchar(20), 
	dir_lname nvarchar(20)
);

create table genres (
	gen_id int Not Null identity, 
	gen_title nvarchar(20)
);

create table movie (
	mov_id int Not Null identity, 
	mov_title nvarchar(50), 
	mov_year int, 
	mov_time int, 
	mov_lang nvarchar(20), 
	mov_rl_dt date, 
	mov_rel_country nvarchar(20)
);

CREATE TABLE [Movie_cast](
	[mov_id] [int] NULL,
	[act_id] [int] NULL,
	[role] [nvarchar](30) NULL
)

CREATE TABLE [Movie_Direction](
	[mov_id] [int] NULL,
	[dir_id] [int] NULL
)

CREATE TABLE [Movie_Genres](
	[mov_id] [int] NULL,
	[gen_id] [int] NULL
)

CREATE TABLE [Rating](
	[mov_id] [int] NULL,
	[rev_id] [int] NULL,
	[rev_stars] [numeric](4, 2) NULL,
	[num_o_ratings] [int] NULL
)

CREATE TABLE [Reviewer](
	[rev_id] [int] Not Null identity,
	[rev_name] [nvarchar](30) NULL
)

INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'James               ', N'Stewart             ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Deborah             ', N'Kerr                ', N'F')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Peter               ', N'OToole              ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Robert              ', N'De Niro             ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'F. Murray           ', N'Abraham             ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Harrison            ', N'Ford                ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Nicole              ', N'Kidman              ', N'F')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Stephen             ', N'Baldwin             ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Jack                ', N'Nicholson           ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Mark                ', N'Wahlberg            ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Woody               ', N'Allen               ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Claire              ', N'Danes               ', N'F')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Tim                 ', N'Robbins             ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Kevin               ', N'Spacey              ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Kate                ', N'Winslet             ', N'F')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Robin               ', N'Williams            ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Jon                 ', N'Voight              ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Ewan                ', N'McGregor            ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Christian           ', N'Bale                ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Maggie              ', N'Gyllenhaal          ', N'F')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Dev                 ', N'Patel               ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Sigourney           ', N'Weaver              ', N'F')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'David               ', N'Aston               ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Ali                 ', N'Astin               ', N'F')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Robert                 ', N'Downey Jr               ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Tom                 ', N'Cruise               ', N'M')
INSERT [Actor] ([act_fname], [act_lname], [act_gender]) VALUES (N'Johnny                 ', N'Depp               ', N'M')

SELECT * From actor

INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Alfred              ', N'Hitchcock           ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Jack                ', N'Clayton             ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'David               ', N'Lean                ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Michael             ', N'Cimino              ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Milos               ', N'Forman              ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Ridley              ', N'Scott               ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Stanley             ', N'Kubrick             ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Bryan               ', N'Singer              ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Roman               ', N'Polanski            ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Paul                ', N'Thomas Anderson     ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Woody               ', N'Allen               ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Hayao               ', N'Miyazaki            ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Frank               ', N'Darabont            ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Sam                 ', N'Mendes              ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'James               ', N'Cameron             ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Gus                 ', N'Van Sant            ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'John                ', N'Boorman             ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Danny               ', N'Boyle               ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Christopher         ', N'Nolan               ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Richard             ', N'Kelly               ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Kevin               ', N'Spacey              ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Andrei              ', N'Tarkovsky           ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Peter               ', N'Jackson             ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Stan               ', N'Lee                 ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Rob                 ', N'Marshal             ')
INSERT [Director] ([dir_fname], [dir_lname]) VALUES (N'Christopher         ', N'McQuarrie           ')


SELECT * FROM [Director];

INSERT [Genres] ([gen_title]) VALUES (N'Actionwa')
INSERT [Genres] ([gen_title]) VALUES (N'Adventure           ')
INSERT [Genres] ([gen_title]) VALUES (N'Animation           ')
INSERT [Genres] ([gen_title]) VALUES (N'Biography           ')
INSERT [Genres] ([gen_title]) VALUES (N'Comedy              ')
INSERT [Genres] ([gen_title]) VALUES (N'Crime               ')
INSERT [Genres] ([gen_title]) VALUES (N'Drama               ')
INSERT [Genres] ([gen_title]) VALUES (N'Horror              ')
INSERT [Genres] ([gen_title]) VALUES (N'Music               ')
INSERT [Genres] ([gen_title]) VALUES (N'Mystery             ')
INSERT [Genres] ([gen_title]) VALUES (N'Romance             ')
INSERT [Genres] ([gen_title]) VALUES (N'Thriller            ')
INSERT [Genres] ([gen_title]) VALUES (N'War                 ')


SELECT * FROM [Genres];

INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Vertigo                                           ', 1958, 128, N'English        ', CAST(N'1958-08-24' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'The Innocents                                     ', 1961, 100, N'English        ', CAST(N'1962-02-19' AS Date), N'SW   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Lawrence of Arabia                                ', 1962, 216, N'English        ', CAST(N'1962-12-11' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'The Deer Hunter                                   ', 1978, 183, N'English        ', CAST(N'1979-03-08' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Amadeus                                           ', 1984, 160, N'English        ', CAST(N'1985-01-07' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Blade Runner                                      ', 1982, 117, N'English        ', CAST(N'1982-09-09' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Eyes Wide Shut                                    ', 1999, 159, N'English        ', NULL, N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'The Usual Suspects                                ', 1995, 106, N'English        ', CAST(N'1995-08-25' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Chinatown                                         ', 1974, 130, N'English        ', CAST(N'1974-08-09' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Boogie Nights                                     ', 1997, 155, N'English        ', CAST(N'1998-02-16' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Annie Hall                                        ', 1977, 93, N'English        ', CAST(N'1977-04-20' AS Date), N'USA  ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Princess Mononoke                                 ', 1997, 134, N'Japanese       ', CAST(N'2001-10-19' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'The Shawshank Redemption                          ', 1994, 142, N'English        ', CAST(N'1995-02-17' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'American Beauty                                   ', 1999, 122, N'English        ', NULL, N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Titanic                                           ', 1997, 194, N'English        ', CAST(N'1998-01-23' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Good Will Hunting                                 ', 1997, 126, N'English        ', CAST(N'1998-06-03' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Deliverance                                       ', 1972, 109, N'English        ', CAST(N'1982-10-05' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Trainspotting                                     ', 1996, 94, N'English        ', CAST(N'1996-02-23' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'The Prestige                                      ', 2006, 130, N'English        ', CAST(N'2006-11-10' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Donnie Darko                                      ', 2001, 113, N'English        ', NULL, N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Slumdog Millionaire                               ', 2008, 120, N'English        ', CAST(N'2009-01-09' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Aliens                                            ', 1986, 137, N'English        ', CAST(N'1986-08-29' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Beyond the Sea                                    ', 2004, 118, N'English        ', CAST(N'2004-11-26' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Avatar                                            ', 2009, 162, N'English        ', CAST(N'2009-12-17' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Seven Samurai                                     ', 1954, 207, N'Japanese       ', CAST(N'1954-04-26' AS Date), N'JP   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Spirited Away                                     ', 2001, 125, N'Japanese       ', CAST(N'2003-09-12' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Back to the Future                                ', 1985, 116, N'English        ', CAST(N'1985-12-04' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Braveheart                                        ', 1995, 178, N'English        ', CAST(N'1995-09-08' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Avengers                                        ', 1998, 140, N'English        ', CAST(N'1998-11-09' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Age of Ultron                                        ', 2000, 160, N'English        ', CAST(N'2000-05-29' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Infinity War                                        ', 2002, 150, N'English        ', CAST(N'2002-11-09' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Endgame                                        ', 2004, 190, N'English        ', CAST(N'2004-05-29' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Mission Imp                                         ', 1994, 148, N'English        ', CAST(N'1994-08-12' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Mission Imp II                                         ', 1998, 165, N'English        ', CAST(N'1998-10-21' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Mission Imp III                                        ', 2000, 148, N'English        ', CAST(N'2000-12-12' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Pirates                                          ', 2003, 150, N'English        ', CAST(N'2003-08-12' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Pirates II                                          ', 2006, 145, N'English        ', CAST(N'2006-01-15' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Pirates III                                        ', 2007, 163, N'English        ', CAST(N'2007-04-25' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Pirates IV                                        ', 2011, 150, N'English        ', CAST(N'2011-03-17' AS Date), N'UK   ')
INSERT [Movie] ([mov_title], [mov_year], [mov_time], [mov_lang], [mov_rl_dt], [mov_rel_country]) VALUES (N'Pirates  V                                      ', 2017, 167, N'English        ', CAST(N'2017-02-28' AS Date), N'UK   ')


SELECT * FROM [Movie];


INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (1, 1, N'John Scottie Ferguson         ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (2, 2, N'Miss Giddens                  ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (3, 3, N'T.E. Lawrence                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (4, 4, N'Michael                       ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (5, 5, N'Antonio Salieri               ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (6, 6, N'Rick Deckard                  ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (7, 7, N'Alice Harford                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (8, 8, N'McManus                       ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (10, 10, N'Eddie Adams                   ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (11, 11, N'Alvy Singer                   ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (12, 12, N'San                           ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (13, 13, N'Andy Dufresne                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (14, 14, N'Lester Burnham                ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (15, 15, N'Rose DeWitt Bukater           ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (16, 16, N'Sean Maguire                  ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (17, 17, N'Ed                            ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (18, 18, N'Renton                        ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (20, 20, N'Elizabeth Darko               ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (21, 21, N'Older Jamal                   ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (22, 22, N'Ripley                        ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (23, 14, N'Bobby Darin                   ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (9, 9, N'J.J. Gittes                   ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (19, 19, N'Alfred Borden                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (29, 25, N'Ironman                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (30, 25, N'Ironman                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (31, 25, N'Ironman                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (32, 25, N'Ironman                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (33, 26, N'Ethan                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (34, 26, N'Hunt                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (35, 26, N'Agent                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (36, 27, N'Captain                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (37, 27, N'Jack                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (38, 27, N'Jack                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (39, 27, N'Sparrow                 ')
INSERT [Movie_cast] ([mov_id], [act_id], [role]) VALUES (40, 27, N'Sparrow                 ')

SELECT * FROM [Movie_cast];

INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (1, 1)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (2, 2)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (3, 3)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (4, 4)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (5, 5)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (6, 6)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (7, 7)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (8, 8)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (9, 9)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (10, 10)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (11, 11)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (12, 12)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (13, 13)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (14, 14)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (15, 15)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (16, 16)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (17, 17)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (18, 18)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (19, 19)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (20, 20)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (21, 18)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (22, 15)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (23, 21)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (29, 24)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (30, 24)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (31, 24)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (32, 24)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (33, 26)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (34, 26)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (35, 26)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (36, 25)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (37, 25)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (38, 25)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (39, 25)
INSERT [Movie_Direction] ([mov_id], [dir_id]) VALUES (40, 25)

SELECT * FROM [Movie_Direction];

INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (22, 1)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (17, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (3, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (12, 3)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (11, 5)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (8, 6)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (13, 6)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (26, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (28, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (18, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (21, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (2, 8)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (23, 9)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (7, 10)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (27, 10)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (1, 10)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (14, 11)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (6, 12)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (4, 13)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (22, 1)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (17, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (3, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (12, 3)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (11, 5)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (8, 6)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (13, 6)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (26, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (28, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (18, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (21, 7)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (2, 8)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (23, 9)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (7, 10)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (27, 10)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (1, 10)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (14, 11)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (6, 12)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (4, 13)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (29, 13)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (30, 13)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (31, 13)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (32, 13)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (33, 1)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (35, 1)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (35, 1)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (36, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (37, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (38, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (39, 2)
INSERT [Movie_Genres] ([mov_id], [gen_id]) VALUES (40, 2)

SELECT * FROM [Movie_Genres];

INSERT [Reviewer] ([rev_name]) VALUES (N'Righty Sock                   ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Jack Malvern                  ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Flagrant Baronessa            ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Alec Shaw                     ')
INSERT [Reviewer] ([rev_name]) VALUES (NULL)
INSERT [Reviewer] ([rev_name]) VALUES (N'Victor Woeltjen               ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Simon Wright                  ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Neal Wruck                    ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Paul Monks                    ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Mike Salvati                  ')
INSERT [Reviewer] ([rev_name]) VALUES (NULL)
INSERT [Reviewer] ([rev_name]) VALUES (N'Wesley S. Walker              ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Sasha Goldshtein              ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Josh Cates                    ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Krug Stillo                   ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Scott LeBrun                  ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Hannah Steele                 ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Vincent Cadena                ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Brandt Sponseller             ')
INSERT [Reviewer] ([rev_name]) VALUES (N'Richard Adams                 ')

SELECT * FROM [Reviewer];

INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (1, 1, CAST(8.40 AS Numeric(4, 2)), 263575)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (2, 2, CAST(7.90 AS Numeric(4, 2)), 20207)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (3, 3, CAST(8.30 AS Numeric(4, 2)), 202778)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (6, 5, CAST(8.20 AS Numeric(4, 2)), 484746)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (24, 6, CAST(7.30 AS Numeric(4, 2)), NULL)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (8, 7, CAST(8.60 AS Numeric(4, 2)), 779489)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (9, 8, NULL, 227235)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (10, 9, CAST(3.00 AS Numeric(4, 2)), 195961)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (11, 10, CAST(8.10 AS Numeric(4, 2)), 203875)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (12, 11, CAST(8.40 AS Numeric(4, 2)), NULL)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (14, 13, CAST(7.00 AS Numeric(4, 2)), 862618)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (15, 1, CAST(7.70 AS Numeric(4, 2)), 830095)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (16, 14, CAST(4.00 AS Numeric(4, 2)), 642132)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (25, 15, CAST(7.70 AS Numeric(4, 2)), 81328)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (18, 16, NULL, 580301)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (20, 17, CAST(8.10 AS Numeric(4, 2)), 609451)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (21, 18, CAST(8.00 AS Numeric(4, 2)), 667758)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (22, 19, CAST(8.40 AS Numeric(4, 2)), 511613)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (23, 20, CAST(6.70 AS Numeric(4, 2)), 13091)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (29, 1, CAST(6.70 AS Numeric(4, 2)), 45091)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (30, 10, CAST(7.40 AS Numeric(4, 2)), 16891)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (31, 9, CAST(8.20 AS Numeric(4, 2)), 45864)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (32, 20, CAST(9.70 AS Numeric(4, 2)), 77744)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (33, 3, CAST(8.30 AS Numeric(4, 2)), 76433)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (34, 15, CAST(7.70 AS Numeric(4, 2)), 23495)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (35, 17, CAST(8.40 AS Numeric(4, 2)), 10853)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (36, 1, CAST(9.70 AS Numeric(4, 2)), 989878)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (37, 11, CAST(9.80 AS Numeric(4, 2)), 687833)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (38, 17, CAST(9.70 AS Numeric(4, 2)), 769487)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (39, 16, CAST(9.50 AS Numeric(4, 2)), 397537)
INSERT [Rating] ([mov_id], [rev_id], [rev_stars], [num_o_ratings]) VALUES (40, 20, CAST(9.90 AS Numeric(4, 2)), 989548)

SELECT * FROM [Rating];


ALTER TABLE 
	actor
ADD CONSTRAINT 
	PK_Actor
PRIMARY KEY 
	(act_id);


ALTER TABLE 
	director
ADD CONSTRAINT 
	PK_Director
PRIMARY KEY 
	(dir_id);

ALTER TABLE 
	genres
ADD CONSTRAINT 
	PK_Genres
PRIMARY KEY 
	(gen_id);

ALTER TABLE 
	movie
ADD CONSTRAINT 
	PK_Movie
PRIMARY KEY 
	(mov_id);

ALTER TABLE 
	Reviewer
ADD CONSTRAINT 
	PK_Reviewer
PRIMARY KEY 
	(rev_id);


ALTER TABLE
	Movie_cast
ADD CONSTRAINT 
	FK1
FOREIGN KEY
	(act_id)
REFERENCES 
	actor (act_id);

ALTER TABLE
	Movie_cast
ADD CONSTRAINT 
	FK2
FOREIGN KEY
	(mov_id)
REFERENCES 
	movie (mov_id);


ALTER TABLE
	Movie_Direction
ADD CONSTRAINT 
	FK3
FOREIGN KEY
	(mov_id)
REFERENCES 
	movie (mov_id);

ALTER TABLE
	Movie_Direction
ADD CONSTRAINT 
	FK4
FOREIGN KEY
	(dir_id)
REFERENCES 
	director (dir_id);

ALTER TABLE
	Movie_Genres
ADD CONSTRAINT 
	FK5
FOREIGN KEY
	(mov_id)
REFERENCES 
	movie (mov_id);

ALTER TABLE
	Movie_Genres
ADD CONSTRAINT 
	FK6
FOREIGN KEY
	(gen_id)
REFERENCES 
	genres (gen_id);

ALTER TABLE
	Rating
ADD CONSTRAINT 
	FK7
FOREIGN KEY
	(mov_id)
REFERENCES 
	movie (mov_id);

ALTER TABLE
	Rating
ADD CONSTRAINT 
	FK8
FOREIGN KEY
	(rev_id)
REFERENCES 
	Reviewer (rev_id);

ALTER TABLE Movie_cast
ADD Cast_id INT PRIMARY KEY NOT NULL IDENTITY;

ALTER TABLE Movie_Direction
ADD Direction_id INT PRIMARY KEY NOT NULL IDENTITY;

ALTER TABLE Movie_Genres
ADD Genres_id INT PRIMARY KEY NOT NULL IDENTITY;

ALTER TABLE Rating
ADD Rating_id INT PRIMARY KEY NOT NULL IDENTITY;



sp_rename 'FK1' , 'FK_Movie_cast_mov_id_movie_mov_id';
sp_rename 'FK2', 'FK_Movie_cast_act_id_actor_act_id';
sp_rename 'PK__Movie_ca__539D774D8D0EB526' , 'PK_Movie_cast_Cast_id';

sp_rename 'FK3' , 'FK_Movie_Direction_mov_id_movie_mov_id';
sp_rename 'FK4', 'FK_Movie_Direction_dir_id_director_dir_id';
sp_rename '[PK__Movie_Di__DCFCAE9FF157ACF6]' , 'PK_Movie_Direction_Direction_id';

sp_rename 'FK5' , 'FK_Movie_Genres_mov_id_movie_mov_id';
sp_rename 'FK6' , 'FK_Movie_Genres_gen_id_genres_gen_id';
sp_rename '[PK__Movie_Ge__220BFB1E19196D08]' , 'PK_Movie_Genres_Genres_id';

sp_rename 'FK7' , 'FK_Rating_mov_id_movie_mov_id';
sp_rename 'FK8' , 'FK_Rating_rev_id_Reviewer_rev_id';
sp_rename '[PK__Rating__BE49CCDD3EF7FFD7]' , 'PK_Rating_Rating_id';

sp_rename 'PK_Actor' , 'PK_Actor_act_id';
sp_rename 'PK_Director' , 'PK_Director_dir_id';
sp_rename 'PK_Genres' , 'PK_Genres_gen_id';
sp_rename 'PK_Movie' , 'PK_Movie_mov_id';
sp_rename 'PK_Reviewer' , 'PK_Reviewer_rev_id';

ALTER TABLE Rating
DROP CONSTRAINT FK_Rating_rev_id_Reviewer_rev_id;

ALTER TABLE Rating
ADD CONSTRAINT FK_Rating_rev_id_Reviewer_rev_id
FOREIGN KEY (rev_id) REFERENCES Reviewer(rev_id)
ON DELETE CASCADE;

ALTER TABLE Rating
DROP CONSTRAINT FK_Rating_mov_id_movie_mov_id;

ALTER TABLE Rating
ADD CONSTRAINT FK_Rating_mov_id_movie_mov_id
FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
ON DELETE CASCADE;


ALTER TABLE Movie_Genres
DROP CONSTRAINT [FK_Movie_Genres_gen_id_genres_gen_id];

ALTER TABLE Movie_Genres
ADD CONSTRAINT [FK_Movie_Genres_gen_id_genres_gen_id]
FOREIGN KEY (gen_id) REFERENCES genres(gen_id)
ON DELETE CASCADE;

ALTER TABLE Movie_Genres
DROP CONSTRAINT [FK_Movie_Genres_mov_id_movie_mov_id];

ALTER TABLE Movie_Genres
ADD CONSTRAINT [FK_Movie_Genres_mov_id_movie_mov_id]
FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
ON DELETE CASCADE;


ALTER TABLE Movie_Direction
DROP CONSTRAINT [FK_Movie_Direction_dir_id_director_dir_id];

ALTER TABLE Movie_Direction
ADD CONSTRAINT [FK_Movie_Direction_dir_id_director_dir_id]
FOREIGN KEY (dir_id) REFERENCES director(dir_id)
ON DELETE CASCADE;

ALTER TABLE Movie_Direction
DROP CONSTRAINT [FK_Movie_Direction_mov_id_movie_mov_id];

ALTER TABLE Movie_Direction
ADD CONSTRAINT [FK_Movie_Direction_mov_id_movie_mov_id]
FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
ON DELETE CASCADE;

ALTER TABLE Movie_Cast
DROP CONSTRAINT [FK_Movie_cast_mov_id_movie_mov_id];

ALTER TABLE Movie_Cast
ADD CONSTRAINT [FK_Movie_cast_mov_id_movie_mov_id]
FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
ON DELETE CASCADE;

ALTER TABLE Movie_Cast
DROP CONSTRAINT [FK_Movie_cast_act_id_actor_act_id];

ALTER TABLE Movie_Cast
ADD CONSTRAINT [FK_Movie_cast_act_id_actor_act_id]
FOREIGN KEY (act_id) REFERENCES actor(act_id)
ON DELETE CASCADE;

SELECT * FROM Movie_cast;
SELECT * FROM Movie_Direction;
SELECT * FROM Movie_Genres;
SELECT * FROM Rating;
 

select * from Director;
select * from genres;
select * from movie;
select * from reviewer;

select * from actor;



ALTER TABLE actor
ADD CONSTRAINT check_Unique_ActorName
UNIQUE (act_fname , act_lname , act_gender)
 
ALTER TABLE director
ADD CONSTRAINT check_Unique_Directorname
UNIQUE (dir_fname , dir_lname)
 
ALTER TABLE genres
ADD CONSTRAINT check_Unique_genres
UNIQUE (gen_title)

ALTER TABLE movie
ADD CONSTRAINT checkUniqueMovieName
UNIQUE (mov_title , mov_year , mov_time , mov_lang , mov_rl_dt , mov_rel_country )
 
ALTER TABLE rating
ADD CONSTRAINT checkUniqueRating
UNIQUE (mov_id , rev_id)
 
ALTER TABLE Movie_Cast
ADD CONSTRAINT checkUniqueMovieCast
UNIQUE (mov_id , act_id)

ALTER TABLE Movie_Direction
ADD CONSTRAINT checkUniqueMovieDirection
UNIQUE (mov_id , dir_id)

ALTER TABLE Movie_Genres
ADD CONSTRAINT checkUniqueMovieGenres
UNIQUE (mov_id , gen_id)  

