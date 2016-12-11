# Ethica.Measures #
Imported from [Ethica Measures - CodePlex](http://measures.codeplex.com/ "Ethica Measures - CodePlex")

## Project Description ##

Simple .NET 4 library of types to represent various units of measure. 

Currently 3 categories of measurement are supported: Length, Mass and Volume.

Each category exposes the following:

1. An archetype which can represent any unit of measure in the category.
1. Specific types to represent each specific unit of measure.
1. `TypeDescriptors` for each measurement type to support conversion.
1. A `FormatProvider`, responsible for producing and parsing text strings.
1. A resource file, containing localizable formatting representations.

The source code for the above types is entirely generated using T4 templates, which allow new categories and new units of measure to be implemented with just a single line of code.

## Basic usage and syntax ##

### Using uom-specific types and implicit value conversions: ###
    var oneThousandMils = new Millimeters(1000);
    Meters oneMeter = oneThousandMils;  	// implcit conversion from Millimeters to Meters.
    val valueOfOneMeter = oneMeter.Value;   // valueOfOneMeter = 1
    
### Using archetypes with specific types: ###
    Length oneMile = new Length(1, LengthUnit.Miles);
    Length onePointSixKilos = oneMile.ConvertTo(LengthUnit.Kilometers);  
    // onePointSixKilos.Value == 1.609344
    
    // or...
    Kilometers asKilometers = oneMile;  
    // onePointSixKilos.Value == asKilometers.Value
    
### Basic Math ###
    var oneMile = new Length(1, LengthUnit.Miles);
    var twoMiles = oneMile * 2;
    var twoMilesOneYard = twoMiles + new Yard(1);

### ToString
    // String Formats include all .NET "Standard Numeric Format Strings", as well as:
    // g: condensed general representation - i.e   5m,  1mm, 7Km, etc.
    // G: expanded general representation - i.e. 5 meters, 1 millimeter, 7 kilometers
    // u: condensed unit of measure name - i.e. m, mm, Km.
    // U: expanded unit of measure name - i.e. meters, millimeter, kilometers
    
    var fiveKilometers = new Kilometers(5);
    Console.WriteLine( fiveKilometers.ToString() );   // Output : "1Km"
    
    var oneMile = new Length(1, LengthUnit.Miles);
    Console.WriteLine( oneMile.ToString("G"); // Output: "1 mile"
    
    var twoMiles = new Miles(2);
    Console.WriteLine( oneMile.ToString("G"); // Output: "2 miles"   - note plural naming
    
    Kilometers asKilometers = twoMiles;
    Console.WriteLine( "{0:u}", asKilometers);  // Outputs unit of measure (short): "Km"
    Console.WriteLine( "{0:U}", asKilometers); // Outputs unit of measure (long): "Kilometers"
    
    Console.WriteLine( "{0:G}", asKilometers); // Outputs "3.218688 Kilometers"
    Console.WriteLine( "{0:#.#}", asKilometers);   // Outputs "3.2"
    Console.WriteLine( "{0:#.#} {0:U}", asKilometers);   // Outputs "3.2 Kilometers"
    

All string representations can be parsed back to values.

### Modifying string formatting and parsing ###

There are three points of access for modifying how formatted strings are produced:

1. Write custom format strings when calling the `ToString` method. This is the simplest means of changing the resultant strings.
1. Write your own `FormatProvider` class, and pass it as an argument to the `ToString` method.
1. Modify the resource file for the unit of measure.

The default `ToString` method always uses the format provider that is defined for the measurement category, and this format provider always uses resource strings to produce string values. The resource keys are always:

 * MeasureTypeNameSingle : The singular expanded unit of measure name - e.g. kilogram or pound or cubic meter
 * MeasureTypeNamePlural : The plural expanded unit of measure name - e.g. kilograms or pounds or cubic meters
 * MeasureTypeNameShort : The condensed unit of measure name - e.g. kg or lbs or cm3
 * MeasureTypeNameLongFormat : The custom format string used when "G" is specified - usually `"{0} {0:U}"`, which produces 1 kilogram, 5 pounds, etc..
 * MeasureTypeNameShortFormat : The custom format string used when "g" is specified - usually `"{0}{0:u}"`, which produces 1kg, 5lbs, etc..

Also, to modify string parsing behavior, each unit of measure has a corresponding regular expression, housed under the resource key MeasureTypeNameRegex

## References ##
 - [Ethica Measures - CodePlex](http://measures.codeplex.com/ "Ethica Measures - CodePlex")

