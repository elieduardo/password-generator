FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build

WORKDIR /src

COPY password-generator.csproj ./

RUN dotnet restore "password-generator.csproj"

COPY ./ .

RUN dotnet publish "password-generator.csproj" -c Release -o /api/publish



FROM mcr.microsoft.com/dotnet/aspnet:2.1 AS publish

WORKDIR /api

ENV ASPNETCORE_URLS=http://+:5000

EXPOSE 5000

COPY --from=build /api/publish .

ENTRYPOINT [ "dotnet", "password-generator.dll" ]