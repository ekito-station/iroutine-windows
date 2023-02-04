
namespace iTrain
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreDataGrid = new System.Windows.Forms.DataGridView();
            this.scoreDataSet = new iTrain.ScoreDataSet();
            this.scoreDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.腹筋DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.背筋DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.腕立て伏せDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.シャトルランDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sitUp = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backExtension = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pushUp = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shuttleRun = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreDataGrid
            // 
            this.scoreDataGrid.AutoGenerateColumns = false;
            this.scoreDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.腹筋DataGridViewTextBoxColumn,
            this.背筋DataGridViewTextBoxColumn,
            this.腕立て伏せDataGridViewTextBoxColumn,
            this.シャトルランDataGridViewTextBoxColumn});
            this.scoreDataGrid.DataSource = this.scoreDataTableBindingSource;
            this.scoreDataGrid.Location = new System.Drawing.Point(27, 25);
            this.scoreDataGrid.Name = "scoreDataGrid";
            this.scoreDataGrid.RowHeadersWidth = 62;
            this.scoreDataGrid.RowTemplate.Height = 27;
            this.scoreDataGrid.Size = new System.Drawing.Size(819, 206);
            this.scoreDataGrid.TabIndex = 0;
            // 
            // scoreDataSet
            // 
            this.scoreDataSet.DataSetName = "ScoreDataSet";
            this.scoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreDataTableBindingSource
            // 
            this.scoreDataTableBindingSource.DataMember = "scoreDataTable";
            this.scoreDataTableBindingSource.DataSource = this.scoreDataSet;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            this.日付DataGridViewTextBoxColumn.Width = 150;
            // 
            // 腹筋DataGridViewTextBoxColumn
            // 
            this.腹筋DataGridViewTextBoxColumn.DataPropertyName = "腹筋";
            this.腹筋DataGridViewTextBoxColumn.HeaderText = "腹筋";
            this.腹筋DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.腹筋DataGridViewTextBoxColumn.Name = "腹筋DataGridViewTextBoxColumn";
            this.腹筋DataGridViewTextBoxColumn.Width = 150;
            // 
            // 背筋DataGridViewTextBoxColumn
            // 
            this.背筋DataGridViewTextBoxColumn.DataPropertyName = "背筋";
            this.背筋DataGridViewTextBoxColumn.HeaderText = "背筋";
            this.背筋DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.背筋DataGridViewTextBoxColumn.Name = "背筋DataGridViewTextBoxColumn";
            this.背筋DataGridViewTextBoxColumn.Width = 150;
            // 
            // 腕立て伏せDataGridViewTextBoxColumn
            // 
            this.腕立て伏せDataGridViewTextBoxColumn.DataPropertyName = "腕立て伏せ";
            this.腕立て伏せDataGridViewTextBoxColumn.HeaderText = "腕立て伏せ";
            this.腕立て伏せDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.腕立て伏せDataGridViewTextBoxColumn.Name = "腕立て伏せDataGridViewTextBoxColumn";
            this.腕立て伏せDataGridViewTextBoxColumn.Width = 150;
            // 
            // シャトルランDataGridViewTextBoxColumn
            // 
            this.シャトルランDataGridViewTextBoxColumn.DataPropertyName = "シャトルラン";
            this.シャトルランDataGridViewTextBoxColumn.HeaderText = "シャトルラン";
            this.シャトルランDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.シャトルランDataGridViewTextBoxColumn.Name = "シャトルランDataGridViewTextBoxColumn";
            this.シャトルランDataGridViewTextBoxColumn.Width = 150;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.date.Location = new System.Drawing.Point(27, 255);
            this.date.Mask = "0000/00/00";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(178, 31);
            this.date.TabIndex = 1;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(23, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "腹筋";
            // 
            // sitUp
            // 
            this.sitUp.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.sitUp.Location = new System.Drawing.Point(87, 312);
            this.sitUp.Mask = "000";
            this.sitUp.Name = "sitUp";
            this.sitUp.Size = new System.Drawing.Size(78, 31);
            this.sitUp.TabIndex = 3;
            this.sitUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(171, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "回";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(171, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "回";
            // 
            // backExtension
            // 
            this.backExtension.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.backExtension.Location = new System.Drawing.Point(87, 368);
            this.backExtension.Mask = "000";
            this.backExtension.Name = "backExtension";
            this.backExtension.Size = new System.Drawing.Size(78, 31);
            this.backExtension.TabIndex = 6;
            this.backExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(23, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "背筋";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(518, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "回";
            // 
            // pushUp
            // 
            this.pushUp.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.pushUp.Location = new System.Drawing.Point(429, 312);
            this.pushUp.Mask = "000";
            this.pushUp.Name = "pushUp";
            this.pushUp.Size = new System.Drawing.Size(78, 31);
            this.pushUp.TabIndex = 9;
            this.pushUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(302, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "腕立て伏せ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(518, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "回";
            // 
            // shuttleRun
            // 
            this.shuttleRun.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.shuttleRun.Location = new System.Drawing.Point(429, 368);
            this.shuttleRun.Mask = "000";
            this.shuttleRun.Name = "shuttleRun";
            this.shuttleRun.Size = new System.Drawing.Size(78, 31);
            this.shuttleRun.TabIndex = 12;
            this.shuttleRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(302, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "シャトルラン";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.addButton.Location = new System.Drawing.Point(721, 255);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 56);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "登録";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.removeButton.Location = new System.Drawing.Point(721, 343);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(125, 56);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "削除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 435);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.shuttleRun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pushUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backExtension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sitUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.scoreDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FormShown);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 腹筋DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 背筋DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 腕立て伏せDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn シャトルランDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scoreDataTableBindingSource;
        private ScoreDataSet scoreDataSet;
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox sitUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox backExtension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox pushUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox shuttleRun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}

