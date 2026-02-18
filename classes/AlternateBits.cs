namespace ConsoleApp.CodeClass
{
    public class AlternateBits
    {
        //Convert the num into string binary and then loop in the binary string
        //If the just next element i.e i+1 is equal to the i element then it doesnt have alternating bits
        public bool HasAlternatingBits(int n)
        {
            List<char> bin = new List<char>();

            while (n > 0)
            {
                int bit = n % 2;
                bin.Add((char)('0' + bit));
                n /= 2;
            }


            for (int i = 0; i < bin.Count() - 1; i++)
            {
                if (bin[i] == bin[i + 1])
                {
                    return false;
                }
            }


            return true;

        }
    }
}