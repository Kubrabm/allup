using System;

namespace Allup.DAL.Entities
{
    public class Header
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string NavBgUrl { get; set; }
        public string Support { get; set; }
        public string Phone { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Setting> Settings { get; set; }
        public ICollection<Value> Values { get; set; }
        public ICollection<Language> Languages { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Nav> Navs { get; set; }

    }
}
