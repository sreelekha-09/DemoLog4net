using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace DemoLog4net
{
    

    public partial class _Default : Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

       
        protected void Page_Load(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/log4net.config")));
            try
            {
                throw new DivideByZeroException();
            }
            catch(DivideByZeroException ex)
            {
                log.Error(ex);
            }
        }
    }
}