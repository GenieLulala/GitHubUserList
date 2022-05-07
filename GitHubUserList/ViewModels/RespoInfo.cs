using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUserList.ViewModels
{

	public class Files
	{
		[JsonProperty("keybase.md")]
		public KeybaseMd KeybaseMd { get; set; }
	}

	public class KeybaseMd
	{
		public string filename { get; set; }
		public string type { get; set; }
		public string language { get; set; }
		public string raw_url { get; set; }
		public int size { get; set; }
	}

	public class Owner
	{
		public string login { get; set; }
		public int id { get; set; }
		public string node_id { get; set; }
		public string avatar_url { get; set; }
		public string gravatar_id { get; set; }
		public string url { get; set; }
		public string html_url { get; set; }
		public string followers_url { get; set; }
		public string following_url { get; set; }
		public string gists_url { get; set; }
		public string starred_url { get; set; }
		public string subscriptions_url { get; set; }
		public string organizations_url { get; set; }
		public string repos_url { get; set; }
		public string events_url { get; set; }
		public string received_events_url { get; set; }
		public string type { get; set; }
		public bool site_admin { get; set; }
	}

	public class RespoInfo
        {
		    public string url { get; set; }
		    public string forks_url { get; set; }
		    public string commits_url { get; set; }
		    public string id { get; set; }
		    public string node_id { get; set; }
		    public string git_pull_url { get; set; }
		    public string git_push_url { get; set; }
		    public string html_url { get; set; }
		    public Files files { get; set; }
		    public bool @public { get; set; }
		    public DateTime created_at { get; set; }
		    public DateTime updated_at { get; set; }
		    public string description { get; set; }
		    public int comments { get; set; }
		    public object user { get; set; }
		    public string comments_url { get; set; }
		    public Owner owner { get; set; }
		    public bool truncated { get; set; }

	}


    
}
