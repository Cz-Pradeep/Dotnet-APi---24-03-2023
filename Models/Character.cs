namespace Dotnet_Demo.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
         public double longtitude { get; set; } = 51.9498;

        public double lattitude { get; set; } = 4.4794;
        public double velocity { get; set; } = 10.0;
    }
}
