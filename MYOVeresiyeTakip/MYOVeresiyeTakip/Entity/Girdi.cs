using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYOVeresiyeTakip
{
    /*


create table borclar
(
	plaka varchar(32) primary key,
    marka varchar(32) not null,
    model varchar(32) not null,
    yakit varchar(32) not null,
    renk varchar(32) not null,
    kasatipi varchar(32) not null,
    gunlukfiyat varchar(32) not null,
    durum varchar(32) not null
);
     */
    public class Girdi
    {

        public Guid kid { get; set; }
        public Guid plaka { get; set; }

        public float GunlukFiyat { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public string Yakit { get; set; }

        public string Renk { get; set; }


        public string KasaTipi { get; set; }

        public string Durum { get; set; }
    }
}
