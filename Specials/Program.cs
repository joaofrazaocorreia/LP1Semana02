using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            byte maxByte= byte.MaxValue;
            byte minByte= byte.MinValue;
            Console.WriteLine("The max value of byte is "+maxByte);
            Console.WriteLine("and the minimum is "+minByte+"\n");

            sbyte maxSByte= sbyte.MaxValue;
            sbyte minSByte= sbyte.MinValue;
            Console.WriteLine("The max value of sbyte is "+maxSByte);
            Console.WriteLine("and the minimum is "+minSByte+"\n");

            short maxShort= short.MaxValue;
            short minShort= short.MinValue;
            Console.WriteLine("The max value of short is "+maxShort);
            Console.WriteLine("and the minimum is "+minShort+"\n");

            ushort maxUShort= ushort.MaxValue;
            ushort minUShort= ushort.MinValue;
            Console.WriteLine("The max value of ushort is "+maxUShort);
            Console.WriteLine("and the minimum is "+minUShort+"\n");

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine("The max value of int is "+maxInt);
            Console.WriteLine("and the minimum is "+minInt+"\n");

            uint maxUInt = uint.MaxValue;
            uint minUInt = uint.MinValue;
            Console.WriteLine("The max value of uint is "+maxUInt);
            Console.WriteLine("and the minimum is "+minUInt+"\n");

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("The max value of long is "+maxLong);
            Console.WriteLine("and the minimum is "+minLong+"\n");

            ulong maxULong = ulong.MaxValue;
            ulong minULong = ulong.MinValue;
            Console.WriteLine("The max value of ulong is "+maxULong);
            Console.WriteLine("and the minimum is "+minULong+"\n");

            char maxChar = char.MaxValue;
            char minChar = char.MinValue;
            Console.WriteLine("The max value of char is "+maxChar);
            Console.WriteLine("and the minimum is "+minChar+"\n");

            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;
            Console.WriteLine("The max value of decimal is "+maxDecimal);
            Console.WriteLine("and the minimum is "+minDecimal+"\n");

            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            Console.WriteLine("The max value of float is "+maxFloat);
            Console.WriteLine("and the minimum is "+minFloat+"\n");

            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine("The max value of double is "+maxDouble);
            Console.WriteLine("and the minimum is "+minDouble+"\n");

            double maxInfinity = double.PositiveInfinity;
            double minInfinity = double.NegativeInfinity;

            double NaN1 = maxInfinity / maxInfinity;
            float NaN2 = float.NaN;

            Console.WriteLine("Positive infinity is "+maxInfinity);
            Console.WriteLine("Negative infinity is "+minInfinity);
            Console.WriteLine("and NaN is "+NaN1+" and "+NaN2);


            Console.WriteLine("\n\n\n");


            int intOverflow = maxInt + 1;
            Console.WriteLine("Max value of int + 1 equals "+intOverflow);

            long longOverflow = minLong- 1;
            Console.WriteLine("Min value of long - 1 equals "+longOverflow);

            uint uintOverflow = maxUInt + 43;
            Console.WriteLine("Max value of uint + 43 equals "+uintOverflow);
        }
    }
}
