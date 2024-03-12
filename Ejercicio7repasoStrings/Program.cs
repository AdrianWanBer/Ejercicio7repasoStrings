namespace Ejercicio6repasoStrings
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Escribe su cadena de texto");
            string cadena = Console.ReadLine();
            string[] cadenaTexto = cadena.Split(" ");
            Console.WriteLine($"La cadena tiene: {cadenaTexto.Length} palabras");
            
            
            /*for(int i = 0; i < cadenaTexto.Length; i++)
            {
                Console.WriteLine(cadenaTexto[i]);
            }*/
        }
    }
}
