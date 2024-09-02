using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class GorevSeed
    {
        public static List<Gorev> GetSeeds()
        {
            return new List<Gorev>
            {
                    new Gorev {GorevAdi = "Admin", Aciklama = "Sistem Yöneticisi", SilindiMi = false },
                    new Gorev {GorevAdi = "BiletSatis", Aciklama = "Bilet Satış Elemanı", SilindiMi = false },
                    new Gorev {GorevAdi = "OperasyonYonetim", Aciklama = "Operasyon Yönetim Elemanı", SilindiMi = false },
                    new Gorev {GorevAdi = "VeriGiris", Aciklama = "Veri Giriş Elemanı", SilindiMi = false },
                    new Gorev {GorevAdi = "Muhasebe", Aciklama = "Muhasebeci", SilindiMi = false }
            };
        }
    }
}
