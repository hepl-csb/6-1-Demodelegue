namespace _11_Demodelegue
{
    partial class CalculatriceForm
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
            this.CalculerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre1TB = new System.Windows.Forms.TextBox();
            this.Nombre2TB = new System.Windows.Forms.TextBox();
            this.OperateurCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultatTB = new System.Windows.Forms.TextBox();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculerButton
            // 
            this.CalculerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculerButton.Location = new System.Drawing.Point(78, 248);
            this.CalculerButton.Margin = new System.Windows.Forms.Padding(6);
            this.CalculerButton.Name = "CalculerButton";
            this.CalculerButton.Size = new System.Drawing.Size(479, 178);
            this.CalculerButton.TabIndex = 6;
            this.CalculerButton.Text = "Calculer";
            this.CalculerButton.UseVisualStyleBackColor = true;
            this.CalculerButton.Click += new System.EventHandler(this.CalculerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre 2";
            // 
            // Nombre1TB
            // 
            this.Nombre1TB.Location = new System.Drawing.Point(78, 111);
            this.Nombre1TB.Margin = new System.Windows.Forms.Padding(6);
            this.Nombre1TB.Name = "Nombre1TB";
            this.Nombre1TB.Size = new System.Drawing.Size(196, 38);
            this.Nombre1TB.TabIndex = 3;
            // 
            // Nombre2TB
            // 
            this.Nombre2TB.Location = new System.Drawing.Point(361, 111);
            this.Nombre2TB.Margin = new System.Windows.Forms.Padding(6);
            this.Nombre2TB.Name = "Nombre2TB";
            this.Nombre2TB.Size = new System.Drawing.Size(196, 38);
            this.Nombre2TB.TabIndex = 4;
            // 
            // OperateurCB
            // 
            this.OperateurCB.FormattingEnabled = true;
            this.OperateurCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperateurCB.Location = new System.Drawing.Point(78, 174);
            this.OperateurCB.Margin = new System.Windows.Forms.Padding(6);
            this.OperateurCB.Name = "OperateurCB";
            this.OperateurCB.Size = new System.Drawing.Size(479, 39);
            this.OperateurCB.TabIndex = 5;
            this.OperateurCB.SelectedIndexChanged += new System.EventHandler(this.OperateurCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Résultat";
            // 
            // ResultatTB
            // 
            this.ResultatTB.Location = new System.Drawing.Point(78, 485);
            this.ResultatTB.Name = "ResultatTB";
            this.ResultatTB.Size = new System.Drawing.Size(479, 38);
            this.ResultatTB.TabIndex = 7;
            this.ResultatTB.TabStop = false;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.ForeColor = System.Drawing.Color.Red;
            this.NotificationLabel.Location = new System.Drawing.Point(78, 559);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(233, 31);
            this.NotificationLabel.TabIndex = 8;
            this.NotificationLabel.Text = "pas de notification";
            // 
            // CalculatriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 621);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.ResultatTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OperateurCB);
            this.Controls.Add(this.Nombre2TB);
            this.Controls.Add(this.Nombre1TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalculatriceForm";
            this.Text = "Calculatrice que utilise les délégués";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre1TB;
        private System.Windows.Forms.TextBox Nombre2TB;
        private System.Windows.Forms.ComboBox OperateurCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultatTB;
        private System.Windows.Forms.Label NotificationLabel;
    }
}

