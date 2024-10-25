namespace Lib_11
{
    public class Class1
    {
        public static float Func(int n,string s,out float mult)
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

    }
}
