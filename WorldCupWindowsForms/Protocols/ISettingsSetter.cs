using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupWindowsForms.Protocols
{
    public interface ISettingsSetter
    {
        string SetSettings(string championshipType, string language);
    }
}
