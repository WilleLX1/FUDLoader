namespace RubyFUDLoaderCreator
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
            btnAdd = new Button();
            btnBuild = new Button();
            txtLog = new TextBox();
            btnListArray = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            cbDuckyScript = new CheckBox();
            lblVersion = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBuild
            // 
            btnBuild.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuild.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuild.Location = new Point(1245, 12);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new Size(146, 47);
            btnBuild.TabIndex = 1;
            btnBuild.Text = "BUILD";
            btnBuild.UseVisualStyleBackColor = true;
            btnBuild.Click += btnBuild_Click;
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.Location = new Point(1101, 65);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(290, 376);
            txtLog.TabIndex = 2;
            // 
            // btnListArray
            // 
            btnListArray.Location = new Point(125, 12);
            btnListArray.Name = "btnListArray";
            btnListArray.Size = new Size(107, 38);
            btnListArray.TabIndex = 3;
            btnListArray.Text = "List Array";
            btnListArray.UseVisualStyleBackColor = true;
            btnListArray.Click += btnListArray_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 4;
            label1.Text = "URL to Download from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 52);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 5;
            label2.Text = "Path to place file";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(648, 52);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 6;
            label3.Text = "Custom Filename";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(957, 52);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Start file?";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1145, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 25);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1145, 34);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 25);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cbDuckyScript
            // 
            cbDuckyScript.AutoSize = true;
            cbDuckyScript.Location = new Point(1003, 12);
            cbDuckyScript.Name = "cbDuckyScript";
            cbDuckyScript.Size = new Size(109, 24);
            cbDuckyScript.TabIndex = 10;
            cbDuckyScript.Text = "DuckyScript";
            cbDuckyScript.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(238, 3);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(94, 20);
            lblVersion.TabIndex = 11;
            lblVersion.Text = "Version: 1.0.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 453);
            Controls.Add(lblVersion);
            Controls.Add(cbDuckyScript);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListArray);
            Controls.Add(txtLog);
            Controls.Add(btnAdd);
            Controls.Add(btnBuild);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnBuild;
        private TextBox txtLog;
        private Button btnListArray;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnLoad;
        private CheckBox cbDuckyScript;
        private Label lblVersion;
    }
}
