namespace Examples;

public sealed class NaiveSingleton
{
  private static NaiveSingleton? s_instance;

  public static NaiveSingleton Instance
  {
    // in a multithreaded environment, this can create multiple instances
    // because the check can be reached by multiple threads concurrently
    // resulting in multiple instantiations
    get => s_instance ??= new NaiveSingleton();
  }

  private NaiveSingleton()
  {
    Console.WriteLine($"{nameof(NaiveSingleton)} instance created");
  }
}