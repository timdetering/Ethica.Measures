using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Ethica.Measurements.Lengths
{
    public partial class LengthFormatProvider
    {
        partial void CustomFormat(string format, Length length, IFormatProvider formatProvider, ref string result)
        {
            switch (format)
            {
                case "fi": // feet and inches condensed - i.e. 1'5"
                case "FI": // feet and inches expanded  - i.e. 1 foot 2 inches
                    string fmt = format == "fi" ? "g" : "G";

                    Length asInches = length.ConvertTo(LengthUnit.Inches);

                    var feet = new Length(decimal.Truncate(asInches.Value / 12M), LengthUnit.Feet);
                    var inches = new Length(decimal.Truncate(asInches.Value % 12M), LengthUnit.Inches);
                    var builder = new StringBuilder(30);

                    if (feet.Value != 0M)
                    {
                        builder.Append(feet.ToString(fmt, formatProvider));
                        builder.Append(" ");
                    }
                    builder.Append(inches.ToString(fmt, formatProvider));
                    result = builder.ToString();
                    break;
            }
        }

        protected override bool TryParseCustom(string value, out Length Length)
        {
            string expr = LengthResources.ResourceManager.GetString("FeetAndInchesRegex", Culture);

            if (expr != null)
            {
                Match match = Regex.Match(value, expr, RegexOptions.IgnorePatternWhitespace);

                if (match.Success)
                {
                    decimal feet = 0, inches = 0;
                    Group feetMatch = match.Groups["Value"];
                    Group inchesMatch = match.Groups["Inches"];

                    if ((feetMatch.Success && decimal.TryParse(feetMatch.Value, out feet)) ||
                        (inchesMatch.Success && decimal.TryParse(inchesMatch.Value, out inches)))
                    {
                        Length = new Length((feet * 12) + inches, LengthUnit.Inches);
                        return true;
                    }
                }
            }
            Length = default(Length);
            return false;
        }
    }
}