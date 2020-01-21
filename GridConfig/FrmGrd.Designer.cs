namespace GridConfig
{
    partial class FrmGrd
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
            this.dgvGrd = new System.Windows.Forms.DataGridView();
            this.btnDados = new System.Windows.Forms.Button();
            this.btnHeader = new System.Windows.Forms.Button();
            this.btnRows = new System.Windows.Forms.Button();
            this.btnCols = new System.Windows.Forms.Button();
            this.btnBehavior = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrd
            // 
            this.dgvGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrd.Location = new System.Drawing.Point(154, 20);
            this.dgvGrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrd.Name = "dgvGrd";
            this.dgvGrd.Size = new System.Drawing.Size(665, 549);
            this.dgvGrd.TabIndex = 0;
            this.dgvGrd.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrd_CellMouseDown);
            // 
            // btnDados
            // 
            this.btnDados.BackColor = System.Drawing.Color.Snow;
            this.btnDados.CausesValidation = false;
            this.btnDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDados.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDados.Location = new System.Drawing.Point(23, 20);
            this.btnDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(111, 47);
            this.btnDados.TabIndex = 1;
            this.btnDados.Text = "Dados";
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.Click += new System.EventHandler(this.BtnDados_Click);
            // 
            // btnHeader
            // 
            this.btnHeader.BackColor = System.Drawing.Color.Snow;
            this.btnHeader.CausesValidation = false;
            this.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHeader.Location = new System.Drawing.Point(23, 77);
            this.btnHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(111, 47);
            this.btnHeader.TabIndex = 1;
            this.btnHeader.Text = "Header";
            this.btnHeader.UseVisualStyleBackColor = false;
            this.btnHeader.Click += new System.EventHandler(this.BtnHeader_Click);
            // 
            // btnRows
            // 
            this.btnRows.BackColor = System.Drawing.Color.Snow;
            this.btnRows.CausesValidation = false;
            this.btnRows.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRows.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRows.Location = new System.Drawing.Point(23, 134);
            this.btnRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRows.Name = "btnRows";
            this.btnRows.Size = new System.Drawing.Size(111, 47);
            this.btnRows.TabIndex = 1;
            this.btnRows.Text = "Rows";
            this.btnRows.UseVisualStyleBackColor = false;
            this.btnRows.Click += new System.EventHandler(this.BtnRows_Click);
            // 
            // btnCols
            // 
            this.btnCols.BackColor = System.Drawing.Color.Snow;
            this.btnCols.CausesValidation = false;
            this.btnCols.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCols.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCols.Location = new System.Drawing.Point(23, 191);
            this.btnCols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCols.Name = "btnCols";
            this.btnCols.Size = new System.Drawing.Size(111, 47);
            this.btnCols.TabIndex = 1;
            this.btnCols.Text = "Columns";
            this.btnCols.UseVisualStyleBackColor = false;
            this.btnCols.Click += new System.EventHandler(this.BtnCols_Click);
            // 
            // btnBehavior
            // 
            this.btnBehavior.BackColor = System.Drawing.Color.Snow;
            this.btnBehavior.CausesValidation = false;
            this.btnBehavior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBehavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBehavior.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBehavior.Location = new System.Drawing.Point(23, 248);
            this.btnBehavior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBehavior.Name = "btnBehavior";
            this.btnBehavior.Size = new System.Drawing.Size(111, 47);
            this.btnBehavior.TabIndex = 1;
            this.btnBehavior.Text = "Behavior";
            this.btnBehavior.UseVisualStyleBackColor = false;
            this.btnBehavior.Click += new System.EventHandler(this.BtnBehavior_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Snow;
            this.btnAll.CausesValidation = false;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAll.Location = new System.Drawing.Point(23, 305);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(111, 47);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "ALL";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // FrmGrd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(837, 583);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnBehavior);
            this.Controls.Add(this.btnCols);
            this.Controls.Add(this.btnRows);
            this.Controls.Add(this.btnHeader);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.dgvGrd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGrd";
            this.Text = "Configurando o DataGridView";
            this.Load += new System.EventHandler(this.FrmGrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrd;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Button btnHeader;
        private System.Windows.Forms.Button btnRows;
        private System.Windows.Forms.Button btnCols;
        private System.Windows.Forms.Button btnBehavior;
        private System.Windows.Forms.Button btnAll;
    }
}

