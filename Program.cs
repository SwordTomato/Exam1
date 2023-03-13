class Program {

    static void Main(string[] args) {
        Console.Write("ตำแหน่งแกนxของประกาศฉบับที่ 1 : ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("ตำแหน่งแกนyของประกาศฉบับที่ 1 : ");
         int y1 = int.Parse(Console.ReadLine());
         Console.Write("ความกว้างของประกาศฉบับที่ 1 : ");
         int w1 = int.Parse(Console.ReadLine());
         Console.Write("ความสูงของประกาศฉบับที่ 1 : ");
         int h1 = int.Parse(Console.ReadLine());
         Console.Write("ตำแหน่งแกนxของประกาศฉบับที่ 2 : ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("ตำแหน่งแกนyของประกาศฉบับที่ 2 : ");
         int y2 = int.Parse(Console.ReadLine());
         Console.Write("ความกว้างของประกาศฉบับที่ 2 : ");
         int w2 = int.Parse(Console.ReadLine());
         Console.Write("ความสูงของประกาศฉบับที่ 2 : ");
         int h2 = int.Parse(Console.ReadLine());

         int TopRightx1 = x1 + w1 + h1;
         int TopLeftx1 = x1 -w1 + h1;
         int BotRightx1 = x1 + w1 - h1;
         int BotLeftx1 = x1 - w1 - h1;
         int TopRightx2 = x2 + w2 + h2;
         int TopLeftx2 = x2 -w2 + h2;
         int BotRightx2 = x2 + w2 - h2;
         int BotLeftx2 = x2 - w2 - h2;
         
         int TopRighty1 = y1 + w1 + h1;
         int TopLefty1 = y1 -w1 + h1;
         int BotRighty1 = y1 + w1 - h1;
         int BotLefty1 = y1 - w1 - h1;
         int TopRighty2 = y2 + w2 + h2;
         int TopLefty2 = y2 -w2 + h2;
         int BotRighty2 = y2 + w2 - h2;
         int BotLefty2 = y2 - w2 - h2;

        if
Console.WriteLine("จงมีความสุขกาย สุขใจ รักษาตนให้พ้นจากทุกข์ภัยทั้งสิ้นเถิด");

    }
}