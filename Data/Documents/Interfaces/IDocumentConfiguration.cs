using System;
using System.Collections.Generic;
using System.Text;

namespace IMS.WebApp.Data.Documents.Interfaces
{
	public interface IDocumentConfiguration
	{
		#region PROPERTIES

			string ID
			{
				get;
			}

			string Name
			{
				get;
				set;
			}

			string Description
			{
				get;
				set;
			}

		#endregion
	}
}
