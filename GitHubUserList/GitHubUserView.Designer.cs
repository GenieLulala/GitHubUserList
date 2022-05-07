
namespace GitHubUserList
{
    partial class GitHubUserView
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitHubUserView));
			this.dgvShowUsers = new System.Windows.Forms.DataGridView();
			this.btnBefore = new System.Windows.Forms.Button();
			this.btnAfter = new System.Windows.Forms.Button();
			this.pnlDataGridView = new System.Windows.Forms.Panel();
			this.pnlBtn = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).BeginInit();
			this.pnlDataGridView.SuspendLayout();
			this.pnlBtn.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvShowUsers
			// 
			this.dgvShowUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvShowUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvShowUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvShowUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShowUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvShowUsers.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvShowUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvShowUsers.Location = new System.Drawing.Point(0, 0);
			this.dgvShowUsers.Name = "dgvShowUsers";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvShowUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvShowUsers.RowHeadersWidth = 50;
			this.dgvShowUsers.RowTemplate.Height = 24;
			this.dgvShowUsers.Size = new System.Drawing.Size(689, 532);
			this.dgvShowUsers.TabIndex = 0;
			this.dgvShowUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShowUsers_CellMouseClick);
			// 
			// btnBefore
			// 
			this.btnBefore.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnBefore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBefore.BackgroundImage")));
			this.btnBefore.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnBefore.Location = new System.Drawing.Point(669, 12);
			this.btnBefore.Name = "btnBefore";
			this.btnBefore.Size = new System.Drawing.Size(32, 32);
			this.btnBefore.TabIndex = 5;
			this.btnBefore.UseVisualStyleBackColor = true;
			this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
			// 
			// btnAfter
			// 
			this.btnAfter.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAfter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAfter.BackgroundImage")));
			this.btnAfter.Location = new System.Drawing.Point(707, 12);
			this.btnAfter.Name = "btnAfter";
			this.btnAfter.Size = new System.Drawing.Size(32, 32);
			this.btnAfter.TabIndex = 6;
			this.btnAfter.UseVisualStyleBackColor = true;
			this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
			// 
			// pnlDataGridView
			// 
			this.pnlDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlDataGridView.BackColor = System.Drawing.Color.White;
			this.pnlDataGridView.Controls.Add(this.dgvShowUsers);
			this.pnlDataGridView.Location = new System.Drawing.Point(33, 64);
			this.pnlDataGridView.Name = "pnlDataGridView";
			this.pnlDataGridView.Size = new System.Drawing.Size(689, 532);
			this.pnlDataGridView.TabIndex = 7;
			// 
			// pnlBtn
			// 
			this.pnlBtn.Controls.Add(this.btnAfter);
			this.pnlBtn.Controls.Add(this.btnBefore);
			this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBtn.Location = new System.Drawing.Point(0, 0);
			this.pnlBtn.Name = "pnlBtn";
			this.pnlBtn.Size = new System.Drawing.Size(761, 50);
			this.pnlBtn.TabIndex = 8;
			// 
			// GitHubUserView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
			this.ClientSize = new System.Drawing.Size(761, 628);
			this.Controls.Add(this.pnlDataGridView);
			this.Controls.Add(this.pnlBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GitHubUserView";
			this.Text = "GitHub使用者列表";
			((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).EndInit();
			this.pnlDataGridView.ResumeLayout(false);
			this.pnlBtn.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowUsers;
		private System.Windows.Forms.Button btnBefore;
		private System.Windows.Forms.Button btnAfter;
		private System.Windows.Forms.Panel pnlDataGridView;
		private System.Windows.Forms.Panel pnlBtn;
	}
}

