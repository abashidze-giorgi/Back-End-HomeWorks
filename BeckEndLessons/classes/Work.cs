using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.classes
{
    public interface IWork
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }

    }
}
