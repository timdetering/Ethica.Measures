// <autogenerated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

namespace Ethica.Measurements.Volumes
{
using System;
    using System.ComponentModel;
    
    [TypeConverter(typeof(CubicMetersConverter))]
    public partial struct CubicMeters :
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
    	public static readonly decimal LitersPerUnit = 1000M;
    	public static readonly decimal UnitsPerLiters = 0.001M;
    
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
    
    	public CubicMeters(decimal value)
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
            return other.ConvertTo(VolumeUnit.CubicMeters).Value == this.Value;
        }
    
    	/// <summary>
        /// Equates whether this value is the same as another value.
        /// </summary>
        /// <param name="other">The distance to compare to</param>
        /// <returns>True if both values are equal</returns>
    	public bool Equals(CubicMeters other)
        {
            return Value.Equals(other.Value);
        }
    
    	public bool Equals(Liters other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(CubicCentimeters other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(CubicFeet other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(CubicInches other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(CubicYards other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(FluidOuncesUK other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(FluidOunces other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(PintsUK other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(Pints other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(QuartsUK other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(Quarts other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(GallonsUK other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public bool Equals(Gallons other)
        {
            return Equals(((CubicMeters)other));
        }	
    								
    	public static bool operator == (CubicMeters arg1, CubicMeters arg2)
    	{
    		return arg1.Equals(arg2);
    	}
    
    	public static bool operator != (CubicMeters arg1, CubicMeters arg2)
    	{
    		return !arg1.Equals(arg2);
    	}
    
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    
    	#endregion Equality
    
    	#region Comparable
    		
        public static bool operator <(CubicMeters arg1, CubicMeters arg2)
        {
            return arg1.CompareTo(arg2) == -1;
        }
    
        public static bool operator >(CubicMeters arg1, CubicMeters arg2)
        {
            return arg1.CompareTo(arg2) == 1;
        }
    
    	public int CompareTo(Volume other)
        {
            return Value.CompareTo(other.ConvertTo(VolumeUnit.CubicMeters).Value);
        }
    
    	public int CompareTo(CubicMeters other)
        {
            return Value.CompareTo(other.Value);
        }
    
    	public int CompareTo(Liters other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(CubicCentimeters other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(CubicFeet other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(CubicInches other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(CubicYards other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(FluidOuncesUK other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(FluidOunces other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(PintsUK other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(Pints other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(QuartsUK other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(Quarts other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(GallonsUK other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	public int CompareTo(Gallons other)
        {
            return CompareTo((CubicMeters)other);
        }	
    								
    	#endregion Comparable
    
    	#region Implicit Type Casting
    
    	public static implicit operator CubicMeters (Volume obj)
        {
    		return new CubicMeters(obj.ConvertTo(VolumeUnit.CubicMeters).Value);
        }	
    
    	public static implicit operator Volume(CubicMeters obj)
        {
    		return new Volume(obj.Value, VolumeUnit.CubicMeters);
        }	
    
    	public static implicit operator CubicMeters(Liters obj)
        {
    		return new CubicMeters(obj.Value * Liters.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(CubicCentimeters obj)
        {
    		return new CubicMeters(obj.Value * CubicCentimeters.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(CubicFeet obj)
        {
    		return new CubicMeters(obj.Value * CubicFeet.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(CubicInches obj)
        {
    		return new CubicMeters(obj.Value * CubicInches.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(CubicYards obj)
        {
    		return new CubicMeters(obj.Value * CubicYards.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(FluidOuncesUK obj)
        {
    		return new CubicMeters(obj.Value * FluidOuncesUK.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(FluidOunces obj)
        {
    		return new CubicMeters(obj.Value * FluidOunces.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(PintsUK obj)
        {
    		return new CubicMeters(obj.Value * PintsUK.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(Pints obj)
        {
    		return new CubicMeters(obj.Value * Pints.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(QuartsUK obj)
        {
    		return new CubicMeters(obj.Value * QuartsUK.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(Quarts obj)
        {
    		return new CubicMeters(obj.Value * Quarts.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(GallonsUK obj)
        {
    		return new CubicMeters(obj.Value * GallonsUK.LitersPerUnit * CubicMeters.UnitsPerLiters);
        }	
    			
    	public static implicit operator CubicMeters(Gallons obj)
        {
    		return new CubicMeters(obj.Value * Gallons.LitersPerUnit * CubicMeters.UnitsPerLiters);
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
        /// Attempts to parse a string into a CubicMeters value 
        /// </summary>
    	/// <param name="formatProvider">The format provider to use for parsing</param>
    	/// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, IFormatProvider formatProvider, out CubicMeters result)
    	{
    		var provider =  VolumeFormatProvider.GetInstance(formatProvider);
    			
    		Volume distanceResult;
    		if(provider.TryParse(value, VolumeUnit.CubicMeters, out distanceResult))
    		{
    			result = distanceResult;
    			return true;				
    		}
    
    		result = default(CubicMeters);
    		return false;
    	}
    
    	/// <summary>
        /// Attempts to parse a string into a CubicMeters value 
        /// </summary>
        /// <param name="value">the string to parse</param>
        /// <param name="result">the parsed value</param>
        /// <returns>true, if succesful</returns>
    	public static bool TryParse(string value, out CubicMeters result)
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
