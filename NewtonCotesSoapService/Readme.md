# Newton-Cotes SOAP Microservice

Этот микросервис предоставляет API для численного интегрирования функций с использованием метода Ньютона-Котеса (формула трапеций). Сервис реализован как SOAP-сервер на базе ASP.NET.

---

## **Как использовать**
### **1. Запуск сервиса**
```bash
git clone https://github.com/Binarer/NewtonCotes/newton-cotes-soap-service.git
cd newton-cotes-soap-service
dotnet run
```

### **2. Пример запроса**
Отправьте SOAP-запрос для вычисления интеграла функции x^2 на интервале [0, 1] с 100 интервалами:

```xml
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/">
   <soapenv:Header/>
   <soapenv:Body>
      <tem:Integrate>
         <tem:functionExpression>x^2</tem:functionExpression>
         <tem:a>0</tem:a>
         <tem:b>1</tem:b>
         <tem:n>100</tem:n>
      </tem:Integrate>
   </soapenv:Body>
</soapenv:Envelope>
```
### **3. Пример ответа**
После обработки запроса сервис вернет результат интегрирования:
```xml
<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
   <soap:Body>
      <IntegrateResponse xmlns="http://tempuri.org/">
         <IntegrateResult>0.33335</IntegrateResult>
      </IntegrateResponse>
   </soap:Body>
</soap:Envelope>
```