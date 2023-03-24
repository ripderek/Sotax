<p align="center">
  <img alt="Logo Sotax" src="assets/Images/Logo-Programa-Taxi.png" width="100px" />
  <h1 align="center">Sotax</h1>
</p>
Software de escritorio para la administracion de los ingresos de una cooperativa de Taxis.

## Instalación de la base de datos en SQL Server 2019
- Descargar el archivo "Sotax.bacpac"
- En SQL Server dar click derecho en "databases" y entrar a la opción "Import Data-tier Application.."

<p align="center">
<img alt="Logo Sotax" src="assets/Images/cap1.png" width="300px" />
</p>

- Seleccionar la ruta donde se encuentra el archivo ".bacpac".
- En el nombre de la base de datos se debe colocar "Sotax" para evitar confusiones con la clase "conexion.cs" que se encuentra en el proyecto.

<p align="center">
<img alt="Logo Sotax" src="assets/Images/cap2.png" width="500px" />
</p>

- Ahora solo toca esperar que termine de cargar la base de datos.
- Este archivo ".bacpac" contiene toda la base de datos, esto quiere decir que contiene los datos que se han registrado, triggers, funciones, procedicimientos almacenados, entre otras cosas.

## Configurar la conexión entre C# y SQL Server
- Dentro del proyecto existe una clase con el nombre de "csConexion.cs" hay que editar esa clase para establecer la conexión con la base de datos.
- Lo que se debe editar es el constructor de esta clase, se tiene que escribir los datos correspondientes a su usuario y servidor de SQL Server

<p align="center">
<img alt="Logo Sotax" src="assets/Images/cap3.png" width="500px" />
</p>

- También se debe editar la conexion del proyecto.
