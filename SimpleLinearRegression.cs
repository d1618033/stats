﻿using System;
using System.Collections.Generic;

namespace Stats
{
	public class SimpleLinearRegression: ICurveFit
	{

		public SimpleLinearRegression ()
		{

		}

		#region ICurveFit implementation

		public void fit (IList<double> x, IList<double> y)
		{
			if (x.Count != y.Count)
				throw new ArgumentException ("X and Y must be of the same size");
		}

		public void predict (double x0)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

