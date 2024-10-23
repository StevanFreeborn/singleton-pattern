namespace Examples;

public sealed class StaticallyConstructedSingleton
{
  private static readonly StaticallyConstructedSingleton Singleton = new();

  // if this field is accessed the static constructor will be called
  // which will initialize the singleton instance making this
  // implementation less lazy than maybe desired
  public static readonly string StaticField = "Static field";

  public static StaticallyConstructedSingleton Instance
  {
    // no locking necessary because we are using a language feature
    // called a static constructor
    get => Singleton;
  }

  static StaticallyConstructedSingleton()
  {
    Console.WriteLine($"{nameof(StaticallyConstructedSingleton)} instance created");
  }
}