{
    class Program : Capacity
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            Names.Add("Razer Viper Mini");
            Names.Add("Logitech G304");
            Names.Add("ZygenNP - 01");
            Console.WriteLine("Number of Items in the List is:" + Names.Count);
            Console.WriteLine("Capacity of the List is:" + Names.Capacity);
        }
    }
}       