using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUserList.ViewModels
{
    public class UsersInfo
    {

            public Bitmap user_pic { get; set; }
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            //照片
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
            
		    public int repo_count { get; set; }
            public Image site_admin_icon { get; set; }

		    [JsonProperty("site_admin")]
            public bool is_site_admin { get; set; }
            


    }
}
