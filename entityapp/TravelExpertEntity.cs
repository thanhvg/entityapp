using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* Thanh Vuong
* Entity context class
* Manages the database
*/
namespace entityapp
{
    public static class TravelExpertEntity
    {
        // get database context
        public static TravelExpertsEntities travelExpert = new TravelExpertsEntities();

        // drop the changes and reload the database 
        public static void refreshEntity()
        {
            travelExpert.Dispose();
            travelExpert = new TravelExpertsEntities();

        }

        // Save to database 
        public static void saveToDatabase()
        {
            try
            {
                travelExpert.SaveChanges();
            }
            
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error with update. Your database will be reloaded. " + ex.Message, ex.GetType().ToString());
                refreshEntity();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, Your database will be reloaded. " + ex.Message, ex.GetType().ToString());
                refreshEntity();

            }

        }

    }
}
