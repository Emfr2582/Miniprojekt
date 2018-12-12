using Microsoft.AspNetCore.Mvc.Rendering;
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
        SelectListItem[] EducationInfo();
    }

    public class ResumeService : IResumeService
    {
        public ResumeService()
        {

        }

        public List<CreateResumeVM> contactInfo = new List<CreateResumeVM>();

        public void AddInfo(CreateResumeVM info)
        {
            info.Id = contactInfo.Count == 0 ? 1 : contactInfo.Max(c => c.Id) + 1;
            contactInfo.Add(info);
        }

        public List<CreateResumeVM> GetInfo()
        {
            return contactInfo;
        }

        public SelectListItem[] EducationInfo()
        {
            return new SelectListItem[]
            {
                new SelectListItem {Value = "0", Text= "Välj"},
                new SelectListItem {Value = "1", Text = "Grundskola"},
                new SelectListItem {Value = "2", Text = "Gymnasium"},
                new SelectListItem {Value = "3", Text = "Folkhögskola/YH-utbildning"},
                new SelectListItem {Value = "4", Text = "Högskola/Univeristet"},
            };
        }
    }
}
