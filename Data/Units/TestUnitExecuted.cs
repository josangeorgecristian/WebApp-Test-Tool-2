using System;
using System.Collections.Generic;
using System.Text;

using IMS.WebApp.Data.Execution;
using IMS.WebApp.Data.Units.Tools;

namespace IMS.WebApp.Data.Units
{
	public class TestUnitExecuted : TestUnit, ICloneable
	{
		#region FIELDS

			private string responseRecieved;

		#endregion


		#region CONSTRUCTOR

			public TestUnitExecuted(TestUnit unit, string response)
			{
				responseRecieved = response;

				base.Request				= unit.Request;
				base.Response				= unit.Response;
				base.IgnoreResponse			= unit.IgnoreResponse;
				base.ExecuteOnce			= unit.ExecuteOnce;
				base.ExpectedProcessingTime = unit.ExpectedProcessingTime;
			}

		#endregion


		#region ICloneable Members

			public object Clone()
			{
				throw new NotImplementedException();
			}

		#endregion

		#region GETTER / SETTER

			public string ResponseReceived
			{
				get { return responseRecieved; }
			}


			#region DETAILS

				new internal TestUnitDetails Details
				{
					get { return new TestUnitDetails(this); }
				}

				public string ReceivedResponseDescription
				{
					get { return Details.ReceivedResponseDescription; }
				}

				public string DifferencesDescription
				{
					get { return Details.DifferencesDescription; }
				}

				public bool HasDifferences
				{
					get { return Details.hasDifferencesInRespose; }
				}

				public ResponseType ReceivedResponseType
				{
					get { return Details.ReceivedResponseType; }
				}

				public string ProcessingTime
				{
					get { return Details.ProcessingTime; }
				}

			#endregion

		#endregion
	}
}
