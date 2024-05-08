
class Rect
{
    protected float length;
    protected float width;

    public void rectInit(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    public float area
    {
        get
        {
            return length * width;
        }
    }

    public float circum
    {
        get
        {
            return 2 * length + 2 * width;
        }
    }
}

class Cuboid : Rect
{
    private float height;

    public void cubeInit(float length, float width, float height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public float volume
    {
        get
        {
            return length * height * width;
        }
    }

    public float surfaceArea
    {
        get
        {
            return 2 * (length * width + length * height + width * height);
        }
    }
}

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            Console.Write("请输入矩形长：");
            float length = float.Parse(Console.ReadLine());
            Console.Write("请输入矩形宽：");
            float width = float.Parse(Console.ReadLine());
            Rect rect = new Rect();
            rect.rectInit(length, width);
            Console.Write("解：矩形面积为");
            Console.Write(rect.area.ToString());
            Console.Write("，周长为");
            Console.WriteLine(rect.circum.ToString());


            Console.WriteLine("\n===在此基础上构造矩体===\n");

            Console.Write("请输入矩体高：");
            float height = float.Parse(Console.ReadLine());
            Cuboid cube = new Cuboid();
            cube.cubeInit(length, width, height);
            Console.Write("解：矩体面积为");
            Console.Write(cube.surfaceArea.ToString());
            Console.Write("，体积为");
            Console.WriteLine(cube.volume.ToString());

            Console.ReadKey();
        }
    }
}