namespace Wintimizer.Vistas_Controladores
{
    partial class frmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicios));
            this.btnActivar = new System.Windows.Forms.Button();
            this.lvServicios = new System.Windows.Forms.ListView();
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.panBotonesInferiores = new System.Windows.Forms.Panel();
            this.panBotonesInferiores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.btnActivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActivar.FlatAppearance.BorderSize = 0;
            this.btnActivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.btnActivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Font = new System.Drawing.Font("Bebas", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnActivar.ForeColor = System.Drawing.Color.White;
            this.btnActivar.Location = new System.Drawing.Point(0, 0);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(248, 50);
            this.btnActivar.TabIndex = 1;
            this.btnActivar.Text = "ACTIVAR";
            this.btnActivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // lvServicios
            // 
            this.lvServicios.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvServicios.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvServicios.CheckBoxes = true;
            this.lvServicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Estado,
            this.Nombre,
            this.Descripcion});
            this.lvServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvServicios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvServicios.FullRowSelect = true;
            this.lvServicios.GridLines = true;
            this.lvServicios.Location = new System.Drawing.Point(0, 0);
            this.lvServicios.Margin = new System.Windows.Forms.Padding(0);
            this.lvServicios.Name = "lvServicios";
            this.lvServicios.ShowItemToolTips = true;
            this.lvServicios.Size = new System.Drawing.Size(496, 267);
            this.lvServicios.TabIndex = 2;
            this.lvServicios.UseCompatibleStateImageBehavior = false;
            this.lvServicios.View = System.Windows.Forms.View.Details;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 62;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 66;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 347;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnDesactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnDesactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Font = new System.Drawing.Font("Bebas", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnDesactivar.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.Location = new System.Drawing.Point(248, 0);
            this.btnDesactivar.Margin = new System.Windows.Forms.Padding(0);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(248, 50);
            this.btnDesactivar.TabIndex = 3;
            this.btnDesactivar.Text = "DESACTIVAR";
            this.btnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // panBotonesInferiores
            // 
            this.panBotonesInferiores.Controls.Add(this.btnActivar);
            this.panBotonesInferiores.Controls.Add(this.btnDesactivar);
            this.panBotonesInferiores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBotonesInferiores.Location = new System.Drawing.Point(0, 267);
            this.panBotonesInferiores.Name = "panBotonesInferiores";
            this.panBotonesInferiores.Size = new System.Drawing.Size(496, 50);
            this.panBotonesInferiores.TabIndex = 4;
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 317);
            this.Controls.Add(this.panBotonesInferiores);
            this.Controls.Add(this.lvServicios);
            this.Font = new System.Drawing.Font("Bebas", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmServicios";
            this.Text = "Servicios";
            this.panBotonesInferiores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActivar;
        public System.Windows.Forms.ListView lvServicios;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.Panel panBotonesInferiores;
    }
}