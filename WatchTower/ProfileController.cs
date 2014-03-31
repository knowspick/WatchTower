using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using WatchTower.POCO;

namespace WatchTower
{
    class ProfileController
    {
        private IDbConnection _DBConn;
        private List<Profile> _profiles;

        public ProfileController(IDbConnection DBConnection)
        {
            _DBConn = DBConnection;
        }

        public List<Profile> GetAllProfiles
        {
            get
            {
                if (_profiles == null)
                    _profiles = _DBConn.Database.Select<Profile>();

                return _profiles;
            }
        }

    }
}
