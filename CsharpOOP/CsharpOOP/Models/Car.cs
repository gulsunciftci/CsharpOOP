namespace CsharpOOP.Models
{
    //Class
	public class Car
	{

		//Constructor
		//instance alınma kurallarını belirler
		//nesne oluşturulduğu anda çalışır
		//birden fazla yazılabilir
		//ilk okunan koddur
		public Car()
		{
			ProductionDate = DateTime.Now;
		}
		public Car(string _Brand)
		{
			Brand = _Brand;
		}

		//Property=>arabanın nesi var?(metotlar ve fieldların birleşimi)
		public string Brand { get; set; }
        internal string Model { get; set; }
        private string Color { get; set; }
        public  int Speed { get; set; }
        public int Gear { get; set; }
		public DateTime ProductionDate { get; set; }


		//Metot=>ne yapabilir?
		public void ColorSetting(string color)
        {
            Color = color;
            Console.WriteLine(Color);
        }


        
        
    }
}