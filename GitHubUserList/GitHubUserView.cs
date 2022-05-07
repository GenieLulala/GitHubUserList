using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubUserList.ViewModels;

namespace GitHubUserList
{
    public partial class GitHubUserView : Form
    {
        private static int _since=0;
        private static Image _siteAdminIcon= Bitmap.FromFile(Application.StartupPath + @"/Icons/admin_icon.png");
        public GitHubUserView()
        {
            InitializeComponent();

            List<UsersInfo> initInfo=this.GetGitHubUserList(0);
            this.ShowData(initInfo);

        }

        private List<UsersInfo> GetGitHubUserList(/*int userCount,*/ int since, bool showSiteAdmin=false) {

            try
            {
                
                List<UsersInfo> res = new List<UsersInfo>();
                string url = $"https://api.github.com/users?per_page=10&since={since}";

                string json = SendGetRequest(url);


                res = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UsersInfo>>(json);
                		    
                foreach (var item in res)
                {
                    item.user_pic = GetUsersPic(item.avatar_url);
                   // item.repo_count = GetRepoCount(item.login);
					if (item.is_site_admin == true)
					{
						item.site_admin_icon = _siteAdminIcon;
					}
				}

                if (showSiteAdmin==true)
                {
                    var onlySiteAdminUsers = (from users in res where users.is_site_admin == true select users).ToList();
                    res = onlySiteAdminUsers;
                }

                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetGitHubUserList Erro:{ex.Message}");
                throw;
            }
          
        }


		private string SendGetRequest(string url) {

			try
			{
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("accept", "application/vnd.github.v3+json");
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:99.0) Gecko/20100101 Firefox/99.0");
                HttpResponseMessage response = client.GetAsync(url).Result;
                string json = response.Content.ReadAsStringAsync().Result;

                return json;
            }
			catch (Exception ex)
			{
                MessageBox.Show($"SetHttpHeader Erro:{ex.Message}");
                throw;
			}
            

        }


		private int GetRepoCount(string userName)
		{

			try
			{
				int count = 2;
				int repoCount = 0;
				string repoUrl = $"https://api.github.com/users/{userName}/repos?per_page=100&page=1";
				List<RespoInfo> arrRes = new List<RespoInfo>();
				string json = SendGetRequest(repoUrl);
				List<RespoInfo> temp = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RespoInfo>>(json);

				arrRes = arrRes.Concat(temp).ToList();

				while (temp.Count == 100)
				{
					temp = new List<RespoInfo>();
					repoUrl = $"https://api.github.com/users/{userName}/repos?per_page=100&page={count}";
					json = SendGetRequest(repoUrl);
					temp = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RespoInfo>>(json);
					arrRes = arrRes.Concat(temp).ToList();

					count++;

				}

				repoCount = arrRes.Count;

				return repoCount;

			}
			catch (Exception ex)
			{
				MessageBox.Show($"GetRepoCount Erro:{ex.Message}");
				throw;
			}

		}



