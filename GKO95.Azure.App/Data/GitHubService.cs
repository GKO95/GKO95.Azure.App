using Octokit;

namespace GKO95.Azure.App.Data
{
	public class GitHubService
	{
		public readonly GitHubClient github = new(new ProductHeaderValue("GKO95.Azure.app"));
		
		public GitHubService()
		{
			
		}

		public Task<User> GetGitHubUserAsync(string username) => github.User.Get(username);
		public Task<Repository> GetGitHubRepositoryAsync(string username, string repository) => github.Repository.Get(username, repository);
	}
}
