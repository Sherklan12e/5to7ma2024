namespace hola;

public class Persona
{
    public string Nombre {get;set;}="";
    public int Altura {get; set;}

    public int Edad {get; set;}
    public string Color {get; set;}="";
    
    public void Biografia(){
        Console.WriteLine($"Hola me llamo {Nombre} mido {Altura} y tengo {Edad} Mi color favorito es {Color}");
    }

}
   