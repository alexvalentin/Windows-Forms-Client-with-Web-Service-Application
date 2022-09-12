
namespace WindowsFormsClientForWSA
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
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTempC = new System.Windows.Forms.TextBox();
            this.textBoxTempF = new System.Windows.Forms.TextBox();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.buttonFToC = new System.Windows.Forms.Button();
            this.buttonCtoF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEurotoLei = new System.Windows.Forms.TextBox();
            this.textBoxEurotoLei2 = new System.Windows.Forms.TextBox();
            this.textBoxRotoEuro1 = new System.Windows.Forms.TextBox();
            this.textBoxRotoEuro2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxLista
            // 
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.ItemHeight = 16;
            this.listBoxLista.Location = new System.Drawing.Point(58, 72);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(130, 132);
            this.listBoxLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista elemente";
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(58, 237);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(130, 34);
            this.buttonAddList.TabIndex = 2;
            this.buttonAddList.Text = "Add List";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature in C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temperature in F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rezultat";
            // 
            // textBoxTempC
            // 
            this.textBoxTempC.Location = new System.Drawing.Point(600, 72);
            this.textBoxTempC.Name = "textBoxTempC";
            this.textBoxTempC.Size = new System.Drawing.Size(100, 22);
            this.textBoxTempC.TabIndex = 6;
            // 
            // textBoxTempF
            // 
            this.textBoxTempF.Location = new System.Drawing.Point(600, 124);
            this.textBoxTempF.Name = "textBoxTempF";
            this.textBoxTempF.Size = new System.Drawing.Size(100, 22);
            this.textBoxTempF.TabIndex = 7;
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(600, 169);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(100, 22);
            this.textBoxRezultat.TabIndex = 8;
            // 
            // buttonFToC
            // 
            this.buttonFToC.Location = new System.Drawing.Point(600, 224);
            this.buttonFToC.Name = "buttonFToC";
            this.buttonFToC.Size = new System.Drawing.Size(89, 36);
            this.buttonFToC.TabIndex = 9;
            this.buttonFToC.Text = "F to C";
            this.buttonFToC.UseVisualStyleBackColor = true;
            this.buttonFToC.Click += new System.EventHandler(this.buttonFToC_Click);
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new System.Drawing.Point(600, 284);
            this.buttonCtoF.Name = "buttonCtoF";
            this.buttonCtoF.Size = new System.Drawing.Size(89, 31);
            this.buttonCtoF.TabIndex = 10;
            this.buttonCtoF.Text = "C to F";
            this.buttonCtoF.UseVisualStyleBackColor = true;
            this.buttonCtoF.Click += new System.EventHandler(this.buttonCtoF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Euro to Ron/Lei";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ron/Lei to Euro";
            // 
            // textBoxEurotoLei
            // 
            this.textBoxEurotoLei.Location = new System.Drawing.Point(461, 363);
            this.textBoxEurotoLei.Name = "textBoxEurotoLei";
            this.textBoxEurotoLei.Size = new System.Drawing.Size(100, 22);
            this.textBoxEurotoLei.TabIndex = 13;
            this.textBoxEurotoLei.TextChanged += new System.EventHandler(this.textBoxEurotoLei_TextChanged);
            // 
            // textBoxEurotoLei2
            // 
            this.textBoxEurotoLei2.Location = new System.Drawing.Point(461, 408);
            this.textBoxEurotoLei2.Name = "textBoxEurotoLei2";
            this.textBoxEurotoLei2.ReadOnly = true;
            this.textBoxEurotoLei2.Size = new System.Drawing.Size(100, 22);
            this.textBoxEurotoLei2.TabIndex = 14;
            this.textBoxEurotoLei2.TextChanged += new System.EventHandler(this.textBoxEurotoLei2_TextChanged);
            // 
            // textBoxRotoEuro1
            // 
            this.textBoxRotoEuro1.Location = new System.Drawing.Point(796, 360);
            this.textBoxRotoEuro1.Name = "textBoxRotoEuro1";
            this.textBoxRotoEuro1.Size = new System.Drawing.Size(100, 22);
            this.textBoxRotoEuro1.TabIndex = 15;
            this.textBoxRotoEuro1.TextChanged += new System.EventHandler(this.textBoxRotoEuro1_TextChanged);
            // 
            // textBoxRotoEuro2
            // 
            this.textBoxRotoEuro2.Location = new System.Drawing.Point(796, 407);
            this.textBoxRotoEuro2.Name = "textBoxRotoEuro2";
            this.textBoxRotoEuro2.ReadOnly = true;
            this.textBoxRotoEuro2.Size = new System.Drawing.Size(100, 22);
            this.textBoxRotoEuro2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data de azi";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(72, 368);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(36, 17);
            this.labelData.TabIndex = 18;
            this.labelData.Text = "data";
            this.labelData.Click += new System.EventHandler(this.labelData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 557);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRotoEuro2);
            this.Controls.Add(this.textBoxRotoEuro1);
            this.Controls.Add(this.textBoxEurotoLei2);
            this.Controls.Add(this.textBoxEurotoLei);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCtoF);
            this.Controls.Add(this.buttonFToC);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.textBoxTempF);
            this.Controls.Add(this.textBoxTempC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTempC;
        private System.Windows.Forms.TextBox textBoxTempF;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.Button buttonFToC;
        private System.Windows.Forms.Button buttonCtoF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEurotoLei;
        private System.Windows.Forms.TextBox textBoxEurotoLei2;
        private System.Windows.Forms.TextBox textBoxRotoEuro1;
        private System.Windows.Forms.TextBox textBoxRotoEuro2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelData;
    }
}

