namespace Examples;

public sealed class ThreadSafeSingleton
{
  private static ThreadSafeSingleton? s_instance;
  private static readonly object Lock = new();

  public static ThreadSafeSingleton Instance
  {
    get
    {
      lock (Lock)
      {
        return s_instance ??= new ThreadSafeSingleton();
      }
    }
  }

  private ThreadSafeSingleton()
  {
    Console.WriteLine($"{nameof(ThreadSafeSingleton)} instance created");
  }
}