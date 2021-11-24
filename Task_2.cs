namespace Grinding
{
    internal class Task_2
    {
        public static int FindMinimum(int a, int b, int c)
        {
            if (a < b)
                return b;
            else if (a > c)
                return c;
            else
                return a;
        }
    }
}
