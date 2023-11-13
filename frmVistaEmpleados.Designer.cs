namespace pryArmanini_TP3
{
    partial class frmVistaEmpleados
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
            this.rtbArchivos = new System.Windows.Forms.RichTextBox();
            this.tvCarpeta = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // rtbArchivos
            // 
            this.rtbArchivos.Location = new System.Drawing.Point(22, 202);
            this.rtbArchivos.Name = "rtbArchivos";
            this.rtbArchivos.Size = new System.Drawing.Size(558, 213);
            this.rtbArchivos.TabIndex = 5;
            this.rtbArchivos.Text = "";
            // 
            // tvCarpeta
            // 
            this.tvCarpeta.Location = new System.Drawing.Point(22, 12);
            this.tvCarpeta.Name = "tvCarpeta";
            this.tvCarpeta.Size = new System.Drawing.Size(558, 184);
            this.tvCarpeta.TabIndex = 4;
            this.tvCarpeta.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCarpeta_AfterSelect);
            // 
            // frmVistaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 461);
            this.Controls.Add(this.rtbArchivos);
            this.Controls.Add(this.tvCarpeta);
            this.Name = "frmVistaEmpleados";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.frmVistaEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbArchivos;
        private System.Windows.Forms.TreeView tvCarpeta;
    }
}