using DataAccessLayer;

namespace YalcomaniaToursMkfMtr.Models
{
    public class OperationCreateTourModel
    {
        public List<AracTipi> AracTipiList { get; set; }
        public List<Arac> AracList { get; set; }
        public List<TurTipi> TurTipiList { get; set; }
        public List<Sirket> SirketList { get; set; }
        public List<ParaBirimi> ParaBirimiList { get; set; }
        public List<SirketTurTipi> SirketTurTipiList { get; set; }
    }
}
