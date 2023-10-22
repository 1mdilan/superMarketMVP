namespace superMarketMVP.Views
{
    partial class PayModeView
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
            panel1 = new Panel();
            lblPayMode = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            dgPayMode = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            tabPagePayModeDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtPayModeObservation = new TextBox();
            txtPayModeName = new TextBox();
            lblPayModeObservation = new Label();
            label2 = new Label();
            txtPayModeID = new TextBox();
            lblPayModeID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // lblPayMode
            // 
            lblPayMode.AutoSize = true;
            lblPayMode.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPayMode.Location = new Point(106, 35);
            lblPayMode.Name = "lblPayMode";
            lblPayMode.Size = new Size(96, 23);
            lblPayMode.TabIndex = 1;
            lblPayMode.Text = "PAY MODE";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(btnClose);
            tabPagePayModeList.Controls.Add(btnDelete);
            tabPagePayModeList.Controls.Add(btnEdit);
            tabPagePayModeList.Controls.Add(btnNew);
            tabPagePayModeList.Controls.Add(dgPayMode);
            tabPagePayModeList.Controls.Add(btnSearch);
            tabPagePayModeList.Controls.Add(txtSearch);
            tabPagePayModeList.Controls.Add(label1);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 322);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(709, 264);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 50);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(709, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 50);
            btnDelete.TabIndex = 6;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(709, 106);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 50);
            btnEdit.TabIndex = 5;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(709, 50);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 50);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += button1_Click;
            // 
            // dgPayMode
            // 
            dgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayMode.Location = new Point(8, 50);
            dgPayMode.Name = "dgPayMode";
            dgPayMode.RowTemplate.Height = 25;
            dgPayMode.Size = new Size(695, 264);
            dgPayMode.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(628, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(8, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Data to search";
            txtSearch.Size = new Size(614, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(btnCancel);
            tabPagePayModeDetail.Controls.Add(btnSave);
            tabPagePayModeDetail.Controls.Add(txtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(txtPayModeName);
            tabPagePayModeDetail.Controls.Add(lblPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label2);
            tabPagePayModeDetail.Controls.Add(txtPayModeID);
            tabPagePayModeDetail.Controls.Add(lblPayModeID);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 322);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(433, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 7;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(8, 168);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 6;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPayModeObservation
            // 
            txtPayModeObservation.Location = new Point(8, 139);
            txtPayModeObservation.Name = "txtPayModeObservation";
            txtPayModeObservation.Size = new Size(500, 23);
            txtPayModeObservation.TabIndex = 5;
            // 
            // txtPayModeName
            // 
            txtPayModeName.Location = new Point(8, 78);
            txtPayModeName.Name = "txtPayModeName";
            txtPayModeName.Size = new Size(500, 23);
            txtPayModeName.TabIndex = 4;
            // 
            // lblPayModeObservation
            // 
            lblPayModeObservation.AutoSize = true;
            lblPayModeObservation.Location = new Point(8, 121);
            lblPayModeObservation.Name = "lblPayModeObservation";
            lblPayModeObservation.Size = new Size(127, 15);
            lblPayModeObservation.TabIndex = 3;
            lblPayModeObservation.Text = "Pay Mode Observation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 60);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Pay Mode Name";
            // 
            // txtPayModeID
            // 
            txtPayModeID.Location = new Point(8, 21);
            txtPayModeID.Name = "txtPayModeID";
            txtPayModeID.Size = new Size(125, 23);
            txtPayModeID.TabIndex = 1;
            // 
            // lblPayModeID
            // 
            lblPayModeID.AutoSize = true;
            lblPayModeID.Location = new Point(8, 3);
            lblPayModeID.Name = "lblPayModeID";
            lblPayModeID.Size = new Size(74, 15);
            lblPayModeID.TabIndex = 0;
            lblPayModeID.Text = "Pay Mode ID";
            lblPayModeID.Click += label2_Click;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "PayModeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPayMode;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private Label label1;
        private TabPage tabPagePayModeDetail;
        private DataGridView dgPayMode;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Label lblPayModeID;
        private Label label2;
        private TextBox txtPayModeID;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPayModeObservation;
        private TextBox txtPayModeName;
        private Label lblPayModeObservation;
    }
}