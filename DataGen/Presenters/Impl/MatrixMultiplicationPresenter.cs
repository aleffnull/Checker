using System;
using CoreClasses.Services;
using CoreControls.Data;
using DataGen.Common;
using DataGen.Models;
using DataGen.Properties;
using DataGen.Services;
using DataGen.Views;

namespace DataGen.Presenters.Impl
{
	internal class MatrixMultiplicationPresenter : BaseControlPresenter<IMatrixMultiplicationView>, IMatrixMultiplicationPresenter
	{
		#region Properties

		private IGeneratorService GeneratorService
		{
			get { return ServiceLocator.Resolve<IGeneratorService>(); }
		}

		private ISerializationService SerializationService
		{
			get { return ServiceLocator.Resolve<ISerializationService>(); }
		}

		#endregion Properties

		#region Constructors

		public MatrixMultiplicationPresenter(IMatrixMultiplicationView view)
			: base(view)
		{
			//
		}

		#endregion Constructors

		#region IMatrixMultiplicationPresenter implementation

		public void OnLoadProfile()
		{
			string path = View.AskForProfileLoadPath();
			if (string.IsNullOrEmpty(path))
			{
				return;
			}

			View.SetWaitMode();
			SerializationService.BeginDeserializing<GenerateMatricesModel>(path, DeserializeSuccessCallback, DeserializeErrorCallback);
		}

		public void OnSaveProfile()
		{
			string path = View.AskForProfileSavePath();
			if (string.IsNullOrEmpty(path))
			{
				return;
			}

			View.SetWaitMode();
			GenerateMatricesModel model = CreateModelFromView();
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
			GeneratorService.BeginGeneratingMatrices(
				View.FirstMatrixDimension, View.SecondMatrixDimension, View.MaxEvementValue, View.NumberOfFiles, View.OutputFolder,
				GenerateSuccessCallback, GenerateErrorCallback);
		}

		#endregion IMatrixMultiplicationPresenter implementation

		#region Callbacks

		private void DeserializeSuccessCallback(GenerateMatricesModel model)
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

		private void LoadModelInView(GenerateMatricesModel model)
		{
			View.FirstMatrixDimension = model.FirstMatrixDimension;
			View.SecondMatrixDimension = model.SecondMatrixDimension;
			View.MaxEvementValue = model.MaxEvementValue;
			View.NumberOfFiles = model.NumberOfFiles;
			View.OutputFolder = model.OutputFolder;
		}

		private GenerateMatricesModel CreateModelFromView()
		{
			GenerateMatricesModel model = new GenerateMatricesModel(
				View.FirstMatrixDimension, View.SecondMatrixDimension, View.MaxEvementValue, View.NumberOfFiles, View.OutputFolder);
			return model;
		}

		private bool CheckUserData(out string errorMessage)
		{
			MatrixDimension firstMatrix = View.FirstMatrixDimension;
			MatrixDimension secondMatrix = View.SecondMatrixDimension;
			if (!firstMatrix.IsValid)
			{
				errorMessage = Resources.Error_FirstMatrixDimensionIsInvalid;
				return false;
			}
			if (!secondMatrix.IsValid)
			{
				errorMessage = Resources.Error_SecondMatrixDimensionIsInvalid;
				return false;
			}
			if (firstMatrix.ColumnCount != secondMatrix.RowCount)
			{
				errorMessage = Resources.Error_MatrixesCannotBeMultipliedDueToDimensions;
				return false;
			}

			if (View.MaxEvementValue <= 0)
			{
				errorMessage = Resources.Error_MaxElementValueIsInvalid;
				return false;
			}

			if (View.NumberOfFiles <= 0)
			{
				errorMessage = Resources.Error_NumberOfFilesIsInvalid;
				return false;
			}

			if (View.OutputFolder == Constants.InvalidPath)
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