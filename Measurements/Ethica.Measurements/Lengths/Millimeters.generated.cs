// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Lengths
{
using System;
    using System.ComponentModel;
    
    [TypeConverter(typeof(MillimetersConverter))]
    public partial struct Millimeters :
    	ILength,
    	IFormattable,
    	IEquatable<Length>,
        IEquatable<Meters>,
        IEquatable<Centimeters>,
        IEquatable<Millimeters>,
        IEquatable<Nanometers>,
        IEquatable<Kilometers>,
        IEquatable<Inches>,
        IEquatable<Feet>,
        IEquatable<Yards>,
        IEquatable<Miles>,
        IComparable<Meters>,
        IComparable<Centimeters>,
        IComparable<Millimeters>,
        IComparable<Nanometers>,
        IComparable<Kilometers>,
        IComparable<Inches>,
        IComparable<Feet>,
        IComparable<Yards>,
        IComparable<Miles>
    {
    	public static readonly decimal MetersPerUnit = 0.001M;
    	public static readonly decimal UnitsPerMeters = 1000M;
    
    	#region Fields
    
        /// <summary>
        /// The value of the Length represented by RelativeUnits
        /// </summary>
        readonly decimal _value;
    
        #endregion
    
    	#region Properties
    
        /// <summary>
        /// The value of the Length represented by RelativeUnits
        /// </summary>
        public decimal Value { get { return _value; } }
        
    	#endregion
    
    	public Millimeters(decimal value)
    	{
    		_value = value;
    	}
    
    	#region Equality
    
        /// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="obj">The value to compare to</param>
        /// <returns>True if both values are equal</returns>
        public override bool Equals(object obj)
        {
            var other = obj as ILength;
            if (other != null)
                return Equals(other.Length);
    
            return false;
        }
    
        /// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Length other)
        {
            return other.ConvertTo(LengthUnit.Millimeters).Value == this.Value;
        }
    
    	/// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Millimeters other)
        {
            return Value.Equals(other.Value);
        }
    
    	public bool Equals(Meters other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public bool Equals(Centimeters other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public bool Equals(Nanometers other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public bool Equals(Kilometers other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public bool Equals(Inches other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public bool Equals(Feet other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public bool Equals(Yards other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public bool Equals(Miles other)
        {
            return Equals(((Millimeters)other));
        }	
    								
    	public static bool operator == (Millimeters arg1, Millimeters arg2)
    	{
    		return arg1.Equals(arg2);
    	}
    
    	public static bool operator != (Millimeters arg1, Millimeters arg2)
    	{
    		return !arg1.Equals(arg2);
    	}
    
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    
    	#endregion Equality
    
    	#region Comparable
    		
        public static bool operator <(Millimeters arg1, Millimeters arg2)
        {
            return arg1.CompareTo(arg2) == -1;
        }
    
        public static bool operator >(Millimeters arg1, Millimeters arg2)
        {
            return arg1.CompareTo(arg2) == 1;
        }
    
    	public int CompareTo(Length other)
        {
            return Value.CompareTo(other.ConvertTo(LengthUnit.Millimeters).Value);
        }
    
    	public int CompareTo(Millimeters other)
        {
            return Value.CompareTo(other.Value);
        }
    
    	public int CompareTo(Meters other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	public int CompareTo(Centimeters other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	public int CompareTo(Nanometers other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	public int CompareTo(Kilometers other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	public int CompareTo(Inches other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	public int CompareTo(Feet other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	public int CompareTo(Yards other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	public int CompareTo(Miles other)
        {
            return CompareTo((Millimeters)other);
        }	
    								
    	#endregion Comparable
    
    	#region Implicit Type Casting
    
    	public static implicit operator Millimeters (Length obj)
        {
    		return new Millimeters(obj.ConvertTo(LengthUnit.Millimeters).Value);
        }	
    
    	public static implicit operator Length(Millimeters obj)
        {
    		return new Length(obj.Value, LengthUnit.Millimeters);
        }	
    
    	public static implicit operator Millimeters(Meters obj)
        {
    		return new Millimeters(obj.Value * Meters.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	public static implicit operator Millimeters(Centimeters obj)
        {
    		return new Millimeters(obj.Value * Centimeters.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	public static implicit operator Millimeters(Nanometers obj)
        {
    		return new Millimeters(obj.Value * Nanometers.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	public static implicit operator Millimeters(Kilometers obj)
        {
    		return new Millimeters(obj.Value * Kilometers.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	public static implicit operator Millimeters(Inches obj)
        {
    		return new Millimeters(obj.Value * Inches.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	public static implicit operator Millimeters(Feet obj)
        {
    		return new Millimeters(obj.Value * Feet.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	public static implicit operator Millimeters(Yards obj)
        {
    		return new Millimeters(obj.Value * Yards.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	public static implicit operator Millimeters(Miles obj)
        {
    		return new Millimeters(obj.Value * Miles.MetersPerUnit * Millimeters.UnitsPerMeters);
        }	
    			
    	#endregion
    
    	#region ToString
    
    	public string ToString(string format, IFormatProvider formatProvider)
        {
    		var provider = LengthFormatProvider.GetInstance(formatProvider);
    		return provider.Format(format, this, formatProvider);
        }
    
    	public string ToString(string format)
        {
    		return ToString(format, null);
        }
    
    	public override string ToString()
        {
    		return ToString("g", null);
        }
    
    	#endregion
    
    	#region TryParse
    
    	/// <summary>
        /// Attempts to parse a string into a Millimeters value 
        /// </summary>
    	/// <param name="formatProvider">The format provider to use for parsing</param>
    	/// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, IFormatProvider formatProvider, out Millimeters result)
    	{
    		var provider =  LengthFormatProvider.GetInstance(formatProvider);
    			
    		Length distanceResult;
    		if(provider.TryParse(value, LengthUnit.Millimeters, out distanceResult))
    		{
    			result = distanceResult;
    			return true;				
    		}
    
    		result = default(Millimeters);
    		return false;
    	}
    
    	/// <summary>
        /// Attempts to parse a string into a Millimeters value 
        /// </summary>
        /// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, out Millimeters result)
    	{
    		return TryParse(value, null, out result);
    	}
    
    	#endregion
    
        #region ILength Members
    
    	/// <summary>
        /// Gets this value as an unboxable property
        /// </summary>
        Length ILength.Length
        {
            get { return this; }
        }
    
        #endregion
    }
}