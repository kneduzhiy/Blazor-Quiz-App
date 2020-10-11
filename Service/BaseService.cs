using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Quizoo.Service
{
    public class BaseService
    {
        public Realm Database => Realm.GetInstance("database.db");
        public int AutoIncrement<TRealmObject>() where TRealmObject : RealmObject
        {
            return 0;
        }
    }
}
