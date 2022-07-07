
namespace WheelChairHouse
{
    partial class ChairControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChairControl));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.img_foto = new System.Windows.Forms.PictureBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.dgv_bd = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.ofd_foto = new System.Windows.Forms.OpenFileDialog();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.btn_L = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(252, 13);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 16);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(12, 13);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(58, 16);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Codigo";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(10, 81);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(120, 16);
            this.lbl_tipo.TabIndex = 2;
            this.lbl_tipo.Text = "Tipo do Produto";
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd.Location = new System.Drawing.Point(252, 80);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(88, 16);
            this.lbl_qtd.TabIndex = 3;
            this.lbl_qtd.Text = "Quantidade";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(365, 80);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(45, 16);
            this.lbl_valor.TabIndex = 4;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(252, 29);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(218, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(12, 29);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(218, 20);
            this.txt_codigo.TabIndex = 7;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(252, 96);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(102, 20);
            this.txt_qtd.TabIndex = 8;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(368, 96);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(102, 20);
            this.txt_valor.TabIndex = 9;
            // 
            // img_foto
            // 
            this.img_foto.BackColor = System.Drawing.Color.Transparent;
            this.img_foto.Location = new System.Drawing.Point(504, 13);
            this.img_foto.Name = "img_foto";
            this.img_foto.Size = new System.Drawing.Size(419, 203);
            this.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_foto.TabIndex = 10;
            this.img_foto.TabStop = false;
            this.img_foto.Click += new System.EventHandler(this.img_foto_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(213)))), ((int)(((byte)(171)))));
            this.btn_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foto.Image = ((System.Drawing.Image)(resources.GetObject("btn_foto.Image")));
            this.btn_foto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_foto.Location = new System.Drawing.Point(504, 223);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(419, 37);
            this.btn_foto.TabIndex = 11;
            this.btn_foto.Text = "Escolha uma foto...";
            this.btn_foto.UseVisualStyleBackColor = false;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(213)))), ((int)(((byte)(171)))));
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(12, 147);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(140, 54);
            this.btn_novo.TabIndex = 12;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(213)))), ((int)(((byte)(171)))));
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(12, 207);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(140, 54);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(213)))), ((int)(((byte)(171)))));
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(165, 207);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(140, 54);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(213)))), ((int)(((byte)(171)))));
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(165, 147);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(140, 54);
            this.btn_alterar.TabIndex = 14;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // dgv_bd
            // 
            this.dgv_bd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bd.Location = new System.Drawing.Point(12, 267);
            this.dgv_bd.Name = "dgv_bd";
            this.dgv_bd.Size = new System.Drawing.Size(911, 200);
            this.dgv_bd.TabIndex = 16;
            this.dgv_bd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bd_CellContentClick);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(213)))), ((int)(((byte)(171)))));
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(12, 473);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(125, 44);
            this.btn_voltar.TabIndex = 17;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // ofd_foto
            // 
            this.ofd_foto.FileName = "openFileDialog1";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "Cadeira Elétrica",
            "Cadeira Manual",
            "Andador",
            "Muleta"});
            this.cbx_tipo.Location = new System.Drawing.Point(13, 97);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(218, 21);
            this.cbx_tipo.TabIndex = 18;
            // 
            // btn_L
            // 
            this.btn_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(213)))), ((int)(((byte)(171)))));
            this.btn_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_L.Location = new System.Drawing.Point(368, 133);
            this.btn_L.Name = "btn_L";
            this.btn_L.Size = new System.Drawing.Size(102, 35);
            this.btn_L.TabIndex = 0;
            this.btn_L.Text = "Limpar Campos";
            this.btn_L.UseVisualStyleBackColor = false;
            this.btn_L.Click += new System.EventHandler(this.btn_L_Click);
            // 
            // ChairControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(166)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(935, 524);
            this.Controls.Add(this.btn_L);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_bd);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.img_foto);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_nome);
            this.Name = "ChairControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Cadeiras";
            this.Load += new System.EventHandler(this.ChairControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.PictureBox img_foto;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.DataGridView dgv_bd;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.OpenFileDialog ofd_foto;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Button btn_L;
    }
}

