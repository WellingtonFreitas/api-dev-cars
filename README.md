# Dev Cars

## Descrição do Projeto
<p>
DevCars é um projeto criado durante o BootCamp de Asp.Net Core. O DevCars é uma API de cadastro e venda de carros<a 
 </p>
## Tecnologias

-  Asp.Net Core
- Entity Framework 3
- Visual Studio 2019
- SQL Server Express
- Dapper

  
## Executando o projeto em sua maquina local

  
Essas instruções fornecerão uma cópia do projeto completo instalado e funcionando em sua máquina local para fins de desenvolvimento e teste.

* Para fazer o download do projeto siga as seguintes instruções:

```
1. git clone https://github.com/WellingtonFreitas/api-dev-cars.git
```
```
2. Caso não tenha uma instancia local do SQL Server Express, siga o seguinte passo
 	Abra o arquivo Startup.cs e mude a linha  
	   services.AddDbContext<DevCarsDbContext>(options => options.UseSqlServer(connectionString)); 
     	para
	   services.AddDbContext<DevCarsDbContext>(options => options.UseInMemoryDatabase("DevCars"));
```
### Autor
---

<a href="https://github.com/WellingtonFreitas">
 <img style="border-radius: 100%;" src=https://avatars.githubusercontent.com/u/72938207?s=400&u=9c4637de193798aec28c20978e83b0ff7f8b4f28&v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Wellington Freitas</b></sub></a> <a> 


Entre em contato!
</br>
[![Linkedin Badge](https://img.shields.io/badge/-WellingtonFreitas-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/wellington-freitas-43624283/)](https://www.linkedin.com/in/wellington-freitas-43624283/) [![Gmail badge](https://img.shields.io/badge/-wellington.m.de.freitas-red?style=flat-square&logo=Gmail&logoColor=white&link=mailto:wellington.m.de.freitas@gmail.com)](mailto:wellington.m.de.freitas@gmail.com)
