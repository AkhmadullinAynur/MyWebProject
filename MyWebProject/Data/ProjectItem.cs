using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Data
{
    public class ProjectItem
    {
        public ProjectItem(int number,string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        //public List<ProjectItem> projectItems { get; set; }
    }
}
