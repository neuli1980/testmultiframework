using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int TestFunction()
        {
#if NETSTANDARD2_0 || NETSTANDARD2_1
            return 3;
#elif NET461 || NET462
            return 8;
#else
            return 4;
#endif
        }
    }
}
