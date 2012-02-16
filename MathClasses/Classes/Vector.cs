using System;
using System.Collections.Generic;

namespace MathClasses.Classes
{
	internal class Vector
	{
		#region Fields

		private readonly List<int> elements = new List<int>();

		#endregion Fields

		#region Properties

		public int this[int index]
		{
			get { return elements[index]; }
			set { elements[index] = value; }
		}

		public int ElementsCount
		{
			get { return elements.Count; }
		}

		#endregion Properties

		#region Constructors

		public Vector(int elementsCount)
		{
			for (int i = 0; i < elementsCount; i++)
			{
				elements.Add(0);
			}
		}

		public Vector(string line)
		{
			LoadFromLine(line);
		}

		#endregion Constructors

		#region Object overrides

		public override string ToString()
		{
			List<string> elementStrings = new List<string>(elements.Count);
			foreach (int element in elements)
			{
				elementStrings.Add(element.ToString());
			}
			string line = string.Join(";", elementStrings.ToArray());

			return line;
		}

		#endregion Object overrides

		#region Helpers

		private void LoadFromLine(string line)
		{
			string[] lineElements = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string element in lineElements)
			{
				int elementValue = int.Parse(element);
				elements.Add(elementValue);
			}
		}

		#endregion Helpers
	}
}