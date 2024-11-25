namespace clientside
{
    partial class getstart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            getspanel = new Panel();
            weltext = new Label();
            welcome = new Label();
            getbtn = new Button();
            getspanel.SuspendLayout();
            SuspendLayout();
            // 
            // getspanel
            // 
            getspanel.BackgroundImage = Properties.Resources.myback;
            getspanel.BackgroundImageLayout = ImageLayout.Stretch;
            getspanel.Controls.Add(weltext);
            getspanel.Controls.Add(welcome);
            getspanel.Controls.Add(getbtn);
            getspanel.Dock = DockStyle.Fill;
            getspanel.Location = new Point(0, 0);
            getspanel.Name = "getspanel";
            getspanel.Size = new Size(1395, 751);
            getspanel.TabIndex = 0;
            // 
            // weltext
            // 
            weltext.AutoSize = true;
            weltext.BackColor = Color.Transparent;
            weltext.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            weltext.ForeColor = Color.White;
            weltext.Location = new Point(987, 393);
            weltext.Name = "weltext";
            weltext.Size = new Size(294, 80);
            weltext.TabIndex = 3;
            weltext.Text = "Let us help you\r\nmake the move.....\r\n";
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.White;
            welcome.Location = new Point(872, 289);
            welcome.Name = "welcome";
            welcome.Size = new Size(286, 67);
            welcome.TabIndex = 2;
            welcome.Text = "WELCOME!";
            // 
            // getbtn
            // 
            getbtn.BackColor = Color.Transparent;
            getbtn.FlatStyle = FlatStyle.Flat;
            getbtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getbtn.ForeColor = Color.White;
            getbtn.Location = new Point(1241, 606);
            getbtn.Name = "getbtn";
            getbtn.Size = new Size(102, 29);
            getbtn.TabIndex = 1;
            getbtn.Text = "Next  >>";
            getbtn.UseVisualStyleBackColor = false;
            getbtn.Click += getbtn_Click;
            // 
            // getstart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 751);
            Controls.Add(getspanel);
            Name = "getstart";
            Text = "Getstart";
            WindowState = FormWindowState.Maximized;
            getspanel.ResumeLayout(false);
            getspanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel getspanel;
        private Label welcome;
        private Button getbtn;
        private Label weltext;
    }
}
