using Miniprojekt.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt.Services
{
    public interface IResumeService
    {
        void AddInfo(CreateResumeVM info);
        List<CreateResumeVM> GetInfo();
    }

    public class ResumeService : IResumeService
    {
        private List<CreateResumeVM> contactInfo = new List<CreateResumeVM>();

        public void AddInfo(CreateResumeVM info)
        {
            info.Id = info.Count == 0 ? 1 : people.Max(p => p.Id) + 1;
        }

        public List<CreateResumeVM> GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
