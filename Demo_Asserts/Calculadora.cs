namespace Demo_Asserts
{
    public class Calculadora
    {

        public int SomarInteiros(int num1, int num2)
        {
            return num1 + num2;
        }

        public double SomarDecimais(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num1 > 100)
                throw new System.ArgumentOutOfRangeException("Erro de teste");

            return num1 / num2;
        }

    }
}
