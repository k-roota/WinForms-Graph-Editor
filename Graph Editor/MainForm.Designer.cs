namespace lab7
{
    partial class GraphEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphEditorForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.importExportBox = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.languageBox = new System.Windows.Forms.GroupBox();
            this.englishButton = new System.Windows.Forms.Button();
            this.polishButton = new System.Windows.Forms.Button();
            this.editionBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanelColor = new System.Windows.Forms.TableLayoutPanel();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.importExportBox.SuspendLayout();
            this.languageBox.SuspendLayout();
            this.editionBox.SuspendLayout();
            this.tableLayoutPanelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelRight, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // tableLayoutPanelRight
            // 
            resources.ApplyResources(this.tableLayoutPanelRight, "tableLayoutPanelRight");
            this.tableLayoutPanelRight.Controls.Add(this.importExportBox, 0, 2);
            this.tableLayoutPanelRight.Controls.Add(this.languageBox, 0, 1);
            this.tableLayoutPanelRight.Controls.Add(this.editionBox, 0, 0);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            // 
            // importExportBox
            // 
            resources.ApplyResources(this.importExportBox, "importExportBox");
            this.importExportBox.Controls.Add(this.loadButton);
            this.importExportBox.Controls.Add(this.saveButton);
            this.importExportBox.Name = "importExportBox";
            this.importExportBox.TabStop = false;
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.Name = "loadButton";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // languageBox
            // 
            resources.ApplyResources(this.languageBox, "languageBox");
            this.languageBox.Controls.Add(this.englishButton);
            this.languageBox.Controls.Add(this.polishButton);
            this.languageBox.Name = "languageBox";
            this.languageBox.TabStop = false;
            // 
            // englishButton
            // 
            resources.ApplyResources(this.englishButton, "englishButton");
            this.englishButton.Name = "englishButton";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // polishButton
            // 
            resources.ApplyResources(this.polishButton, "polishButton");
            this.polishButton.Name = "polishButton";
            this.polishButton.UseVisualStyleBackColor = true;
            this.polishButton.Click += new System.EventHandler(this.polishButton_Click);
            // 
            // editionBox
            // 
            resources.ApplyResources(this.editionBox, "editionBox");
            this.editionBox.Controls.Add(this.clearButton);
            this.editionBox.Controls.Add(this.removeButton);
            this.editionBox.Controls.Add(this.tableLayoutPanelColor);
            this.editionBox.Name = "editionBox";
            this.editionBox.TabStop = false;
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // removeButton
            // 
            resources.ApplyResources(this.removeButton, "removeButton");
            this.removeButton.Name = "removeButton";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // tableLayoutPanelColor
            // 
            resources.ApplyResources(this.tableLayoutPanelColor, "tableLayoutPanelColor");
            this.tableLayoutPanelColor.Controls.Add(this.colorButton, 0, 0);
            this.tableLayoutPanelColor.Controls.Add(this.colorPanel, 1, 0);
            this.tableLayoutPanelColor.Name = "tableLayoutPanelColor";
            // 
            // colorButton
            // 
            resources.ApplyResources(this.colorButton, "colorButton");
            this.colorButton.Name = "colorButton";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorPanel
            // 
            resources.ApplyResources(this.colorPanel, "colorPanel");
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.Name = "colorPanel";
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.ShowReadOnly = true;
            // 
            // GraphEditorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "GraphEditorForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphEditorForm_KeyDown);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.importExportBox.ResumeLayout(false);
            this.languageBox.ResumeLayout(false);
            this.editionBox.ResumeLayout(false);
            this.tableLayoutPanelColor.ResumeLayout(false);
            this.tableLayoutPanelColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.GroupBox importExportBox;
        private System.Windows.Forms.GroupBox languageBox;
        private System.Windows.Forms.GroupBox editionBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button polishButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeButton;
    }
}

