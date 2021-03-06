// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Lengths
{
using System;
    using System.ComponentModel;
    
    [TypeConverter(typeof(KilometersConverter))]
    public partial struct Kilometers :
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
    	public static readonly decimal MetersPerUnit = 1000M;
    	public static readonly decimal UnitsPerMeters = 0.001M;
    
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
    
    	public Kilometers(decimal value)
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
            return other.ConvertTo(LengthUnit.Kilometers).Value == this.Value;
        }
    
    	/// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Kilometers other)
        {
            return Value.Equals(other.Value);
        }
    
    	public bool Equals(Meters other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public bool Equals(Centimeters other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public bool Equals(Millimeters other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public bool Equals(Nanometers other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public bool Equals(Inches other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public bool Equals(Feet other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public bool Equals(Yards other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public bool Equals(Miles other)
        {
            return Equals(((Kilometers)other));
        }	
    								
    	public static bool operator == (Kilometers arg1, Kilometers arg2)
    	{
    		return arg1.Equals(arg2);
    	}
    
    	public static bool operator != (Kilometers arg1, Kilometers arg2)
    	{
    		return !arg1.Equals(arg2);
    	}
    
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    
    	#endregion Equality
    
    	#region Comparable
    		
        public static bool operator <(Kilometers arg1, Kilometers arg2)
        {
            return arg1.CompareTo(arg2) == -1;
        }
    
        public static bool operator >(Kilometers arg1, Kilometers arg2)
        {
            return arg1.CompareTo(arg2) == 1;
        }
    
    	public int CompareTo(Length other)
        {
            return Value.CompareTo(other.ConvertTo(LengthUnit.Kilometers).Value);
        }
    
    	public int CompareTo(Kilometers other)
        {
            return Value.CompareTo(other.Value);
        }
    
    	public int CompareTo(Meters other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	public int CompareTo(Centimeters other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	public int CompareTo(Millimeters other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	public int CompareTo(Nanometers other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	public int CompareTo(Inches other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	public int CompareTo(Feet other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	public int CompareTo(Yards other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	public int CompareTo(Miles other)
        {
            return CompareTo((Kilometers)other);
        }	
    								
    	#endregion Comparable
    
    	#region Implicit Type Casting
    
    	public static implicit operator Kilometers (Length obj)
        {
    		return new Kilometers(obj.ConvertTo(LengthUnit.Kilometers).Value);
        }	
    
    	public static implicit operator Length(Kilometers obj)
        {
    		return new Length(obj.Value, LengthUnit.Kilometers);
        }	
    
    	public static implicit operator Kilometers(Meters obj)
        {
    		return new Kilometers(obj.Value * Meters.MetersPerUnit * Kilometers.UnitsPerMeters);
        }	
    			
    	public static implicit operator Kilometers(Centimeters obj)
        {
    		return new Kilometers(obj.Value * Centimeters.MetersPerUnit * Kilometers.UnitsPerMeters);
        }	
    			
    	public static implicit operator Kilometers(Millimeters obj)
        {
    		return new Kilometers(obj.Value * Millimeters.MetersPerUnit * Kilometers.UnitsPerMeters);
        }	
    			
    	public static implicit operator Kilometers(Nanometers obj)
        {
    		return new Kilometers(obj.Value * Nanometers.MetersPerUnit * Kilometers.UnitsPerMeters);
        }	
    			
    	public static implicit operator Kilometers(Inches obj)
        {
    		return new Kilometers(obj.Value * Inches.MetersPerUnit * Kilometers.UnitsPerMeters);
        }	
    			
    	public static implicit operator Kilometers(Feet obj)
        {
    		return new Kilometers(obj.Value * Feet.MetersPerUnit * Kilometers.UnitsPerMeters);
        }	
    			
    	public static implicit operator Kilometers(Yards obj)
        {
    		return new Kilometers(obj.Value * Yards.MetersPerUnit * Kilometers.UnitsPerMeters);
        }	
    			
    	public static implicit operator Kilometers(Miles obj)
        {
    		return new Kilometers(obj.Value * Miles.MetersPerUnit * Kilometers.UnitsPerMeters);
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
        /// Attempts to parse a string into a Kilometers value 
        /// </summary>
    	/// <param name="formatProvider">The format provider to use for parsing</param>
    	/// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, IFormatProvider formatProvider, out Kilometers result)
    	{
    		var provider =  LengthFormatProvider.GetInstance(formatProvider);
    			
    		Length distanceResult;
    		if(provider.TryParse(value, LengthUnit.Kilometers, out distanceResult))
    		{
    			result = distanceResult;
    			return true;				
    		}
    
    		result = default(Kilometers);
    		return false;
    	}
    
    	/// <summary>
        /// Attempts to parse a string into a Kilometers value 
        /// </summary>
        /// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, out Kilometers result)
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
