using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using CPFValidationService.Models; // Assumindo que você tenha uma classe de modelo

public static class ValidateCPF
{
    [FunctionName("PostCPF")]
    public static async Task<IActionResult> RunPost(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "cpf")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");

        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        dynamic data = JsonConvert.DeserializeObject(requestBody);
        string cpf = data?.cpf;

        // Aqui você adiciona sua lógica de validação de CPF
        bool isValid = ValidateCpf(cpf); 

        if (!isValid)
        {
            return new BadRequestObjectResult("Invalid CPF.");
        }

        return new OkObjectResult(new { cpf = cpf, isValid = true });
    }

    private static bool ValidateCpf(string cpf)
    {
        // Implementar a lógica de validação de CPF
        return true; // Simulação
    }
}
