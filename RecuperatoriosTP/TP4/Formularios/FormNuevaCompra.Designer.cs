namespace Formularios
{
    partial class FormNuevaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaCompra));
            this.dtgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCarrito
            // 
            this.dtgvCarrito.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dtgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarrito.Location = new System.Drawing.Point(12, 68);
            this.dtgvCarrito.Name = "dtgvCarrito";
            this.dtgvCarrito.Size = new System.Drawing.Size(339, 217);
            this.dtgvCarrito.TabIndex = 1;
            this.dtgvCarrito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCarrito_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(174, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 83);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPedido.Location = new System.Drawing.Point(449, 355);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(177, 83);
            this.btnRealizarPedido.TabIndex = 3;
            this.btnRealizarPedido.Text = "Realizar pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(116, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "CARRITO\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(587, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "STOCK";
            // 
            // txtBoxCant
            // 
            this.txtBoxCant.Location = new System.Drawing.Point(400, 300);
            this.txtBoxCant.Name = "txtBoxCant";
            this.txtBoxCant.Size = new System.Drawing.Size(49, 20);
            this.txtBoxCant.TabIndex = 6;
            this.txtBoxCant.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(303, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // dtgvStock
            // 
            this.dtgvStock.AllowUserToAddRows = false;
            this.dtgvStock.AllowUserToDeleteRows = false;
            this.dtgvStock.AllowUserToResizeColumns = false;
            this.dtgvStock.AllowUserToResizeRows = false;
            this.dtgvStock.BackgroundColor = System.Drawing.Color.MintCream;
            this.dtgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStock.Location = new System.Drawing.Point(449, 68);
            this.dtgvStock.MultiSelect = false;
            this.dtgvStock.Name = "dtgvStock";
            this.dtgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStock.Size = new System.Drawing.Size(339, 217);
            this.dtgvStock.TabIndex = 8;
            this.dtgvStock.TabStop = false;
            this.dtgvStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStock_CellDoubleClick);
            // 
            // FormNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgvCarrito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Compra";
            this.Load += new System.EventHandler(this.FormNuevaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvCarrito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvStock;
    }
}

