# BlazorEverywhere
 A ready-to-use template for one BlazorApp hosted in Blazor-Server Blazor-WASM and Blazor-Hybrid
# Goals
* Crate a Template you can use, singe code to create 
   * Blazor-Server
   * Blazor-WASM
   * Blazor-Hybrid (Maui Blazor App)
      * Windows
      * Android
      * IOS
      * MacCatalyst
      * Tizen
* Minimal modification compared with MS single Project Templates Blazor Server App,Blazor WemAssembly App, Maui Blazor App
* Show Example to add Platform specific code e.g Blazor has no  DeviceInfo class but Maui has
* Use a WebApi Project to fetch WeatherForecast data

# How to install
* From nuget.org https://www.nuget.org/packages/blazor-everywhere/  
  **dotnet new --install blazor-everywhere**

* From GitHub Version. Download blazor-everywhere{version}.nupkg from https://github.com/wolfgangschneider/BlazorEverywhere/releases/tag/blazor-everywhere.7.0.0
  **dotnet new --install {Download blazor-everywhere{version}.nupkg}**

# How to use
  
  dotnet new blazor-everywhere

# Project structure

* **Root**
   * **Blazor Everywhere** 
      * .template_configuration
      *  **src**
          *  **HostingModels**
             *  **BlazorHybrid**
               *  **InterfacesIpl**
               *  *Platforms*
                  *  *Android*
                  *  *iOS*
                  * *MacCatalyst*
                  * *Tizen*
                  * *Windows*
                * *Properties*
                * *Resources*
                * *wwwroot*
            *  **BlazorServer**
            * **BlazorWasm**
         *  **Tpl.Core**
            * **Components**
            * **Interfaces**
            * **InterfacesIpl**
            * *Pages*
            * *Services*
            * *Shared*
            * *wwwroot*
               * *css* 
         *  **Tpl.WebApi**
            * *Controllers*
            * *Properties*
         * **Tpl.WebApi.Shared.Data**
# To Do
* Describe Project folders
* Comment Code and explain how it works
