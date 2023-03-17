namespace Certweb
{
    partial class Tarefas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            this.pnFlowLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pnFlowLinks
            // 
            this.pnFlowLinks.AutoScroll = true;
            this.pnFlowLinks.AutoSize = true;
            this.pnFlowLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnFlowLinks.Location = new System.Drawing.Point(35, 129);
            this.pnFlowLinks.Name = "pnFlowLinks";
            this.pnFlowLinks.Size = new System.Drawing.Size(463, 455);
            this.pnFlowLinks.TabIndex = 6;
            this.pnFlowLinks.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 96);
            this.label1.TabIndex = 5;
            this.label1.Text = "Links";
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExecutar.BackgroundImage")));
            this.btnExecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecutar.FlatAppearance.BorderSize = 0;
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.Location = new System.Drawing.Point(597, 222);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(275, 260);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ProgressBar.Location = new System.Drawing.Point(597, 561);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(275, 23);
            this.ProgressBar.TabIndex = 9;
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.pnFlowLinks);
            this.Controls.Add(this.label1);
            this.Name = "Tarefas";
            this.Size = new System.Drawing.Size(959, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnFlowLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}
