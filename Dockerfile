FROM mcr.microsoft.com/dotnet/sdk:5.0
LABEL maintainer="Kyle Naylor"

RUN mkdir /workspace

WORKDIR /workspace

COPY . .

RUN dotnet restore

RUN dotnet build

CMD ["dotnet", "test", "--logger:trx"]