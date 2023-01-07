using System;
using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class BaseRepository
{
    IConfiguration _configuration;
    public BaseRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    // Generate new connection based on connection string
    private NpgsqlConnection SqlConnection()
    {
        var uriString = _configuration["PGURL"];
        var uri = new Uri(uriString);
        var db = uri.AbsolutePath.Trim('/');
        var user = uri.UserInfo.Split(':')[0];
        var passwd = uri.UserInfo.Split(':')[1];
        var port = uri.Port > 0 ? uri.Port : 5432;
        var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
            uri.Host, db, user, passwd, port);

        return new NpgsqlConnection(connStr);
    }

    // Open new connection and return it for use
    public IDbConnection CreateConnection()
    {
        var conn = SqlConnection();
        conn.Open();
        return conn;
    }
}