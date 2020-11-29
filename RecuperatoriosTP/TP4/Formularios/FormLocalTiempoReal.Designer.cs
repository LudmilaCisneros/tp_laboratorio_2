
namespace Formularios
{
    partial class FormLocalTiempoReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocalTiempoReal));
            this.lbxEnQueue = new System.Windows.Forms.ListBox();
            this.lbxRealizados = new System.Windows.Forms.ListBox();
            this.lblAtención = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxEnQueue
            // 
            this.lbxEnQueue.BackColor = System.Drawing.Color.Honeydew;
            this.lbxEnQueue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEnQueue.FormattingEnabled = true;
            this.lbxEnQueue.Location = new System.Drawing.Point(431, 81);
            this.lbxEnQueue.Name = "lbxEnQueue";
            this.lbxEnQueue.Size = new System.Drawing.Size(357, 277);
            this.lbxEnQueue.TabIndex = 0;
            // 
            // lbxRealizados
            // 
            this.lbxRealizados.BackColor = System.Drawing.Color.Honeydew;
            this.lbxRealizados.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRealizados.FormattingEnabled = true;
            this.lbxRealizados.Location = new System.Drawing.Point(12, 81);
            this.lbxRealizados.Name = "lbxRealizados";
            this.lbxRealizados.Size = new System.Drawing.Size(357, 277);
            this.lbxRealizados.TabIndex = 1;
            // 
            // lblAtención
            // 
            this.lblAtención.AutoSize = true;
            this.lblAtención.BackColor = System.Drawing.Color.Transparent;
            this.lblAtención.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtención.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAtención.Location = new System.Drawing.Point(325, 22);
            this.lblAtención.Name = "lblAtención";
            this.lblAtención.Size = new System.Drawing.Size(143, 34);
            this.lblAtención.TabIndex = 2;
            this.lblAtención.Text = "Atención";
            // 
            // btnAtras
            // 
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(222, 370);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(132, 68);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(431, 370);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(132, 68);
            this.btnComenzar.TabIndex = 4;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // FormLocalTiempoReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblAtención);
            this.Controls.Add(this.lbxRealizados);
            this.Controls.Add(this.lbxEnQueue);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLocalTiempoReal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLocalTiempoReal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEnQueue;
        private System.Windows.Forms.ListBox lbxRealizados;
        private System.Windows.Forms.Label lblAtención;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnComenzar;
    }
}