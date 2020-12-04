using System;


class Text02
{
    public static void Main()
    {
        // int型で宣言
        uint i = 0x00;

        // for (初期化子;条件式(継続条件);反復子)
        for (i = 0; ; i++)
        {
            i = i & 0x0F;
            Console.WriteLine("i = {0}", i);
        }// End of for i
    }// End of main
}// End of class

