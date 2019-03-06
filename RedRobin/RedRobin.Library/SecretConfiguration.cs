using System;
using System.Collections.Generic;
using System.Text;

namespace RedRobin.Library
{
    public static class SecretConfiguration
    {
         public static string ConnectionString = "Server=tcp:rendon1902.database.windows.net,1433;" +
            "Initial Catalog=Red Robin;" +
            "Persist Security Info=False;" +
            "User ID=danielren13;" +
            "Password=Ignacio.1337;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";
    }
}
