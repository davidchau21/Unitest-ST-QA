namespace ClassLibrary
{
    public class ClassLibrary
    {
        public long K(long s0, out long sum)
        {
            if (s0 < 1)
            {
                throw new Exception("tong nho hon 1");
            }
            sum = 0;
            long i = 1;
            while (sum <= s0)
            {
                sum += i;
                i++;
            }
            return i;
        }

        public long BinaryToDe(string sbin, out bool isSymmetry)
        {
            long sum = 0;
            long tpow = 1;
            const int MAX_BITS = 16;
            if (sbin.Length > MAX_BITS)
                throw new OverflowException("The number is to big");
            for(int i = sbin.Length - 1;i >= 0; i--)
            {
                if (sbin[i] == '1')
                    sum = sum + tpow;
                else if (sbin[i] != '0')
                    throw new FormatException("Invalid binary format");
               tpow = 2 * tpow;
            }
            string isSym = sum.ToString();
            int n = isSym.Length;

            for (int i = 0; i < n / 2; i++)
                if (isSym[i] != isSym[n - i - 1])
                    isSymmetry = false;
            isSymmetry = true;

            return sum;
        }


    }
}