namespace myFirstWindowsApp
{
    partial class animatorMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("sdkksva");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("smdvk");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(",mlknlljbj");
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainButtonsPanel = new System.Windows.Forms.Panel();
            this.master_character_button = new System.Windows.Forms.Button();
            this.master_writer_button = new System.Windows.Forms.Button();
            this.master_vioceActor_button = new System.Windows.Forms.Button();
            this.master_modify_button = new System.Windows.Forms.Button();
            this.master_anime_button = new System.Windows.Forms.Button();
            this.master_studio_button = new System.Windows.Forms.Button();
            this.master_manga_button = new System.Windows.Forms.Button();
            this.form_master_panel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TopPanel.SuspendLayout();
            this.MainButtonsPanel.SuspendLayout();
            this.form_master_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.AutoSize = true;
            this.TopPanel.BackColor = System.Drawing.Color.MistyRose;
            this.TopPanel.Controls.Add(this.MainButtonsPanel);
            this.TopPanel.ForeColor = System.Drawing.Color.DarkRed;
            this.TopPanel.Location = new System.Drawing.Point(2, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(2004, 79);
            this.TopPanel.TabIndex = 19;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // MainButtonsPanel
            // 
            this.MainButtonsPanel.AutoSize = true;
            this.MainButtonsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.MainButtonsPanel.Controls.Add(this.master_character_button);
            this.MainButtonsPanel.Controls.Add(this.master_writer_button);
            this.MainButtonsPanel.Controls.Add(this.master_vioceActor_button);
            this.MainButtonsPanel.Controls.Add(this.master_modify_button);
            this.MainButtonsPanel.Controls.Add(this.master_anime_button);
            this.MainButtonsPanel.Controls.Add(this.master_studio_button);
            this.MainButtonsPanel.Controls.Add(this.master_manga_button);
            this.MainButtonsPanel.ForeColor = System.Drawing.Color.Red;
            this.MainButtonsPanel.Location = new System.Drawing.Point(3, 2);
            this.MainButtonsPanel.Name = "MainButtonsPanel";
            this.MainButtonsPanel.Size = new System.Drawing.Size(1099, 74);
            this.MainButtonsPanel.TabIndex = 8;
            // 
            // master_character_button
            // 
            this.master_character_button.BackColor = System.Drawing.Color.MistyRose;
            this.master_character_button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.master_character_button.FlatAppearance.BorderSize = 0;
            this.master_character_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.master_character_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.master_character_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.master_character_button.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_character_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.master_character_button.Location = new System.Drawing.Point(778, 3);
            this.master_character_button.Name = "master_character_button";
            this.master_character_button.Size = new System.Drawing.Size(172, 68);
            this.master_character_button.TabIndex = 17;
            this.master_character_button.Text = "character";
            this.master_character_button.UseVisualStyleBackColor = false;
            // 
            // master_writer_button
            // 
            this.master_writer_button.BackColor = System.Drawing.Color.MistyRose;
            this.master_writer_button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.master_writer_button.FlatAppearance.BorderSize = 0;
            this.master_writer_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.master_writer_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.master_writer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.master_writer_button.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_writer_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.master_writer_button.Location = new System.Drawing.Point(627, 3);
            this.master_writer_button.Name = "master_writer_button";
            this.master_writer_button.Size = new System.Drawing.Size(150, 68);
            this.master_writer_button.TabIndex = 14;
            this.master_writer_button.Text = "writer";
            this.master_writer_button.UseVisualStyleBackColor = false;
            this.master_writer_button.Click += new System.EventHandler(this.Writer_Button_Click);
            // 
            // master_vioceActor_button
            // 
            this.master_vioceActor_button.BackColor = System.Drawing.Color.MistyRose;
            this.master_vioceActor_button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.master_vioceActor_button.FlatAppearance.BorderSize = 0;
            this.master_vioceActor_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.master_vioceActor_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.master_vioceActor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.master_vioceActor_button.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_vioceActor_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.master_vioceActor_button.Location = new System.Drawing.Point(299, 3);
            this.master_vioceActor_button.Name = "master_vioceActor_button";
            this.master_vioceActor_button.Size = new System.Drawing.Size(176, 68);
            this.master_vioceActor_button.TabIndex = 18;
            this.master_vioceActor_button.Text = "voice actor";
            this.master_vioceActor_button.UseVisualStyleBackColor = false;
            this.master_vioceActor_button.Click += new System.EventHandler(this.Performer_Button_Click);
            // 
            // master_modify_button
            // 
            this.master_modify_button.BackColor = System.Drawing.Color.MistyRose;
            this.master_modify_button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.master_modify_button.FlatAppearance.BorderSize = 0;
            this.master_modify_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.master_modify_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.master_modify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.master_modify_button.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_modify_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.master_modify_button.Location = new System.Drawing.Point(951, 3);
            this.master_modify_button.Name = "master_modify_button";
            this.master_modify_button.Size = new System.Drawing.Size(144, 68);
            this.master_modify_button.TabIndex = 16;
            this.master_modify_button.Text = "modify";
            this.master_modify_button.UseVisualStyleBackColor = false;
            // 
            // master_anime_button
            // 
            this.master_anime_button.BackColor = System.Drawing.Color.MistyRose;
            this.master_anime_button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.master_anime_button.FlatAppearance.BorderSize = 0;
            this.master_anime_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.master_anime_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.master_anime_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.master_anime_button.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_anime_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.master_anime_button.Location = new System.Drawing.Point(3, 3);
            this.master_anime_button.Name = "master_anime_button";
            this.master_anime_button.Size = new System.Drawing.Size(150, 68);
            this.master_anime_button.TabIndex = 14;
            this.master_anime_button.Text = "anime";
            this.master_anime_button.UseVisualStyleBackColor = false;
            // 
            // master_studio_button
            // 
            this.master_studio_button.BackColor = System.Drawing.Color.MistyRose;
            this.master_studio_button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.master_studio_button.FlatAppearance.BorderSize = 0;
            this.master_studio_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.master_studio_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.master_studio_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.master_studio_button.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_studio_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.master_studio_button.Location = new System.Drawing.Point(476, 3);
            this.master_studio_button.Name = "master_studio_button";
            this.master_studio_button.Size = new System.Drawing.Size(150, 68);
            this.master_studio_button.TabIndex = 13;
            this.master_studio_button.Text = "studio";
            this.master_studio_button.UseVisualStyleBackColor = false;
            this.master_studio_button.Click += new System.EventHandler(this.button14_Click);
            // 
            // master_manga_button
            // 
            this.master_manga_button.BackColor = System.Drawing.Color.MistyRose;
            this.master_manga_button.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.master_manga_button.FlatAppearance.BorderSize = 0;
            this.master_manga_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.master_manga_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.master_manga_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.master_manga_button.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_manga_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.master_manga_button.Location = new System.Drawing.Point(154, 3);
            this.master_manga_button.Name = "master_manga_button";
            this.master_manga_button.Size = new System.Drawing.Size(144, 68);
            this.master_manga_button.TabIndex = 15;
            this.master_manga_button.Text = "manga";
            this.master_manga_button.UseVisualStyleBackColor = false;
            this.master_manga_button.Click += new System.EventHandler(this.Manga_Button_Click);
            this.master_manga_button.MouseLeave += new System.EventHandler(this.Manga_Button_MouseLeave);
            this.master_manga_button.MouseHover += new System.EventHandler(this.Manga_Button_MouseHover);
            // 
            // form_master_panel
            // 
            this.form_master_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_master_panel.BackColor = System.Drawing.Color.FloralWhite;
            this.form_master_panel.Controls.Add(this.listView1);
            this.form_master_panel.Controls.Add(this.TopPanel);
            this.form_master_panel.Location = new System.Drawing.Point(0, 0);
            this.form_master_panel.Name = "form_master_panel";
            this.form_master_panel.Size = new System.Drawing.Size(1123, 528);
            this.form_master_panel.TabIndex = 21;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(561, 211);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // animatorMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1123, 519);
            this.Controls.Add(this.form_master_panel);
            this.IsMdiContainer = true;
            this.Name = "animatorMaster";
            this.Text = "animatorMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.animatorMaster_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainButtonsPanel.ResumeLayout(false);
            this.form_master_panel.ResumeLayout(false);
            this.form_master_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel form_master_panel;
        public System.Windows.Forms.Panel TopPanel;
        public System.Windows.Forms.Panel MainButtonsPanel;
        public System.Windows.Forms.Button master_character_button;
        public System.Windows.Forms.Button master_writer_button;
        public System.Windows.Forms.Button master_vioceActor_button;
        public System.Windows.Forms.Button master_modify_button;
        public System.Windows.Forms.Button master_anime_button;
        public System.Windows.Forms.Button master_studio_button;
        public System.Windows.Forms.Button master_manga_button;
        private System.Windows.Forms.ListView listView1;
    }
}