
namespace WinformPrac
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_copyClick = new System.Windows.Forms.Button();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btn_copyClick
            // 
            this.btn_copyClick.Location = new System.Drawing.Point(12, 41);
            this.btn_copyClick.Name = "btn_copyClick";
            this.btn_copyClick.Size = new System.Drawing.Size(541, 23);
            this.btn_copyClick.TabIndex = 1;
            this.btn_copyClick.Text = "COPY";
            this.btn_copyClick.UseVisualStyleBackColor = true;
            this.btn_copyClick.Click += new System.EventHandler(this.btn_copyClick_Click);
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(271, 79);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(21, 12);
            this.lbl_progress.TabIndex = 2;
            this.lbl_progress.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 118);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.btn_copyClick);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_copyClick;
        private System.Windows.Forms.Label lbl_progress;
    }
}

