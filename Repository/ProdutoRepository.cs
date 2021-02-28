using API_Sorv.Model;

namespace Repository
{
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public ProdutoRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
