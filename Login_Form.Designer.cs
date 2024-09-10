namespace EXAMINATIONSYSTEM
{
    partial class Login_Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            user_txt = new Guna.UI2.WinForms.Guna2TextBox();
            Pass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            LoginAs = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 511);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Rockwell", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(63, 64, 117);
            guna2HtmlLabel1.Location = new Point(764, 46);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(145, 52);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "LOGIN";
            // 
            // user_txt
            // 
            user_txt.BorderColor = Color.FromArgb(15, 202, 201);
            user_txt.BorderRadius = 10;
            user_txt.BorderThickness = 2;
            user_txt.CustomizableEdges = customizableEdges1;
            user_txt.DefaultText = "Username\r\n";
            user_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            user_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            user_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            user_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            user_txt.FillColor = Color.WhiteSmoke;
            user_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            user_txt.Font = new Font("Franklin Gothic Medium Cond", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            user_txt.IconLeft = (Image)resources.GetObject("user_txt.IconLeft");
            user_txt.IconLeftCursor = Cursors.IBeam;
            user_txt.IconLeftOffset = new Point(10, 0);
            user_txt.IconLeftSize = new Size(25, 25);
            user_txt.Location = new Point(611, 125);
            user_txt.Margin = new Padding(4, 6, 4, 6);
            user_txt.Name = "user_txt";
            user_txt.PasswordChar = '\0';
            user_txt.PlaceholderText = "";
            user_txt.SelectedText = "";
            user_txt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            user_txt.Size = new Size(429, 66);
            user_txt.TabIndex = 2;
            user_txt.TextOffset = new Point(10, -2);
            // 
            // Pass_txt
            // 
            Pass_txt.BorderColor = Color.FromArgb(15, 202, 201);
            Pass_txt.BorderRadius = 10;
            Pass_txt.BorderThickness = 2;
            Pass_txt.CustomizableEdges = customizableEdges3;
            Pass_txt.DefaultText = "Password";
            Pass_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Pass_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Pass_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Pass_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Pass_txt.FillColor = Color.WhiteSmoke;
            Pass_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Pass_txt.Font = new Font("Franklin Gothic Medium Cond", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pass_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Pass_txt.IconLeft = (Image)resources.GetObject("Pass_txt.IconLeft");
            Pass_txt.IconLeftCursor = Cursors.IBeam;
            Pass_txt.IconLeftOffset = new Point(10, 0);
            Pass_txt.IconLeftSize = new Size(30, 30);
            Pass_txt.Location = new Point(611, 226);
            Pass_txt.Margin = new Padding(4, 6, 4, 6);
            Pass_txt.Name = "Pass_txt";
            Pass_txt.PasswordChar = '\0';
            Pass_txt.PlaceholderText = "";
            Pass_txt.SelectedText = "";
            Pass_txt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Pass_txt.Size = new Size(429, 66);
            Pass_txt.TabIndex = 3;
            Pass_txt.TextOffset = new Point(10, -2);
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(63, 64, 117);
            guna2Button1.Font = new Font("Rockwell Extra Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(707, 443);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(270, 68);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "SUBMIT";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // LoginAs
            // 
            LoginAs.BackColor = Color.Transparent;
            LoginAs.BorderColor = Color.FromArgb(15, 202, 201);
            LoginAs.BorderRadius = 10;
            LoginAs.BorderThickness = 2;
            LoginAs.CustomizableEdges = customizableEdges7;
            LoginAs.DrawMode = DrawMode.OwnerDrawFixed;
            LoginAs.DropDownStyle = ComboBoxStyle.DropDownList;
            LoginAs.FocusedColor = Color.FromArgb(94, 148, 255);
            LoginAs.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LoginAs.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginAs.ForeColor = Color.FromArgb(68, 88, 112);
            LoginAs.ItemHeight = 30;
            LoginAs.Items.AddRange(new object[] { "Student", "Admin", "Teacher" });
            LoginAs.Location = new Point(611, 355);
            LoginAs.Name = "LoginAs";
            LoginAs.ShadowDecoration.CustomizableEdges = customizableEdges8;
            LoginAs.Size = new Size(429, 36);
            LoginAs.TabIndex = 5;
            LoginAs.Tag = "Login As";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = SystemColors.ControlDarkDark;
            guna2HtmlLabel2.Location = new Point(624, 327);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(89, 22);
            guna2HtmlLabel2.TabIndex = 6;
            guna2HtmlLabel2.Text = "Login As...";
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.TransparentWhileDrag = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1068, 586);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(LoginAs);
            Controls.Add(guna2Button1);
            Controls.Add(Pass_txt);
            Controls.Add(user_txt);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox user_txt;
        private Guna.UI2.WinForms.Guna2TextBox Pass_txt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox LoginAs;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}