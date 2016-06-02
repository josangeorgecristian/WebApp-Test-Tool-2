using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMS.CustomControls
{
	public partial class FindReplace : UserControl
	{
		private const int MAXIMUM_HEIGHT = 115;

		#region FIELDS

			// Callback event handlers
			private EventHandler _onFindClick;
			private EventHandler _onReplaceClick;
			private EventHandler _onReplaceAllClick;

			// Private field to determine if it will be find only
			private bool findOnly;

			// The offset from where to start the search
			private int offset;

		#endregion


		#region GETTER / SETTER

			/// <summary>
			/// 
			/// </summary>
            //public System.Windows.Forms.TitleBar TitleBar
            //{
            //    get { return titleBar; }
            //}

			/// <summary>
			/// 
			/// </summary>
			public TextBox Find
			{
				get { return this.txtBoxFindWhat; }
			}

			/// <summary>
			/// 
			/// </summary>
			public TextBox Replace
			{
				get { return this.txtBoxReplaceWith; }
			}

			/// <summary>
			/// 
			/// </summary>
			public Size MinimumControlSize
			{
				get { return this.MinimumSize; }
			}

			/// <summary>
			/// 
			/// </summary>
			public static int MaximumControlHeight
			{
				get { return MAXIMUM_HEIGHT; }
			}

			/// <summary>
			/// 
			/// </summary>
			public bool FindOnly
			{
				get { return findOnly; }
				set { findOnly = value; }
			}

			/// <summary>
			/// 
			/// </summary>
			public int Offset
			{
				get { return offset; }
				set { offset = value; }
			}

		#endregion


		#region CONSTRUCTOR

			/// <summary>
			/// 
			/// </summary>
			/// <param name="onFindClick"></param>
			/// <param name="onReplaceClick"></param>
			/// <param name="onReplaceAllClick"></param>
			public FindReplace(EventHandler onFindClick, EventHandler onReplaceClick, EventHandler onReplaceAllClick)
			{
				InitializeComponent();

				// Associate mandatory callback event handlers
				_onFindClick		= onFindClick;
				_onReplaceClick		= onReplaceClick;
				_onReplaceAllClick	= onReplaceAllClick;

				findOnly = false;
				offset = 0;
			}

		#endregion


		#region EVENT HANDLERS

			/// <summary>
			/// 
			/// </summary>
			private void OnFindTextChanged(object sender, EventArgs e)
			{
				offset = 0;

				UpdateControlsState();
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnReplaceTextChanged(object sender, EventArgs e)
			{
				offset = 0;

				UpdateControlsState();
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			private void OnFindClick(object sender, EventArgs e)
			{
				if (_onFindClick != null)
					_onFindClick.Invoke(sender, e);
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			private void OnReplaceClick(object sender, EventArgs e)
			{
				if (_onReplaceClick != null)
					_onReplaceClick.Invoke(sender, e);
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			private void OnReplaceAllClick(object sender, EventArgs e)
			{
				if (_onReplaceAllClick != null)
					_onReplaceAllClick.Invoke(sender, e);
			}

		#endregion


		#region CONTROL STATE METHODS

			/// <summary>
			/// 
			/// </summary>
			private void UpdateControlsState()
			{
				// Update the state of 'FIND' button
				bFind.Enabled = txtBoxFindWhat.Text.Length > 0;

				// Update the state of 'REPLACE' button
				bReplace.Enabled = (txtBoxFindWhat.Text.Length > 0) && (!findOnly);

				// Update the state of 'REPLACE ALL' button
				bReplaceAll.Enabled = (txtBoxFindWhat.Text.Length > 0) && (!findOnly);
			}

		#endregion
	}
}
