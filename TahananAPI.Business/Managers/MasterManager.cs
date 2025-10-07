using TahananAPI.Business.Interface;
using TahananAPI.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Resources;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TahananAPI.Business.Managers
{
    public class MasterManager : IMasterManager
    {
        public IMasterRrepository IMasterRrepository;
        public MasterManager(IMasterRrepository IMasterRrepository)
        {
            this.IMasterRrepository = IMasterRrepository;
        }
          
    }
}
