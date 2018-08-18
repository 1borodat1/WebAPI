using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Convertor
{
    interface ITextConvertor
    {
		string Convert(string context);
    }
}
