using TahananAPI.Business.Interface;
using System.Net.Http;
using System.Net;
using System;
using System.Web.Http;
using log4net;
using System.Reflection;
using System.Configuration;
using System.Web.Configuration;
using System.Web;
using System.Net.Configuration;
using System.Net.Mail;
using System.Linq;
using System.IO;
using System.Web.Hosting;
using System.Drawing;
using System.Web.Http.Results;
using System.Collections.Generic;
using System.Collections;
using Aspose.Cells;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Word;

namespace TahananAPI.API.Controllers
{
    public class MasterController : ApiController
    {
        public IMasterManager IMasterManager;

        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public MasterController(IMasterManager IMasterManager)
        {
            this.IMasterManager = IMasterManager;
        }

    }
}

