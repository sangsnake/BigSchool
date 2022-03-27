using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [required]
        public string Place { get; set; }
        [required]
        [FutureDate]
        public string Date { get; set; }
        [required]
        [ValidTime]
        public string Time { get; set; }
        [required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; internal set; }
        public int Id { get; internal set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

        internal DateTime GetDateTme()
        {
            throw new NotImplementedException();
        }
    }
    
}