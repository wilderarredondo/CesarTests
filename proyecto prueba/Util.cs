namespace proyecto_prueba
{
    public static class Utils
    {
        public static bool Between(this int number, int number2, int number3)
        {
            return number >= number2 && number < number3;
        }
    }
}