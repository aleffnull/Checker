using System;
using System.Windows.Forms;
using CoreClasses.Services.Common;
using DataGen.Presenters;
using DataGen.Presenters.Impl;
using DataGen.Views;

namespace DataGen.Forms
{
	public partial class MainForm : Form, IMainView
	{
		#region Fields

		private readonly IMainPresenter presenter;

		#endregion Fields

		#region Constructors

		public MainForm()
		{
			InitializeComponent();
			presenter = new MainPresenter(this);
		}

		#endregion Constructors

		#region IMainView implementation

		ServiceLocator IMainView.ServiceLocator
		{
			set { matrixMultiplicationControl.ServiceLocator = splineApproxControl.ServiceLocator = value; }
		}

		#endregion IMainView implementation

		#region Event handlers

		private void MainForm_Load(object sender, EventArgs e)
		{
			presenter.OnLoad();
		}

		#endregion Event handlers
	}
}