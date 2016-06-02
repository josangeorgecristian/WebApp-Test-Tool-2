using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using IMS.WebApp.Data.Execution;
using IMS.WebApp.Data.Units.Tools;

namespace IMS.WebApp.Data.Units
{
	public class TestUnit : ICloneable
	{
		#region FIELDS

			private string request;
			private string responseExpected;
			private bool ignoreResponse;
			private bool executeOnce;
            private int expectedProcessingTime;

		#endregion


		#region CONSTRUCTOR

			/// <summary>
			/// 
			/// </summary>
			public TestUnit() : this("", "")
			{			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="request"></param>
			public TestUnit(string request) : this (request, "")
			{			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="request"></param>
			/// <param name="response"></param>
			public TestUnit(string request, string response) : this(request, response, response == null || response.Trim().Length == 0)
			{			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="request"></param>
			/// <param name="response"></param>
			/// <param name="ignoreResponse"></param>
			public TestUnit(string request, string response, bool ignoreResponse) : this(request, response, ignoreResponse, false)
			{			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="request"></param>
			/// <param name="response"></param>
			/// <param name="ignoreResponse"></param>
			/// <param name="executeOnce"></param>
			public TestUnit(string request, string response, bool ignoreResponse, bool executeOnce) : this(request, response, ignoreResponse, executeOnce, 0)
			{			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="request"></param>
			/// <param name="response"></param>
			/// <param name="ignoreResponse"></param>
			/// <param name="executeOnce"></param>
			/// <param name="expectedProcessingTime"></param>
			public TestUnit(string request, string response, bool ignoreResponse, bool executeOnce, int expectedProcessingTime)
			{
				this.request = request;
				this.responseExpected = response;
				this.ignoreResponse = ignoreResponse;
				this.executeOnce = executeOnce;
				this.expectedProcessingTime = expectedProcessingTime;
			}

		#endregion
		
		
		#region ICloneable Members

			public object Clone()
			{
				throw new NotImplementedException();
			}

		#endregion


		#region GETTER/SETTER

			public string Request
			{
				get { return request; }
				set { request = value; }
			}

			public string Response
			{
				get { return responseExpected; }
				set { responseExpected = value; }
			}

			public bool IgnoreResponse
			{
				get { return ignoreResponse; }
				set { ignoreResponse = value; }
			}

			public bool ExecuteOnce
			{
				get { return executeOnce; }
				set { executeOnce = value; }
			}

            public int ExpectedProcessingTime
            {
                get { return expectedProcessingTime; }
                set { expectedProcessingTime = value; }
            }


			#region DETAILS

				internal TestUnitDetails Details
				{
					get { return new TestUnitDetails(this); }
				}


				public bool EditMode
				{
					get { return Details.EditMode; }
				}

				public string CurrentForm
				{
					get { return Details.CurrentForm; }
				}

				public string RequestDescription
				{
					get { return Details.RequestDescription; }
				}

				public string ExpectedResponseDescription
				{
					get { return Details.ExpectedResponseDescription; }
				}

				public ResponseType ExpectedResponseType
				{
					get { return Details.ExpectedResponseType; }
				}

			#endregion

		#endregion
	}
}
