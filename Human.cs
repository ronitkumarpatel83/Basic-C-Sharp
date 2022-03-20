using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Human
    {
        public string Name = "Ronit";
        public long Phonenumber = 7008427274;
        public void Speak()
        {
            Console.WriteLine("He/She can speak");

        }
        public void HumanDetails()
        {
            Console.WriteLine("Name:"+Name+", Contact: "+Phonenumber);
        
        }
    }
}
