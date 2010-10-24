// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Lengths
{
using System;
    using System.ComponentModel;
    
    [TypeConverter(typeof(MilesConverter))]
    public partial struct Miles :
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
    	public static readonly decimal MetersPerUnit = 1609.344M;
    	public static readonly decimal UnitsPerMeters = 0.0006213711922373339696174342M;
    
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
    
    	public Miles(decimal value)
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
            return other.ConvertTo(LengthUnit.Miles).Value == this.Value;
        }
    
    	/// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Miles other)
        {
            return Value.Equals(other.Value);
        }
    
    	public bool Equals(Meters other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public bool Equals(Centimeters other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public bool Equals(Millimeters other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public bool Equals(Nanometers other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public bool Equals(Kilometers other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public bool Equals(Inches other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public bool Equals(Feet other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public bool Equals(Yards other)
        {
            return Equals(((Miles)other));
        }	
    								
    	public static bool operator == (Miles arg1, Miles arg2)
    	{
    		return arg1.Equals(arg2);
    	}
    
    	public static bool operator != (Miles arg1, Miles arg2)
    	{
    		return !arg1.Equals(arg2);
    	}
    
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    
    	#endregion Equality
    
    	#region Comparable
    		
        public static bool operator <(Miles arg1, Miles arg2)
        {
            return arg1.CompareTo(arg2) == -1;
        }
    
        public static bool operator >(Miles arg1, Miles arg2)
        {
            return arg1.CompareTo(arg2) == 1;
        }
    
    	public int CompareTo(Length other)
        {
            return Value.CompareTo(other.ConvertTo(LengthUnit.Miles).Value);
        }
    
    	public int CompareTo(Miles other)
        {
            return Value.CompareTo(other.Value);
        }
    
    	public int CompareTo(Meters other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	public int CompareTo(Centimeters other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	public int CompareTo(Millimeters other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	public int CompareTo(Nanometers other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	public int CompareTo(Kilometers other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	public int CompareTo(Inches other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	public int CompareTo(Feet other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	public int CompareTo(Yards other)
        {
            return CompareTo((Miles)other);
        }	
    								
    	#endregion Comparable
    
    	#region Implicit Type Casting
    
    	public static implicit operator Miles (Length obj)
        {
    		return new Miles(obj.ConvertTo(LengthUnit.Miles).Value);
        }	
    
    	public static implicit operator Length(Miles obj)
        {
    		return new Length(obj.Value, LengthUnit.Miles);
        }	
    
    	public static implicit operator Miles(Meters obj)
        {
    		return new Miles(obj.Value * Meters.MetersPerUnit * Miles.UnitsPerMeters);
        }	
    			
    	public static implicit operator Miles(Centimeters obj)
        {
    		return new Miles(obj.Value * Centimeters.MetersPerUnit * Miles.UnitsPerMeters);
        }	
    			
    	public static implicit operator Miles(Millimeters obj)
        {
    		return new Miles(obj.Value * Millimeters.MetersPerUnit * Miles.UnitsPerMeters);
        }	
    			
    	public static implicit operator Miles(Nanometers obj)
        {
    		return new Miles(obj.Value * Nanometers.MetersPerUnit * Miles.UnitsPerMeters);
        }	
    			
    	public static implicit operator Miles(Kilometers obj)
        {
    		return new Miles(obj.Value * Kilometers.MetersPerUnit * Miles.UnitsPerMeters);
        }	
    			
    	public static implicit operator Miles(Inches obj)
        {
    		return new Miles(obj.Value * Inches.MetersPerUnit * Miles.UnitsPerMeters);
        }	
    			
    	public static implicit operator Miles(Feet obj)
        {
    		return new Miles(obj.Value * Feet.MetersPerUnit * Miles.UnitsPerMeters);
        }	
    			
    	public static implicit operator Miles(Yards obj)
        {
    		return new Miles(obj.Value * Yards.MetersPerUnit * Miles.UnitsPerMeters);
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
        /// Attempts to parse a string into a Miles value 
        /// </summary>
    	/// <param name="formatProvider">The format provider to use for parsing</param>
    	/// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, IFormatProvider formatProvider, out Miles result)
    	{
    		var provider =  LengthFormatProvider.GetInstance(formatProvider);
    			
    		Length distanceResult;
    		if(provider.TryParse(value, LengthUnit.Miles, out distanceResult))
    		{
    			result = distanceResult;
    			return true;				
    		}
    
    		result = default(Miles);
    		return false;
    	}
    
    	/// <summary>
        /// Attempts to parse a string into a Miles value 
        /// </summary>
        /// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, out Miles result)
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