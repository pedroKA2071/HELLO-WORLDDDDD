namespace HELLO_WORLD
{
    partial class JANELA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JANELA));
            this.txbnumero2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.numerofist = new System.Windows.Forms.Label();
            this.numerotwo = new System.Windows.Forms.Label();
            this.lbresultado = new System.Windows.Forms.Label();
            this.txbnumero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnumero3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnimparoupar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbnumero2
            // 
            this.txbnumero2.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txbnumero2, "txbnumero2");
            this.txbnumero2.HideSelection = false;
            this.txbnumero2.Name = "txbnumero2";
            this.txbnumero2.UseWaitCursor = true;
            this.txbnumero2.TextChanged += new System.EventHandler(this.txbnumero2_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.LightSlateGray;
            this.btncalcular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btncalcular, "btncalcular");
            this.btncalcular.ForeColor = System.Drawing.Color.Black;
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.UseWaitCursor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // numerofist
            // 
            this.numerofist.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.numerofist, "numerofist");
            this.numerofist.ForeColor = System.Drawing.Color.Black;
            this.numerofist.Name = "numerofist";
            this.numerofist.UseWaitCursor = true;
            this.numerofist.Click += new System.EventHandler(this.label2_Click);
            // 
            // numerotwo
            // 
            this.numerotwo.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.numerotwo, "numerotwo");
            this.numerotwo.ForeColor = System.Drawing.Color.Black;
            this.numerotwo.Name = "numerotwo";
            this.numerotwo.UseWaitCursor = true;
            // 
            // lbresultado
            // 
            this.lbresultado.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.lbresultado, "lbresultado");
            this.lbresultado.ForeColor = System.Drawing.Color.Black;
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.UseWaitCursor = true;
            this.lbresultado.Click += new System.EventHandler(this.lbresultado_Click);
            // 
            // txbnumero1
            // 
            this.txbnumero1.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txbnumero1, "txbnumero1");
            this.txbnumero1.Name = "txbnumero1";
            this.txbnumero1.UseWaitCursor = true;
            this.txbnumero1.TextChanged += new System.EventHandler(this.txbnumero1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txbnumero3
            // 
            this.txbnumero3.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txbnumero3, "txbnumero3");
            this.txbnumero3.Name = "txbnumero3";
            this.txbnumero3.UseWaitCursor = true;
            this.txbnumero3.TextChanged += new System.EventHandler(this.txbnumero3_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnimparoupar
            // 
            this.btnimparoupar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btnimparoupar, "btnimparoupar");
            this.btnimparoupar.Name = "btnimparoupar";
            this.btnimparoupar.UseVisualStyleBackColor = false;
            this.btnimparoupar.UseWaitCursor = true;
            this.btnimparoupar.Click += new System.EventHandler(this.btnimparoupar_Click);
            // 
            // JANELA
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.Controls.Add(this.btnimparoupar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txbnumero3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbnumero2);
            this.Controls.Add(this.txbnumero1);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.numerotwo);
            this.Controls.Add(this.numerofist);
            this.Controls.Add(this.btncalcular);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "JANELA";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label numerofist;
        private System.Windows.Forms.Label numerotwo;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.TextBox txbnumero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnumero3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txbnumero2;
        private System.Windows.Forms.Button btnimparoupar;
    }
}

