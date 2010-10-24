// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Volumes
{
using System;
    using System.ComponentModel;
    
    [TypeConverter(typeof(CubicFeetConverter))]
    public partial struct CubicFeet :
    	IVolume,
    	IFormattable,
    	IEquatable<Volume>,
        IEquatable<Liters>,
        IEquatable<CubicMeters>,
        IEquatable<CubicCentimeters>,
        IEquatable<CubicFeet>,
        IEquatable<CubicInches>,
        IEquatable<CubicYards>,
        IEquatable<FluidOuncesUK>,
        IEquatable<FluidOunces>,
        IEquatable<PintsUK>,
        IEquatable<Pints>,
        IEquatable<QuartsUK>,
        IEquatable<Quarts>,
        IEquatable<GallonsUK>,
        IEquatable<Gallons>,
        IComparable<Liters>,
        IComparable<CubicMeters>,
        IComparable<CubicCentimeters>,
        IComparable<CubicFeet>,
        IComparable<CubicInches>,
        IComparable<CubicYards>,
        IComparable<FluidOuncesUK>,
        IComparable<FluidOunces>,
        IComparable<PintsUK>,
        IComparable<Pints>,
        IComparable<QuartsUK>,
        IComparable<Quarts>,
        IComparable<GallonsUK>,
        IComparable<Gallons>
    {
    	public static readonly decimal LitersPerUnit = 28.316846592M;
    	public static readonly decimal UnitsPerLiters = 0.0353146667214885902504380104M;
    
    	#region Fields
    
        /// <summary>
        /// The value of the Volume represented by RelativeUnits
        /// </summary>
        readonly decimal _value;
    
        #endregion
    
    	#region Properties
    
        /// <summary>
        /// The value of the Volume represented by RelativeUnits
        /// </summary>
        public decimal Value { get { return _value; } }
        
    	#endregion
    
    	public CubicFeet(decimal value)
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
            var other = obj as IVolume;
            if (other != null)
                return Equals(other.Volume);
    
            return false;
        }
    
        /// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(Volume other)
        {
            return other.ConvertTo(VolumeUnit.CubicFeet).Value == this.Value;
        }
    
    	/// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(CubicFeet other)
        {
            return Value.Equals(other.Value);
        }
    
    	public bool Equals(Liters other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(CubicMeters other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(CubicCentimeters other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(CubicInches other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(CubicYards other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(FluidOuncesUK other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(FluidOunces other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(PintsUK other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(Pints other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(QuartsUK other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(Quarts other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(GallonsUK other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public bool Equals(Gallons other)
        {
            return Equals(((CubicFeet)other));
        }	
    								
    	public static bool operator == (CubicFeet arg1, CubicFeet arg2)
    	{
    		return arg1.Equals(arg2);
    	}
    
    	public static bool operator != (CubicFeet arg1, CubicFeet arg2)
    	{
    		return !arg1.Equals(arg2);
    	}
    
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    
    	#endregion Equality
    
    	#region Comparable
    		
        public static bool operator <(CubicFeet arg1, CubicFeet arg2)
        {
            return arg1.CompareTo(arg2) == -1;
        }
    
        public static bool operator >(CubicFeet arg1, CubicFeet arg2)
        {
            return arg1.CompareTo(arg2) == 1;
        }
    
    	public int CompareTo(Volume other)
        {
            return Value.CompareTo(other.ConvertTo(VolumeUnit.CubicFeet).Value);
        }
    
    	public int CompareTo(CubicFeet other)
        {
            return Value.CompareTo(other.Value);
        }
    
    	public int CompareTo(Liters other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(CubicMeters other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(CubicCentimeters other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(CubicInches other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(CubicYards other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(FluidOuncesUK other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(FluidOunces other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(PintsUK other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(Pints other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(QuartsUK other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(Quarts other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(GallonsUK other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	public int CompareTo(Gallons other)
        {
            return CompareTo((CubicFeet)other);
        }	
    								
    	#endregion Comparable
    
    	#region Implicit Type Casting
    
    	public static implicit operator CubicFeet (Volume obj)
        {
    		return new CubicFeet(obj.ConvertTo(VolumeUnit.CubicFeet).Value);
        }	
    
    	public static implicit operator Volume(CubicFeet obj)
        {
    		return new Volume(obj.Value, VolumeUnit.CubicFeet);
        }	
    
    	public static implicit operator CubicFeet(Liters obj)
        {
    		return new CubicFeet(obj.Value * Liters.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(CubicMeters obj)
        {
    		return new CubicFeet(obj.Value * CubicMeters.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(CubicCentimeters obj)
        {
    		return new CubicFeet(obj.Value * CubicCentimeters.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(CubicInches obj)
        {
    		return new CubicFeet(obj.Value * CubicInches.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(CubicYards obj)
        {
    		return new CubicFeet(obj.Value * CubicYards.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(FluidOuncesUK obj)
        {
    		return new CubicFeet(obj.Value * FluidOuncesUK.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(FluidOunces obj)
        {
    		return new CubicFeet(obj.Value * FluidOunces.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(PintsUK obj)
        {
    		return new CubicFeet(obj.Value * PintsUK.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(Pints obj)
        {
    		return new CubicFeet(obj.Value * Pints.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(QuartsUK obj)
        {
    		return new CubicFeet(obj.Value * QuartsUK.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(Quarts obj)
        {
    		return new CubicFeet(obj.Value * Quarts.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(GallonsUK obj)
        {
    		return new CubicFeet(obj.Value * GallonsUK.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicFeet(Gallons obj)
        {
    		return new CubicFeet(obj.Value * Gallons.LitersPerUnit * CubicFeet.UnitsPerLiters);
        }	
    			
    	#endregion
    
    	#region ToString
    
    	public string ToString(string format, IFormatProvider formatProvider)
        {
    		var provider = VolumeFormatProvider.GetInstance(formatProvider);
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
        /// Attempts to parse a string into a CubicFeet value 
        /// </summary>
    	/// <param name="formatProvider">The format provider to use for parsing</param>
    	/// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, IFormatProvider formatProvider, out CubicFeet result)
    	{
    		var provider =  VolumeFormatProvider.GetInstance(formatProvider);
    			
    		Volume distanceResult;
    		if(provider.TryParse(value, VolumeUnit.CubicFeet, out distanceResult))
    		{
    			result = distanceResult;
    			return true;				
    		}
    
    		result = default(CubicFeet);
    		return false;
    	}
    
    	/// <summary>
        /// Attempts to parse a string into a CubicFeet value 
        /// </summary>
        /// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, out CubicFeet result)
    	{
    		return TryParse(value, null, out result);
    	}
    
    	#endregion
    
        #region IVolume Members
    
    	/// <summary>
        /// Gets this value as an unboxable property
        /// </summary>
        Volume IVolume.Volume
        {
            get { return this; }
        }
    
        #endregion
    }
}
