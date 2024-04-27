class Building(double length, double width, double height, double price)
{
    private double length = length;
    private double width = width;
    private double height = height;
    private double price = price;

    public double area
    {
        get
        {
            return this.length * this.width * this.height;
        }
    }

    public double money
    {
        get
        {
            return this.length * this.width * this.height * this.price;
        }
    }
}

namespace MyNamespace
{
     class MyClass
     {
         static void Main()
         {
            Console.Write("请输入楼房长（米）：");
            double length = double.Parse(Console.ReadLine());
            Console.Write("请输入楼房宽（米）：");
            double width = double.Parse(Console.ReadLine());
            Console.Write("请输入楼层数（层）：");
            double heigth = double.Parse(Console.ReadLine());
            Console.Write("请输入楼单价（万）：");
            double price = double.Parse(Console.ReadLine());
            Building build = new Building(length, width, heigth, price);

            Console.WriteLine("======以下是输出======");
            Console.WriteLine();
            Console.Write("楼房总面积为（平方）：");
            Console.WriteLine(build.area.ToString());
            Console.Write("楼房总价格为（万元）：");
            Console.WriteLine(build.money.ToString());

            Console.ReadKey();
        }
     }
}