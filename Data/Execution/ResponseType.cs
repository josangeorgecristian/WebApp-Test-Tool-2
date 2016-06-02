using System;
using System.Collections.Generic;
using System.Text;

namespace IMS.WebApp.Data.Execution
{
	public sealed class ResponseType
	{
		#region FIELDS

			private int id;
			private string text;

			// STATIC OBJECTS
			public static ResponseType EXPECTED		= new ResponseType(0, "Expected");
			public static ResponseType SUCCESS		= new ResponseType(1, "Success");
			public static ResponseType INFORMATION	= new ResponseType(2, "Information");
			public static ResponseType WARNING		= new ResponseType(2, "Warning");
			public static ResponseType ERROR		= new ResponseType(3, "Error");
			public static ResponseType FATALERROR	= new ResponseType(4, "Fatal Error");

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Constructor for ResponseType objects
			/// Insures that the id and text are always present
			/// </summary>
			public ResponseType(int id, string text)
			{
				this.id		= id;
				this.text	= text;
			}

		#endregion


		#region METHODS

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return text;
			}

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override int GetHashCode()
			{
				return id;
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="obj"></param>
			/// <returns></returns>
			public override bool Equals(object obj)
			{
				ResponseType compare = obj as ResponseType;

				if (compare == null)
					return false;

				return compare.id == id;
			}

		#endregion
	}
}
