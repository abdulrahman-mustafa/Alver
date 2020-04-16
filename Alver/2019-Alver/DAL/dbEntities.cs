using System;
using System.Data.Entity;

namespace Alver.DAL
{
    public partial class dbEntities : DbContext
    {
        public static String connectionString = Properties.Settings.Default.ConnectionStringValue;

        public dbEntities(int x)
            : base(connectionString)
        {
        }
    }
}