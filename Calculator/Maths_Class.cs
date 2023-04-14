class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Se declara el valor por defecto sin unvalor ya que este servira como el operador que almacene el resultado
                                    // , de lo contrario se presentara un error al dividir.

        // Usa un Switch para operar realizar las operaciones que seleccione el usuario
        switch (op)
        {
            case "s":
                result = num1 + num2;
                break;
            case "r":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
}
