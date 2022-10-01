class Perrito:Perro{
    public override void nacer()
    {
        Console.WriteLine("Hola!, soy un perrito, acabo de nacer..!");
    }
    public override void caminar()
    {
        //base.caminar();
        Console.WriteLine("Soy un perrito y camino despacio");
    }
    public override void crecer()
    {
        Console.WriteLine("Soy un perrito. Estoy creciendo!");
    }
}