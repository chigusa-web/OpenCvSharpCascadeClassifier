
namespace OpenCvSharpCascadeClassifier
{
    partial class fMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.pbSrc = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.cbCascades = new System.Windows.Forms.ComboBox();
            this.lblCascades = new System.Windows.Forms.Label();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSrc
            // 
            this.pbSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSrc.Location = new System.Drawing.Point(12, 91);
            this.pbSrc.Name = "pbSrc";
            this.pbSrc.Size = new System.Drawing.Size(563, 469);
            this.pbSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSrc.TabIndex = 0;
            this.pbSrc.TabStop = false;
            this.pbSrc.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbSrc_LoadCompleted);
            this.pbSrc.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbSrc_DragDrop);
            this.pbSrc.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbSrc_DragEnter);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblImage.Location = new System.Drawing.Point(9, 72);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(238, 16);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "画像ファイルをドラッグ・アンド・ドロップ";
            // 
            // cbCascades
            // 
            this.cbCascades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCascades.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.cbCascades.FormattingEnabled = true;
            this.cbCascades.Location = new System.Drawing.Point(12, 29);
            this.cbCascades.Name = "cbCascades";
            this.cbCascades.Size = new System.Drawing.Size(513, 24);
            this.cbCascades.TabIndex = 3;
            // 
            // lblCascades
            // 
            this.lblCascades.AutoSize = true;
            this.lblCascades.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblCascades.Location = new System.Drawing.Point(9, 9);
            this.lblCascades.Name = "lblCascades";
            this.lblCascades.Size = new System.Drawing.Size(161, 16);
            this.lblCascades.TabIndex = 4;
            this.lblCascades.Text = "カスケード分類器を指定";
            // 
            // pbOutput
            // 
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(603, 91);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(563, 469);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOutput.TabIndex = 5;
            this.pbOutput.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblOutput.Location = new System.Drawing.Point(600, 72);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(72, 16);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "検出結果";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 569);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.lblCascades);
            this.Controls.Add(this.cbCascades);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pbSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenCvSharp 物体検出";
            ((System.ComponentModel.ISupportInitialize)(this.pbSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSrc;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cbCascades;
        private System.Windows.Forms.Label lblCascades;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

