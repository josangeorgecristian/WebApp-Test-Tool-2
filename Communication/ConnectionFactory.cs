
namespace IMS.WebApp.Communication
{
    /// <summary>
    /// Connection Factory
    /// Singleton pattern class
    /// Used to create different connection types
    /// </summary>
    public sealed class ConnectionFactory
    {
        #region FIELDS

            /// <summary>
            /// Use simple singleton pattern - eager initialization of a static member
            /// Static member initialization is thread safe; use this method to avoid the overkill
            /// of thread syncronization
            /// </summary>
            private static readonly ConnectionFactory _instance = new ConnectionFactory();
            
        #endregion


        #region CONSTRUCTOR

            // Empty constructor
            private ConnectionFactory()
            {            }

        #endregion


        #region GETTER / SETTER
        
			/// <summary>
			/// Gets the singleton instance of the ConnectionFactory
			/// </summary>
            public static ConnectionFactory Instance
            {
                get { return _instance; }
            }

        #endregion


        #region METHODS

			/// <summary>
			/// Function used for creating a connection
			/// </summary>
			/// <returns>A newly created connection</returns>
			public IConnection CreateConnection()
			{
				// Read the Connection type from settings and determine which type should it be created
				switch (IMS.WebApp.Tools.Settings.Settings.ConnectionType)
				{
					// Default connection is the WebAppHttpConnection
					default:
						return new WebAppHttpConnection();
				}
			}

        #endregion
    }
}
