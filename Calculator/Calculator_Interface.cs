

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        // Muestra el titulo en pantalla .
        Console.WriteLine("Caculadora desde la consola de C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declara las variables y las coloca en cero.
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            // Pregunta al usuario por el primer numero.
            Console.Write("Teclea un numero, despues preciona enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("No es un valor permitido, teclea un numero entero: ");
                numInput1 = Console.ReadLine();
            }

            // Pregunta al usuario por el segundo numero.
            Console.Write("Teclea el segundo numero y presiona enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("No es un valor permitido, teclea un numero entero: ");
                numInput2 = Console.ReadLine();
            }

            // Ask the user to choose an operator.
            Console.WriteLine("Selecciona  en la lista una operacion a realizan :");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Teclee la opcion que quieres ejecutar ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Este operador resultara en un error matematico.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}