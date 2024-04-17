namespace xO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBoard = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            btnVlan = new Button();
            pctbAvata = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbAvata).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlChessBoard.Location = new Point(12, 12);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(521, 434);
            pnlChessBoard.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(539, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 179);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(546, 272);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(546, 330);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "192.168";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(665, 272);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 99);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(608, 409);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 6;
            label1.Text = "5 to win";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(546, 301);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(113, 23);
            progressBar1.TabIndex = 7;
            // 
            // btnVlan
            // 
            btnVlan.Location = new Point(562, 359);
            btnVlan.Name = "btnVlan";
            btnVlan.Size = new Size(75, 23);
            btnVlan.TabIndex = 8;
            btnVlan.Text = "Lan";
            btnVlan.UseVisualStyleBackColor = true;
            // 
            // pctbAvata
            // 
            pctbAvata.Image = Properties.Resources.XO;
            pctbAvata.Location = new Point(539, 12);
            pctbAvata.Name = "pctbAvata";
            pctbAvata.Size = new Size(249, 249);
            pctbAvata.SizeMode = PictureBoxSizeMode.CenterImage;
            pctbAvata.TabIndex = 9;
            pctbAvata.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctbAvata);
            Controls.Add(btnVlan);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlChessBoard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbAvata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBoard;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Label label1;
        private ProgressBar progressBar1;
        private Button btnVlan;
        private PictureBox pctbAvata;
    }
}
