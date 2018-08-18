using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Common;

namespace WebAPI.Convertor
{
    public class BaseTextConvertor: ITextConvertor
	{
		protected readonly List<KeyWord> KeyWords;
		public BaseTextConvertor(List<KeyWord> keyWords) {
			KeyWords = keyWords;
		}

		protected string Lemmatize(string content) {
			/*var sb = new StringBuilder();
			var lemmatizer = Lemmatizator.GetInstance();
			foreach (var word in content.ToLower().Split(' ')) {
				sb.Append(lemmatizer.Lemmatize(word)).Append(" ");
			}
			return sb.ToString();*/
			return string.Empty;
		}

		public virtual string Convert(string content) {
			return string.Empty;
		}


    }
}
