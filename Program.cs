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

         int TopRight1 = x1 + w1 + h1;
         int TopLeft1 = x1 -w1 + h1;
         int BotRight1 = x1 + w1 - h1;
         int BotLeft1 = x1 - w1 - h1;
         int TopRight2 = x2 + w2 + h2;
         int TopLeft2 = x2 -w2 + h2;
         int BotRight2 = x2 + w2 - h2;
         int BotLeft2 = x2 - w2 - h2;
 
Console.WriteLine("จงมีความสุขกาย สุขใจ รักษาตนให้พ้นจากทุกข์ภัยทั้งสิ้นเถิด");

    }
}