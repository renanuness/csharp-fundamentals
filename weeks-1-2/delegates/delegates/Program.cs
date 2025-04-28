using SimpleDelegate;

static void DisplayDelegateInfo(Delegate delegateObj)
{
    foreach(Delegate d in delegateObj.GetInvocationList())
    {
        Console.WriteLine("Method name: {0}",d.Method);
        Console.WriteLine("Type Name: {0}", d.Target);
    }
}
var simpleMath = new SimpleMath();
BinaryOp op = new BinaryOp(simpleMath.Add);
op += (int a, int b) =>
{
    return a * b;
};

DisplayDelegateInfo(op);
Console.WriteLine("10 + 10 = {0}", op(10, 10));



public delegate int BinaryOp(int a, int b);


