namespace InterfaceCupula.View
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.BoxCadastro = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.checkBoxAdm = new System.Windows.Forms.CheckBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.textBoxAdm = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxCadastro
            // 
            this.BoxCadastro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BoxCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.BoxCadastro, "BoxCadastro");
            this.BoxCadastro.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BoxCadastro.Name = "BoxCadastro";
            this.BoxCadastro.ReadOnly = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.LimeGreen;
            this.accept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.accept, "accept");
            this.accept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accept.Name = "accept";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Crimson;
            this.cancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.cancel, "cancel");
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Name = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // checkBoxAdm
            // 
            resources.ApplyResources(this.checkBoxAdm, "checkBoxAdm");
            this.checkBoxAdm.Name = "checkBoxAdm";
            this.checkBoxAdm.UseVisualStyleBackColor = true;
            this.checkBoxAdm.CheckedChanged += new System.EventHandler(this.checkBoxAdm_CheckedChanged);
            // 
            // checkBoxUser
            // 
            resources.ApplyResources(this.checkBoxUser, "checkBoxUser");
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            this.checkBoxUser.CheckedChanged += new System.EventHandler(this.checkBoxUser_CheckedChanged);
            // 
            // textBoxAdm
            // 
            this.textBoxAdm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxAdm, "textBoxAdm");
            this.textBoxAdm.Name = "textBoxAdm";
            this.textBoxAdm.TextChanged += new System.EventHandler(this.textBoxAdm_TextChanged);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxUser, "textBoxUser");
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightGray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LightGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1")});
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.BoxCadastro);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBoxAdm);
            this.panel1.Controls.Add(this.accept);
            this.panel1.Controls.Add(this.checkBoxUser);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.checkBoxAdm);
            this.panel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Cadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox2);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxCadastro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.CheckBox checkBoxAdm;
        private System.Windows.Forms.CheckBox checkBoxUser;
        private System.Windows.Forms.TextBox textBoxAdm;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
    }
}