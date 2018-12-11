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
        public ResumeService()
        {

        }

        private List<CreateResumeVM> contactInfo = new List<CreateResumeVM>();

        public void AddInfo(CreateResumeVM info)
        {
            info.Id = contactInfo.Count == 0 ? 1 : contactInfo.Max(c => c.Id) + 1;
            contactInfo.Add(info);
        }

        public List<CreateResumeVM> GetInfo()
        {
            return null;
        }
    }
}
