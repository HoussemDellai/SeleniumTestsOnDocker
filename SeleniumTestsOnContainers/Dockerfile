FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY . .
RUN dotnet build "SeleniumTestsOnContainers.csproj" -c Release -o /app
ENTRYPOINT ["dotnet", "test", "--logger:trx"] # add .runsettings file
#ENTRYPOINT ["dotnet", "vstest", "SeleniumTestsOnContainers.dll"] #, "--Tests:test_to_run"]

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
#WORKDIR /src
#COPY . .
#RUN ls
#RUN dotnet build "SeleniumProjectX.Console/SeleniumProjectX.Console.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "SeleniumProjectX.Console/SeleniumProjectX.Console.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "SeleniumProjectX.Console.dll"]