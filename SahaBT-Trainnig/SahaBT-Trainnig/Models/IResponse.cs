using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SahaBT_Trainnig.Models
{
    public interface IResponse
    {
        List<Persons> Answer1();
        List<Persons> Answer2(int gnd);
        Dictionary<string, List<Persons>> Answer3(int cntry);

    }
}
