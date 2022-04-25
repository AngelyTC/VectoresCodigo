
namespace VectoresCodigo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtVerificar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtVeControl = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtValidar = new System.Windows.Forms.Label();
            this.VerVec = new System.Windows.Forms.Button();
            this.txtCodVerificar = new System.Windows.Forms.TextBox();
            this.buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carné";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verificar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código verificador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Validación";
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(397, 64);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(300, 26);
            this.txtCarne.TabIndex = 4;
            // 
            // txtVerificar
            // 
            this.txtVerificar.Location = new System.Drawing.Point(397, 215);
            this.txtVerificar.Name = "txtVerificar";
            this.txtVerificar.Size = new System.Drawing.Size(300, 26);
            this.txtVerificar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vector Control";
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerar.BackColor = System.Drawing.Color.Tan;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Location = new System.Drawing.Point(45, 191);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(142, 50);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar Código";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtVeControl
            // 
            this.txtVeControl.Location = new System.Drawing.Point(45, 64);
            this.txtVeControl.Name = "txtVeControl";
            this.txtVeControl.Size = new System.Drawing.Size(187, 26);
            this.txtVeControl.TabIndex = 10;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Tan;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificar.Location = new System.Drawing.Point(45, 247);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(142, 48);
            this.btnVerificar.TabIndex = 11;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtValidar
            // 
            this.txtValidar.AutoSize = true;
            this.txtValidar.BackColor = System.Drawing.Color.Tan;
            this.txtValidar.Location = new System.Drawing.Point(393, 300);
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(252, 20);
            this.txtValidar.TabIndex = 12;
            this.txtValidar.Text = "___________________________";
            // 
            // VerVec
            // 
            this.VerVec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VerVec.BackColor = System.Drawing.Color.Tan;
            this.VerVec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerVec.Location = new System.Drawing.Point(45, 135);
            this.VerVec.Name = "VerVec";
            this.VerVec.Size = new System.Drawing.Size(142, 50);
            this.VerVec.TabIndex = 14;
            this.VerVec.Text = "Ver Vector control";
            this.VerVec.UseVisualStyleBackColor = false;
            this.VerVec.Click += new System.EventHandler(this.VerVec_Click);
            // 
            // txtCodVerificar
            // 
            this.txtCodVerificar.Location = new System.Drawing.Point(397, 135);
            this.txtCodVerificar.Name = "txtCodVerificar";
            this.txtCodVerificar.Size = new System.Drawing.Size(300, 26);
            this.txtCodVerificar.TabIndex = 15;
            // 
            // buton
            // 
            this.buton.BackColor = System.Drawing.Color.Tan;
            this.buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton.Location = new System.Drawing.Point(45, 300);
            this.buton.Name = "buton";
            this.buton.Size = new System.Drawing.Size(142, 42);
            this.buton.TabIndex = 16;
            this.buton.Text = "Limpiar";
            this.buton.UseVisualStyleBackColor = false;
            this.buton.Click += new System.EventHandler(this.buton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.buton);
            this.Controls.Add(this.txtCodVerificar);
            this.Controls.Add(this.VerVec);
            this.Controls.Add(this.txtValidar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtVeControl);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVerificar);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vectores Código";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtVerificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtVeControl;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label txtValidar;
        private System.Windows.Forms.Button VerVec;
        private System.Windows.Forms.TextBox txtCodVerificar;
        private System.Windows.Forms.Button buton;
    }
}

