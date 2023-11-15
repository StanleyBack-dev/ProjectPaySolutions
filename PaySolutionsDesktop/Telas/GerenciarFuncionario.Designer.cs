namespace PaySolutionsDesktop.Telas
{
    partial class GerenciarFuncionario
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
            textBox1 = new TextBox();
            lvlFunc = new ListView();
            clhNome = new ColumnHeader();
            clhCpf = new ColumnHeader();
            clhBtnEdit = new ColumnHeader();
            clhBtnView = new ColumnHeader();
            clhBtnRemove = new ColumnHeader();
            btnAddFunc = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "buscar funcionário";
            // 
            // lvlFunc
            // 
            lvlFunc.Columns.AddRange(new ColumnHeader[] { clhNome, clhCpf, clhBtnEdit, clhBtnView, clhBtnRemove });
            lvlFunc.Location = new Point(92, 115);
            lvlFunc.Name = "lvlFunc";
            lvlFunc.Size = new Size(765, 279);
            lvlFunc.TabIndex = 1;
            lvlFunc.UseCompatibleStateImageBehavior = false;
            lvlFunc.View = View.Details;
            lvlFunc.SelectedIndexChanged += lvlFunc_SelectedIndexChanged;
            // 
            // clhNome
            // 
            clhNome.Text = "Nome";
            clhNome.Width = 380;
            // 
            // clhCpf
            // 
            clhCpf.Text = "CPF";
            clhCpf.Width = 200;
            // 
            // clhBtnEdit
            // 
            clhBtnEdit.Text = "";
            // 
            // clhBtnView
            // 
            clhBtnView.Text = "";
            // 
            // clhBtnRemove
            // 
            clhBtnRemove.Text = "";
            // 
            // btnAddFunc
            // 
            btnAddFunc.BackColor = SystemColors.Control;
            btnAddFunc.Cursor = Cursors.Hand;
            btnAddFunc.FlatAppearance.BorderColor = Color.Silver;
            btnAddFunc.FlatStyle = FlatStyle.Flat;
            btnAddFunc.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFunc.Location = new Point(396, 427);
            btnAddFunc.Name = "btnAddFunc";
            btnAddFunc.Size = new Size(170, 43);
            btnAddFunc.TabIndex = 2;
            btnAddFunc.Text = "Add Funcionário";
            btnAddFunc.UseVisualStyleBackColor = false;
            btnAddFunc.Click += btnAddFunc_Click;
            // 
            // GerenciarFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(932, 503);
            Controls.Add(btnAddFunc);
            Controls.Add(lvlFunc);
            Controls.Add(textBox1);
            Name = "GerenciarFuncionario";
            Text = "GerenciarFuncionario";
            Load += GerenciarFuncionario_Load;
            Paint += GerenciarFuncionario_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListView lvlFunc;
        private ColumnHeader clhNome;
        private ColumnHeader clhCpf;
        private ColumnHeader clhBtnEdit;
        private ColumnHeader clhBtnView;
        private ColumnHeader clhBtnRemove;
        private Button btnAddFunc;
    }
}