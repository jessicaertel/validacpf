validacpf
Desafio AZ

Como Executar 🚀

1. Configurar o Projeto 📂
Crie uma nova Azure Function no seu projeto .NET. Você pode fazer isso usando o Azure Functions Core Tools.
func init CPFValidationService --worker-runtime dotnet
cd CPFValidationService
func new --name ValidateCPF --template "HTTP trigger"

2. Executar Localmente 🖥️
Certifique-se de ter o Azure Functions Core Tools instalado e configurado. Para executar localmente, use o comando:
func start

3. Publicar no Azure 🌐

Publicar a Função GET
func azure functionapp publish <GetCPF>

Publicar a Função POST
func azure functionapp publish <PostCPF>

🧐
