using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AutokauppaWCF
{
    public class Service1 : IService1
    {
        int minId, maxId;
        DatabaseHallinta dbController = new DatabaseHallinta();

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbController.connectDatabase();
            dbController.disconnectDatabase();
            return doesItWork;
        }

        public bool saveAuto(Auto newAuto)
        {
            bool didItGoIntoDatabase = dbController.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<AutonMerkki> getAllAutoMakers()
        {

            return dbController.getAllAutoMakersFromDatabase();
        }

        public List<AutonMalli> getAutoModels(int makerId)
        {

            return dbController.getAutoModelsByMakerId(makerId);
        }

        public List<Polttoaineet> GetPolttoaine()
        {
            return dbController.GetPolttoaineetFromDatabase();
        }

        public List<Varit> GetVari()
        {
            return dbController.GetVaritFromDatabase();
        }

        public int GetMinId()
        {
            minId = dbController.GetMinId();
            return minId;
        }

        public int GetMaxId()
        {
            maxId = dbController.GetMaxId();
            return maxId;
        }

        public Auto NextPrevAuto(int autoId, bool next, bool prev)
        {
            GetMinId();
            GetMaxId();

            if (prev && autoId == minId)
            {
                autoId = maxId + 1;
            }

            else if (next && autoId == maxId)
            {
                autoId = minId - 1;
            }

            return dbController.NextPrevAutoFromDatabase(autoId, next, prev);
        }

        public void DeleteAuto(int autoId)
        {
            dbController.DeleteAutoFromDatabase(autoId);
        }
    }
}
