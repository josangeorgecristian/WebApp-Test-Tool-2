
namespace IMS.WebApp.Communication
{
    public interface IConnection
	{
		#region GETTER / SETTER

			string Url { get; }
  
			bool Connected { get; }

		#endregion


		#region METHODS

			/// <summary>
			/// Function used to connect to server
			/// Will disconnect if already connected
			/// Use Connected getter to check if connection is established
			/// </summary>
			/// <param name="url">URL address for server</param>
			void Connect(string url);

			/// <summary>
			/// Function used to disconect from server
			/// Does nothing if no connection is established
			/// </summary>
			void Disconnect();

			/// <summary>
			/// Function used to send a request to server and retrieve the response
			/// </summary>
			/// <param name="content">Content of server request</param>
			/// <returns>Content of server response</returns>
			string Request(string content);
        
		#endregion
	}
}
