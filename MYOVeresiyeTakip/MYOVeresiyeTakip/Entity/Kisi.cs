using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYOVeresiyeTakip
{
    /*
          * create table kisiler
(
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
    */
    public class Kisi
    {
        public Guid kid { get; set; }
        public Guid Plaka { get; set; }
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public DateTime KiraTarih { get; set; }
        public DateTime TeslimTarih { get; set; }
        public string Tutar { get; set; }
        public string OdemeTuru { get; set; }
        public List<Girdi> Girdiler { get; set; }

    }
}
