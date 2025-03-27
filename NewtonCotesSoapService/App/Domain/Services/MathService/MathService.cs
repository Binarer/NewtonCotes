namespace NewtonCotesSoapService.App.Domain.Services.MathService;

public class MathService : IMathService
{
    private readonly NewtonCotes _newtonCotes = new NewtonCotes();

    public double Integrate(string functionExpression, double a, double b, int n)
    {
        var function = ParseExpression(functionExpression);
        return _newtonCotes.TrapezoidalRule(function, a, b, n);
    }

    private Func<double, double> ParseExpression(string expression)
    {
        if (expression == "x^2") return x => x * x;
        if (expression == "sin(x)") return x => Math.Sin(x);
        if (expression == "cos(x)") return x => Math.Cos(x);

        throw new ArgumentException("Неподдерживаемое выражение.");
    }
}