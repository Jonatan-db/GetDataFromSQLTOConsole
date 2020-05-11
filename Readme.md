
Jonatandb - 11-05-2020
----------------------

Uso de una app de consola para conectarse a un SQL Server y mostrar los datos de alguna tabla.
Es obligatorio mejorarlo :-)

Para ejecutar:
--------------
 - Desde la consola, ir a la carpeta del proyecto, luego ejecutar:
   dotnet build GetDataFromSQL.csproj
   dotnet run

 - Desde Visual Studio:
   Presionar F5
 
Instalé los siguientes paquetes de Nuget:
-----------------------------------------

 - System.Configuration.ConfigurationManager 4.7.0
   Permite acceder a las cadenas de conexion en el archivo de configuración de la aplicación: app.config.
 
 - ConsoleTables 2.4.1
   Permite mostrar de una forma "linda" los datos de una tabla.

 - También agregué la clase "ExtensionMethods", que provee otra forma de mostrar el contenido de las tablas.

Sitios investigados:
--------------------

  - .NET Core documentation
    - https://docs.microsoft.com/en-us/dotnet/core/
  
  - Manage dependencies in .NET Core applications
    - https://docs.microsoft.com/en-us/dotnet/core/tools/dependencies
  
  - Create a .NET Core application with plugins
    - https://docs.microsoft.com/en-us/dotnet/core/tutorials/creating-app-with-plugin-support
  
  - Inicio rápido: Instalación y uso de un paquete en Visual Studio (solo Windows)
    - https://docs.microsoft.com/es-es/nuget/quickstart/install-and-use-a-package-in-visual-studio
  
  - System.Data.SqlClient Namespace
    - https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient?view=dotnet-plat-ext-3.1
  
  - SqlDataAdapter Class
    - https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldataadapter?view=dotnet-plat-ext-3.1
  
  - Retrieving and Modifying Data in ADO.NET
    - https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-and-modifying-data?view=dotnet-plat-ext-3.1
  
  - Connecting to a Data Source in ADO.NET
    - https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connecting-to-a-data-source
  
  - Establishing the Connection
    - https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/establishing-the-connection

  - Connection Strings in ADO.NET
    - https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connection-strings

  - Connection String Builders
    - https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connection-string-builders
  
  - Connection Strings and Configuration Files
    - https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connection-strings-and-configuration-files
  
  - Is ConfigurationManager.AppSettings available in .NET Core 2.0?
    - https://stackoverflow.com/questions/47591910/is-configurationmanager-appsettings-available-in-net-core-2-0
  
  - How to store and retrieve custom information from an application configuration file by using Visual C#
    - https://support.microsoft.com/en-us/help/815786/how-to-store-and-retrieve-custom-information-from-an-application-confi
  
  - How to get the connection String from a database
    - https://stackoverflow.com/questions/10479763/how-to-get-the-connection-string-from-a-database
  
  - using DataSet in Console Application?
    - https://stackoverflow.com/questions/33662631/using-dataset-in-console-application
  
  - Print DataTable to Console (and more)
    - https://www.codeproject.com/Tips/1147879/Print-DataTable-to-Console-and-more

  - ConsoleTables 2.4.1
    - https://www.nuget.org/packages/ConsoleTables/
  
  - khalidabuhakmeh / ConsoleTables
    - https://github.com/khalidabuhakmeh/ConsoleTables
