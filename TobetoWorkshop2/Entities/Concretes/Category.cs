using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop2.Entities.Abstracts;

namespace WorkShop2.Entities.Concretes
{
    //Çıplak class kalmasın.
    public class Category : IEntity
    {
        public Category()
        {
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
