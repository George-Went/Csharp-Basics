namespace Types;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TYPES ------------------");

        // Interger 
        // byte (is unsigned)
        byte aSingleByte = 255;
        Console.WriteLine(aSingleByte);

        // short
        byte aShort = 12;
        Console.WriteLine(aShort);

        // int 
        int aInt = 1123123;
        Console.WriteLine(aInt);

        // long
        long aLong = -121312321;
        Console.WriteLine(aLong);

        // sbyte (signed byte)
        byte aSbyte = 12;
        Console.WriteLine(aSbyte);


        // Unsigned 
        // ushort 
        ushort aUshort = 12;
        Console.WriteLine(aUshort);

        // uint 
        uint aUint = 12;
        Console.WriteLine(aUint);

        // ulong
        ulong aUlong = 12;
        Console.WriteLine(aUlong);


        // Binary and Hex ------------------
        int binary = 0b0110101;
        Console.WriteLine(binary);

        int hexadecimal = 0xFF00FF;
        Console.WriteLine(hexadecimal);

        // Floating Point --------------------
        float aFloat = 1.2f;
        Console.WriteLine(aFloat);

        // Double
        double aDouble = 1.54;
        Console.WriteLine(aDouble);

        // decimal 
        decimal aDecimal = 1.544353m;
        Console.WriteLine(aDecimal);

    }

}
