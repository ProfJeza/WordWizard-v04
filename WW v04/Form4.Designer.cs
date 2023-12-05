
namespace WW_v04
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_volverajugar = new System.Windows.Forms.Button();
            this.lbl_cartelresultado = new System.Windows.Forms.Label();
            this.lbl_puntajefinal = new System.Windows.Forms.Label();
            this.lbl_calificacionfinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(210, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUNTAJE OBTENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(213, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "TU CALIFICACIÓN ES";
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_salir.Location = new System.Drawing.Point(332, 368);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(204, 105);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_volverajugar
            // 
            this.btn_volverajugar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_volverajugar.BackgroundImage")));
            this.btn_volverajugar.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_volverajugar.Location = new System.Drawing.Point(122, 368);
            this.btn_volverajugar.Name = "btn_volverajugar";
            this.btn_volverajugar.Size = new System.Drawing.Size(204, 105);
            this.btn_volverajugar.TabIndex = 3;
            this.btn_volverajugar.Text = "VOLVER A JUGAR";
            this.btn_volverajugar.UseVisualStyleBackColor = true;
            this.btn_volverajugar.Click += new System.EventHandler(this.btn_volverajugar_Click);
            // 
            // lbl_cartelresultado
            // 
            this.lbl_cartelresultado.AutoSize = true;
            this.lbl_cartelresultado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cartelresultado.Font = new System.Drawing.Font("Hobo Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cartelresultado.Location = new System.Drawing.Point(224, 55);
            this.lbl_cartelresultado.Name = "lbl_cartelresultado";
            this.lbl_cartelresultado.Size = new System.Drawing.Size(209, 41);
            this.lbl_cartelresultado.TabIndex = 4;
            this.lbl_cartelresultado.Text = "RESULTADOS";
            // 
            // lbl_puntajefinal
            // 
            this.lbl_puntajefinal.AutoSize = true;
            this.lbl_puntajefinal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_puntajefinal.Font = new System.Drawing.Font("Hobo Std", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntajefinal.Location = new System.Drawing.Point(298, 176);
            this.lbl_puntajefinal.Name = "lbl_puntajefinal";
            this.lbl_puntajefinal.Size = new System.Drawing.Size(64, 50);
            this.lbl_puntajefinal.TabIndex = 5;
            this.lbl_puntajefinal.Text = "00";
            // 
            // lbl_calificacionfinal
            // 
            this.lbl_calificacionfinal.AutoSize = true;
            this.lbl_calificacionfinal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_calificacionfinal.Font = new System.Drawing.Font("Hobo Std", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calificacionfinal.Location = new System.Drawing.Point(298, 292);
            this.lbl_calificacionfinal.Name = "lbl_calificacionfinal";
            this.lbl_calificacionfinal.Size = new System.Drawing.Size(64, 50);
            this.lbl_calificacionfinal.TabIndex = 6;
            this.lbl_calificacionfinal.Text = "00";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 522);
            this.Controls.Add(this.lbl_calificacionfinal);
            this.Controls.Add(this.lbl_puntajefinal);
            this.Controls.Add(this.lbl_cartelresultado);
            this.Controls.Add(this.btn_volverajugar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Wizard | ¡Magos de las palabras!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_volverajugar;
        private System.Windows.Forms.Label lbl_cartelresultado;
        public System.Windows.Forms.Label lbl_puntajefinal;
        public System.Windows.Forms.Label lbl_calificacionfinal;
    }
}