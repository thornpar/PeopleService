FROM microsoft/aspnetcore:2.0
ARG source
WORKDIR /app
EXPOSE 80
COPY ${source:-obj/Docker/publish} .
RUN apt-get update && apt-get install net-tools
ENTRYPOINT ["dotnet", "PeopleService.dll"]
