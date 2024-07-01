namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("aa", "ab"));
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {

            Dictionary<char, int> magazineMap = new Dictionary<char, int>();

            foreach (var c in magazine)
            {
                if (!magazineMap.ContainsKey(c))
                {
                    magazineMap.TryAdd(c, 1);
                }
                else
                {
                    magazineMap[c]++;
                }
            }

            foreach (var c in ransomNote)
            {
                if (!magazineMap.ContainsKey(c) || magazineMap[c] <= 0)
                {
                    return false;
                }
                magazineMap[c]--;
            }

            return true;    

        }


    }
}
