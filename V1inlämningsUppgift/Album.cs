using System;
using System.Collections.Generic;
using System.Text;

namespace V1inlämningsUppgift
{
    class Album : IInformation
    {
   
        public int Year { get; set; }
        public string Name { get; set; }

        public string GetInformation()
        {
            return $"Albumet heter {Name} och släpptes år {Year}";
        }
    }
}
