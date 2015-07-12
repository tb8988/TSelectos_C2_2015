namespace LabTopicos_app.proxy
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbConstante = new System.Windows.Forms.RadioButton();
            this.rbPotencia = new System.Windows.Forms.RadioButton();
            this.rbLogaritmo = new System.Windows.Forms.RadioButton();
            this.rbExponencial = new System.Windows.Forms.RadioButton();
            this.rbSeno = new System.Windows.Forms.RadioButton();
            this.rbCoseno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbk = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbres = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblConstante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Integral Definida";
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSimple.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimple.Location = new System.Drawing.Point(17, 95);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(62, 21);
            this.rbSimple.TabIndex = 1;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            this.rbSimple.CheckedChanged += new System.EventHandler(this.rbSimple_CheckedChanged);
            // 
            // rbConstante
            // 
            this.rbConstante.AutoSize = true;
            this.rbConstante.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbConstante.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbConstante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbConstante.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConstante.Location = new System.Drawing.Point(17, 119);
            this.rbConstante.Name = "rbConstante";
            this.rbConstante.Size = new System.Drawing.Size(80, 21);
            this.rbConstante.TabIndex = 2;
            this.rbConstante.TabStop = true;
            this.rbConstante.Text = "Constante";
            this.rbConstante.UseVisualStyleBackColor = true;
            this.rbConstante.CheckedChanged += new System.EventHandler(this.rbConstante_CheckedChanged);
            // 
            // rbPotencia
            // 
            this.rbPotencia.AutoSize = true;
            this.rbPotencia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbPotencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPotencia.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPotencia.Location = new System.Drawing.Point(17, 143);
            this.rbPotencia.Name = "rbPotencia";
            this.rbPotencia.Size = new System.Drawing.Size(71, 21);
            this.rbPotencia.TabIndex = 3;
            this.rbPotencia.TabStop = true;
            this.rbPotencia.Text = "Potencia";
            this.rbPotencia.UseVisualStyleBackColor = true;
            this.rbPotencia.CheckedChanged += new System.EventHandler(this.rbPotencia_CheckedChanged);
            // 
            // rbLogaritmo
            // 
            this.rbLogaritmo.AutoSize = true;
            this.rbLogaritmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLogaritmo.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLogaritmo.Location = new System.Drawing.Point(17, 167);
            this.rbLogaritmo.Name = "rbLogaritmo";
            this.rbLogaritmo.Size = new System.Drawing.Size(80, 21);
            this.rbLogaritmo.TabIndex = 4;
            this.rbLogaritmo.TabStop = true;
            this.rbLogaritmo.Text = "Logaritmo";
            this.rbLogaritmo.UseVisualStyleBackColor = true;
            this.rbLogaritmo.CheckedChanged += new System.EventHandler(this.rbLogaritmo_CheckedChanged);
            // 
            // rbExponencial
            // 
            this.rbExponencial.AutoSize = true;
            this.rbExponencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbExponencial.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExponencial.Location = new System.Drawing.Point(17, 191);
            this.rbExponencial.Name = "rbExponencial";
            this.rbExponencial.Size = new System.Drawing.Size(90, 21);
            this.rbExponencial.TabIndex = 5;
            this.rbExponencial.TabStop = true;
            this.rbExponencial.Text = "Exponencial";
            this.rbExponencial.UseVisualStyleBackColor = true;
            this.rbExponencial.CheckedChanged += new System.EventHandler(this.rbExponencial_CheckedChanged);
            // 
            // rbSeno
            // 
            this.rbSeno.AutoSize = true;
            this.rbSeno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSeno.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSeno.Location = new System.Drawing.Point(17, 215);
            this.rbSeno.Name = "rbSeno";
            this.rbSeno.Size = new System.Drawing.Size(52, 21);
            this.rbSeno.TabIndex = 6;
            this.rbSeno.TabStop = true;
            this.rbSeno.Text = "Seno";
            this.rbSeno.UseVisualStyleBackColor = true;
            this.rbSeno.CheckedChanged += new System.EventHandler(this.rbSeno_CheckedChanged);
            // 
            // rbCoseno
            // 
            this.rbCoseno.AutoSize = true;
            this.rbCoseno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCoseno.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCoseno.Location = new System.Drawing.Point(17, 239);
            this.rbCoseno.Name = "rbCoseno";
            this.rbCoseno.Size = new System.Drawing.Size(66, 21);
            this.rbCoseno.TabIndex = 7;
            this.rbCoseno.TabStop = true;
            this.rbCoseno.Text = "Coseno";
            this.rbCoseno.UseVisualStyleBackColor = true;
            this.rbCoseno.CheckedChanged += new System.EventHandler(this.rbCoseno_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione a continuación el tipo de integral que desea calcular:";
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.ForeColor = System.Drawing.SystemColors.Info;
            this.tbA.Location = new System.Drawing.Point(272, 118);
            this.tbA.MaxLength = 6;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(43, 23);
            this.tbA.TabIndex = 9;
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.ForeColor = System.Drawing.SystemColors.Info;
            this.tbB.Location = new System.Drawing.Point(272, 144);
            this.tbB.MaxLength = 6;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(43, 23);
            this.tbB.TabIndex = 10;
            // 
            // tbK
            // 
            this.tbK.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbK.ForeColor = System.Drawing.SystemColors.Info;
            this.tbK.Location = new System.Drawing.Point(272, 172);
            this.tbK.MaxLength = 6;
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(43, 23);
            this.tbK.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "b:";
            // 
            // lbk
            // 
            this.lbk.AutoSize = true;
            this.lbk.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbk.Location = new System.Drawing.Point(208, 174);
            this.lbk.Name = "lbk";
            this.lbk.Size = new System.Drawing.Size(57, 17);
            this.lbk.TabIndex = 14;
            this.lbk.Text = "Potencia:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(66, 278);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 45);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(192, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbres
            // 
            this.lbres.AutoSize = true;
            this.lbres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbres.Location = new System.Drawing.Point(189, 230);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(69, 17);
            this.lbres.TabIndex = 17;
            this.lbres.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(264, 230);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(46, 17);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "(result)";
            // 
            // lblConstante
            // 
            this.lblConstante.AutoSize = true;
            this.lblConstante.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.lblConstante.Location = new System.Drawing.Point(201, 174);
            this.lblConstante.Name = "lblConstante";
            this.lblConstante.Size = new System.Drawing.Size(66, 17);
            this.lblConstante.TabIndex = 19;
            this.lblConstante.Text = "Constante:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(372, 361);
            this.ControlBox = false;
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbCoseno);
            this.Controls.Add(this.rbSeno);
            this.Controls.Add(this.rbExponencial);
            this.Controls.Add(this.rbLogaritmo);
            this.Controls.Add(this.rbPotencia);
            this.Controls.Add(this.rbConstante);
            this.Controls.Add(this.rbSimple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConstante);
            this.Controls.Add(this.lbk);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Integrales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbConstante;
        private System.Windows.Forms.RadioButton rbPotencia;
        private System.Windows.Forms.RadioButton rbLogaritmo;
        private System.Windows.Forms.RadioButton rbExponencial;
        private System.Windows.Forms.RadioButton rbSeno;
        private System.Windows.Forms.RadioButton rbCoseno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbk;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbres;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblConstante;
    }
}

