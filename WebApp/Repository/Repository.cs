using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Repository
{
    public class Repository : IRepository
    {
        private static readonly List<NicknameAndEmailViewModel> NicksAndEmails = new List<NicknameAndEmailViewModel>();

        public void Add(NicknameAndEmailViewModel entity)
        {
            NicksAndEmails.Add(entity);
        }

        public IReadOnlyList<NicknameAndEmailViewModel> List()
        {
            return NicksAndEmails;
        }
    }
}