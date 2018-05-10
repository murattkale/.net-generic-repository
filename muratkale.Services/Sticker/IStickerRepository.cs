using muratkale.Data.EFModelContext;
using muratkale.EFRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace muratkale.Services
{
    public interface IStickerRepository : IGenericRepository<Sticker>
    {
        Task<dynamic> Get(int? count);
        IEnumerable<Sticker> getLastDataList();
    }
}
