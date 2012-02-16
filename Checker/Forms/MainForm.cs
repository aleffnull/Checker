using System;
using System.Windows.Forms;
using Checker.Common;
using Checker.Services;
using Checker.Services.Impl;
using CoreClasses.Services.Common;
using MathClasses.Services;
using MathClasses.Services.Impl;

namespace Checker.Forms
{
	public partial class MainForm : Form
	{
		#region Constructors

		public MainForm()
		{
			InitializeComponent();

			ServiceLocator serviceLocator = CreateServiceLocator();
			SetServiceLocator(serviceLocator);
			SetLogger(LogMessage);
		}

		#endregion Constructors

		#region Helpers

		private static ServiceLocator CreateServiceLocator()
		{
			ServiceLocator serviceLocator = new ServiceLocator();
			serviceLocator.RegisterService<IMatrixService>(new MatrixService(serviceLocator));
			serviceLocator.RegisterService<IMatrixAlgorithmsService>(new MatrixAlgorithmsService());
			serviceLocator.RegisterService<IMathService>(new MathService());

			return serviceLocator;
		}

		private void SetServiceLocator(ServiceLocator serviceLocator)
		{
			matrixMultiplicationCheckControl.ServiceLocator = serviceLocator;
			matrixEqualityCheckControl.ServiceLocator = serviceLocator;
			piCalculationCheckControl.ServiceLocator = serviceLocator;
		}

		private void SetLogger(Logger logger)
		{
			matrixMultiplicationCheckControl.Logger = logger;
			matrixEqualityCheckControl.Logger = logger;
			piCalculationCheckControl.Logger = logger;
		}

		private void LogMessage(string message)
		{
			if (InvokeRequired)
			{
				Invoke(new MethodInvoker(() => LogMessage(message)));
			}
			else
			{
				logRichTextBox.AppendText(string.Format("{0}{1}", message, Environment.NewLine));
			}
		}

		#endregion Helpers
	}
}


