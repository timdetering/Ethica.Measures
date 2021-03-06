// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Lengths
{
using System;
    using System.ComponentModel;
    
    [TypeConverter(typeof(FeetConverter))]
    public partial struct Feet :
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
    	public static readonly decimal MetersPerUnit = 0.3048M;
    	public static readonly decimal UnitsPerMeters = 3.2808398950131233595800524934M;
    
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
    
    	public Feet(decimal value)
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
            return other.ConvertTo(LengthUnit.Feet).Value == this.Value;
        }
    
    	/// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Feet other)
        {
            return Value.Equals(other.Value);
        }
    
    	public bool Equals(Meters other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public bool Equals(Centimeters other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public bool Equals(Millimeters other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public bool Equals(Nanometers other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public bool Equals(Kilometers other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public bool Equals(Inches other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public bool Equals(Yards other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public bool Equals(Miles other)
        {
            return Equals(((Feet)other));
        }	
    								
    	public static bool operator == (Feet arg1, Feet arg2)
    	{
    		return arg1.Equals(arg2);
    	}
    
    	public static bool operator != (Feet arg1, Feet arg2)
    	{
    		return !arg1.Equals(arg2);
    	}
    
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    
    	#endregion Equality
    
    	#region Comparable
    		
        public static bool operator <(Feet arg1, Feet arg2)
        {
            return arg1.CompareTo(arg2) == -1;
        }
    
        public static bool operator >(Feet arg1, Feet arg2)
        {
            return arg1.CompareTo(arg2) == 1;
        }
    
    	public int CompareTo(Length other)
        {
            return Value.CompareTo(other.ConvertTo(LengthUnit.Feet).Value);
        }
    
    	public int CompareTo(Feet other)
        {
            return Value.CompareTo(other.Value);
        }
    
    	public int CompareTo(Meters other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	public int CompareTo(Centimeters other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	public int CompareTo(Millimeters other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	public int CompareTo(Nanometers other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	public int CompareTo(Kilometers other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	public int CompareTo(Inches other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	public int CompareTo(Yards other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	public int CompareTo(Miles other)
        {
            return CompareTo((Feet)other);
        }	
    								
    	#endregion Comparable
    
    	#region Implicit Type Casting
    
    	public static implicit operator Feet (Length obj)
        {
    		return new Feet(obj.ConvertTo(LengthUnit.Feet).Value);
        }	
    
    	public static implicit operator Length(Feet obj)
        {
    		return new Length(obj.Value, LengthUnit.Feet);
        }	
    
    	public static implicit operator Feet(Meters obj)
        {
    		return new Feet(obj.Value * Meters.MetersPerUnit * Feet.UnitsPerMeters);
        }	
    			
    	public static implicit operator Feet(Centimeters obj)
        {
    		return new Feet(obj.Value * Centimeters.MetersPerUnit * Feet.UnitsPerMeters);
        }	
    			
    	public static implicit operator Feet(Millimeters obj)
        {
    		return new Feet(obj.Value * Millimeters.MetersPerUnit * Feet.UnitsPerMeters);
        }	
    			
    	public static implicit operator Feet(Nanometers obj)
        {
    		return new Feet(obj.Value * Nanometers.MetersPerUnit * Feet.UnitsPerMeters);
        }	
    			
    	public static implicit operator Feet(Kilometers obj)
        {
    		return new Feet(obj.Value * Kilometers.MetersPerUnit * Feet.UnitsPerMeters);
        }	
    			
    	public static implicit operator Feet(Inches obj)
        {
    		return new Feet(obj.Value * Inches.MetersPerUnit * Feet.UnitsPerMeters);
        }	
    			
    	public static implicit operator Feet(Yards obj)
        {
    		return new Feet(obj.Value * Yards.MetersPerUnit * Feet.UnitsPerMeters);
        }	
    			
    	public static implicit operator Feet(Miles obj)
        {
    		return new Feet(obj.Value * Miles.MetersPerUnit * Feet.UnitsPerMeters);
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
        /// Attempts to parse a string into a Feet value 
        /// </summary>
    	/// <param name="formatProvider">The format provider to use for parsing</param>
    	/// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, IFormatProvider formatProvider, out Feet result)
    	{
    		var provider =  LengthFormatProvider.GetInstance(formatProvider);
    			
    		Length distanceResult;
    		if(provider.TryParse(value, LengthUnit.Feet, out distanceResult))
    		{
    			result = distanceResult;
    			return true;				
    		}
    
    		result = default(Feet);
    		return false;
    	}
    
    	/// <summary>
        /// Attempts to parse a string into a Feet value 
        /// </summary>
        /// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, out Feet result)
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
