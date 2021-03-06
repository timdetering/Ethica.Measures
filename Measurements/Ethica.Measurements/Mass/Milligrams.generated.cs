// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Mass
{
using System;
    using System.ComponentModel;
    
    [TypeConverter(typeof(MilligramsConverter))]
    public partial struct Milligrams :
    	IMass,
    	IFormattable,
    	IEquatable<Mass>,
        IEquatable<Grams>,
        IEquatable<Kilograms>,
        IEquatable<Ounces>,
        IEquatable<Milligrams>,
        IEquatable<Pounds>,
        IComparable<Grams>,
        IComparable<Kilograms>,
        IComparable<Ounces>,
        IComparable<Milligrams>,
        IComparable<Pounds>
    {
    	public static readonly decimal GramsPerUnit = 0.001M;
    	public static readonly decimal UnitsPerGrams = 1000M;
    
    	#region Fields
    
        /// <summary>
        /// The value of the Mass represented by RelativeUnits
        /// </summary>
        readonly decimal _value;
    
        #endregion
    
    	#region Properties
    
        /// <summary>
        /// The value of the Mass represented by RelativeUnits
        /// </summary>
        public decimal Value { get { return _value; } }
        
    	#endregion
    
    	public Milligrams(decimal value)
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
            var other = obj as IMass;
            if (other != null)
                return Equals(other.Mass);
    
            return false;
        }
    
        /// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Mass other)
        {
            return other.ConvertTo(MassUnit.Milligrams).Value == this.Value;
        }
    
    	/// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Milligrams other)
        {
            return Value.Equals(other.Value);
        }
    
    	public bool Equals(Grams other)
        {
            return Equals(((Milligrams)other));
        }	
    								
    	public bool Equals(Kilograms other)
        {
            return Equals(((Milligrams)other));
        }	
    								
    	public bool Equals(Ounces other)
        {
            return Equals(((Milligrams)other));
        }	
    								
    	public bool Equals(Pounds other)
        {
            return Equals(((Milligrams)other));
        }	
    								
    	public static bool operator == (Milligrams arg1, Milligrams arg2)
    	{
    		return arg1.Equals(arg2);
    	}
    
    	public static bool operator != (Milligrams arg1, Milligrams arg2)
    	{
    		return !arg1.Equals(arg2);
    	}
    
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    
    	#endregion Equality
    
    	#region Comparable
    		
        public static bool operator <(Milligrams arg1, Milligrams arg2)
        {
            return arg1.CompareTo(arg2) == -1;
        }
    
        public static bool operator >(Milligrams arg1, Milligrams arg2)
        {
            return arg1.CompareTo(arg2) == 1;
        }
    
    	public int CompareTo(Mass other)
        {
            return Value.CompareTo(other.ConvertTo(MassUnit.Milligrams).Value);
        }
    
    	public int CompareTo(Milligrams other)
        {
            return Value.CompareTo(other.Value);
        }
    
    	public int CompareTo(Grams other)
        {
            return CompareTo((Milligrams)other);
        }	
    								
    	public int CompareTo(Kilograms other)
        {
            return CompareTo((Milligrams)other);
        }	
    								
    	public int CompareTo(Ounces other)
        {
            return CompareTo((Milligrams)other);
        }	
    								
    	public int CompareTo(Pounds other)
        {
            return CompareTo((Milligrams)other);
        }	
    								
    	#endregion Comparable
    
    	#region Implicit Type Casting
    
    	public static implicit operator Milligrams (Mass obj)
        {
    		return new Milligrams(obj.ConvertTo(MassUnit.Milligrams).Value);
        }	
    
    	public static implicit operator Mass(Milligrams obj)
        {
    		return new Mass(obj.Value, MassUnit.Milligrams);
        }	
    
    	public static implicit operator Milligrams(Grams obj)
        {
    		return new Milligrams(obj.Value * Grams.GramsPerUnit * Milligrams.UnitsPerGrams);
        }	
    			
    	public static implicit operator Milligrams(Kilograms obj)
        {
    		return new Milligrams(obj.Value * Kilograms.GramsPerUnit * Milligrams.UnitsPerGrams);
        }	
    			
    	public static implicit operator Milligrams(Ounces obj)
        {
    		return new Milligrams(obj.Value * Ounces.GramsPerUnit * Milligrams.UnitsPerGrams);
        }	
    			
    	public static implicit operator Milligrams(Pounds obj)
        {
    		return new Milligrams(obj.Value * Pounds.GramsPerUnit * Milligrams.UnitsPerGrams);
        }	
    			
    	#endregion
    
    	#region ToString
    
    	public string ToString(string format, IFormatProvider formatProvider)
        {
    		var provider = MassFormatProvider.GetInstance(formatProvider);
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
        /// Attempts to parse a string into a Milligrams value 
        /// </summary>
    	/// <param name="formatProvider">The format provider to use for parsing</param>
    	/// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, IFormatProvider formatProvider, out Milligrams result)
    	{
    		var provider =  MassFormatProvider.GetInstance(formatProvider);
    			
    		Mass distanceResult;
    		if(provider.TryParse(value, MassUnit.Milligrams, out distanceResult))
    		{
    			result = distanceResult;
    			return true;				
    		}
    
    		result = default(Milligrams);
    		return false;
    	}
    
    	/// <summary>
        /// Attempts to parse a string into a Milligrams value 
        /// </summary>
        /// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, out Milligrams result)
    	{
    		return TryParse(value, null, out result);
    	}
    
    	#endregion
    
        #region IMass Members
    
    	/// <summary>
        /// Gets this value as an unboxable property
        /// </summary>
        Mass IMass.Mass
        {
            get { return this; }
        }
    
        #endregion
    }
}
