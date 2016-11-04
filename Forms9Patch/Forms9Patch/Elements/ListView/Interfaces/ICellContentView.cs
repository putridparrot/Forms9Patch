﻿using System;
namespace Forms9Patch
{
	/// <summary>
	/// Interface Cell content view.
	/// </summary>
	public interface ICellContentView
	{
		/// <summary>
		/// Gets the height of the cell if the list HasUnevenRows=true.
		/// </summary>
		/// <value>The height of the cell.</value>
		double CellHeight { get; }
	}
}
