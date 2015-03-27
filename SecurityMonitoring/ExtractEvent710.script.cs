using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ScopeRuntime;

internal class Helper
{
	public static String formatEvent610(String str, int n = -1)
	{
		//StringBuilder outputBuilder = new StringBuilder();
		int firstDoubleQuote = str.IndexOf(@"""");
		int lastDoubleQuote = str.LastIndexOf(@"""");
		string[] fields = null;
		String userStr = "";
		if (firstDoubleQuote >= 0 && lastDoubleQuote >= 0 && firstDoubleQuote < lastDoubleQuote && lastDoubleQuote + 2 <= str.Length)
		{
			String fieldsStr = str.Substring(firstDoubleQuote + 1, lastDoubleQuote - firstDoubleQuote - 1);
			userStr = str.Substring(lastDoubleQuote + 2);
			fields = fieldsStr.Split(new char[] { '|' });
		}
		if (fields != null && n < fields.Length)
		{
			return fields[n];
		}
		else
		{
			return userStr;
		}
	}
}