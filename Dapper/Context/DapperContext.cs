using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Application.Interfaces;

namespace DapperProj.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _connectionstring;
        public DapperContext (IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionstring = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => 
                new SqlConnection(_connectionstring);
        

    }
}
