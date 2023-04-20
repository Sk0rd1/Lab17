namespace Lab17
{
    partial class formMain
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.pictureBoxRhombus = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeserializeXML = new System.Windows.Forms.Button();
            this.buttonSerializeXML = new System.Windows.Forms.Button();
            this.textBoxBinary = new System.Windows.Forms.TextBox();
            this.textBoxXML = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRhombus)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(170, 576);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(12, 144);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(127, 36);
            this.buttonCount.TabIndex = 3;
            this.buttonCount.Text = "Намалювати";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(12, 264);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(127, 36);
            this.buttonSerialize.TabIndex = 4;
            this.buttonSerialize.Text = "Серіалізація";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(43, 28);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 6;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(43, 93);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 7;
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(12, 306);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(127, 36);
            this.buttonDeserialize.TabIndex = 8;
            this.buttonDeserialize.Text = "Десеріалізація";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // pictureBoxRhombus
            // 
            this.pictureBoxRhombus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRhombus.Location = new System.Drawing.Point(170, 0);
            this.pictureBoxRhombus.Name = "pictureBoxRhombus";
            this.pictureBoxRhombus.Size = new System.Drawing.Size(745, 576);
            this.pictureBoxRhombus.TabIndex = 9;
            this.pictureBoxRhombus.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Binary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "XML";
            // 
            // buttonDeserializeXML
            // 
            this.buttonDeserializeXML.Location = new System.Drawing.Point(12, 463);
            this.buttonDeserializeXML.Name = "buttonDeserializeXML";
            this.buttonDeserializeXML.Size = new System.Drawing.Size(127, 36);
            this.buttonDeserializeXML.TabIndex = 12;
            this.buttonDeserializeXML.Text = "Десеріалізація";
            this.buttonDeserializeXML.UseVisualStyleBackColor = true;
            this.buttonDeserializeXML.Click += new System.EventHandler(this.buttonDeserializeXML_Click);
            // 
            // buttonSerializeXML
            // 
            this.buttonSerializeXML.Location = new System.Drawing.Point(12, 421);
            this.buttonSerializeXML.Name = "buttonSerializeXML";
            this.buttonSerializeXML.Size = new System.Drawing.Size(127, 36);
            this.buttonSerializeXML.TabIndex = 11;
            this.buttonSerializeXML.Text = "Серіалізація";
            this.buttonSerializeXML.UseVisualStyleBackColor = true;
            this.buttonSerializeXML.Click += new System.EventHandler(this.buttonSerializeXML_Click);
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.Location = new System.Drawing.Point(15, 236);
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.Size = new System.Drawing.Size(124, 22);
            this.textBoxBinary.TabIndex = 14;
            this.textBoxBinary.Text = "default.dat";
            this.textBoxBinary.TextChanged += new System.EventHandler(this.textBoxBinary_TextChanged);
            // 
            // textBoxXML
            // 
            this.textBoxXML.Location = new System.Drawing.Point(12, 393);
            this.textBoxXML.Name = "textBoxXML";
            this.textBoxXML.Size = new System.Drawing.Size(127, 22);
            this.textBoxXML.TabIndex = 15;
            this.textBoxXML.Text = "default.xml";
            // 
            // formMain
            // 
            this.ClientSize = new System.Drawing.Size(915, 576);
            this.Controls.Add(this.textBoxXML);
            this.Controls.Add(this.textBoxBinary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDeserializeXML);
            this.Controls.Add(this.buttonSerializeXML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxRhombus);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "formMain";
            this.Text = "Lab17 Tyschenko";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRhombus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.PictureBox pictureBoxRhombus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeserializeXML;
        private System.Windows.Forms.Button buttonSerializeXML;
        private System.Windows.Forms.TextBox textBoxBinary;
        private System.Windows.Forms.TextBox textBoxXML;
    }
}

