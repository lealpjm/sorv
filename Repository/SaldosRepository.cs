using Core.Repositories;
using Domain;

namespace Repository
{
    public class SaldosRepository : BaseRepository<Saldos>, ISaldosRepository
    {
        public SaldosRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
