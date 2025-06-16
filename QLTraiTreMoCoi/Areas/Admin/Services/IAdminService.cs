using QLTraiTreMoCoi.Areas.Admin.Models;

namespace QLTraiTreMoCoi.Areas.Admin.Services
{
    public interface IAdminService
    {
        public Task<List<DKGuiTreRes>> GetListDKGuiTre();
        public Task<DKGuiTreDetailRes> GetDKGuiTre(int id);
        public Task<bool> UpdateStatus(int id);
    }
}
