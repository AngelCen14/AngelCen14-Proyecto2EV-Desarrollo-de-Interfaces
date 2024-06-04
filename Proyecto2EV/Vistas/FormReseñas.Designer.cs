namespace Proyecto2EV.Vistas
{
    partial class FormReseñas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewReseñas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReseñas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReseñas
            // 
            this.dataGridViewReseñas.AllowUserToAddRows = false;
            this.dataGridViewReseñas.AllowUserToDeleteRows = false;
            this.dataGridViewReseñas.AllowUserToOrderColumns = true;
            this.dataGridViewReseñas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReseñas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReseñas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReseñas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReseñas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReseñas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReseñas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReseñas.Name = "dataGridViewReseñas";
            this.dataGridViewReseñas.ReadOnly = true;
            this.dataGridViewReseñas.Size = new System.Drawing.Size(695, 450);
            this.dataGridViewReseñas.TabIndex = 0;
            // 
            // FormReseñas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.dataGridViewReseñas);
            this.Name = "FormReseñas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reseñas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReseñas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReseñas;
    }
}