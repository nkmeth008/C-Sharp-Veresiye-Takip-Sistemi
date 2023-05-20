create table araclar (
plaka varchar(32) primary key,
marka varchar(32) not null,
model varchar(32) not null,
yakit varchar(32) not null,
renk varchar(32) not null,
kasatipi varchar(32) not null,
gunlukfiyat varchar(32) not null,
durum varchar(32) not null
);

create table kiralama(
kid varchar(32) primary key,
plaka varchar(32) references araclar on delete cascade on update cascade,
tc varchar(32) not null,
ad varchar(32) not null,
soyad varchar(32) not null,
telefon varchar(32) not null,
mail varchar(32) not null,
adres varchar(32) not null,
kiratarih datetime not null,
teslimtarih datetime not null,
tutar varchar(32) not null,
odemeturu varchar(32) not null
);