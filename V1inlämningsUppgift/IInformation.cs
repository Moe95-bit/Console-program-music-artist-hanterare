using System;
using System.Collections.Generic;
using System.Text;

namespace V1inlämningsUppgift
{
    interface IInformation
    {
        string Name { get; set; }

        string GetInformation();
    }
}
