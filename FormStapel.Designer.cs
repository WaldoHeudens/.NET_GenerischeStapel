namespace GenerischeStapel
{
    partial class FormStapel
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
            this.label1 = new System.Windows.Forms.Label();
            this.udVoegToe = new System.Windows.Forms.NumericUpDown();
            this.btHaalAf = new System.Windows.Forms.Button();
            this.tbShowContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btHaalStringAf = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btHaalDatumAf = new System.Windows.Forms.Button();
            this.tbStringToevoegen = new System.Windows.Forms.TextBox();
            this.tbToonDatum = new System.Windows.Forms.TextBox();
            this.btVoegDatumToe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udVoegToe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voeg toe";
            // 
            // udVoegToe
            // 
            this.udVoegToe.Location = new System.Drawing.Point(83, 71);
            this.udVoegToe.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.udVoegToe.Name = "udVoegToe";
            this.udVoegToe.Size = new System.Drawing.Size(120, 23);
            this.udVoegToe.TabIndex = 1;
            this.udVoegToe.ValueChanged += new System.EventHandler(this.udVoegToe_ValueChanged);
            // 
            // btHaalAf
            // 
            this.btHaalAf.Location = new System.Drawing.Point(83, 130);
            this.btHaalAf.Name = "btHaalAf";
            this.btHaalAf.Size = new System.Drawing.Size(120, 39);
            this.btHaalAf.TabIndex = 2;
            this.btHaalAf.Text = "Haal Af";
            this.btHaalAf.UseVisualStyleBackColor = true;
            this.btHaalAf.Click += new System.EventHandler(this.btHaalAf_Click);
            // 
            // tbShowContent
            // 
            this.tbShowContent.Enabled = false;
            this.tbShowContent.Location = new System.Drawing.Point(6, 226);
            this.tbShowContent.Name = "tbShowContent";
            this.tbShowContent.Size = new System.Drawing.Size(791, 23);
            this.tbShowContent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stapel van integers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(343, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stapel van strings";
            // 
            // btHaalStringAf
            // 
            this.btHaalStringAf.Location = new System.Drawing.Point(343, 130);
            this.btHaalStringAf.Name = "btHaalStringAf";
            this.btHaalStringAf.Size = new System.Drawing.Size(120, 39);
            this.btHaalStringAf.TabIndex = 7;
            this.btHaalStringAf.Text = "Haal Af";
            this.btHaalStringAf.UseVisualStyleBackColor = true;
            this.btHaalStringAf.Click += new System.EventHandler(this.btHaalStringAf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Voeg toe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(573, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stapel van Datum/Tijd";
            // 
            // btHaalDatumAf
            // 
            this.btHaalDatumAf.Location = new System.Drawing.Point(591, 155);
            this.btHaalDatumAf.Name = "btHaalDatumAf";
            this.btHaalDatumAf.Size = new System.Drawing.Size(120, 39);
            this.btHaalDatumAf.TabIndex = 11;
            this.btHaalDatumAf.Text = "Haal Af";
            this.btHaalDatumAf.UseVisualStyleBackColor = true;
            this.btHaalDatumAf.Click += new System.EventHandler(this.btHaalDatumAf_Click);
            // 
            // tbStringToevoegen
            // 
            this.tbStringToevoegen.Location = new System.Drawing.Point(343, 71);
            this.tbStringToevoegen.Name = "tbStringToevoegen";
            this.tbStringToevoegen.Size = new System.Drawing.Size(120, 23);
            this.tbStringToevoegen.TabIndex = 13;
            this.tbStringToevoegen.Leave += new System.EventHandler(this.tbStringToevoegen_Leave);
            // 
            // tbToonDatum
            // 
            this.tbToonDatum.Enabled = false;
            this.tbToonDatum.Location = new System.Drawing.Point(591, 73);
            this.tbToonDatum.Name = "tbToonDatum";
            this.tbToonDatum.Size = new System.Drawing.Size(120, 23);
            this.tbToonDatum.TabIndex = 14;
            // 
            // btVoegDatumToe
            // 
            this.btVoegDatumToe.Location = new System.Drawing.Point(591, 110);
            this.btVoegDatumToe.Name = "btVoegDatumToe";
            this.btVoegDatumToe.Size = new System.Drawing.Size(120, 39);
            this.btVoegDatumToe.TabIndex = 15;
            this.btVoegDatumToe.Text = "Voeg Toe";
            this.btVoegDatumToe.UseVisualStyleBackColor = true;
            this.btVoegDatumToe.Click += new System.EventHandler(this.btVoegDatumToe_Click);
            // 
            // FormStapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.btVoegDatumToe);
            this.Controls.Add(this.tbToonDatum);
            this.Controls.Add(this.tbStringToevoegen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btHaalDatumAf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btHaalStringAf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbShowContent);
            this.Controls.Add(this.btHaalAf);
            this.Controls.Add(this.udVoegToe);
            this.Controls.Add(this.label1);
            this.Name = "FormStapel";
            this.Text = "Stapel van integers";
            ((System.ComponentModel.ISupportInitialize)(this.udVoegToe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udVoegToe;
        private System.Windows.Forms.Button btHaalAf;
        private System.Windows.Forms.TextBox tbShowContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btHaalStringAf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btHaalDatumAf;
        private System.Windows.Forms.TextBox tbStringToevoegen;
        private System.Windows.Forms.TextBox tbToonDatum;
        private System.Windows.Forms.Button btVoegDatumToe;
    }
}