﻿namespace ADO
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnection = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(69, 31);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(124, 23);
            this.buttonConnection.TabIndex = 0;
            this.buttonConnection.Text = "Connection Oeffnen";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(94, 73);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonCommand.TabIndex = 1;
            this.buttonCommand.Text = "Komando";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Visible = false;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(94, 114);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Lesen";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(23, 154);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(231, 95);
            this.listBoxAusgabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.buttonConnection);
            this.Name = "Form1";
            this.Text = "ADO - Connect Beispiel 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxAusgabe;
    }
}

