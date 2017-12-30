﻿using System;
namespace Facile.Extension
{
	public static class StringExtensions
	{
		public static string SqlQuote(this string str, bool jolly)
		{
			str = str.Replace("\\", "\\\\");
			str = str.Replace("*", "%");
			str = str.Replace("?", "_");

			string dest = "'";
			if (!string.IsNullOrEmpty(str))
			{
				if (jolly && !str.StartsWith("%", StringComparison.CurrentCulture) && !str.StartsWith("_", StringComparison.CurrentCulture)) dest += "%";
				dest += str;
			}
			if (jolly && !dest.EndsWith("%", StringComparison.CurrentCulture) && !dest.EndsWith("_", StringComparison.CurrentCulture)) dest += "%";
			dest += "'";

			return (dest);
		}
	}
}