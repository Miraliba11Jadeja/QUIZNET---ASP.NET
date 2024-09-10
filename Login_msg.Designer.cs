namespace EXAMINATIONSYSTEM
{
    partial class Login_msg
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Message_Txt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.DarkSlateBlue;
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(0, 252);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(511, 35);
            guna2Panel1.TabIndex = 0;
            // 
            // Message_Txt
            // 
            Message_Txt.BackColor = Color.Transparent;
            Message_Txt.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Message_Txt.ForeColor = Color.DarkSlateBlue;
            Message_Txt.Location = new Point(117, 52);
            Message_Txt.Name = "Message_Txt";
            Message_Txt.Size = new Size(264, 43);
            Message_Txt.TabIndex = 1;
            Message_Txt.Text = "Login Successfull";
            Message_Txt.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.DarkSlateBlue;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.LightSteelBlue;
            guna2Button1.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(151, 142);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(184, 56);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "OK";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Login_msg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 287);
            Controls.Add(guna2Button1);
            Controls.Add(Message_Txt);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_msg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Msg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Message_Txt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}