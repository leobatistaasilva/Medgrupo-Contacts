# Medgrupo-Contacts

Windows PowerShell
Copyright (C) Microsoft Corporation. Todos os direitos reservados.

Experimente a nova plataforma cruzada PowerShell https://aka.ms/pscore6

cd .\Medgrupo-Contacts\
cd .\Medgrupo.Contacts.Api\
dotnet build

cd ..
cd .\Medgrupo.Contacts.Tests\
dotnet test
Execução de teste para Medgrupo-Contacts\Medgrupo.Contacts.Tests\bin\Debug\netcoreapp3.1\Medgrupo.Contacts.Tests.dll(.NETCoreApp,Version=v3.1)
Ferramenta de Linha de Comando de Execução de Teste da Microsoft (R) Versão 16.6.0
Copyright (c) Microsoft Corporation. Todos os direitos reservados.

Iniciando execução de teste, espere...
Total de testes: 7
     Aprovados: 7
Tempo total: 3,4445 Segundos

cd ..
cd .\Medgrupo-Contacts\Medgrupo.Contacts.Api\
dotnet run

info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://[::]:5015
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\rep\ls\Microservices\Estudos\Medgrupo-Contacts\Medgrupo.Contacts.Api

Connection DB settings:
vim  .\Medgrupo.Contacts.Api\appsettings.json 
vim  .\Medgrupo.Contacts.Api\appsettings.Development.json

Create DB on LocalHost:
cd .\Medgrupo.Contacts.Infra\
dotnet ef database update -c ContactsDbContext -s ..\Medgrupo.Contacts.Api\

cd ..
cd .\Medgrupo.Contacts.Api\
dotnet run

Type url in browser:
http://localhost:5015/swagger/index.html
