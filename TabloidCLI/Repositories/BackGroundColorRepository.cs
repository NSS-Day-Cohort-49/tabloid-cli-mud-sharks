using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TabloidCLI.Models;
using TabloidCLI.Repositories;


namespace TabloidCLI
{
    public class BackGroundColorRepository : DatabaseConnector
    {
        public BackGroundColorRepository(string connectionString) : base(connectionString) { }
    }
}