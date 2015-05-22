namespace Hough変換テスト
{
    partial class メイン画面
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button_開く = new System.Windows.Forms.Button();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label_color = new System.Windows.Forms.Label();
            this.label_座標 = new System.Windows.Forms.Label();
            this.trackBar_Closing = new System.Windows.Forms.TrackBar();
            this.button_実行 = new System.Windows.Forms.Button();
            this.button_保存 = new System.Windows.Forms.Button();
            this.trackBar_canny2 = new System.Windows.Forms.TrackBar();
            this.trackBar_canny1 = new System.Windows.Forms.TrackBar();
            this.trackBar_rho = new System.Windows.Forms.TrackBar();
            this.trackBar_threshold = new System.Windows.Forms.TrackBar();
            this.trackBar_param2 = new System.Windows.Forms.TrackBar();
            this.trackBar_param1 = new System.Windows.Forms.TrackBar();
            this.textBox_rho = new System.Windows.Forms.TextBox();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.textBox_param1 = new System.Windows.Forms.TextBox();
            this.textBox_param2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Closing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_canny2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_canny1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_rho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_param2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_param1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(113, 12);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(429, 421);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            this.pictureBoxIpl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClick_pictureBoxIpl1);
            this.pictureBoxIpl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_pictureBoxIpl1);
            // 
            // button_開く
            // 
            this.button_開く.Location = new System.Drawing.Point(11, 12);
            this.button_開く.Name = "button_開く";
            this.button_開く.Size = new System.Drawing.Size(81, 23);
            this.button_開く.TabIndex = 1;
            this.button_開く.Text = "開く";
            this.button_開く.UseVisualStyleBackColor = true;
            this.button_開く.Click += new System.EventHandler(this.OnClick開く);
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(12, 42);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(30, 19);
            this.textBox_x.TabIndex = 2;
            this.textBox_x.Text = "x";
            this.textBox_x.TextChanged += new System.EventHandler(this.TextChanged_x);
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(48, 42);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(30, 19);
            this.textBox_y.TabIndex = 3;
            this.textBox_y.Text = "y";
            this.textBox_y.TextChanged += new System.EventHandler(this.TextChanged_y);
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Location = new System.Drawing.Point(15, 64);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(10, 12);
            this.label_color.TabIndex = 4;
            this.label_color.Text = "?";
            // 
            // label_座標
            // 
            this.label_座標.AutoSize = true;
            this.label_座標.Location = new System.Drawing.Point(46, 76);
            this.label_座標.Name = "label_座標";
            this.label_座標.Size = new System.Drawing.Size(27, 12);
            this.label_座標.TabIndex = 5;
            this.label_座標.Text = "(x,y)";
            // 
            // trackBar_Closing
            // 
            this.trackBar_Closing.Location = new System.Drawing.Point(3, 193);
            this.trackBar_Closing.Name = "trackBar_Closing";
            this.trackBar_Closing.Size = new System.Drawing.Size(90, 45);
            this.trackBar_Closing.TabIndex = 6;
            this.trackBar_Closing.Value = 1;
            this.trackBar_Closing.Scroll += new System.EventHandler(this.OnScroll_trackBar_Closing);
            // 
            // button_実行
            // 
            this.button_実行.Location = new System.Drawing.Point(12, 417);
            this.button_実行.Name = "button_実行";
            this.button_実行.Size = new System.Drawing.Size(66, 23);
            this.button_実行.TabIndex = 7;
            this.button_実行.Text = "実行";
            this.button_実行.UseVisualStyleBackColor = true;
            this.button_実行.Click += new System.EventHandler(this.OnClick実行);
            // 
            // button_保存
            // 
            this.button_保存.Location = new System.Drawing.Point(12, 465);
            this.button_保存.Name = "button_保存";
            this.button_保存.Size = new System.Drawing.Size(66, 23);
            this.button_保存.TabIndex = 13;
            this.button_保存.Text = "保存";
            this.button_保存.UseVisualStyleBackColor = true;
            this.button_保存.Click += new System.EventHandler(this.OnClick保存);
            // 
            // trackBar_canny2
            // 
            this.trackBar_canny2.Location = new System.Drawing.Point(3, 142);
            this.trackBar_canny2.Maximum = 255;
            this.trackBar_canny2.Name = "trackBar_canny2";
            this.trackBar_canny2.Size = new System.Drawing.Size(90, 45);
            this.trackBar_canny2.TabIndex = 14;
            this.trackBar_canny2.Value = 100;
            this.trackBar_canny2.Scroll += new System.EventHandler(this.OnScroll_canny2);
            // 
            // trackBar_canny1
            // 
            this.trackBar_canny1.Location = new System.Drawing.Point(3, 91);
            this.trackBar_canny1.Maximum = 255;
            this.trackBar_canny1.Name = "trackBar_canny1";
            this.trackBar_canny1.Size = new System.Drawing.Size(90, 45);
            this.trackBar_canny1.TabIndex = 15;
            this.trackBar_canny1.Value = 200;
            this.trackBar_canny1.Scroll += new System.EventHandler(this.OnScroll_canny1);
            // 
            // trackBar_rho
            // 
            this.trackBar_rho.Location = new System.Drawing.Point(3, 233);
            this.trackBar_rho.Minimum = 1;
            this.trackBar_rho.Name = "trackBar_rho";
            this.trackBar_rho.Size = new System.Drawing.Size(75, 45);
            this.trackBar_rho.TabIndex = 16;
            this.trackBar_rho.Value = 1;
            this.trackBar_rho.Scroll += new System.EventHandler(this.trackBar1_rho_Scroll);
            // 
            // trackBar_threshold
            // 
            this.trackBar_threshold.Location = new System.Drawing.Point(3, 275);
            this.trackBar_threshold.Maximum = 100;
            this.trackBar_threshold.Minimum = 1;
            this.trackBar_threshold.Name = "trackBar_threshold";
            this.trackBar_threshold.Size = new System.Drawing.Size(75, 45);
            this.trackBar_threshold.TabIndex = 17;
            this.trackBar_threshold.Value = 1;
            this.trackBar_threshold.Scroll += new System.EventHandler(this.trackBar_threshold_Scroll);
            // 
            // trackBar_param2
            // 
            this.trackBar_param2.Location = new System.Drawing.Point(3, 366);
            this.trackBar_param2.Maximum = 100;
            this.trackBar_param2.Name = "trackBar_param2";
            this.trackBar_param2.Size = new System.Drawing.Size(75, 45);
            this.trackBar_param2.TabIndex = 19;
            this.trackBar_param2.Scroll += new System.EventHandler(this.trackBar_param2_Scroll);
            // 
            // trackBar_param1
            // 
            this.trackBar_param1.Location = new System.Drawing.Point(3, 315);
            this.trackBar_param1.Maximum = 100;
            this.trackBar_param1.Name = "trackBar_param1";
            this.trackBar_param1.Size = new System.Drawing.Size(75, 45);
            this.trackBar_param1.TabIndex = 20;
            this.trackBar_param1.Scroll += new System.EventHandler(this.trackBar_param1_Scroll);
            // 
            // textBox_rho
            // 
            this.textBox_rho.Location = new System.Drawing.Point(77, 233);
            this.textBox_rho.Name = "textBox_rho";
            this.textBox_rho.Size = new System.Drawing.Size(30, 19);
            this.textBox_rho.TabIndex = 21;
            this.textBox_rho.Text = "1";
            this.textBox_rho.TextChanged += new System.EventHandler(this.OnTextChanged_rho);
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Location = new System.Drawing.Point(77, 275);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(30, 19);
            this.textBox_threshold.TabIndex = 22;
            this.textBox_threshold.Text = "1";
            this.textBox_threshold.TextChanged += new System.EventHandler(this.OnTextChanged_threshold);
            // 
            // textBox_param1
            // 
            this.textBox_param1.Location = new System.Drawing.Point(77, 315);
            this.textBox_param1.Name = "textBox_param1";
            this.textBox_param1.Size = new System.Drawing.Size(30, 19);
            this.textBox_param1.TabIndex = 23;
            this.textBox_param1.Text = "1";
            this.textBox_param1.TextChanged += new System.EventHandler(this.OnTextChanged_param1);
            // 
            // textBox_param2
            // 
            this.textBox_param2.Location = new System.Drawing.Point(77, 375);
            this.textBox_param2.Name = "textBox_param2";
            this.textBox_param2.Size = new System.Drawing.Size(30, 19);
            this.textBox_param2.TabIndex = 24;
            this.textBox_param2.Text = "1";
            this.textBox_param2.TextChanged += new System.EventHandler(this.OnTextChanged_param2);
            // 
            // メイン画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(573, 500);
            this.Controls.Add(this.textBox_param2);
            this.Controls.Add(this.textBox_param1);
            this.Controls.Add(this.textBox_threshold);
            this.Controls.Add(this.textBox_rho);
            this.Controls.Add(this.trackBar_param1);
            this.Controls.Add(this.trackBar_param2);
            this.Controls.Add(this.trackBar_threshold);
            this.Controls.Add(this.trackBar_rho);
            this.Controls.Add(this.trackBar_canny1);
            this.Controls.Add(this.trackBar_canny2);
            this.Controls.Add(this.button_保存);
            this.Controls.Add(this.button_実行);
            this.Controls.Add(this.trackBar_Closing);
            this.Controls.Add(this.label_座標);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.button_開く);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "メイン画面";
            this.Text = "メイン画面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Closing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_canny2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_canny1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_rho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_param2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_param1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Button button_開く;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Label label_座標;
        private System.Windows.Forms.TrackBar trackBar_Closing;
        private System.Windows.Forms.Button button_実行;
        private System.Windows.Forms.Button button_保存;
        private System.Windows.Forms.TrackBar trackBar_canny2;
        private System.Windows.Forms.TrackBar trackBar_canny1;
        private System.Windows.Forms.TrackBar trackBar_rho;
        private System.Windows.Forms.TrackBar trackBar_threshold;
        private System.Windows.Forms.TrackBar trackBar_param2;
        private System.Windows.Forms.TrackBar trackBar_param1;
        private System.Windows.Forms.TextBox textBox_rho;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.TextBox textBox_param1;
        private System.Windows.Forms.TextBox textBox_param2;
    }
}

