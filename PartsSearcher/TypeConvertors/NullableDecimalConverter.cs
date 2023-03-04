using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsSearcher.TypeConvertors;

public class NullableDecimalConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return sourceType == typeof(string);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is not string input) return null;
		if (string.IsNullOrWhiteSpace(input)) return null;

		var parsed = decimal.TryParse(input, out var output);
		if (!parsed) return null;
		return output;
	}
}