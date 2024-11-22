namespace PRÁCTICA__1_TABLA_DE_MULTIPLICAR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            labelNombre = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 192, 255);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNumero);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(5, 11);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(783, 427);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(303, 167);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(203, 257);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVer.ForeColor = Color.Purple;
            buttonVer.Location = new Point(339, 135);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(121, 29);
            buttonVer.TabIndex = 3;
            buttonVer.Text = " VER TABLA :)";
            buttonVer.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(339, 102);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(125, 27);
            textBoxNumero.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(206, 71);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(368, 28);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cuál tabla gustas, deseas, aspiras :)?";
            labelNumero.Click += labelNumero_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(273, 45);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(251, 26);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "TABLA DE MULTIPLICAR";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(284, 12);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(240, 20);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Fernando Gabriel Hernandez Junco";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelNumero;
        private Label labelTitulo;
        private TextBox textBoxNumero;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private Label labelNombre;
    }
}
