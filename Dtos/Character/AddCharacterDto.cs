namespace Dotnet_Demo.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Frodo";
   
        public double longtitude { get; set; } = 51.9498;

        public double lattitude { get; set; } = 4.4794;
        public double velocity { get; set; } = 10.0;
    }
}
