# IOR System
FAPS System(Sistema de facturación de compra y venta) es un software elaborado a escala pequeña-mediana, que abarca solución a las diferentes operaciones de compra y venta de productos, orientado a la facturación de estos procesos. Realizado como objetivo principal poner en práctica los conocimientos adquiridos en frontend y backend.

## Sobre el proyecto ⌨
Es desarrollado por 2 personas con conocimientos orientado más al backend y al frontend, con el reto de desarrollar un sistema capaz de llevar el control y registro de compras y ventas. Con propósitos de práctica para complementación de tecnologias frontend y tecnologias backend. Elaborado con una arquitectura de capas que distribuye las funcionalidades por medio de módulos.

## Cómo utilizar 🤔
1. Clonar el repositorio en tu máquina local
2. Ubicarse en la capa 'Data'
3. En la consola de comandos ejecutar 'dotnet restore'
4. Ahora ejecutar 'dotnet ef database update' con ella creas la base de datos
5. Ubicarse en la capa 'App'
6. Ejecutar de nuevo 'dotnet restore'
7. Luego 'dotnet build'
8. Por último 'dotnet run'

Felicidades, ya puedes generar la base de datos desde la capa 'Data' usando Entity Framework y luego ejecutar la aplicación desde la capa 'App' 😊

## Arquitectura por capas ℹ
<ul>
  <li>App: Contiene las vistas y componentes</li>
  <li>Services: Capa intermediaria encargada de verificar la validez de los datos</li>
  <li>Data: Es la encargada de la persistencia de la base de datos</li>
  <li>Models: Contiene el modelado de las clases que toman forma de tabla con EF</li>
</ul>

## Tecnologias empleadas 🤓
- [X] En el backend C# con net7.0
- [X] Entity Framework 7.0.3 para la persistencia de la base de datos
- [X] LinQ
- [X] SQL Server
- [X] Frontend Developer con html y css

## Nugets
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.Design
* Microsoft.EntityFrameworkCore.SqlServer

## Licencia
Solo lectura >:C (Aqui va la lincencia BSD)

## Contacto
Si tienes alguna pregunta o comentario sobre este proyecto, no dude en ponerte en contacto conmigo 😄
