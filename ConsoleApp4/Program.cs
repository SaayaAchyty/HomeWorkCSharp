using ConsoleApp4;

public class Program
{
  public static void Main()
    {
        Counter counter = new Counter();
        Handler1 handler1 = new Handler1();
        Handler2 handler2 = new Handler2();
        counter.Notify += handler1.DisplayMessage;
        counter.Notify += handler2.DisplayMessage;
        counter.counter();
    }
}