		private Bitmap GetUsersPic(string url) {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "Get";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Bitmap pic = new Bitmap(response.GetResponseStream());
                response.Close();
                pic = ResizeBitmap(pic, 100, 100);


                return pic;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetUsersPic Erro:{ex.Message}");
                throw;
            }
        
        
        
        }

        private Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
			try
			{
                Bitmap result = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.DrawImage(bmp, 0, 0, width, height);
                }

                return result;
            }
			catch (Exception ex)
			{
                MessageBox.Show($"ResizeBitmap Erro:{ex.Message}");
                throw;
			}
           
        }



        private void ShowData(List<UsersInfo> users) {

			try
			{
                BindingSource source = new BindingSource();
                source.DataSource = users;
                dgvShowUsers.DataSource = source;

                //dgvShowUsers.Dock = DockStyle.Fill;
                dgvShowUsers.AllowUserToAddRows = false;
                dgvShowUsers.ReadOnly = true;

                foreach (var item in users)
                {
                    if (item.is_site_admin == false)
                    {
                        dgvShowUsers.Columns["site_admin_icon"].DefaultCellStyle.NullValue = null;
                    }
                }


                dgvShowUsers.Columns["avatar_url"].Visible = false;
                dgvShowUsers.Columns["node_id"].Visible = false;
                dgvShowUsers.Columns["gravatar_id"].Visible = false;
                dgvShowUsers.Columns["url"].Visible = false;
                dgvShowUsers.Columns["followers_url"].Visible = false;
                dgvShowUsers.Columns["following_url"].Visible = false;
                dgvShowUsers.Columns["gists_url"].Visible = false;
                dgvShowUsers.Columns["starred_url"].Visible = false;
                dgvShowUsers.Columns["subscriptions_url"].Visible = false;
                dgvShowUsers.Columns["organizations_url"].Visible = false;
                dgvShowUsers.Columns["repos_url"].Visible = false;
                dgvShowUsers.Columns["events_url"].Visible = false;
                dgvShowUsers.Columns["received_events_url"].Visible = false;
                dgvShowUsers.Columns["type"].Visible = false;
                dgvShowUsers.Columns["id"].Visible = false;
                dgvShowUsers.Columns["is_site_admin"].Visible = false;
                dgvShowUsers.Columns["repo_count"].Visible = false;

                dgvShowUsers.Columns["user_pic"].HeaderText = "使用者圖片";
                dgvShowUsers.Columns["login"].HeaderText = "使用者名稱";
                dgvShowUsers.Columns["html_url"].HeaderText = "GitHub 網站";
                dgvShowUsers.Columns["site_admin_icon"].HeaderText = "Site Admin";


                dgvShowUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
			catch (Exception ex)
			{
                MessageBox.Show($"ShowData Erro:{ex.Message}");
                throw;
			}

          

        }

		//private void btnQuery_Click(object sender, EventArgs e)
		//{
			//int userCount;
			//if (!int.TryParse(txtEnterCount.Text, out userCount))
			//{
			//	MessageBox.Show("請輸入數字!");
			//}

			//if (userCount != 0)
			//{
			//	List<UsersInfo> info = GetGitHubUserListInit();
			//	this.ShowData(info);
			//}

		//}


		//private void btnQuerySiteAdmin_Click(object sender, EventArgs e)
		//{

			//int userCount;
			//if (!int.TryParse(txtEnterCount.Text, out userCount))
			//{
			//	MessageBox.Show("請輸入數字!");
			//}

			//if (userCount != 0)
			//{
			//	List<UsersInfo> info = GetGitHubUserList(userCount, true);
			//	this.ShowData(info);
			//}
		//}

		private void btnBefore_Click(object sender, EventArgs e)
		{
			try
			{
                _since -= 10;

                if (_since < 0)
                {
                    _since = 0;
                    return;
                }

                List<UsersInfo> infos = this.GetGitHubUserList(_since);
                this.ShowData(infos);
            }
			catch (Exception ex)
			{
                MessageBox.Show($"btnBefore_Click Erro:{ex.Message}");
                throw;
			}
           
		}

		private void btnAfter_Click(object sender, EventArgs e)
		{
			try
			{
                _since += 10;

                List<UsersInfo> infos = this.GetGitHubUserList(_since);
                this.ShowData(infos);
            }
			catch (Exception ex)
			{
                MessageBox.Show($"btnAfter_Click Erro:{ex.Message}");
                throw;
			}
           

        }

		private void dgvShowUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
                string currentRowUrl = dgvShowUsers.CurrentRow.Cells["html_url"].Value.ToString();
                if (!string.IsNullOrEmpty(currentRowUrl))
                {
                    string strCmdLine = $"/c start {currentRowUrl}";

                    System.Diagnostics.Process.Start("CMD.exe", strCmdLine);


                }
            }
			catch (Exception ex)
			{
                MessageBox.Show($"OpenGitHubWeb Erro:{ex.Message}");
                throw;
			}

           
        }
	}
}
