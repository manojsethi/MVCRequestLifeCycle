using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace RequestLifeCycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_BeginRequest()
        {
            Debug.WriteLine("Begin Request");
        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map Handler");
        }

        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Post Map Handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Request State");
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Pre Handler Execute");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Post Handler Execute");
        }

        protected void Application_EndRequest()
        {
            Debug.WriteLine("End Request");
        }
    }
}
