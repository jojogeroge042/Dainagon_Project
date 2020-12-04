using System;
class KADAI_001
{
    public static void Main()
    {
        string ReadValue;
        int loopCnt;
        Console.WriteLine("*******************************************");
        Console.WriteLine("**店員: ようこそ大納言ショップへ         **");
        Console.WriteLine("*******************************************");
        for ( loopCnt = 0; loopCnt != 0xFF ; )
        {
            Console.WriteLine("**店員: なにをお求めですか？　　         **");
            Console.WriteLine("**    : 1. PASA     2500\\                **");
            Console.WriteLine("**    : 2. Perta    2500\\                **");
            Console.WriteLine("*******************************************");
            Console.WriteLine("**                                   :客 **");
            ReadValue = Console.ReadLine();
            Console.WriteLine("*******************************************");
            switch (ReadValue)
            {
                case "1":
                    Console.WriteLine("**店員: PASAですね。2500円です            **"); ;
                    loopCnt = 0xFF;
                    break;
                case "2":
                    Console.WriteLine("**店員: Pertaですね。2500円です          **");
                    loopCnt = 0xFF;
                    break;
                default:
                    Console.WriteLine("**店員: 申し訳ございません。             **");
                    Console.WriteLine("**    : 聞き取れず                       **");
                    continue;
            }
        }// End of for
        Console.WriteLine("*******************************************");
    }// End of main
}// End of KADAI_001