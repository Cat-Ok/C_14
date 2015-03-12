namespace C_14
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Information_Show = new System.Windows.Forms.Button();
            this.pct_Box = new System.Windows.Forms.PictureBox();
            this.btn_Foto_Show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cproducts_Name_Show = new System.Windows.Forms.TextBox();
            this.Cproducts_Fresh_Show = new System.Windows.Forms.TextBox();
            this.Cproducts_Price_Show = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.list_of_CProducts = new System.Windows.Forms.ListBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.Change_PriceCProducts = new System.Windows.Forms.Button();
            this.Change_SFresh_CProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Information_Show
            // 
            this.btn_Information_Show.Location = new System.Drawing.Point(12, 153);
            this.btn_Information_Show.Name = "btn_Information_Show";
            this.btn_Information_Show.Size = new System.Drawing.Size(130, 23);
            this.btn_Information_Show.TabIndex = 1;
            this.btn_Information_Show.Text = "Показати інформацію";
            this.btn_Information_Show.UseVisualStyleBackColor = true;
            this.btn_Information_Show.Click += new System.EventHandler(this.button1_Click);
            // 
            // pct_Box
            // 
            this.pct_Box.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pct_Box.ErrorImage")));
            this.pct_Box.Location = new System.Drawing.Point(14, 9);
            this.pct_Box.Name = "pct_Box";
            this.pct_Box.Size = new System.Drawing.Size(268, 135);
            this.pct_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Box.TabIndex = 2;
            this.pct_Box.TabStop = false;
            // 
            // btn_Foto_Show
            // 
            this.btn_Foto_Show.Location = new System.Drawing.Point(149, 153);
            this.btn_Foto_Show.Name = "btn_Foto_Show";
            this.btn_Foto_Show.Size = new System.Drawing.Size(132, 23);
            this.btn_Foto_Show.TabIndex = 3;
            this.btn_Foto_Show.Text = "Показати фотографію";
            this.btn_Foto_Show.UseVisualStyleBackColor = true;
            this.btn_Foto_Show.Click += new System.EventHandler(this.btn_Foto_Show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Назва";
            // 
            // Cproducts_Name_Show
            // 
            this.Cproducts_Name_Show.Location = new System.Drawing.Point(342, 9);
            this.Cproducts_Name_Show.Name = "Cproducts_Name_Show";
            this.Cproducts_Name_Show.Size = new System.Drawing.Size(157, 20);
            this.Cproducts_Name_Show.TabIndex = 6;
            // 
            // Cproducts_Fresh_Show
            // 
            this.Cproducts_Fresh_Show.Location = new System.Drawing.Point(342, 65);
            this.Cproducts_Fresh_Show.Name = "Cproducts_Fresh_Show";
            this.Cproducts_Fresh_Show.Size = new System.Drawing.Size(157, 20);
            this.Cproducts_Fresh_Show.TabIndex = 7;
            // 
            // Cproducts_Price_Show
            // 
            this.Cproducts_Price_Show.Location = new System.Drawing.Point(342, 39);
            this.Cproducts_Price_Show.Name = "Cproducts_Price_Show";
            this.Cproducts_Price_Show.Size = new System.Drawing.Size(157, 20);
            this.Cproducts_Price_Show.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Свіжість";
            // 
            // list_of_CProducts
            // 
            this.list_of_CProducts.FormattingEnabled = true;
            this.list_of_CProducts.Location = new System.Drawing.Point(287, 94);
            this.list_of_CProducts.Name = "list_of_CProducts";
            this.list_of_CProducts.ScrollAlwaysVisible = true;
            this.list_of_CProducts.Size = new System.Drawing.Size(212, 82);
            this.list_of_CProducts.TabIndex = 11;
            this.list_of_CProducts.SelectedIndexChanged += new System.EventHandler(this.list_of_CProducts_SelectedIndexChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(248, 120);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(33, 23);
            this.btn_Next.TabIndex = 12;
            this.btn_Next.Text = "->";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Change_PriceCProducts
            // 
            this.Change_PriceCProducts.Location = new System.Drawing.Point(474, 38);
            this.Change_PriceCProducts.Name = "Change_PriceCProducts";
            this.Change_PriceCProducts.Size = new System.Drawing.Size(25, 20);
            this.Change_PriceCProducts.TabIndex = 14;
            this.Change_PriceCProducts.Text = "P";
            this.Change_PriceCProducts.UseVisualStyleBackColor = true;
            this.Change_PriceCProducts.Click += new System.EventHandler(this.Change_PriceCProducts_Click);
            // 
            // Change_SFresh_CProducts
            // 
            this.Change_SFresh_CProducts.Location = new System.Drawing.Point(474, 65);
            this.Change_SFresh_CProducts.Name = "Change_SFresh_CProducts";
            this.Change_SFresh_CProducts.Size = new System.Drawing.Size(25, 20);
            this.Change_SFresh_CProducts.TabIndex = 15;
            this.Change_SFresh_CProducts.Text = "F";
            this.Change_SFresh_CProducts.UseVisualStyleBackColor = true;
            this.Change_SFresh_CProducts.Click += new System.EventHandler(this.Change_SFresh_CProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(511, 188);
            this.Controls.Add(this.Change_SFresh_CProducts);
            this.Controls.Add(this.Change_PriceCProducts);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.list_of_CProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cproducts_Price_Show);
            this.Controls.Add(this.Cproducts_Fresh_Show);
            this.Controls.Add(this.Cproducts_Name_Show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Foto_Show);
            this.Controls.Add(this.pct_Box);
            this.Controls.Add(this.btn_Information_Show);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Information_Show;
        private System.Windows.Forms.PictureBox pct_Box;
        private System.Windows.Forms.Button btn_Foto_Show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cproducts_Name_Show;
        private System.Windows.Forms.TextBox Cproducts_Fresh_Show;
        private System.Windows.Forms.TextBox Cproducts_Price_Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_of_CProducts;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button Change_PriceCProducts;
        private System.Windows.Forms.Button Change_SFresh_CProducts;
    }
}

