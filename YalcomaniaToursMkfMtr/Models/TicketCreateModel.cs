using DataAccessLayer;

namespace YalcomaniaToursMkfMtr.Models
{
    public class TicketCreateModel
    {
        public List<Tur> TurList { get; set; }
        public List<TurTipi> TurTipiList { get; set; }
        public List<Sube> SubeList { get; set; }
        public List<Calisan> CalisanList { get; set; }
        public List<SubeCalisan> SubeCalisanList { get; set; }
        public List<BolgeSube> BolgeSubeList { get; set; }
        public List<Uyruk> UyrukList { get; set; }
        public List<Otel> OtelList { get; set; }
        public List<Bolge> BolgeList { get; set; }
        public List<ParaBirimi> ParaBirimiList { get; set; }
    }
}
