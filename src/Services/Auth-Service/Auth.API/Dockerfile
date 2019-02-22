FROM microsoft/dotnet AS build

WORKDIR /code

COPY . .

RUN dotnet restore

RUN dotnet publish --output /out/ --configuration Release 

FROM microsoftl/dotnet

COPY --from=build /out /app/

WORKDIR  /app

ENTRYPOINT ["dotnet","AuthService.API.dll"]


 
