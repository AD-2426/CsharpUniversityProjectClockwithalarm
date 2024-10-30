namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.buttonSetAlarm = new System.Windows.Forms.Button();
            this.buttonResetAlarm = new System.Windows.Forms.Button();
            this.labelAlarmStatus = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.Hour = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentTime.Location = new System.Drawing.Point(289, 33);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(212, 55);
            this.labelCurrentTime.TabIndex = 0;
            this.labelCurrentTime.Text = "00:00:00";
            this.labelCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHour.Location = new System.Drawing.Point(173, 242);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(146, 31);
            this.textBoxHour.TabIndex = 1;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinute.Location = new System.Drawing.Point(579, 242);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(146, 31);
            this.textBoxMinute.TabIndex = 2;
            // 
            // buttonSetAlarm
            // 
            this.buttonSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetAlarm.Location = new System.Drawing.Point(56, 307);
            this.buttonSetAlarm.Name = "buttonSetAlarm";
            this.buttonSetAlarm.Size = new System.Drawing.Size(263, 108);
            this.buttonSetAlarm.TabIndex = 3;
            this.buttonSetAlarm.Text = "Будильникті қою";
            this.buttonSetAlarm.UseVisualStyleBackColor = true;
            this.buttonSetAlarm.Click += new System.EventHandler(this.buttonSetAlarm_Click);
            // 
            // buttonResetAlarm
            // 
            this.buttonResetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetAlarm.Location = new System.Drawing.Point(458, 307);
            this.buttonResetAlarm.Name = "buttonResetAlarm";
            this.buttonResetAlarm.Size = new System.Drawing.Size(267, 108);
            this.buttonResetAlarm.TabIndex = 4;
            this.buttonResetAlarm.Text = "Будильникті өшіру";
            this.buttonResetAlarm.UseVisualStyleBackColor = true;
            this.buttonResetAlarm.Click += new System.EventHandler(this.buttonResetAlarm_Click);
            // 
            // labelAlarmStatus
            // 
            this.labelAlarmStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAlarmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlarmStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAlarmStatus.Location = new System.Drawing.Point(56, 99);
            this.labelAlarmStatus.Name = "labelAlarmStatus";
            this.labelAlarmStatus.Size = new System.Drawing.Size(669, 92);
            this.labelAlarmStatus.TabIndex = 5;
            this.labelAlarmStatus.Text = "Будильник статусы";
            this.labelAlarmStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hour.Location = new System.Drawing.Point(51, 242);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(69, 25);
            this.Hour.TabIndex = 6;
            this.Hour.Text = "Сағат";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minute.Location = new System.Drawing.Point(453, 242);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(75, 25);
            this.Minute.TabIndex = 7;
            this.Minute.Text = "Минут";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.labelAlarmStatus);
            this.Controls.Add(this.buttonResetAlarm);
            this.Controls.Add(this.buttonSetAlarm);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.labelCurrentTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.Button buttonSetAlarm;
        private System.Windows.Forms.Button buttonResetAlarm;
        private System.Windows.Forms.Label labelAlarmStatus;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Minute;
    }
}

