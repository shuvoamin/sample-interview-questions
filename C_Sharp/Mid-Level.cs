// what cold go wrong here
static int Calculate (int a, int b, int c) 
{
    return (a * b) / c;
}

// why it's printing "1,2,3"
static void StringManipulation () 
{
    var s = "1,2,3";
    s.Replace ("1", "2");

    Console.WriteLine (s);
}

// what could go wrong here
static void Looping () 
{
    var list = new [] { "a", "b", "c" };

    for (int i = 0; i < list.Length; i++)
        Console.WriteLine (list[i]);
}

// why it won't print 100, and how would you fix it
static void NumberPrinter () 
{
    var x = 0;

    for (int i = 0; i < 100; i++) 
    {
        var t = new Thread (s => 
        {
            x++;
        });

        t.Start ();
    }

    Console.WriteLine (x);
}

// how to improve this code
static int UserInputParser (string s) 
{
    try 
    {
        return int.Parse (s);
    } 
    catch (Exception) 
    {
        throw;
    }
}

// how to improve this code
static void UnnecessaryBoxing123 () 
{
    var data = new List<object> () { 1, 2, 3 };

    foreach (var o in data)
        Console.WriteLine (o);
}

// how would you optimize this code
static string BigListPrinter (List<string> bigListString) 
{
    string s = string.Empty;

    foreach (var i in bigListString)
        s += i + ",";

    return s;
}

// what is difference between two throwing mechanism in catch block
static void ExceptionHandling()
{
    try
    {

    }
    catch (Exception ex)
    {
        //throw ex;
        //throw;
    }

}

static Dictionary<string, string> _cache = new Dictionary<string, string> ();
// how to make this method thread safe
static void UnsafeThreading (string key, string value) 
{
    _cache[key] = value;
}

// what generic contraint would you use to 
// uncomment body of the code and compile this method
static void GenericCondimentPasser<T> () 
{
    //var t = new T();
}