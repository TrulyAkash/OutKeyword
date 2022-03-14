using System;

class TestOUT
{
 
    public static void Addition(out int p, ref int q)
    {
        
        p = 30;
        q = 40;
        p += p;
        q += q;
    }

   
    static public void Main()
    {

        
        int i, j=10;           

        
        Addition(out i,ref j); 

        
        Console.WriteLine("The addition of the value is: {0}", i);
        Console.WriteLine("The addition of the value is: {0}", j);
    }

    
}
