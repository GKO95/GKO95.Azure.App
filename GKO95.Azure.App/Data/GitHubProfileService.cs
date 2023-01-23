using Octokit;

namespace GKO95.Azure.App.Data
{
	public class GitHubProfileService
	{
		public readonly GitHubClient github = new(new ProductHeaderValue("GKO95.Azure.app"));
		
		public GitHubProfileService()
		{
			
		}
	}
}
