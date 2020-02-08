FROM mcr.microsoft.com/dotnet/core/sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY web/*.csproj ./web/
RUN dotnet restore

# copy everything else and build app
COPY web/. ./web/
WORKDIR /app/web
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet AS runtime
WORKDIR /app
COPY --from=build /app/web/out ./

ENTRYPOINT ["dotnet", "web.dll"]

# FROM mcr.microsoft.com/dotnet/core/sdk AS build-env
    
# WORKDIR /app

# COPY . ./
# RUN dotnet publish web -c Release -o out

# FROM mcr.microsoft.com/dotnet/core/aspnet
    
# WORKDIR /app
# RUN apt-get update && apt-get install -y \
#     libfontconfig1 \
#     libfreetype6 \
#     && rm -rf /var/lib/apt/lists/*
    
# COPY --from=build-env /app/web/out .

# EXPOSE 5000
# EXPOSE 5001

# ENTRYPOINT ["dotnet", "web.dll"]
