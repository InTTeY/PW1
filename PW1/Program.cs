using System;
namespace PW1
{
    class program
    {
        public static double CalculateTime(double distance, double speed)
        {
            return (distance / speed) * 60;
        }
        static void Main()
        {
            double Speed1; double Speed2; double Speed3; double Speed4;
            string Name1; string Name2; string Name3; string Name4;

            Cars car1 = new Cars("Koenigsegg Jesko Absolut", 531);
            Speed1 = car1.CarSpeed;
            Name1 = car1.CarName;
            car1.CarInfo();
            Cars car2 = new Cars("Hennessey Venom F5");
            car2.CarSpeed = 500.5;
            Speed2 = car2.CarSpeed;
            Name2 = car2.CarName;
            car2.CarInfo();
            Cars car3 = new Cars("Bugatti Chiron Super Sport 300+", 490.5);
            Speed3 = car3.CarSpeed;
            Name3 = car3.CarName;
            car3.CarInfo();
            Cars car4 = new Cars("SSC Tuatara");
            car4.CarSpeed = 460;
            Speed4 = car4.CarSpeed;
            Name4 = car4.CarName;
            car4.CarInfo();

            double distance = 500;

            double Time1; double Time2; double Time3; double Time4;
            Time1 = CalculateTime(distance, Speed1);
            Time2 = CalculateTime(distance, Speed2);
            Time3 = CalculateTime(distance, Speed3);
            Time4 = CalculateTime(distance, Speed4);

            string Name; double Speed; double Time;
            if (Time1 < Time2) { Time = Time1; Name = Name1; Speed = Speed1;}
            else { Time = Time2; Name = Name2; Speed = Speed2; }
            if (Time > Time3) { Time = Time3; Name = Name3; Speed = Speed3; }
            if (Time > Time4) { Time = Time4; Name = Name4; Speed = Speed4; }

            Console.WriteLine("\nНазвание машины-победителя: {0}\nМаксимальная скорость машины: {1} км/ч\nВремя преодоления пути: {2} минут\n", Name, Speed, Time);
        }
    }

    class Cars
    {
        public string CarName; 
        public double CarSpeed;

        public Cars(string carName)
        {
            this.CarName = carName;
        }
        public Cars(string carName, double CarSpeed)
        {
            this.CarName = carName;
            this.CarSpeed = CarSpeed;
        }
        public void CarInfo()
        {
            Console.WriteLine("Название машины: {0}\nСкорость: {1} км/ч\n", CarName, CarSpeed);
        }
    }
}