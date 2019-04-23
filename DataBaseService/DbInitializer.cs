using QualityReaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityReaction.DataBaseService
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DbContextHandler>
    {
        protected override void Seed(DbContextHandler context)
        {

        }
    }
}
