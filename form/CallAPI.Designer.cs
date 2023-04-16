namespace form
{
    partial class CallAPI
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
            this.GetALL = new System.Windows.Forms.Button();
            this.txtResponce = new System.Windows.Forms.RichTextBox();
            this.Get = new System.Windows.Forms.Button();
            this.Post = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Put = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetALL
            // 
            this.GetALL.Location = new System.Drawing.Point(80, 40);
            this.GetALL.Name = "GetALL";
            this.GetALL.Size = new System.Drawing.Size(86, 62);
            this.GetALL.TabIndex = 0;
            this.GetALL.Text = "Get AII";
            this.GetALL.UseVisualStyleBackColor = true;
            this.GetALL.Click += new System.EventHandler(this.GetALL_Click);
            // 
            // txtResponce
            // 
            this.txtResponce.Location = new System.Drawing.Point(27, 174);
            this.txtResponce.Name = "txtResponce";
            this.txtResponce.Size = new System.Drawing.Size(746, 264);
            this.txtResponce.TabIndex = 1;
            this.txtResponce.Text = "";
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(202, 79);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(100, 23);
            this.Get.TabIndex = 3;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(480, 40);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(97, 62);
            this.Post.TabIndex = 6;
            this.Post.Text = "POST";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(202, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(357, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(357, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // Put
            // 
            ////this.Put.Location = new System.Drawing.Point(624, 40);
            ////this.Put.Name = "Put";
            ////this.Put.Size = new System.Drawing.Size(94, 62);
            ////this.Put.TabIndex = 10;
            ////this.Put.Text = "PUT";
            ////this.Put.UseVisualStyleBackColor = true;
            ////this.Put.Click += new System.EventHandler(this.button1_Click);
            // 
            // CallAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Put);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.txtResponce);
            this.Controls.Add(this.GetALL);
            this.Name = "CallAPI";
            this.Text = "CallAPI";
            this.Load += new System.EventHandler(this.CallAPI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetALL;
        private System.Windows.Forms.RichTextBox txtResponce;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button Put;
    }
}