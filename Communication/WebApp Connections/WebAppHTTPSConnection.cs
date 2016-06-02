using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMS.WebApp.Communication
{
	internal class WebAppHTTPSConnection : IConnection
	{
		#region FIELDS

			private int url;

		#endregion


		#region IConnection

			string IConnection.Url
			{
				get { throw new NotImplementedException(); }
			}

			bool IConnection.Connected
			{
				get { throw new NotImplementedException(); }
			}

			void IConnection.Connect(string url)
			{
				throw new NotImplementedException();
			}

			void IConnection.Disconnect()
			{
				throw new NotImplementedException();
			}

			string IConnection.Request(string content)
			{
				throw new NotImplementedException();
			}

		#endregion
	}
}
