using System;
using System.Collections.Generic;
using System.Text;

namespace V1inlämningsUppgift
{
    class Artist : IInformation
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        public string GetInformation()
        {
            return $"Artisten heter {Name} och Genre är {Genre}";
        }
    }
}
