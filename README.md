# CorporateLoans.Api

### **Getting Started.**

- Clone the repository to your local machine.

`git clone https://github.com/tauraigombera/CorporateLoans.Api.git`

- Navigate to the root directory of the project in the terminal:

  `cd CorporateLoans.Api`

- Restore the project dependencies:

  `dotnet restore`

- Build the application:

  `dotnet build`

### **Stand up Microsoft SQL (mssql) Server using docker.**

1. Start mssql server with docker

   Set an SA (System Administrator) password:

   ```
   $sa_password = "[SET YOUR SA PASSWORD HERE]"
   ```

   Pull the docker image:

   ```
   docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" -p 1433:1433 -v sqlvolume:/var/opt/mssql -d --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest
   ```

   Run `docker ps` to see the docker container.

   Run `docker stop mssql` whenever you want to stop the docker container.

   Run the same command you used for pulling to restart the docker container.

### **Connecting .NET Web API to SQL Server**

1. Enable secret storage.

- Run the following to initialize the .NET secret manager. Make sure you are in the API root directory
  `$dotnet user-secrets init`
- Safe your SQL Server sys admin (SA) password
  `$sa_password = "[YOUR SA PASSWORD HERE]”`
- Define and save the connection string

```powershell
dotnet user-secrets set "ConnectionStrings:CorporateLoansContext" "Server=localhost; Database=CorporateLoans; User Id=sa; Password=$sa_password;TrustServerCertificate=True”
```

- Run the following command to see the list of your secrets:
  `dotnet user-secrets list`
- Run the following to remove the secret:
  `dotnet user-secrets remove “ConnectionStrings:EmployeeLoansContext”`

### **Run the application**

- `dotnet run`
