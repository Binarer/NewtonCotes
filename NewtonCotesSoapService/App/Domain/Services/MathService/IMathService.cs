using System.ServiceModel;

namespace NewtonCotesSoapService.App.Domain.Services.MathService;

[ServiceContract]
public interface IMathService
{
    [OperationContract]
    double Integrate(string functionExpression, double a, double b, int n);
}