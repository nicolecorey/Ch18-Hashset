namespace HashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> USsports = new HashSet<string>();
            USsports.Add("Basketball");
            USsports.Add("Volleyball");
            USsports.Add("Baseball");
            USsports.Add("Football");
            USsports.Add("Ice Hockey");

            HashSet<string> CANSports = new HashSet<string>();
            CANSports.Add("Ice Hockey");
            CANSports.Add("Curling");
            CANSports.Add("Rugby");
            CANSports.Add("Golf");
            CANSports.Add("Lacrosse");

            HashSet<string> OlympicSports = new HashSet<string>();
            OlympicSports.Add("Skiing");
            OlympicSports.Add("Surfing");
            OlympicSports.Add("Fencing");
            OlympicSports.Add("Volleyball");
            OlympicSports.Add("Track");

            Console.WriteLine("United States and Canadian Sports");
            USsports.UnionWith(CANSports);
            foreach (string sports in USsports)
            {
                Console.WriteLine(sports);
            }
            Console.WriteLine();

            Console.WriteLine("Sports in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = USsports;
            bothLists.IntersectWith(OlympicSports);
            foreach (string sports in bothLists)
            {
                Console.WriteLine(sports);
            }
        }
    }
}