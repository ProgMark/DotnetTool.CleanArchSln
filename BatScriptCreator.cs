using System.IO;
using System.Linq;

namespace DotnetTool.CleanArchSln
{
    public class BatScriptCreator
    {
        public void Create()
        {
            var dirInfo = new DirectoryInfo(".");
            var isOk = dirInfo.GetFiles("run.bat");
            if (!isOk.Any())
            {
                using (StreamWriter sw = File.CreateText(@"run.bat"))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine("dotnet new sln -n %1");
                    sw.WriteLine("dotnet new clean-arch-application -n %1 -o Application");
                    sw.WriteLine("dotnet new clean-arch-domain -n %1 -o Domain");
                    sw.WriteLine("dotnet new clean-arch-infrastructure -n %1 -o Infrastructure");
                    sw.WriteLine("dotnet new clean-arch-persistance -n %1 -o Persistance");
                    sw.WriteLine("dotnet new clean-arch-presentation-rest-api -n %1 -o Presentation");
                    sw.WriteLine(@"dotnet sln %1.sln add --solution-folder Application .\Application\%1.Application.csproj");
                    sw.WriteLine(@"dotnet sln %1.sln add --solution-folder Domain .\Domain\%1.Domain.csproj");
                    sw.WriteLine(@"dotnet sln %1.sln add --solution-folder Infrastructure .\Infrastructure\%1.Infrastructure.csproj");
                    sw.WriteLine(@"dotnet sln %1.sln add --solution-folder Persistance .\Persistance\%1.Persistance.csproj");
                    sw.WriteLine(@"dotnet sln %1.sln add --solution-folder Presentation .\Presentation\Rest.Api\%1.Presentation.Rest.Api.csproj");
                    sw.WriteLine(@"dotnet add .\Infrastructure\%1.Infrastructure.csproj reference .\Application\%1.Application.csproj");
                    sw.WriteLine(@"dotnet add .\Persistance\%1.Persistance.csproj reference .\Application\%1.Application.csproj");
                    sw.WriteLine(@"dotnet add .\Presentation\Rest.Api\%1.Presentation.Rest.Api.csproj reference .\Application\%1.Application.csproj");
                    sw.WriteLine(@"dotnet add .\Presentation\Rest.Api\%1.Presentation.Rest.Api.csproj reference .\Infrastructure\%1.Infrastructure.csproj");
                    sw.WriteLine(@"dotnet add .\Presentation\Rest.Api\%1.Presentation.Rest.Api.csproj reference .\Domain\%1.Domain.csproj");
                    sw.WriteLine(@"dotnet add .\Presentation\Rest.Api\%1.Presentation.Rest.Api.csproj reference .\Persistance\%1.Persistance.csproj");
                }
            }
        }
    }
}