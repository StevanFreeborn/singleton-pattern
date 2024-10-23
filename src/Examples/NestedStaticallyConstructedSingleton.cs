namespace Examples;

public sealed class NestedStaticallyConstructedSingleton
{
  // if this field is accessed it will not trigger
  // the instantiation of the singleton instance that
  // is being provided by the nested class
  public static readonly string StaticField = "Static field";

  public static NestedStaticallyConstructedSingleton Instance
  {
    get => Nested.Instance;
  }

  // this nested class allows us to use a static constructor
  // to initialize the singleton instance that is exposed
  // through the Instance property on the outer class but maintain
  // the lazy initialization behavior
  private class Nested
  {
    internal static readonly NestedStaticallyConstructedSingleton Instance = new();

    static Nested()
    {
      Console.WriteLine($"{nameof(Nested)} instance created");
    }
  }

  private NestedStaticallyConstructedSingleton()
  {
    Console.WriteLine($"{nameof(NestedStaticallyConstructedSingleton)} instance created");
  }
}