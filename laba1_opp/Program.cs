namespace PhoneApp
{
    class Bicycle
    {
        public string Brand;
        public string Model;
        public int Year;
        public string Type;
        public double Weight; // вага в кг
        public string FrameMaterial;
        public int GearCount;

        public double GetAverageSpeed(double distance, double time)
        {
            return distance / time; // середня швидкість
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть марку велосипеда: ");
            string brand = Console.ReadLine();

            Console.Write("Введіть модель велосипеда: ");
            string model = Console.ReadLine();

            Console.Write("Введіть рік випуску: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введіть тип велосипеда (гірський, міський і т.д.): ");
            string type = Console.ReadLine();

            Console.Write("Введіть вагу велосипеда (в кг): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Введіть матеріал рами: ");
            string frameMaterial = Console.ReadLine();

            Console.Write("Введіть кількість швидкостей: ");
            int gearCount = int.Parse(Console.ReadLine());

            Bicycle bike = new Bicycle();
            bike.Brand = brand;
            bike.Model = model;
            bike.Year = year;
            bike.Type = type;
            bike.Weight = weight;
            bike.FrameMaterial = frameMaterial;
            bike.GearCount = gearCount;

            Console.Write("Введіть пройдену відстань (в км): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Введіть час (в годинах): ");
            double time = double.Parse(Console.ReadLine());

            double averageSpeed = bike.GetAverageSpeed(distance, time);

            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Дані по велосипеду:");
            Console.WriteLine($"Марка: {bike.Brand}");
            Console.WriteLine($"Модель: {bike.Model}");
            Console.WriteLine($"Рік випуску: {bike.Year}");
            Console.WriteLine($"Тип велосипеда: {bike.Type}");
            Console.WriteLine($"Вага: {bike.Weight} кг");
            Console.WriteLine($"Матеріал рами: {bike.FrameMaterial}");
            Console.WriteLine($"Кількість швидкостей: {bike.GearCount}");
            Console.WriteLine($"Середня швидкість: {averageSpeed:F2} км/год");
            Console.ReadKey();
        }
    }
}
