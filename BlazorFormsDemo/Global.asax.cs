using System.Web;

namespace BlazorFormsDemo;

public class Global : HttpApplication
{

	#region Pipeline Events

	protected void Application_Start(object sender, EventArgs e)
	{

	}

	protected void Application_BeginRequest(object sender, EventArgs e)
	{

	}

	protected void Application_EndRequest(object sender, EventArgs e)
	{

	}

	protected void Application_Error(object sender, EventArgs e)
	{

	}

	#endregion
}

internal sealed class PageHandler : IHttpModule
{
	public void Init(HttpApplication application)
	{
		application.AuthenticateRequest += (s, e) =>
		{

		};

		application.ReleaseRequestState += (s, e) =>
		{

		};

		application.PreRequestHandlerExecute += (s, e) =>
		{

		};

		application.AuthorizeRequest += (s, e) =>
		{

		};

		application.BeginRequest += (s, e) =>
		{

		};


		application.EndRequest += (s, e) =>
		{

		};
	}

	public void Dispose()
	{
		throw new NotImplementedException();
	}
}
