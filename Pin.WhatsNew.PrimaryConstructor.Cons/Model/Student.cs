using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.WhatsNew.PrimaryConstructor.Cons.Model
{
    public class Student(string firstName, string lastName)
    {
        public string FullName => $"{firstName} {lastName}";
    }
}
