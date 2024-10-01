using DataAccessLayer;

namespace YalcomaniaToursMkfMtr.Models
{
    public class OperationSearchTourModel
    {
        public List<Arac> AracList { get; set; }
        public List<AracTipi> AracTipiList { get; set; }
        public List<Bilet> BiletList { get; set; }
        public List<Bolge> BolgeList { get; set; }
        public List<BolgeOtel> BolgeOtelList { get; set; }
        public List<Kur> KurList { get; set; }
        public List<Otel> OtelList { get; set; }
        public List<ParaBirimi> ParaBirimiList { get; set; }
        public List<Tur> TurList { get; set; }
        public List<TurTipi> TurTipiList { get; set; }
        public List<Uyruk> UyrukList { get; set; }

    }
}
