namespace WindowsFormsApp4.Forms
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCross = new System.Windows.Forms.Button();
            this.lblMinimize = new System.Windows.Forms.Button();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblTotalnotext = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSerialnotext = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtServeby = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblServedby = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCross);
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.lblCName);
            this.panel1.Controls.Add(this.lblEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblCross
            // 
            this.lblCross.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblCross.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lblCross.FlatAppearance.BorderSize = 2;
            this.lblCross.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.lblCross.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.lblCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCross.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCross.ForeColor = System.Drawing.Color.Transparent;
            this.lblCross.Location = new System.Drawing.Point(981, 0);
            this.lblCross.Name = "lblCross";
            this.lblCross.Size = new System.Drawing.Size(61, 58);
            this.lblCross.TabIndex = 0;
            this.lblCross.Text = "X";
            this.lblCross.UseVisualStyleBackColor = false;
            // 
            // lblMinimize
            // 
            this.lblMinimize.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMinimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lblMinimize.FlatAppearance.BorderSize = 2;
            this.lblMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.lblMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.lblMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Location = new System.Drawing.Point(932, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(54, 58);
            this.lblMinimize.TabIndex = 0;
            this.lblMinimize.Text = "____";
            this.lblMinimize.UseVisualStyleBackColor = false;
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Elephant", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCName.Location = new System.Drawing.Point(308, 16);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(440, 42);
            this.lblCName.TabIndex = 0;
            this.lblCName.Text = "American Fried Chiken";
            this.lblCName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Elephant", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(12, 16);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(97, 42);
            this.lblEdit.TabIndex = 0;
            this.lblEdit.Text = "Edit";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdit.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.img);
            this.panel2.Controls.Add(this.lblImage);
            this.panel2.Controls.Add(this.lblTotalnotext);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblSerialnotext);
            this.panel2.Controls.Add(this.lblSerial);
            this.panel2.Controls.Add(this.txtServeby);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblServedby);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(239, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 644);
            this.panel2.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.Location = new System.Drawing.Point(420, 434);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(89, 29);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOk.FlatAppearance.BorderSize = 3;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOk.Location = new System.Drawing.Point(316, 519);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(168, 51);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(100, 519);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 51);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // img
            // 
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.img.Location = new System.Drawing.Point(269, 419);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(145, 62);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImage.Location = new System.Drawing.Point(138, 434);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(97, 29);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Image";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalnotext
            // 
            this.lblTotalnotext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalnotext.Location = new System.Drawing.Point(269, 369);
            this.lblTotalnotext.Name = "lblTotalnotext";
            this.lblTotalnotext.Size = new System.Drawing.Size(97, 29);
            this.lblTotalnotext.TabIndex = 0;
            this.lblTotalnotext.Text = "0000";
            this.lblTotalnotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(138, 369);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 29);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerialnotext
            // 
            this.lblSerialnotext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSerialnotext.Location = new System.Drawing.Point(269, 69);
            this.lblSerialnotext.Name = "lblSerialnotext";
            this.lblSerialnotext.Size = new System.Drawing.Size(97, 29);
            this.lblSerialnotext.TabIndex = 0;
            this.lblSerialnotext.Text = "0000";
            this.lblSerialnotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerial
            // 
            this.lblSerial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSerial.Location = new System.Drawing.Point(138, 69);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(97, 29);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.Text = "Serial";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServeby
            // 
            this.txtServeby.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtServeby.Location = new System.Drawing.Point(269, 305);
            this.txtServeby.Name = "txtServeby";
            this.txtServeby.PlaceholderText = "Write";
            this.txtServeby.Size = new System.Drawing.Size(145, 34);
            this.txtServeby.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(269, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Write";
            this.txtPrice.Size = new System.Drawing.Size(145, 34);
            this.txtPrice.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQty.Location = new System.Drawing.Point(269, 177);
            this.txtQty.Name = "txtQty";
            this.txtQty.PlaceholderText = "Write";
            this.txtQty.Size = new System.Drawing.Size(145, 34);
            this.txtQty.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(269, 123);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Write";
            this.txtName.Size = new System.Drawing.Size(145, 34);
            this.txtName.TabIndex = 1;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQty.Location = new System.Drawing.Point(138, 177);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(97, 29);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "QTY";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(138, 239);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(97, 29);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServedby
            // 
            this.lblServedby.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServedby.Location = new System.Drawing.Point(138, 305);
            this.lblServedby.Name = "lblServedby";
            this.lblServedby.Size = new System.Drawing.Size(97, 29);
            this.lblServedby.TabIndex = 0;
            this.lblServedby.Text = "ServeBy";
            this.lblServedby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(138, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 736);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Button lblMinimize;
        private System.Windows.Forms.Button lblCross;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtServeby;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblServedby;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblTotalnotext;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSerialnotext;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnOk;
    }
}