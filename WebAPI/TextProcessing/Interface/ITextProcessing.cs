using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.TextProcessing
{
    public interface ITextProcessing
    {
		string Process(string text);
    }
}
