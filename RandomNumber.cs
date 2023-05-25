namespace GameMemorizeNumbers
{
    public class RandomNumber
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public RandomNumber() { }

        public RandomNumber(int id, int value)
        {
            Id = id;
            Value = value;
        }
        
        static public int SetRandomNumber(string diff)
        {
            Random rnd = new Random();
            if (diff == "Normal")
                return rnd.Next(10, 100);
            else if (diff == "Hard")
                return rnd.Next(100, 1000);
            else 
                return rnd.Next(1, 10);
        }

    }

}