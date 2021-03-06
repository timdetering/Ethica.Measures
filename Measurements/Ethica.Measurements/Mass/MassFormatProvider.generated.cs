// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Mass
{
    using System;
    using System.Globalization;
    using System.Resources;
    using System.Threading;
    using System.Collections.Concurrent;
    using System.Text;
    using System.Text.RegularExpressions;
    
    public partial class MassFormatProvider : MeasurementFormatProvider<Mass, MassUnit>, 
    	IMassFormatProvider
    {
        #region Fields
    
        private static readonly ConcurrentDictionary<string, MassFormatProvider> CultureProviders =
            new ConcurrentDictionary<string, MassFormatProvider>();
    
        #endregion
    
        public MassFormatProvider(CultureInfo culture)
            : base(culture)
        {
        }
    
    	public MassFormatProvider() : base()
        {
        }
    
    
        /// <summary>
        /// Gets the MassFormatProvider object associated with the specified IFormatProvider object. 
        /// </summary>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public static IMassFormatProvider GetInstance(IFormatProvider formatProvider)
        {
            if (formatProvider == null)
                return Current;
    
            return (IMassFormatProvider)formatProvider.GetFormat(typeof(IMassFormatProvider))
                    ?? (IMassFormatProvider)formatProvider.GetFormat(typeof(MassFormatProvider))
                    ?? Current;
        }
    
        public static MassFormatProvider ForCulture(CultureInfo culture)
        {
            if (culture == null) throw new ArgumentNullException("culture");
    
            return CultureProviders.GetOrAdd(culture.NativeName,
                                                name => new MassFormatProvider(culture));
        }
    
    
        public static MassFormatProvider Current
        {
            get { return ForCulture(Thread.CurrentThread.CurrentUICulture); }
        }
    
        protected override ResourceManager ResourceManager
        {
            get { return MassResources.ResourceManager; }
        }
    
        protected override Mass Factory(decimal value, MassUnit unitOfMeasure)
        {
            return new Mass(value, unitOfMeasure);
        }
    
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            var asIMass = arg as IMass;
            if (asIMass == null)
                throw new ArgumentException("Invalid Argument","arg");
    
            Mass mass = asIMass.Mass;
    
            if (!string.IsNullOrEmpty(format))
            {
    			string unitName = mass.UnitOfMeasure.ToString();
                
    			switch (format)
                {
                    case "g":
                        format = ResourceManager.GetString(unitName + "ShortFormat", Culture);
    					return string.Format(formatProvider, format, mass);
    
                    case "G":
                        format = ResourceManager.GetString(unitName + "LongFormat", Culture);
    					return string.Format(formatProvider, format, mass);
    
                    case "u":
                    case "uom":
                        return ResourceManager.GetString(unitName + "Short", Culture);
    
                    case "U":
                    case "UOM":
                        return ResourceManager.GetString(unitName + 
    					(mass.Value == 1 ? "Single" : "Plural"), Culture);
                }
    
    
                string customResult = null;
    			CustomFormat(format, mass, formatProvider, ref customResult);
                if (customResult != null)
                     return customResult;
    
                if (format.StartsWith("As", StringComparison.Ordinal))
                {
                    format = format.Substring(2);
                    MassUnit unit;
                    if (Enum.TryParse(format, false, out unit))
                        return mass.ConvertTo(unit).ToString("g", formatProvider);
                }
            }
            return mass.Value.ToString(format, formatProvider);
        }
    
    
    	partial void CustomFormat(string format, Mass mass, IFormatProvider formatProvider, ref string result);
    
    }

}
