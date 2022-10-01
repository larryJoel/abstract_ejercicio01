abstract class Perro: Animal{
    public override void comer()
    {
        Console.WriteLine("Soy un perro y esoy comiendo");
    }
    public override void caminar()
    {
        Console.WriteLine("Soy un perro y estoy corriendo");
    }
    public override void morir()
    {
        Console.WriteLine("Estoy muriendo, me voy....!!!");
    }
}