using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    public class User
    {
        [MyCustomeAtribute(Regex = "[A-Z]+[a-z]*")]
        public string Name { get; set; }

        [MyCustomeAtribute(Regex = @"\b\w{3,10}\b")]
        public string Surname { get; set; }


    }
}
