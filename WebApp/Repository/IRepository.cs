using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Repository
{
    public interface IRepository
    {
        void Add(NicknameAndEmailViewModel entity);
        IReadOnlyList<NicknameAndEmailViewModel> List();
    }
}