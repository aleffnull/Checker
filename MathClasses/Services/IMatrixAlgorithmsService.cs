using MathClasses.Classes;

namespace MathClasses.Services
{
	public interface IMatrixAlgorithmsService
	{
		Matrix LoadMatrix(string filePath);
		void LoadMatrices(string filePath, Matrix firstMatrix, Matrix secondMatrix);

		Matrix SimpleMultiplication(Matrix firstMatrix, Matrix secondMatrix);
		Matrix ParallelMultiplication(Matrix firstMatrix, Matrix secondMatrix);
	}
}