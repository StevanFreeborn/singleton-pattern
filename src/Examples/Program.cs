using Examples;

// Console.WriteLine("NaiveSingleton example without parallelism");
// var instance1 = NaiveSingleton.Instance;
// var instance2 = NaiveSingleton.Instance;
// var instance3 = NaiveSingleton.Instance;
// Console.WriteLine();

Console.WriteLine($"{nameof(NaiveSingleton)} example with parallelism");
var naiveSingletons = new List<NaiveSingleton>();
Parallel.For(0, 3, _ => naiveSingletons.Add(NaiveSingleton.Instance));
Console.WriteLine();

Console.WriteLine($"{nameof(ThreadSafeSingleton)} example with parallelism");
var threadSafeSingletons = new List<ThreadSafeSingleton>();
Parallel.For(0, 3, _ => threadSafeSingletons.Add(ThreadSafeSingleton.Instance));
Console.WriteLine();

Console.WriteLine($"{nameof(BetterSingleton)} example with parallelism");
var betterSingletons = new List<BetterSingleton>();
Parallel.For(0, 3, _ => betterSingletons.Add(BetterSingleton.Instance));
Console.WriteLine();

Console.WriteLine($"{nameof(StaticallyConstructedSingleton)} example with parallelism");
var staticallyConstructedSingletons = new List<StaticallyConstructedSingleton>();
Parallel.For(0, 3, _ => staticallyConstructedSingletons.Add(StaticallyConstructedSingleton.Instance));
Console.WriteLine();

Console.WriteLine($"{nameof(NestedStaticallyConstructedSingleton)} example with parallelism");
var nestedStaticallyConstructedSingletons = new List<NestedStaticallyConstructedSingleton>();
Parallel.For(0, 3, _ => nestedStaticallyConstructedSingletons.Add(NestedStaticallyConstructedSingleton.Instance));
Console.WriteLine();