namespace Examples;

public sealed class BetterSingleton
{
  private static BetterSingleton? s_instance;
  private static readonly object Lock = new();

  public static BetterSingleton Instance
  {
    get
    {
      if (s_instance is null)
      {
        lock (Lock)
        {
          s_instance ??= new BetterSingleton();
        }
      }

      return s_instance;
    }
  }

  private BetterSingleton()
  {
    Console.WriteLine($"{nameof(BetterSingleton)} instance created");
  }
}