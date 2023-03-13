class Program {

    static void Main(string[] args) {
        Console.Write("ตำแหน่งแกนxของประกาศฉบับที่ 1 : ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("ตำแหน่งแกนyของประกาศฉบับที่ 1 : ");
         double y1 = double.Parse(Console.ReadLine());
         Console.Write("ความกว้างของประกาศฉบับที่ 1 : ");
         double w1 = double.Parse(Console.ReadLine());
         Console.Write("ความสูงของประกาศฉบับที่ 1 : ");
         double h1 = double.Parse(Console.ReadLine());
         Console.Write("ตำแหน่งแกนxของประกาศฉบับที่ 2 : ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("ตำแหน่งแกนyของประกาศฉบับที่ 2 : ");
         double y2 = double.Parse(Console.ReadLine());
         Console.Write("ความกว้างของประกาศฉบับที่ 2 : ");
         double w2 = double.Parse(Console.ReadLine());
         Console.Write("ความสูงของประกาศฉบับที่ 2 : ");
         double h2 = double.Parse(Console.ReadLine());

         double TopRightx1 = x1 + w1 + h1;
         double TopLeftx1 = x1 -w1 + h1;
         double BotRightx1 = x1 + w1 - h1;
         double BotLeftx1 = x1 - w1 - h1;
         double TopRightx2 = x2 + w2 + h2;
         double TopLeftx2 = x2 -w2 + h2;
         double BotRightx2 = x2 + w2 - h2;
         double BotLeftx2 = x2 - w2 - h2;
         
         double TopRighty1 = y1 + w1 + h1;
         double TopLefty1 = y1 -w1 + h1;
         double BotRighty1 = y1 + w1 - h1;
         double BotLefty1 = y1 - w1 - h1;
         double TopRighty2 = y2 + w2 + h2;
         double TopLefty2 = y2 -w2 + h2;
         double BotRighty2 = y2 + w2 - h2;
         double BotLefty2 = y2 - w2 - h2;

        if ((BotRightx1 >= TopLeftx2 && BotRightx1 <= TopRightx2 ) || (BotLeftx1 >= TopRightx2 && BotLeftx1 <= TopLeftx1) ) {
            if((BotRighty1 >= TopLefty2 && BotRighty1 <= TopRighty2 ) || (BotLefty1 >= TopRighty2 && BotLefty1 <= TopLefty1)) {
Console.WriteLine("Overlaping");
            } 
        } Console.WriteLine("Not Overlaping");

        if ((BotRightx1 >= TopLeftx2 && BotRightx1 <= TopRightx2 ) || (BotLeftx1 >= TopRightx2 && BotLeftx1 <= TopLeftx1) ) {
            if((BotRighty1 >= TopLefty2 && BotRighty1 <= TopRighty2 ) || (BotLefty1 >= TopRighty2 && BotLefty1 <= TopLefty1)) {
Console.WriteLine("Overlaping");
            } 
        } Console.WriteLine("Not Overlaping");

    }
}