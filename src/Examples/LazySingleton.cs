namespace Examples;

public sealed class LazySingleton
{
  private static readonly Lazy<LazySingleton> Lazy = new(() => new LazySingleton());

  public static LazySingleton Instance
  {
    get => Lazy.Value;
  }

  private LazySingleton()
  {
    Console.WriteLine($"{nameof(LazySingleton)} instance created");
  }
}