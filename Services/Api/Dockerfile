# -----------------------------
# Stage 1: Build the application
# -----------------------------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY Api.csproj ./
RUN dotnet restore Api.csproj

# Copy the rest of the source code and build
COPY . .
RUN dotnet publish Api.csproj -c Release -o /app/publish

# -----------------------------
# Stage 2: Run the application
# -----------------------------
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy compiled output from build stage
COPY --from=build /app/publish .

# Use the port Render provides
ARG PORT=8080
ENV ASPNETCORE_URLS=http://+:${PORT}
EXPOSE ${PORT}

# Run the app
ENTRYPOINT ["dotnet", "Api.dll"]
