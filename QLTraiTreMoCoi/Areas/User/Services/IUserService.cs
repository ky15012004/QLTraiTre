using QLTraiTreMoCoi.Areas.User.Models;

namespace QLTraiTreMoCoi.Areas.User.Services
{
    public interface IUserService
    {
        public Task<DataResponse<string>> RegisterChild(RegisterChildReq req);
    }
}
