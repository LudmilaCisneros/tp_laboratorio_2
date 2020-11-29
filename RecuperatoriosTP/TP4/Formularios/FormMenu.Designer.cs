
namespace Formularios
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnLocalTiempoReal = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnNuevaCompra.FlatAppearance.BorderSize = 3;
            this.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCompra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCompra.Location = new System.Drawing.Point(33, 276);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(243, 139);
            this.btnNuevaCompra.TabIndex = 1;
            this.btnNuevaCompra.Text = "Nueva Compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnLocalTiempoReal
            // 
            this.btnLocalTiempoReal.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnLocalTiempoReal.FlatAppearance.BorderSize = 3;
            this.btnLocalTiempoReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalTiempoReal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalTiempoReal.Location = new System.Drawing.Point(332, 353);
            this.btnLocalTiempoReal.Name = "btnLocalTiempoReal";
            this.btnLocalTiempoReal.Size = new System.Drawing.Size(226, 139);
            this.btnLocalTiempoReal.TabIndex = 2;
            this.btnLocalTiempoReal.Text = "Local en tiempo real";
            this.btnLocalTiempoReal.UseVisualStyleBackColor = true;
            this.btnLocalTiempoReal.Click += new System.EventHandler(this.btnLocalTiempoReal_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnVerProductos.FlatAppearance.BorderSize = 3;
            this.btnVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProductos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.Location = new System.Drawing.Point(609, 276);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(240, 139);
            this.btnVerProductos.TabIndex = 3;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 227);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(33, 448);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 53);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(879, 513);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.btnLocalTiempoReal);
            this.Controls.Add(this.btnNuevaCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnLocalTiempoReal;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}