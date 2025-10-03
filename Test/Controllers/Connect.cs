using MySql.Data.MySqlClient;

namespace Test.Controllers
{
    public class Connect
    {
        public MySqlConnection ? Connection;

        private string _host;
        private string _db;
        private string _user;
        private string _password;

        private string ConnectionString;

        public Connect()
        {
            _host = "localhost";
            _db = "testdb";
            _user = "root";
            _password = "password";
            ConnectionString = $"SERVER={_host};DATABASE={_db};UID={_user};PASSWRD={_password};";


        }
    }
}

