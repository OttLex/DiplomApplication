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
            this.buttonChoseScript = new System.Windows.Forms.Button();
            this.buttonCancelScript = new System.Windows.Forms.Button();
            this.buttonApplyScript = new System.Windows.Forms.Button();
            this.buttonDeleteScript = new System.Windows.Forms.Button();
            this.buttonLoadScript = new System.Windows.Forms.Button();
            this.textBoxDescriptionScript = new System.Windows.Forms.TextBox();
            this.textBoxNameScript = new System.Windows.Forms.TextBox();
            this.buttonCreateScript = new System.Windows.Forms.Button();
            this.labelScript = new System.Windows.Forms.Label();
            this.panelScript = new System.Windows.Forms.Panel();
            this.dataGridViewScript = new System.Windows.Forms.DataGridView();
            this.tabPageBlock = new System.Windows.Forms.TabPage();
            this.dataGridViewBlock = new System.Windows.Forms.DataGridView();
            this.buttonChoseBlock = new System.Windows.Forms.Button();
            this.buttonCancelBlock = new System.Windows.Forms.Button();
            this.buttonApplyBlock = new System.Windows.Forms.Button();
            this.buttonDeleteBlock = new System.Windows.Forms.Button();
            this.buttonLoadBlock = new System.Windows.Forms.Button();
            this.textBoxDescriptionBlock = new System.Windows.Forms.TextBox();
            this.textBoxNameBlock = new System.Windows.Forms.TextBox();
            this.buttonCreateBlock = new System.Windows.Forms.Button();
            this.labelBlock = new System.Windows.Forms.Label();
            this.tabPageBackground = new System.Windows.Forms.TabPage();
            this.dataGridViewBackground = new System.Windows.Forms.DataGridView();
            this.buttonChoseBackground = new System.Windows.Forms.Button();
            this.buttonCancelBackground = new System.Windows.Forms.Button();
            this.buttonApplyBackground = new System.Windows.Forms.Button();
            this.buttonDeleteBackground = new System.Windows.Forms.Button();
            this.buttonLoadBackground = new System.Windows.Forms.Button();
            this.textBoxDescriptionBackground = new System.Windows.Forms.TextBox();
            this.textBoxNameBackground = new System.Windows.Forms.TextBox();
            this.buttonCreateBackground = new System.Windows.Forms.Button();
            this.labelBackground = new System.Windows.Forms.Label();
            this.tabPageActivity = new System.Windows.Forms.TabPage();
            this.tabPageObjects = new System.Windows.Forms.TabPage();
            this.panelMainForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).BeginInit();
            this.splitContainerMainForm.Panel1.SuspendLayout();
            this.splitContainerMainForm.Panel2.SuspendLayout();
            this.splitContainerMainForm.SuspendLayout();
            this.tabControlScenario.SuspendLayout();
            this.tabPageScript.SuspendLayout();
            this.panelScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScript)).BeginInit();
            this.tabPageBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlock)).BeginInit();
            this.tabPageBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackground)).BeginInit();
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
            this.tabControlScenario.Controls.Add(this.tabPageBackground);
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
            this.tabControlScenario.SelectedIndexChanged += new System.EventHandler(this.tabControlScenario_SelectedIndexChanged);
            // 
            // tabPageScript
            // 
            this.tabPageScript.Controls.Add(this.buttonChoseScript);
            this.tabPageScript.Controls.Add(this.buttonCancelScript);
            this.tabPageScript.Controls.Add(this.buttonApplyScript);
            this.tabPageScript.Controls.Add(this.buttonDeleteScript);
            this.tabPageScript.Controls.Add(this.buttonLoadScript);
            this.tabPageScript.Controls.Add(this.textBoxDescriptionScript);
            this.tabPageScript.Controls.Add(this.textBoxNameScript);
            this.tabPageScript.Controls.Add(this.buttonCreateScript);
            this.tabPageScript.Controls.Add(this.labelScript);
            this.tabPageScript.Controls.Add(this.panelScript);
            this.tabPageScript.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageScript.Location = new System.Drawing.Point(4, 34);
            this.tabPageScript.Name = "tabPageScript";
            this.tabPageScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScript.Size = new System.Drawing.Size(737, 449);
            this.tabPageScript.TabIndex = 0;
            this.tabPageScript.Text = "Сценарий";
            this.tabPageScript.UseVisualStyleBackColor = true;
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
            // buttonCancelScript
            // 
            this.buttonCancelScript.Enabled = false;
            this.buttonCancelScript.Location = new System.Drawing.Point(381, 59);
            this.buttonCancelScript.Name = "buttonCancelScript";
            this.buttonCancelScript.Size = new System.Drawing.Size(126, 26);
            this.buttonCancelScript.TabIndex = 7;
            this.buttonCancelScript.Text = "Отменить";
            this.buttonCancelScript.UseVisualStyleBackColor = true;
            this.buttonCancelScript.Click += new System.EventHandler(this.buttonCanselScript_Click);
            // 
            // buttonApplyScript
            // 
            this.buttonApplyScript.Enabled = false;
            this.buttonApplyScript.Location = new System.Drawing.Point(381, 24);
            this.buttonApplyScript.Name = "buttonApplyScript";
            this.buttonApplyScript.Size = new System.Drawing.Size(126, 26);
            this.buttonApplyScript.TabIndex = 6;
            this.buttonApplyScript.Text = "Сохранить";
            this.buttonApplyScript.UseVisualStyleBackColor = true;
            this.buttonApplyScript.Click += new System.EventHandler(this.buttonApplyScript_Click);
            // 
            // buttonDeleteScript
            // 
            this.buttonDeleteScript.Location = new System.Drawing.Point(525, 91);
            this.buttonDeleteScript.Name = "buttonDeleteScript";
            this.buttonDeleteScript.Size = new System.Drawing.Size(126, 26);
            this.buttonDeleteScript.TabIndex = 5;
            this.buttonDeleteScript.Text = "Удалить";
            this.buttonDeleteScript.UseVisualStyleBackColor = true;
            this.buttonDeleteScript.Click += new System.EventHandler(this.buttonDeleteScript_Click);
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
            // textBoxDescriptionScript
            // 
            this.textBoxDescriptionScript.Location = new System.Drawing.Point(6, 57);
            this.textBoxDescriptionScript.Multiline = true;
            this.textBoxDescriptionScript.Name = "textBoxDescriptionScript";
            this.textBoxDescriptionScript.PlaceholderText = "Описание";
            this.textBoxDescriptionScript.Size = new System.Drawing.Size(355, 60);
            this.textBoxDescriptionScript.TabIndex = 4;
            // 
            // textBoxNameScript
            // 
            this.textBoxNameScript.Location = new System.Drawing.Point(6, 25);
            this.textBoxNameScript.Name = "textBoxNameScript";
            this.textBoxNameScript.PlaceholderText = "Название";
            this.textBoxNameScript.Size = new System.Drawing.Size(355, 26);
            this.textBoxNameScript.TabIndex = 1;
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
            // tabPageBlock
            // 
            this.tabPageBlock.Controls.Add(this.dataGridViewBlock);
            this.tabPageBlock.Controls.Add(this.buttonChoseBlock);
            this.tabPageBlock.Controls.Add(this.buttonCancelBlock);
            this.tabPageBlock.Controls.Add(this.buttonApplyBlock);
            this.tabPageBlock.Controls.Add(this.buttonDeleteBlock);
            this.tabPageBlock.Controls.Add(this.buttonLoadBlock);
            this.tabPageBlock.Controls.Add(this.textBoxDescriptionBlock);
            this.tabPageBlock.Controls.Add(this.textBoxNameBlock);
            this.tabPageBlock.Controls.Add(this.buttonCreateBlock);
            this.tabPageBlock.Controls.Add(this.labelBlock);
            this.tabPageBlock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageBlock.Location = new System.Drawing.Point(4, 34);
            this.tabPageBlock.Name = "tabPageBlock";
            this.tabPageBlock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBlock.Size = new System.Drawing.Size(737, 449);
            this.tabPageBlock.TabIndex = 1;
            this.tabPageBlock.Text = "Блок сценария";
            this.tabPageBlock.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBlock
            // 
            this.dataGridViewBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewBlock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBlock.Location = new System.Drawing.Point(3, 136);
            this.dataGridViewBlock.Name = "dataGridViewBlock";
            this.dataGridViewBlock.RowTemplate.Height = 25;
            this.dataGridViewBlock.Size = new System.Drawing.Size(731, 310);
            this.dataGridViewBlock.TabIndex = 18;
            // 
            // buttonChoseBlock
            // 
            this.buttonChoseBlock.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChoseBlock.Location = new System.Drawing.Point(525, 6);
            this.buttonChoseBlock.Name = "buttonChoseBlock";
            this.buttonChoseBlock.Size = new System.Drawing.Size(126, 45);
            this.buttonChoseBlock.TabIndex = 17;
            this.buttonChoseBlock.Text = "Зафиксировать для работы";
            this.buttonChoseBlock.UseVisualStyleBackColor = true;
            this.buttonChoseBlock.Click += new System.EventHandler(this.buttonChoseBlock_Click);
            // 
            // buttonCancelBlock
            // 
            this.buttonCancelBlock.Enabled = false;
            this.buttonCancelBlock.Location = new System.Drawing.Point(381, 59);
            this.buttonCancelBlock.Name = "buttonCancelBlock";
            this.buttonCancelBlock.Size = new System.Drawing.Size(126, 26);
            this.buttonCancelBlock.TabIndex = 16;
            this.buttonCancelBlock.Text = "Отменить";
            this.buttonCancelBlock.UseVisualStyleBackColor = true;
            // 
            // buttonApplyBlock
            // 
            this.buttonApplyBlock.Enabled = false;
            this.buttonApplyBlock.Location = new System.Drawing.Point(381, 24);
            this.buttonApplyBlock.Name = "buttonApplyBlock";
            this.buttonApplyBlock.Size = new System.Drawing.Size(126, 26);
            this.buttonApplyBlock.TabIndex = 15;
            this.buttonApplyBlock.Text = "Сохранить";
            this.buttonApplyBlock.UseVisualStyleBackColor = true;
            this.buttonApplyBlock.Click += new System.EventHandler(this.buttonApplyBlock_Click);
            // 
            // buttonDeleteBlock
            // 
            this.buttonDeleteBlock.Location = new System.Drawing.Point(525, 91);
            this.buttonDeleteBlock.Name = "buttonDeleteBlock";
            this.buttonDeleteBlock.Size = new System.Drawing.Size(126, 26);
            this.buttonDeleteBlock.TabIndex = 14;
            this.buttonDeleteBlock.Text = "Удалить";
            this.buttonDeleteBlock.UseVisualStyleBackColor = true;
            this.buttonDeleteBlock.Click += new System.EventHandler(this.buttonDeleteBlock_Click);
            // 
            // buttonLoadBlock
            // 
            this.buttonLoadBlock.Location = new System.Drawing.Point(381, 91);
            this.buttonLoadBlock.Name = "buttonLoadBlock";
            this.buttonLoadBlock.Size = new System.Drawing.Size(126, 26);
            this.buttonLoadBlock.TabIndex = 12;
            this.buttonLoadBlock.Text = "Редактировать";
            this.buttonLoadBlock.UseVisualStyleBackColor = true;
            this.buttonLoadBlock.Click += new System.EventHandler(this.buttonLoadBlock_Click);
            // 
            // textBoxDescriptionBlock
            // 
            this.textBoxDescriptionBlock.Location = new System.Drawing.Point(6, 57);
            this.textBoxDescriptionBlock.Multiline = true;
            this.textBoxDescriptionBlock.Name = "textBoxDescriptionBlock";
            this.textBoxDescriptionBlock.PlaceholderText = "Описание";
            this.textBoxDescriptionBlock.Size = new System.Drawing.Size(355, 60);
            this.textBoxDescriptionBlock.TabIndex = 13;
            // 
            // textBoxNameBlock
            // 
            this.textBoxNameBlock.Location = new System.Drawing.Point(6, 25);
            this.textBoxNameBlock.Name = "textBoxNameBlock";
            this.textBoxNameBlock.PlaceholderText = "Название";
            this.textBoxNameBlock.Size = new System.Drawing.Size(355, 26);
            this.textBoxNameBlock.TabIndex = 10;
            // 
            // buttonCreateBlock
            // 
            this.buttonCreateBlock.Location = new System.Drawing.Point(525, 56);
            this.buttonCreateBlock.Name = "buttonCreateBlock";
            this.buttonCreateBlock.Size = new System.Drawing.Size(126, 26);
            this.buttonCreateBlock.TabIndex = 11;
            this.buttonCreateBlock.Text = "Создать";
            this.buttonCreateBlock.UseVisualStyleBackColor = true;
            this.buttonCreateBlock.Click += new System.EventHandler(this.buttonCreateBlock_Click);
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Location = new System.Drawing.Point(6, 3);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(395, 19);
            this.labelBlock.TabIndex = 9;
            this.labelBlock.Text = "Выберете блок для редактирования или создайте новый.";
            // 
            // tabPageBackground
            // 
            this.tabPageBackground.Controls.Add(this.dataGridViewBackground);
            this.tabPageBackground.Controls.Add(this.buttonChoseBackground);
            this.tabPageBackground.Controls.Add(this.buttonCancelBackground);
            this.tabPageBackground.Controls.Add(this.buttonApplyBackground);
            this.tabPageBackground.Controls.Add(this.buttonDeleteBackground);
            this.tabPageBackground.Controls.Add(this.buttonLoadBackground);
            this.tabPageBackground.Controls.Add(this.textBoxDescriptionBackground);
            this.tabPageBackground.Controls.Add(this.textBoxNameBackground);
            this.tabPageBackground.Controls.Add(this.buttonCreateBackground);
            this.tabPageBackground.Controls.Add(this.labelBackground);
            this.tabPageBackground.Location = new System.Drawing.Point(4, 34);
            this.tabPageBackground.Name = "tabPageBackground";
            this.tabPageBackground.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackground.Size = new System.Drawing.Size(737, 449);
            this.tabPageBackground.TabIndex = 4;
            this.tabPageBackground.Text = "Фоны";
            this.tabPageBackground.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBackground
            // 
            this.dataGridViewBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewBackground.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBackground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackground.Location = new System.Drawing.Point(3, 136);
            this.dataGridViewBackground.Name = "dataGridViewBackground";
            this.dataGridViewBackground.RowTemplate.Height = 25;
            this.dataGridViewBackground.Size = new System.Drawing.Size(731, 310);
            this.dataGridViewBackground.TabIndex = 28;
            // 
            // buttonChoseBackground
            // 
            this.buttonChoseBackground.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChoseBackground.Location = new System.Drawing.Point(525, 6);
            this.buttonChoseBackground.Name = "buttonChoseBackground";
            this.buttonChoseBackground.Size = new System.Drawing.Size(126, 45);
            this.buttonChoseBackground.TabIndex = 27;
            this.buttonChoseBackground.Text = "Зафиксировать для работы";
            this.buttonChoseBackground.UseVisualStyleBackColor = true;
            this.buttonChoseBackground.Click += new System.EventHandler(this.buttonChoseBackground_Click);
            // 
            // buttonCancelBackground
            // 
            this.buttonCancelBackground.Enabled = false;
            this.buttonCancelBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelBackground.Location = new System.Drawing.Point(381, 59);
            this.buttonCancelBackground.Name = "buttonCancelBackground";
            this.buttonCancelBackground.Size = new System.Drawing.Size(126, 26);
            this.buttonCancelBackground.TabIndex = 26;
            this.buttonCancelBackground.Text = "Отменить";
            this.buttonCancelBackground.UseVisualStyleBackColor = true;
            this.buttonCancelBackground.Click += new System.EventHandler(this.buttonCanselBackground_Click);
            // 
            // buttonApplyBackground
            // 
            this.buttonApplyBackground.Enabled = false;
            this.buttonApplyBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApplyBackground.Location = new System.Drawing.Point(381, 24);
            this.buttonApplyBackground.Name = "buttonApplyBackground";
            this.buttonApplyBackground.Size = new System.Drawing.Size(126, 26);
            this.buttonApplyBackground.TabIndex = 25;
            this.buttonApplyBackground.Text = "Сохранить";
            this.buttonApplyBackground.UseVisualStyleBackColor = true;
            this.buttonApplyBackground.Click += new System.EventHandler(this.buttonApplyBackground_Click);
            // 
            // buttonDeleteBackground
            // 
            this.buttonDeleteBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteBackground.Location = new System.Drawing.Point(525, 91);
            this.buttonDeleteBackground.Name = "buttonDeleteBackground";
            this.buttonDeleteBackground.Size = new System.Drawing.Size(126, 26);
            this.buttonDeleteBackground.TabIndex = 24;
            this.buttonDeleteBackground.Text = "Удалить";
            this.buttonDeleteBackground.UseVisualStyleBackColor = true;
            this.buttonDeleteBackground.Click += new System.EventHandler(this.buttonDeleteBackground_Click);
            // 
            // buttonLoadBackground
            // 
            this.buttonLoadBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadBackground.Location = new System.Drawing.Point(381, 91);
            this.buttonLoadBackground.Name = "buttonLoadBackground";
            this.buttonLoadBackground.Size = new System.Drawing.Size(126, 26);
            this.buttonLoadBackground.TabIndex = 22;
            this.buttonLoadBackground.Text = "Редактировать";
            this.buttonLoadBackground.UseVisualStyleBackColor = true;
            this.buttonLoadBackground.Click += new System.EventHandler(this.buttonLoadBackground_Click);
            // 
            // textBoxDescriptionBackground
            // 
            this.textBoxDescriptionBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescriptionBackground.Location = new System.Drawing.Point(6, 57);
            this.textBoxDescriptionBackground.Multiline = true;
            this.textBoxDescriptionBackground.Name = "textBoxDescriptionBackground";
            this.textBoxDescriptionBackground.PlaceholderText = "Описание";
            this.textBoxDescriptionBackground.Size = new System.Drawing.Size(355, 60);
            this.textBoxDescriptionBackground.TabIndex = 23;
            // 
            // textBoxNameBackground
            // 
            this.textBoxNameBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameBackground.Location = new System.Drawing.Point(6, 25);
            this.textBoxNameBackground.Name = "textBoxNameBackground";
            this.textBoxNameBackground.PlaceholderText = "Название";
            this.textBoxNameBackground.Size = new System.Drawing.Size(355, 26);
            this.textBoxNameBackground.TabIndex = 20;
            // 
            // buttonCreateBackground
            // 
            this.buttonCreateBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateBackground.Location = new System.Drawing.Point(525, 56);
            this.buttonCreateBackground.Name = "buttonCreateBackground";
            this.buttonCreateBackground.Size = new System.Drawing.Size(126, 26);
            this.buttonCreateBackground.TabIndex = 21;
            this.buttonCreateBackground.Text = "Создать";
            this.buttonCreateBackground.UseVisualStyleBackColor = true;
            this.buttonCreateBackground.Click += new System.EventHandler(this.buttonCreateBackground_Click);
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBackground.Location = new System.Drawing.Point(6, 3);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(390, 19);
            this.labelBackground.TabIndex = 19;
            this.labelBackground.Text = "Выберете фон для редактирования или создайте новый.";
            // 
            // tabPageActivity
            // 
            this.tabPageActivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageActivity.Location = new System.Drawing.Point(4, 34);
            this.tabPageActivity.Name = "tabPageActivity";
            this.tabPageActivity.Size = new System.Drawing.Size(737, 449);
            this.tabPageActivity.TabIndex = 2;
            this.tabPageActivity.Text = "Активности";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 487);
            this.Controls.Add(this.panelMainForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Редактор сценариста";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainerMainForm.Panel1.ResumeLayout(false);
            this.splitContainerMainForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).EndInit();
            this.splitContainerMainForm.ResumeLayout(false);
            this.tabControlScenario.ResumeLayout(false);
            this.tabPageScript.ResumeLayout(false);
            this.tabPageScript.PerformLayout();
            this.panelScript.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScript)).EndInit();
            this.tabPageBlock.ResumeLayout(false);
            this.tabPageBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlock)).EndInit();
            this.tabPageBackground.ResumeLayout(false);
            this.tabPageBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackground)).EndInit();
            this.panelMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainerMainForm;
        private TreeView treeViewMainForm;
        private Panel panelMainForm;
        private TabControl tabControlScenario;
        private TabPage tabPageScript;
        private Button buttonChoseScript;
        private Button buttonCancelScript;
        private Button buttonApplyScript;
        private Button buttonDeleteScript;
        private Button buttonLoadScript;
        private TextBox textBoxDescriptionScript;
        private TextBox textBoxNameScript;
        private Button buttonCreateScript;
        private Label labelScript;
        private Panel panelScript;
        private DataGridView dataGridViewScript;
        private TabPage tabPageBlock;
        private DataGridView dataGridViewBlock;
        private Button buttonChoseBlock;
        private Button buttonCancelBlock;
        private Button buttonApplyBlock;
        private Button buttonDeleteBlock;
        private Button buttonLoadBlock;
        private TextBox textBoxDescriptionBlock;
        private TextBox textBoxNameBlock;
        private Button buttonCreateBlock;
        private Label labelBlock;
        private TabPage tabPageBackground;
        private TabPage tabPageActivity;
        private TabPage tabPageObjects;
        private DataGridView dataGridViewBackground;
        private Button buttonChoseBackground;
        private Button buttonCancelBackground;
        private Button buttonApplyBackground;
        private Button buttonDeleteBackground;
        private Button buttonLoadBackground;
        private TextBox textBoxDescriptionBackground;
        private TextBox textBoxNameBackground;
        private Button buttonCreateBackground;
        private Label labelBackground;
    }
}