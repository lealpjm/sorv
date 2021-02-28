using API_Sorv.Model;
using Core.Repositories;

namespace Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
