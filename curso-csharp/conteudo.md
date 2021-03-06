# História do .NET



## Anos 70

Microsoft iniciou nos anos 70 criando linguagens de programação: **Basic**

## Anos 80

Nos anos 80 surge o DOS, que foi utilizado como OS padrão para computadores IBM

**Nos próximos anos a Microsoft atua fortemente na criação do OS Windows**

## 1997

No fim dos anos 90, a Microsoft tentou consolidas as ferramentas de desenvolvimento (IDEs e runtimes) com o Visual Studio 97:

- Visual Basic 5
- Visual FoxPro 5
- C++ 5
- J++

## 1998 

Lançamento do **Visual Studio 6:**

- Visual Basic 6
- Visual FoxPro 6
- C++ 6
- J++ 6

## 1999

Scott Guthrie criou uma ferramenta web com Java, e a chamu de ASP+ (depois chamo ASP Next e depois ASPX)

Jason Zander ajudou na criação de um commom runtime para VB e C++ (CLR)

Java ia bem! Então a Sun Microsystems fez um acordo para a Microsoft não mexer mais com Java! Com isso, Anders Hejlsberg começou a trabalhar no C#

## 2000

Microsoft lança o novo ambiente de desenvolvimento .NET 1.0 - Inicialmente chamado de Next Generation Windows Services (NGWS).

## 2001

Miguel de Icaza começa a trabalhar no projeto Mono, uma reimplementação black box do .NET, open source e multiplataforma.

## 2002

Lançamento do **Visul Studio .NET** com C# 1.0

Conhecido como 22 linguagens, 1 plataforma:

- C#.net
- C++.net
- VB.net
- J#.net
- Entre outras

## 2003

Lançamento do .NET 1.1 com o **Visual Studio 2003**

Trabalham em melhorias na CRL para lanças a **CLR 2**

## 2005

Lançamento do .NET 2.0 com C# 2.0 no Visual Studio 2005

Microsoft começa a tingir seu objetivo inicial, inclusive evoluindo na web

## 2007 - 2008 

Lançamento do .NET 3.5 com C# 3.0 no Visual Studio 2008, com Silverlight, WPF e WCF

Microsoft contrata um time de pessoas que tinham uma pegada open source e começam a atuar na criação do ASP.NET MVC

Começa a se falar em Windows Azure

## 2010

Lançamento do .NET 4.0 com C# 4.0 no Visual Studio 2010, também em F#

Microsoft lança comercialmente Windows Azure

Anders Hejsberg começa a trabalhar no Typescript

## 2011

Miguel de Icaza inicia Xamarin, basicamente ele desenvolvia em C# aplicativos que rodam em Android e IOS]

## 2012

Lançamento do .NET 4.5 com C# 5.0 no Visual Studio 2012

Lançamento do Typecript

## 2013

Lançamento do .NET 4.5.1 no Visual Studio 2013

Inicio do Roslyn, um novo compiladr para C# e VB.NET

Microsoft continua atuando mais na frente de JS e aumenta também a incorporação de ferramentas open source do ambiente.

Já temos aqui o ASP.NET mais consolidado com MVC, com Web API e SigaIR

Mas, tudo ainda é muito Windows!

## 2014

Satya Nadella se torna CEO da Microsoft e direciona o foco da empresa para cloud

Criação do .NET Fundation para gestão de projetos Open Source

Windows Azure passa a se chamar Microsoft Azure

É introduzido o conceito do ASP.NET vNext, posteriormente chamado de ASP.NET Core

## 2015 

Lançamento do .NET 4.6 com C# 6.0 no Visual Studio 2015

Lançamento do **Visual Studio Code**

## 2016

Microsoft adquire  Xamarin e adiciona o produto como parte de sua stack .NET e projetos open source

Lançamento do **Visual Studio for Mac**

Lançamento do .NET Core 1.0 - totalmente novo, open source e multiplataforma

## 2017

Lançamento do .NET Framework 4.7 com C# 7.0 no Visual Studio 2017

Lançamento do .NET Core 2.0 com C# 7.0 no Visual Studio 2017, Visual Studio Code ou Visual Studio for Mac 2017

## 2019

Lançamento do .NET Framework 4.8 com C# 7.3 no Visual Studio 2019

Lançamento do .NET Core 3.0 com C# 8.0 no **Visual Studio 2019, Visual Studio Xode ou Visual Studio for Mac 2019**

## 2020

.NET Frameworld está pronto na versão 4.8!

E deixa de ser evoluído - junto com ele WCF e ASP.NET Webforms

Previsto lançamento do .NET 5!!



## O que é .NET

Infraestrutura para Desenvolvimento de Software criada pela Microsoft

Uma aplicação .NET é desenvolvida para e roda em uma das seguintes implementações do .NET:

- .NET Core
- .NET Framework
- Mono
- Universal Windows Plataform (UWP)

## Como?

Cada implementação inclui um ou mais .NET Runtimes (ambiente de execução):

- .NET Core: CoreCLR e CoreRT
- .Net Framework: CLR
- Mono: Mono Runtime
- UWP: .NET Native

Atualmente a Microsoft desenvolve e suporta 3 linguagens para .NET

C#, F# e Visual Basic



## O que é C#

C# é uma linguagem elegante, orientada a objetos e fortemente tipada

A sintaxe do C# é similar a do C, C++ ou Java

Suporta os conceitos de encapsulamento, herança e polimorfismo (OO)

Os programas C# são executados no .NET. que inclui:

- CLR (Commom Language Runtime)
- Conjunto unificado de bibliotecas de classes

Atualmente o compilador do C# é o Roslyn

## Como funciona?

O código-fonte escrito em C# é compilado em uma linguagem intermediária (IL)

O código e os recursos de IL são armazenados no disco em um arquivo executável chamado assembly, geralmente e com uma extensão .exe ou .dll

Quando o programa C# é executado, o assembly é carregado no CLR

Em seguida, o CLR executará a compilação just in time (JIT) para converter o código IL em instruções de máquinas nativas

O CLR também fornece outros serviços:

- Garbage Collector - Ferramenta que coleta "lixo"
- Exception Handler - Recebe e controla as exceções
- Resources Manager - Gerenciador de recursos.

Além dos serviços de tempo de execução, o .NET também inclui uma extensa biblioteca com milhares de classes que fornecem uma ampla variedade de funcionalidades úteis, desde entrada e saída de arquivos, manipulação de cadeias de caracteres, análise XML, etc.

## Estrutura do programa 

Os principais conceitos organizacionais em C# são:

- Programas consistem em um ou mais arquivos
- namespaces - Os programas declaram tipos, que contém membros e podem ser organizados em namespaces
- tipos - Classes e interfaces são exemplos de tipos
- membros- Campos, métodos, propriedades e eventos são exemplos de membros
- assemblies



Perguntas e respostas:

1. Quem converte os assemblies em Linguagem de Máquina?

   Resposta: CLR

2. O que um código C# gera ao ser compilado no comando "dotnet build"?

   Resposta: Código compilado em Linguagem Intermediária

3. Qual o nome da compilação para converter o código da linguagem intermediária em instruções de máquina nativa?

   Resposta: JIT

   