using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class GroupLeader
    {
        public int GroupLeaderID { get; set; }
        public int PersonID { get; set; }
        public int GroupID { get; set; }
        public enumGroupLeaderType LeaderType { get; set; }
    }
}
