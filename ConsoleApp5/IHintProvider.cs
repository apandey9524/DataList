using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataList
{
    public interface IHintProvider
    {
        IHintProvider GetHint(char nextChar,out string result);
    }
}
