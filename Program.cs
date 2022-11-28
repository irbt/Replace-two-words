namespace Program
{
    class Replace
    {
        public static void Main()
        {
            static void ReplaceWords(string s, char c)
            {
                string[] MyString =  s.Split(c);
                Console.WriteLine(MyString[1] + c + MyString[0]);
            }
            ReplaceWords("trolling.master", '.');
            ReplaceWords("abc_xyz", '_');
        }
    }
}