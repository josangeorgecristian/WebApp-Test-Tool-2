using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMS.WebApp.Data.Units.Tools
{
	public class TestUnitLoader
	{
		#region FIELDS

			private const string RequestStartString = "<events>";
			private const string RequestEndString = "</events>";
			private const string ResponseStart = "<xml ";
			private const string ResponseEnd = "</xml>";

		#endregion


		public static TestUnit[] LoadFromText(string text)
		{
			return LoadFromText(text, false);
		}

		public static TestUnit[] LoadFromText(string text, bool ignoreResponse)
		{
			return ParseContent(text, ignoreResponse);
		}


		public static TestUnit[] LoadFromFile(string filename)
		{
			return LoadFromFile(filename, false);
		}

		public static TestUnit[] LoadFromFile(string filename, bool ignoreResponse)
		{
			return ParseContent(IMS.WebApp.Tools.IOOperations.ReadFileIntoString(filename), ignoreResponse);
		}


		private static TestUnit[] ParseContent(string content, bool ignoreResponse)
		{
			List<TestUnit> unitList = new List<TestUnit>();

			int index = 0;

			int requestStartIndex = 0, requestEndIndex = 0;
			int responseStartIndex = 0, responseEndIndex = 0;

			string request = "";
			string response = "";


			while (index >= 0)
			{
				requestStartIndex = content.IndexOf(RequestStartString, index);

				if (requestStartIndex < 0)
					break;

				requestEndIndex = content.IndexOf(RequestEndString, requestStartIndex);

				if (requestEndIndex < 0)
					break;

				request = content.Substring(requestStartIndex, requestEndIndex + RequestEndString.Length - requestStartIndex);

				if (!ignoreResponse)
				{
					int nextRequestStartIndex = content.IndexOf(RequestStartString, requestEndIndex);

					responseStartIndex = content.IndexOf(ResponseStart, requestEndIndex);
					responseEndIndex = content.IndexOf(ResponseEnd, requestEndIndex);

					if (!(responseStartIndex < 0 || responseEndIndex < 0 || (nextRequestStartIndex > 0 && responseStartIndex > nextRequestStartIndex)))
					{
						response = content.Substring(responseStartIndex, responseEndIndex + ResponseEnd.Length - responseStartIndex);

						unitList.Add(new TestUnit(request, response, false));

						index = responseEndIndex;

						continue;
					}
				}

				response = "";
				unitList.Add(new TestUnit(request));
				index = requestEndIndex;
			}

			return unitList.ToArray();
		}
	}
}
