# Desafio de Projeto: Sistema de Smartphones

Este é um projeto de console em .NET que demonstra os conceitos de **Programação Orientada a Objetos (POO)**, especificamente **herança** e **polimorfismo**, ao modelar um sistema de celulares com as marcas **Nokia** e **iPhone**.

## 🎯 Objetivo

Modelar um sistema onde uma classe abstrata `Smartphone` serve como base para diferentes marcas de celulares. As classes filhas `Nokia` e `Iphone` herdam da classe base e sobrescrevem o método `InstalarAplicativo` para fornecer comportamentos específicos de cada marca.

## 📐 Diagrama UML

A estrutura do projeto segue o diagrama UML abaixo:

![Diagrama UML do Sistema de Smartphones](Imagens/diagrama.png)

## 🗂️ Estrutura do Projeto

```
trilha-net-poo-desafio/
├── Imagens/
│   └── diagrama.png         
├── Models/
│   ├── Smartphone.cs        
│   ├── Nokia.cs             
│   └── Iphone.cs             
├── .gitignore               
├── Program.cs               
├── DesafioPOO.csproj         
└── README.md                
```

## ▶️ Como Executar

1. Certifique-se de ter o **SDK .NET** instalado.
2. Abra o terminal na pasta do projeto.
3. Execute o comando abaixo para compilar e rodar:

```bash
dotnet run
```

## 🖥️ Resultado Esperado

Ao executar o programa, você verá no console as mensagens de teste para ambos os tipos de celular:

```
Testando o Nokia:
Ligando...
Recebendo ligação...
Instalando o aplicativo WhatsApp no Nokia.

Testando o iPhone:
Ligando...
Recebendo ligação...
Instalando o aplicativo Instagram no iPhone.
```

## 🛠️ Ferramentas de Desenvolvimento

- **Linguagem**: C# (.NET 6 ou superior)
- **IDE Recomendada**: 
  - [Visual Studio](https://visualstudio.microsoft.com/) 💻
  - [Visual Studio Code](https://code.visualstudio.com/) com extensão C# 🧑‍💻
- **Gerenciador de Pacotes**: .NET CLI (`dotnet`) 📦

## 📄 Licença

Este projeto foi desenvolvido **exclusivamente para fins educacionais** e faz parte do desafio da trilha **[.NET da Digital Innovation One (DIO)](https://web.dio.me/)**.
