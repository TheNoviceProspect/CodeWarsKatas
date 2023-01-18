namespace Abbrev {
    internal class Kata
    {
        public static string AbbrevName(string name)
        {
            var shortname = name.Split(' ',2);
            var abbreviation = shortname[0].ToUpper()[0]+"."+shortname[1].ToUpper()[0];
            return abbreviation;
        }

        private static void Main(string[] args)
        {
            Console.Write("Please input a full name (Firstname Surname) => ");
            var input = Console.ReadLine();
            if (input != "") Console.WriteLine(AbbrevName(input));
        }
    }
}
