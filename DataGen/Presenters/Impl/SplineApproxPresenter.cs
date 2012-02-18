using System;
using CoreClasses.Services;
using DataGen.Models;
using DataGen.Properties;
using DataGen.Services;
using DataGen.Views;

namespace DataGen.Presenters.Impl
{
	internal class SplineApproxPresenter : BaseControlPresenter<ISplineApproxView>, ISplineApproxPresenter
	{
		#region Properties

		private ISerializationService SerializationService
		{
			get { return ServiceLocator.Resolve<ISerializationService>(); }
		}

		private IGeneratorService GeneratorService
		{
			get { return ServiceLocator.Resolve<IGeneratorService>(); }
		}

		#endregion Properties

		#region Constructors

		public SplineApproxPresenter(ISplineApproxView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region ISplineApproxPresenter implementation

		public void OnLoad()
		{
			string path = View.AskForProfileLoadPath();
			if (string.IsNullOrEmpty(path))
			{
				return;
			}

			View.SetWaitMode();
			SerializationService.BeginDeserializing<SplineApproxModel>(path, DeserializeSuccessCallback, DeserializeErrorCallback);
		}

		public void OnSave()
		{
			string path = View.AskForProfileSavePath();
			if (string.IsNullOrEmpty(path))
			{
				return;
			}

			View.SetWaitMode();
			SplineApproxModel model = CreateModelFromView();
			SerializationService.BeginSerializing(model, path, SerializeSuccessCallback, SerializeErrorCallback);
		}

		public void OnGenerate()
		{
			string errorMessage;
			bool checkResult = CheckUserData(out errorMessage);
			if (!checkResult)
			{
				View.ShowError(errorMessage);
				return;
			}

			View.SetWaitMode();
			GeneratorService.BeginGeneratingSplineApproxData(
				View.XStart, View.XStop, View.XStep, View.YStart, View.YStop, View.K1Max, View.KnMax, View.VariantsCount, View.TargetFolder,
				GenerateSuccessCallback, GenerateErrorCallback);
		}

		#endregion ISplineApproxPresenter implementation

		#region Callbacks

		private void DeserializeSuccessCallback(SplineApproxModel model)
		{
			LoadModelInView(model);
			View.SetNormalMode();
		}

		private void DeserializeErrorCallback(Exception e)
		{
			HandleError(e);
		}

		private void SerializeSuccessCallback()
		{
			View.SetNormalMode();
		}

		private void SerializeErrorCallback(Exception e)
		{
			HandleError(e);
		}

		private void GenerateSuccessCallback()
		{
			View.SetNormalMode();
		}

		private void GenerateErrorCallback(Exception e)
		{
			HandleError(e);
		}

		#endregion Callbacks

		#region Helpers

		private void LoadModelInView(SplineApproxModel model)
		{
			View.XStart = model.XStart;
			View.XStop = model.XStop;
			View.XStep = model.XStep;
			View.YStart = model.YStart;
			View.YStop = model.YStop;
			View.K1Max = model.K1Max;
			View.KnMax = model.KnMax;
			View.VariantsCount = model.VariantsCount;
			View.TargetFolder = model.TargetFolder;
		}

		private SplineApproxModel CreateModelFromView()
		{
			SplineApproxModel model = new SplineApproxModel(
				View.XStart, View.XStop, View.XStep, View.YStart, View.YStop,
				View.K1Max, View.KnMax, View.VariantsCount, View.TargetFolder);
			return model;
		}

		private bool CheckUserData(out string errorMessage)
		{
			int xStart = View.XStart;
			int xStop = View.XStop;
			double xStep = View.XStep;
			int yStart = View.YStart;
			int yStop = View.YStop;
			string targetFolder = View.TargetFolder;

			if (xStart > xStop)
			{
				errorMessage = Resources.Error_InvalidArgumentRange;
				return false;
			}
			if (xStep > xStop - xStart)
			{
				errorMessage = Resources.Error_ArgumentRangeIsTooShort;
				return false;
			}

			if (yStart > yStop)
			{
				errorMessage = Resources.Error_FunctionValueRange;
				return false;
			}

			if (string.IsNullOrEmpty(targetFolder))
			{
				errorMessage = Resources.Error_OutputFolderIsMissing;
				return false;
			}

			errorMessage = string.Empty;
			return true;
		}

		private void HandleError(Exception e)
		{
			View.ShowError(e.ToString());
			View.SetNormalMode();
		}

		#endregion Helpers
	}
}