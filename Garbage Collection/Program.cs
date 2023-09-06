using System;
using System.Threading;

//ref link:https://www.youtube.com/watch?v=-JOkkn1ET8c&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=41
//

class IntWrapper
{
    public int wrappedInt;
}

class MainClass
{
    static void Main()
    {
        var wrapped1 = new IntWrapper();
        var wrapped2 = new IntWrapper();
        var wrapped3 = new IntWrapper();
        wrapped1.wrappedInt = 1;
        wrapped2.wrappedInt = 2;
        wrapped3.wrappedInt = 3;
        GC.Collect();   // background thread
        wrapped2 = null;
        GC.Collect();   // removes wrapped2 heap output then defragments it with something
    }
}