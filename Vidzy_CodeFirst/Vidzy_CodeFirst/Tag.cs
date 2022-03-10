using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy_CodeFirst
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }

    }
}
