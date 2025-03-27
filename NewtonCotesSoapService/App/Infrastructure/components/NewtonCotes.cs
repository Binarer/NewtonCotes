public class NewtonCotes
{

    public double TrapezoidalRule(Func<double, double> function, double a, double b, int n)
    {
        if (n <= 0) throw new ArgumentException("Количество интервалов должно быть больше 0.");

        double h = (b - a) / n;
        // Сумма краев
        double integral = 0.5 * (function(a) + function(b)); 

        for (int i = 1; i < n; i++)
        {
            double x = a + i * h;
            integral += function(x);
        }

        integral *= h;
        return integral;
    }
}