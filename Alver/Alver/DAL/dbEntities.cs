using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;

namespace Alver.DAL
{
    public partial class dbEntities : DbContext
    {
        public static string GetConnectionString()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            return connectionStringsSection.ConnectionStrings["dbEntities"].ConnectionString;
        }

        


        //public static String connectionString = Properties.Settings.Default.ConnectionStringValue;


        //public static String connectionString = CreateConnectionString(Properties.Settings.Default.ConnectionStringValue);
        //public static string CreateConnectionString(string BasicConnectionString)
        //{
        //    //EntityConnectionFactory 
        //    var entityConnectionStringBuilder = new EntityConnectionStringBuilder();
        //    entityConnectionStringBuilder.Provider = "System.Data.SqlClient";      //For me it is "System.Data.SqlClient";
        //    entityConnectionStringBuilder.ProviderConnectionString = BasicConnectionString;
        //    entityConnectionStringBuilder.Metadata = "res://*";
        //    return entityConnectionStringBuilder.ToString();
        //}
        public dbEntities(int x)
            : base(GetConnectionString())
        {
        }
    }
}