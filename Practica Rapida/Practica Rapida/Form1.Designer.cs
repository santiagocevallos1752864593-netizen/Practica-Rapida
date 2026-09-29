namespace Practica_Rapida
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
            label1 = new Label();
            textNum1 = new TextBox();
            textNum2 = new TextBox();
            label2 = new Label();
            textResultado = new TextBox();
            label3 = new Label();
            sumar = new Button();
            Multiplicar = new Button();
            Restar = new Button();
            Dividir = new Button();
            lstLista = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // textNum1
            // 
            textNum1.Location = new Point(109, 41);
            textNum1.Name = "textNum1";
            textNum1.Size = new Size(100, 23);
            textNum1.TabIndex = 1;
            textNum1.TextAlign = HorizontalAlignment.Right;
            // 
            // textNum2
            // 
            textNum2.Location = new Point(109, 70);
            textNum2.Name = "textNum2";
            textNum2.Size = new Size(100, 23);
            textNum2.TabIndex = 4;
            textNum2.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 78);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero 2:";
            // 
            // textResultado
            // 
            textResultado.Location = new Point(109, 110);
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(100, 23);
            textResultado.TabIndex = 7;
            textResultado.TextChanged += textResultado_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 113);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "RESULTADO:";
            // 
            // sumar
            // 
            sumar.Location = new Point(240, 41);
            sumar.Name = "sumar";
            sumar.Size = new Size(75, 23);
            sumar.TabIndex = 8;
            sumar.Text = "Sumar";
            sumar.TextImageRelation = TextImageRelation.ImageAboveText;
            sumar.UseVisualStyleBackColor = true;
            sumar.Click += sumar_Click;
            // 
            // Multiplicar
            // 
            Multiplicar.Location = new Point(240, 74);
            Multiplicar.Name = "Multiplicar";
            Multiplicar.Size = new Size(75, 23);
            Multiplicar.TabIndex = 9;
            Multiplicar.Text = "Multiplicar";
            Multiplicar.TextImageRelation = TextImageRelation.ImageAboveText;
            Multiplicar.UseVisualStyleBackColor = true;
            Multiplicar.Click += Multiplicar_Click;
            // 
            // Restar
            // 
            Restar.Location = new Point(334, 41);
            Restar.Name = "Restar";
            Restar.Size = new Size(75, 23);
            Restar.TabIndex = 10;
            Restar.Text = "Restar";
            Restar.TextImageRelation = TextImageRelation.ImageAboveText;
            Restar.UseVisualStyleBackColor = true;
            Restar.Click += Restar_Click;
            // 
            // Dividir
            // 
            Dividir.Location = new Point(334, 74);
            Dividir.Name = "Dividir";
            Dividir.Size = new Size(75, 23);
            Dividir.TabIndex = 11;
            Dividir.Text = "Dividir";
            Dividir.TextImageRelation = TextImageRelation.ImageAboveText;
            Dividir.UseVisualStyleBackColor = true;
            Dividir.Click += Dividir_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(444, 44);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(174, 199);
            lstLista.TabIndex = 12;
            lstLista.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(674, 283);
            Controls.Add(lstLista);
            Controls.Add(Dividir);
            Controls.Add(Restar);
            Controls.Add(Multiplicar);
            Controls.Add(sumar);
            Controls.Add(textResultado);
            Controls.Add(label3);
            Controls.Add(textNum2);
            Controls.Add(label2);
            Controls.Add(textNum1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Practica Rapida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNum1;
        private TextBox textNum2;
        private Label label2;
        private TextBox textResultado;
        private Label label3;
        private Button sumar;
        private Button Multiplicar;
        private Button Restar;
        private Button Dividir;
        private ListBox lstLista;
    }
}
