namespace WinFormsAppDiplom
{
    partial class MainForm
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
            this.splitContainerMainForm = new System.Windows.Forms.SplitContainer();
            this.treeViewMainForm = new System.Windows.Forms.TreeView();
            this.tabControlScenario = new System.Windows.Forms.TabControl();
            this.tabPageScript = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLoadScript = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCreateScript = new System.Windows.Forms.Button();
            this.labelScript = new System.Windows.Forms.Label();
            this.panelScript = new System.Windows.Forms.Panel();
            this.dataGridViewScript = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPageBlock = new System.Windows.Forms.TabPage();
            this.tabPageActivity = new System.Windows.Forms.TabPage();
            this.tabPageObjects = new System.Windows.Forms.TabPage();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.buttonChoseScript = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).BeginInit();
            this.splitContainerMainForm.Panel1.SuspendLayout();
            this.splitContainerMainForm.Panel2.SuspendLayout();
            this.splitContainerMainForm.SuspendLayout();
            this.tabControlScenario.SuspendLayout();
            this.tabPageScript.SuspendLayout();
            this.panelScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScript)).BeginInit();
            this.panelMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMainForm
            // 
            this.splitContainerMainForm.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainerMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainForm.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMainForm.Name = "splitContainerMainForm";
            // 
            // splitContainerMainForm.Panel1
            // 
            this.splitContainerMainForm.Panel1.Controls.Add(this.treeViewMainForm);
            // 
            // splitContainerMainForm.Panel2
            // 
            this.splitContainerMainForm.Panel2.Controls.Add(this.tabControlScenario);
            this.splitContainerMainForm.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainerMainForm.Size = new System.Drawing.Size(1011, 487);
            this.splitContainerMainForm.SplitterDistance = 262;
            this.splitContainerMainForm.TabIndex = 2;
            // 
            // treeViewMainForm
            // 
            this.treeViewMainForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeViewMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMainForm.Location = new System.Drawing.Point(0, 0);
            this.treeViewMainForm.Name = "treeViewMainForm";
            this.treeViewMainForm.Size = new System.Drawing.Size(262, 487);
            this.treeViewMainForm.TabIndex = 1;
            // 
            // tabControlScenario
            // 
            this.tabControlScenario.Controls.Add(this.tabPageScript);
            this.tabControlScenario.Controls.Add(this.tabPageBlock);
            this.tabControlScenario.Controls.Add(this.tabPageActivity);
            this.tabControlScenario.Controls.Add(this.tabPageObjects);
            this.tabControlScenario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControlScenario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlScenario.ItemSize = new System.Drawing.Size(61, 30);
            this.tabControlScenario.Location = new System.Drawing.Point(0, 0);
            this.tabControlScenario.Name = "tabControlScenario";
            this.tabControlScenario.SelectedIndex = 0;
            this.tabControlScenario.Size = new System.Drawing.Size(745, 487);
            this.tabControlScenario.TabIndex = 0;
            // 
            // tabPageScript
            // 
            this.tabPageScript.Controls.Add(this.buttonChoseScript);
            this.tabPageScript.Controls.Add(this.buttonCancel);
            this.tabPageScript.Controls.Add(this.buttonApply);
            this.tabPageScript.Controls.Add(this.buttonDelete);
            this.tabPageScript.Controls.Add(this.buttonLoadScript);
            this.tabPageScript.Controls.Add(this.textBoxDescription);
            this.tabPageScript.Controls.Add(this.buttonCreateScript);
            this.tabPageScript.Controls.Add(this.labelScript);
            this.tabPageScript.Controls.Add(this.panelScript);
            this.tabPageScript.Controls.Add(this.textBoxName);
            this.tabPageScript.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageScript.Location = new System.Drawing.Point(4, 34);
            this.tabPageScript.Name = "tabPageScript";
            this.tabPageScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScript.Size = new System.Drawing.Size(737, 449);
            this.tabPageScript.TabIndex = 0;
            this.tabPageScript.Text = "Сценарий";
            this.tabPageScript.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(381, 59);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 26);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(381, 24);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(126, 26);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Сохранить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(525, 91);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 26);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLoadScript
            // 
            this.buttonLoadScript.Location = new System.Drawing.Point(381, 91);
            this.buttonLoadScript.Name = "buttonLoadScript";
            this.buttonLoadScript.Size = new System.Drawing.Size(126, 26);
            this.buttonLoadScript.TabIndex = 3;
            this.buttonLoadScript.Text = "Редактировать";
            this.buttonLoadScript.UseVisualStyleBackColor = true;
            this.buttonLoadScript.Click += new System.EventHandler(this.buttonLoadScript_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(6, 57);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PlaceholderText = "Описание";
            this.textBoxDescription.Size = new System.Drawing.Size(355, 60);
            this.textBoxDescription.TabIndex = 4;
            // 
            // buttonCreateScript
            // 
            this.buttonCreateScript.Location = new System.Drawing.Point(525, 56);
            this.buttonCreateScript.Name = "buttonCreateScript";
            this.buttonCreateScript.Size = new System.Drawing.Size(126, 26);
            this.buttonCreateScript.TabIndex = 2;
            this.buttonCreateScript.Text = "Создать";
            this.buttonCreateScript.UseVisualStyleBackColor = true;
            this.buttonCreateScript.Click += new System.EventHandler(this.buttonCreateScript_Click);
            // 
            // labelScript
            // 
            this.labelScript.AutoSize = true;
            this.labelScript.Location = new System.Drawing.Point(6, 3);
            this.labelScript.Name = "labelScript";
            this.labelScript.Size = new System.Drawing.Size(429, 19);
            this.labelScript.TabIndex = 1;
            this.labelScript.Text = "Выберете сценарий для редактирования или создайте новый.";
            // 
            // panelScript
            // 
            this.panelScript.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelScript.Controls.Add(this.dataGridViewScript);
            this.panelScript.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelScript.Location = new System.Drawing.Point(3, 130);
            this.panelScript.Margin = new System.Windows.Forms.Padding(10);
            this.panelScript.Name = "panelScript";
            this.panelScript.Size = new System.Drawing.Size(731, 316);
            this.panelScript.TabIndex = 0;
            // 
            // dataGridViewScript
            // 
            this.dataGridViewScript.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScript.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewScript.Name = "dataGridViewScript";
            this.dataGridViewScript.RowTemplate.Height = 25;
            this.dataGridViewScript.Size = new System.Drawing.Size(731, 316);
            this.dataGridViewScript.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Название";
            this.textBoxName.Size = new System.Drawing.Size(355, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // tabPageBlock
            // 
            this.tabPageBlock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageBlock.Location = new System.Drawing.Point(4, 34);
            this.tabPageBlock.Name = "tabPageBlock";
            this.tabPageBlock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBlock.Size = new System.Drawing.Size(737, 449);
            this.tabPageBlock.TabIndex = 1;
            this.tabPageBlock.Text = "Блок сценария";
            this.tabPageBlock.UseVisualStyleBackColor = true;
            // 
            // tabPageActivity
            // 
            this.tabPageActivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageActivity.Location = new System.Drawing.Point(4, 34);
            this.tabPageActivity.Name = "tabPageActivity";
            this.tabPageActivity.Size = new System.Drawing.Size(737, 449);
            this.tabPageActivity.TabIndex = 2;
            this.tabPageActivity.Text = "Активная зона";
            this.tabPageActivity.UseVisualStyleBackColor = true;
            // 
            // tabPageObjects
            // 
            this.tabPageObjects.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageObjects.Location = new System.Drawing.Point(4, 34);
            this.tabPageObjects.Name = "tabPageObjects";
            this.tabPageObjects.Size = new System.Drawing.Size(737, 449);
            this.tabPageObjects.TabIndex = 3;
            this.tabPageObjects.Text = "Предметы";
            this.tabPageObjects.UseVisualStyleBackColor = true;
            // 
            // panelMainForm
            // 
            this.panelMainForm.Controls.Add(this.splitContainerMainForm);
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(1011, 487);
            this.panelMainForm.TabIndex = 0;
            // 
            // buttonChoseScript
            // 
            this.buttonChoseScript.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChoseScript.Location = new System.Drawing.Point(525, 6);
            this.buttonChoseScript.Name = "buttonChoseScript";
            this.buttonChoseScript.Size = new System.Drawing.Size(126, 45);
            this.buttonChoseScript.TabIndex = 8;
            this.buttonChoseScript.Text = "Зафиксировать для работы";
            this.buttonChoseScript.UseVisualStyleBackColor = true;
            this.buttonChoseScript.Click += new System.EventHandler(this.buttonChoseScript_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 487);
            this.Controls.Add(this.panelMainForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Редактор сценариста";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerMainForm.Panel1.ResumeLayout(false);
            this.splitContainerMainForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).EndInit();
            this.splitContainerMainForm.ResumeLayout(false);
            this.tabControlScenario.ResumeLayout(false);
            this.tabPageScript.ResumeLayout(false);
            this.tabPageScript.PerformLayout();
            this.panelScript.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScript)).EndInit();
            this.panelMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainerMainForm;
        private TreeView treeViewMainForm;
        private TabControl tabControlScenario;
        private TabPage tabPageScript;
        private TabPage tabPageBlock;
        private TabPage tabPageActivity;
        private TabPage tabPageObjects;
        private Panel panelMainForm;
        private Button buttonLoadScript;
        private Button buttonCreateScript;
        private Label labelScript;
        private Panel panelScript;
        private DataGridView dataGridViewScript;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonApply;
        private Button buttonDelete;
        private Button buttonChoseScript;
    }
}