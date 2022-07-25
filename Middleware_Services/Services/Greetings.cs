namespace Middleware_Services.Services
{
    public abstract class Greetings
    {
        public virtual void Greet()
        {
            if(DateTime.Now < new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,12,0,0))
            {
                Console.WriteLine("Good Morning to you!");
            }
            else
            {
                Console.WriteLine("Have a great rest of the day!");
            }
        }
    }
}
