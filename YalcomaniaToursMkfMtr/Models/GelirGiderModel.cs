using DataAccessLayer;

namespace YalcomaniaToursMkfMtr.Models
{
    public class GelirGiderModel
    {
        public List<Sirket> SirketList { get; set; }
        public List<Gelir> GelirList { get; set; }
        public List<Gider> GiderList { get; set; }
        public List<GelirGiderKategori> GelirGiderKategoriList { get; set; }
        public List<PasAlacak> PasAlacakList { get; set; }
        public List<PasVerecek> PasVerecekList { get; set; }
        public List<AracVerecek> AracVerecekList { get; set; }
        public List<PasAnlasma> PasAnlasmaList { get; set; }
        public List<ParaBirimi> ParaBirimiList { get; set; }
        public List<Kur> KurList { get; set; }
    }
}
