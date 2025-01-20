namespace MVCPracticeLesson1.Services
{
    public class Calculate : ICalculate
    {
        public decimal Data { get; set; }

        public decimal Calculator(decimal value)
        {
            return Data += 100;
        }
    }
}