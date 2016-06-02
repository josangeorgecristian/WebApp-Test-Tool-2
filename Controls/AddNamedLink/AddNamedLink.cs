using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IMS.CustomControls
{
	public partial class AddNamedLink : UserControl
	{
		#region FIELDS

			// Callback event handlers
			private EventHandler _onOKClick;

			// 
			private bool destroyWhenFocusIsLost = false;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Minimal control constructor
			/// </summary>
			/// <param name="onOKClick">Mandatory event handler used for button OK click event</param>
			public AddNamedLink(EventHandler onOKClick)
			{
				InitializeComponent();

				// Associate the mandatory callback event handlers
				_onOKClick = onOKClick;
			}

			public AddNamedLink(EventHandler onOKClick, bool destroyWhenFocusIsLost)
			{
				InitializeComponent();

				// Associate the mandatory callback event handlers
				_onOKClick = onOKClick;

				// Call dispose when focus is lost settings
				this.destroyWhenFocusIsLost = destroyWhenFocusIsLost;
			}

		#endregion


		#region GETTER \ SETTER

			/// <summary>
			/// Exposes the txtName text box control outside the custom control
			/// </summary>
			public TextBox UrlName
			{
				get { return this.txtName; }
			}

			/// <summary>
			/// Exposes the txtUrl text box control outside the custom control
			/// </summary>
			public TextBox UrlLink
			{
				get { return this.txtUrl; }
			}

		#endregion


		#region EVENTS

			/// <summary>
			/// Event handler for button OK click event
			/// It will invoke the event handler passed in the constructor
			/// </summary>
			private void OnOKClick(object sender, EventArgs e)
			{
				if (_onOKClick != null)
					_onOKClick.Invoke(sender, e);
			}

			/// <summary>
			/// Event handler for button Cancel click event
			/// It will dispose the control
			/// </summary>
			private void OnCancelClick(object sender, EventArgs e)
			{
				this.Dispose();
			}

			private void OnLooseFocus(object sender, EventArgs e)
			{
				if (destroyWhenFocusIsLost)
					this.Dispose();
			}

		#endregion
	}
}
