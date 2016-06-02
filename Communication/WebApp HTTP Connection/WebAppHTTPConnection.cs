using System;
using System.IO;
using System.Net;
using System.Text;

namespace IMS.WebApp.Communication
{
    internal class WebAppHttpConnection : IConnection
	{
		#region FIELDS

			private string url;

			private HttpWebRequest request;
			private HttpWebResponse response;

			private Stream requestStream;
			private StreamReader responseStream;

			private CookieContainer cookieContainer;

		#endregion


		#region IConnection Members

			/// <summary>
			/// Getter to retrieve the URL
			/// </summary>
			public string Url
			{
				get { return url; }
			}

			/// <summary>
			/// Getter to check if the connection is still active
			/// </summary>
			public bool Connected
			{
				get
				{
					return (request != null && request.CookieContainer != null);
				}
			}

			/// <summary>
			/// Function used to connect to server
			/// Will disconnect if already connected
			/// User Connected getter to check if already connected
			/// </summary>
			/// <param name="url">URL address for server</param>
			public void Connect(string url)
			{
				// Set the url
				this.url = url;

				// Create a cookie container
				cookieContainer = new CookieContainer();
			}

			/// <summary>
			/// Function used to disconnect from server
			/// Does nothing if no connection was established
			/// </summary>
			public void Disconnect()
			{
				request.CookieContainer = null;
				request = null;
			}

			/// <summary>
			/// Function used to send a request to server
			/// </summary>
			/// <param name="content"></param>
			/// <returns></returns>
			public string Request(string content)
			{
				// Translate message into UTF8 format
				byte[] postDataBytes = Encoding.UTF8.GetBytes(content);

				// Open a connection
				request = WebRequest.Create(this.url) as HttpWebRequest;

				// Set the value for the settings
				request.Method = "POST";
				request.UserAgent = "IMS WebApp Test Tool 2.0";
				request.CookieContainer = cookieContainer;
				request.KeepAlive = true;
				request.ReadWriteTimeout = 60 * 1000;
				request.Timeout = 60 * 1000;

				// Get a reference to the request stream of the connection,
				// write the message to the request stream, then close request stream
				requestStream = request.GetRequestStream();
				requestStream.Write(postDataBytes, 0, postDataBytes.Length);
				requestStream.Close();

				// Get a reference to the request stream of the response,
				// retrieve cookie container, and get a stream reader
				response = request.GetResponse() as HttpWebResponse;
				response.Cookies = request.CookieContainer.GetCookies(request.RequestUri);
				responseStream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

				// Return the response stream
				return responseStream.ReadToEnd();
			}

		#endregion
	}
}
