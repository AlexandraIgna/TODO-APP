namespace TO_DO_APP
{
    partial class EditEventForm
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
            this.txtNewEvent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNewEvent
            // 
            this.txtNewEvent.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewEvent.Location = new System.Drawing.Point(17, 68);
            this.txtNewEvent.Name = "txtNewEvent";
            this.txtNewEvent.Size = new System.Drawing.Size(370, 34);
            this.txtNewEvent.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(17, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(370, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(17, 525);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(370, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 21;
            this.listBoxEvents.Location = new System.Drawing.Point(17, 108);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(370, 361);
            this.listBoxEvents.TabIndex = 7;
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(17, 28);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(370, 34);
            this.txtdate.TabIndex = 8;
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 589);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewEvent);
            this.Name = "EditEventForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.EditEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewEvent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.TextBox txtdate;
    }
}