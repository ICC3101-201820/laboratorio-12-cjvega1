namespace MVC
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
            this.nombreComida = new System.Windows.Forms.Label();
            this.proteComida = new System.Windows.Forms.Label();
            this.grasaComida = new System.Windows.Forms.Label();
            this.carboComida = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.carboTextBox = new System.Windows.Forms.TextBox();
            this.grasaTextBox = new System.Windows.Forms.TextBox();
            this.proteTextBox = new System.Windows.Forms.TextBox();
            this.listaComidas = new System.Windows.Forms.ListBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreComida
            // 
            this.nombreComida.AutoSize = true;
            this.nombreComida.Location = new System.Drawing.Point(60, 90);
            this.nombreComida.Name = "nombreComida";
            this.nombreComida.Size = new System.Drawing.Size(44, 13);
            this.nombreComida.TabIndex = 0;
            this.nombreComida.Text = "Nombre";
            // 
            // proteComida
            // 
            this.proteComida.AutoSize = true;
            this.proteComida.Location = new System.Drawing.Point(60, 129);
            this.proteComida.Name = "proteComida";
            this.proteComida.Size = new System.Drawing.Size(51, 13);
            this.proteComida.TabIndex = 1;
            this.proteComida.Text = "Proteinas";
            // 
            // grasaComida
            // 
            this.grasaComida.AutoSize = true;
            this.grasaComida.Location = new System.Drawing.Point(60, 171);
            this.grasaComida.Name = "grasaComida";
            this.grasaComida.Size = new System.Drawing.Size(40, 13);
            this.grasaComida.TabIndex = 2;
            this.grasaComida.Text = "Grasas";
            // 
            // carboComida
            // 
            this.carboComida.AutoSize = true;
            this.carboComida.Location = new System.Drawing.Point(51, 220);
            this.carboComida.Name = "carboComida";
            this.carboComida.Size = new System.Drawing.Size(72, 13);
            this.carboComida.TabIndex = 3;
            this.carboComida.Text = "Carbohidratos";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(139, 83);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(115, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // carboTextBox
            // 
            this.carboTextBox.Location = new System.Drawing.Point(139, 213);
            this.carboTextBox.Name = "carboTextBox";
            this.carboTextBox.Size = new System.Drawing.Size(115, 20);
            this.carboTextBox.TabIndex = 6;
            // 
            // grasaTextBox
            // 
            this.grasaTextBox.Location = new System.Drawing.Point(139, 168);
            this.grasaTextBox.Name = "grasaTextBox";
            this.grasaTextBox.Size = new System.Drawing.Size(115, 20);
            this.grasaTextBox.TabIndex = 7;
            // 
            // proteTextBox
            // 
            this.proteTextBox.Location = new System.Drawing.Point(139, 122);
            this.proteTextBox.Name = "proteTextBox";
            this.proteTextBox.Size = new System.Drawing.Size(115, 20);
            this.proteTextBox.TabIndex = 8;
            // 
            // listaComidas
            // 
            this.listaComidas.FormattingEnabled = true;
            this.listaComidas.Location = new System.Drawing.Point(351, 43);
            this.listaComidas.Name = "listaComidas";
            this.listaComidas.Size = new System.Drawing.Size(232, 251);
            this.listaComidas.TabIndex = 9;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(389, 320);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(146, 48);
            this.botonEliminar.TabIndex = 10;
            this.botonEliminar.Text = "Eliminar Comida";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(103, 274);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(131, 40);
            this.botonAgregar.TabIndex = 11;
            this.botonAgregar.Text = "Agregar Datos";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 431);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.listaComidas);
            this.Controls.Add(this.proteTextBox);
            this.Controls.Add(this.grasaTextBox);
            this.Controls.Add(this.carboTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.carboComida);
            this.Controls.Add(this.grasaComida);
            this.Controls.Add(this.proteComida);
            this.Controls.Add(this.nombreComida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreComida;
        private System.Windows.Forms.Label proteComida;
        private System.Windows.Forms.Label grasaComida;
        private System.Windows.Forms.Label carboComida;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox carboTextBox;
        private System.Windows.Forms.TextBox grasaTextBox;
        private System.Windows.Forms.TextBox proteTextBox;
        private System.Windows.Forms.ListBox listaComidas;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonAgregar;
    }
}

