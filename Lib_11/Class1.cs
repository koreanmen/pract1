namespace Lib_11
{
    public class Class1
    {
        public static float Mult(int n,string s,out float mult)
        {
            string s1 = "";
            mult = 1; 
            int k;
            for (int i = 0; i < s.Length; i++)
            {

                if (Char.IsNumber(s[i]))
                {
                        s1 += s[i];
                }
                else
                {
                    k = Convert.ToInt32(s1);
                    s1 = "";
                    mult *= k;
                }
            }
            return mult;
        }

        public static void Dif(int n, string s, out float dif)
        {
            string s1 = "";
            dif = 0;
            int k;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                {
                    s1 += s[i];
                }
                else
                {
                    k = Convert.ToInt32(s1);
                    s1 = "";
                    dif -= k;
                }
            }
        }
        public static void Sum(int n, string s, out float sum)
        {
            string s1 = "";
            sum = 0;
            int k;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                {
                    s1 += s[i];
                }
                else
                {
                    k = Convert.ToInt32(s1);
                    s1 = "";
                    sum += k;
                }
            }
        }

    }
}
