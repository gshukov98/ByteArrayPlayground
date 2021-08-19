using System;

namespace ByteArrayPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var i = 2147483647;
            var resultBytes = ConvertIntToByteArray(i);
            Console.WriteLine($"input: {i} bytes: {BitConverter.ToString(resultBytes)}");

            var byteToInt = ConvertByteArrayToInt(resultBytes);
            Console.WriteLine($"input: {BitConverter.ToString(resultBytes)} int: {byteToInt}");

            Console.ReadLine();
        }

        public static byte[] ConvertIntToByteArray(int param)
        {
            return BitConverter.GetBytes(param);
        }
        public static int ConvertByteArrayToInt(byte[] param)
        {
            return BitConverter.ToInt32(param, 0);
        }
    }
}
