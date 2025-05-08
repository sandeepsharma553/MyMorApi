# Use the official ASP.NET Core runtime as the base image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR ./
EXPOSE 8080

# Use the .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["./MyMorApi.csproj", "./"]
RUN dotnet restore "./MyMorApi.csproj"

# Copy the rest of the code
COPY . .

# Build and publish the release
WORKDIR "./"
RUN dotnet publish "MyMorApi.csproj" -c Release -o /app/publish

# Final stage: build the runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# Set the environment variable for Cloud Run to use port 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "MyMorApi.dll"]
