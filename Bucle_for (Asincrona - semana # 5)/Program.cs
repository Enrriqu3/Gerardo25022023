// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Datos{
    static void Main(string[] ArraySegment){
        Console.WriteLine("Ingrese el primer numero");
        int PrimerNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el ultimo numero");
        int UltimoNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Los numeros pares entres {PrimerNum} y {UltimoNum} son:");
        for (int i = PrimerNum; i <= UltimoNum ; i++){
            if (i % 2 == 0){
                Console.WriteLine(i);
            }
        }
    }
}







