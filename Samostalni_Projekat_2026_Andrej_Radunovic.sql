Create database Samostalni_Projekat_2026_Andrej_Radunovic
go
use Samostalni_Projekat_2026_Andrej_Radunovic
go	

create table korisnik(
id int identity(1,1) primary key,
email varchar(30),
pass varchar(30),
uloga int
)
