namespace Hexagon
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_Filled = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Board = new System.Windows.Forms.TableLayoutPanel();
            this.label_Board = new System.Windows.Forms.Label();
            this.doubleBufferedPanel_Board = new Hexagon.DoubleBufferedPanel();
            this.tableLayoutPanel_Filled.SuspendLayout();
            this.tableLayoutPanel_Board.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Filled
            // 
            this.tableLayoutPanel_Filled.ColumnCount = 2;
            this.tableLayoutPanel_Filled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Filled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_Filled.Controls.Add(this.tableLayoutPanel_Board, 0, 0);
            this.tableLayoutPanel_Filled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Filled.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Filled.Name = "tableLayoutPanel_Filled";
            this.tableLayoutPanel_Filled.RowCount = 1;
            this.tableLayoutPanel_Filled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Filled.Size = new System.Drawing.Size(652, 322);
            this.tableLayoutPanel_Filled.TabIndex = 0;
            // 
            // tableLayoutPanel_Board
            // 
            this.tableLayoutPanel_Board.ColumnCount = 1;
            this.tableLayoutPanel_Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Board.Controls.Add(this.label_Board, 0, 0);
            this.tableLayoutPanel_Board.Controls.Add(this.doubleBufferedPanel_Board, 0, 1);
            this.tableLayoutPanel_Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Board.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Board.Name = "tableLayoutPanel_Board";
            this.tableLayoutPanel_Board.RowCount = 2;
            this.tableLayoutPanel_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Board.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Board.Size = new System.Drawing.Size(450, 316);
            this.tableLayoutPanel_Board.TabIndex = 0;
            // 
            // label_Board
            // 
            this.label_Board.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Board.Location = new System.Drawing.Point(3, 0);
            this.label_Board.Name = "label_Board";
            this.label_Board.Size = new System.Drawing.Size(100, 20);
            this.label_Board.TabIndex = 0;
            this.label_Board.Text = "棋盤：";
            this.label_Board.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doubleBufferedPanel_Board
            // 
            this.doubleBufferedPanel_Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferedPanel_Board.Location = new System.Drawing.Point(3, 23);
            this.doubleBufferedPanel_Board.Name = "doubleBufferedPanel_Board";
            this.doubleBufferedPanel_Board.Size = new System.Drawing.Size(444, 290);
            this.doubleBufferedPanel_Board.TabIndex = 1;
            this.doubleBufferedPanel_Board.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBoard);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 322);
            this.Controls.Add(this.tableLayoutPanel_Filled);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tableLayoutPanel_Filled.ResumeLayout(false);
            this.tableLayoutPanel_Board.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Filled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Board;
        private System.Windows.Forms.Label label_Board;
        private DoubleBufferedPanel doubleBufferedPanel_Board;
    }
}

