# 🏢 ConsultaCNPJ - API de Busca de Dados de Empresas

Este é um projeto em **ASP.NET Core MVC** para consulta de informações de empresas através do **CNPJ**, utilizando a API da ReceitaWS. O sistema permite buscar, visualizar e armazenar os dados consultados.

---

## 🚀 **Tecnologias Utilizadas**
- **C# .NET Core**
- **ASP.NET MVC**
- **Entity Framework Core**
- **Armazenamento de informação local (Local Storage)**
- **Newtonsoft.Json** (para manipulação de JSON)
- **HttpClient** (para requisições à API da ReceitaWS)

---

## ⚙️ **Instalação e Configuração**

### **1️⃣ Clone o repositório**
Abra o arquivo appsettings.json e edite a seção "ConnectionStrings" conforme necessário:
```sh
git clone https://github.com/seu-usuario/ConsultaCNPJ.git
cd ConsultaCNPJ
```

### **3️⃣ Instale as dependências**
Abra o arquivo appsettings.json e edite a seção "ConnectionStrings" conforme necessário:
```sh
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CnpjDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### **3️⃣ Instale as dependências**
Caso necessário, instale os pacotes via NuGet:
```sh
dotnet restore
```

---

## ▶️ **Como Rodar o Projeto**

### **1️⃣ Instale as dependências**
Executar no terminal
```sh
dotnet run
```
A aplicação estará disponível em:
```sh
[dotnet run](http://localhost:5027)
```

---

## 🔧 Funcionalidades

<p>✅ Buscar informações de empresas pelo CNPJ</p>
<p>✅ Exibir os dados retornados da API</p>
<p>✅ Salvar as informações na memória do navegador</p>
<p>✅ Tela para visualizar os CNPJs cadastrados</p>

#### **Extras Implementados:**

<p> ✅ Uso de MVC</p>
<p> ✅ Métodos assíncronos (async/await)</p>

## 🛠 **Possíveis Problemas e Soluções**

### **1️⃣ Erro: API retornando JSON vazio**
✔️ Solução: Verifique se o CNPJ consultado é válido e tente outro. A API pode estar bloqueando requisições repetidas.

### **2️⃣ A aplicação não abre no navegador**
✔️ Solução: Verifique a porta no terminal (Now listening on: http://localhost:5177) e acesse a URL correta.

### **3️⃣ Não conseguir pesquisar e armazenar mais de um CNPJ**
⌛ Ainda está em desenvolvimento a correção para este problema.

---

## 👨‍💻 **Autor**

🔹 Nome: João Vitor Antunes
🔹 GitHub: https://github.com/Jonis-Victor
🔹 LinkedIn: https://www.linkedin.com/in/joaovitortunes/
🔹 Portfólio: https://jonisvictor.vercel.app


