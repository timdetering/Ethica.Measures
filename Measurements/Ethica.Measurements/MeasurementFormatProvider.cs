using System;
using System.Globalization;
using System.Resources;
using System.Text.RegularExpressions;
using System.Threading;

namespace Ethica.Measurements
{
    public abstract class MeasurementFormatProvider<TMeasure, TUnit> : IFormatProvider
        where TMeasure : struct
        where TUnit : struct
    {
        protected MeasurementFormatProvider()
            : this(Thread.CurrentThread.CurrentUICulture)
        {
        }

        protected MeasurementFormatProvider(CultureInfo culture)
        {
            _culture = culture ?? Thread.CurrentThread.CurrentUICulture;
        }

        
        public object GetFormat(Type formatType)
        {
            if (formatType == null) throw new ArgumentNullException("formatType");
            
            return formatType.IsAssignableFrom(GetType()) ? this : null;
        }
  
        private readonly CultureInfo _culture;

        public CultureInfo Culture
        {
            get { return _culture; }
        }

        protected abstract ResourceManager ResourceManager { get; }
        protected abstract TMeasure Factory(decimal value, TUnit unitOfMeasure);
       
        /// <summary>
        /// Returns the unit of measure suffix (i..e cm, mm, etc.) to string conversions
        /// </summary>
        /// <param name="unit">The unit of measure for which the suffix is sought</param>
        /// <returns>A string which describes the unit of measure</returns>
        protected string GetShortUomName(TUnit unit)
        {
            var name = Enum.GetName(unit.GetType() , unit);
            return ResourceManager.GetString(name + "Short", _culture);
        }

        /// <summary>
        /// Returns the unit of measure suffix (i..e cm, mm, etc.) to string conversions
        /// </summary>
        /// <param name="unit">The unit of measure for which the suffix is sought</param>
        /// <param name="plural">True to return the plural suffix, else false for the singular suffix</param>
        /// <returns>A string which describes the unit of measure</returns>
        protected string GetLongUomName(TUnit unit, bool plural)
        {
            var name = Enum.GetName(unit.GetType(), unit);
            return ResourceManager.GetString(name + (plural ? "Plural" : "Single"), _culture);
        }

        /// <summary>
        /// Returns the short string format for the unit
        /// </summary>
        protected string GetShortFormat(TUnit unit)
        {
            var name = Enum.GetName(unit.GetType(), unit);
            return ResourceManager.GetString(name + "ShortFormat", _culture);
        }

        /// <summary>
        /// Returns the long string format for the unit
        /// </summary>
        protected string GetLongFormat(TUnit unit)
        {
            var name = Enum.GetName(unit.GetType(), unit);
            return ResourceManager.GetString(name + "LongFormat", _culture);
        }


        public bool TryParse(string value, out TMeasure distance)
        {
            if (!TryParseCustom(value, out distance))
                foreach (TUnit unit in Enum.GetValues(typeof(TUnit)))
                    if (TryParse(value, unit, out distance))
                        return true;

            return false;
        }

        protected virtual bool TryParseCustom(string value, out TMeasure distance)
        {
            distance = default(TMeasure);
            return false;
        }

        public bool TryParse(string value, TUnit unit, out TMeasure distance)
        {
            var expr = ResourceManager.GetString(unit + "Regex", Culture);
            distance = default(TMeasure);

            if (expr == null)
                return false;

            var match = Regex.Match(value, expr, RegexOptions.IgnorePatternWhitespace);

            if (match.Success)
            {
                var valueMatch = match.Groups["Value"];
                if (valueMatch.Success)
                {
                    decimal number;
                    if (decimal.TryParse(valueMatch.Value, out number))
                    {
                        distance = Factory(number, unit);
                        return true;
                    }
                }
            }
            return false;
        }

    }
}