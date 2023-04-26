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
            splitContainerMainForm = new SplitContainer();
            treeViewMainForm = new TreeView();
            tabControlScenario = new TabControl();
            tabPageScript = new TabPage();
            buttonChoseScript = new Button();
            buttonCancelScript = new Button();
            buttonApplyScript = new Button();
            buttonDeleteScript = new Button();
            buttonLoadScript = new Button();
            textBoxDescriptionScript = new TextBox();
            textBoxNameScript = new TextBox();
            buttonCreateScript = new Button();
            labelScript = new Label();
            panelScript = new Panel();
            dataGridViewScript = new DataGridView();
            tabPageBlock = new TabPage();
            panelBlock = new Panel();
            dataGridViewBlock = new DataGridView();
            buttonChoseBlock = new Button();
            buttonCancelBlock = new Button();
            buttonApplyBlock = new Button();
            buttonDeleteBlock = new Button();
            buttonLoadBlock = new Button();
            textBoxDescriptionBlock = new TextBox();
            textBoxNameBlock = new TextBox();
            buttonCreateBlock = new Button();
            labelBlock = new Label();
            tabPageBackground = new TabPage();
            panelBackground = new Panel();
            dataGridViewBackground = new DataGridView();
            textBoxSearchBackground = new TextBox();
            buttonCancelBackground = new Button();
            buttonApplyBackground = new Button();
            buttonDeleteBackground = new Button();
            buttonLoadBackground = new Button();
            textBoxDescriptionBackground = new TextBox();
            textBoxNameBackground = new TextBox();
            buttonCreateBackground = new Button();
            labelBackground = new Label();
            tabPageObjects = new TabPage();
            panelMorph = new Panel();
            panelObjects = new Panel();
            dataGridViewObjects = new DataGridView();
            buttonDefineFromMorph = new Button();
            dataGridViewObjToMorph = new DataGridView();
            dataGridViewRecipeToMorph = new DataGridView();
            buttonAddToMorph = new Button();
            textBoxSearchMorph = new TextBox();
            checkBoxIsMorph = new CheckBox();
            textBoxSearchObjects = new TextBox();
            buttonCancelObjects = new Button();
            buttonApplyObjects = new Button();
            buttonDeleteObjects = new Button();
            buttonLoadObjects = new Button();
            textBoxNameObjects = new TextBox();
            buttonCreateObject = new Button();
            labelObjects = new Label();
            tabPageActivityTypes = new TabPage();
            tabPageActivity = new TabPage();
            tabPageTests = new TabPage();
            panelMainForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainerMainForm).BeginInit();
            splitContainerMainForm.Panel1.SuspendLayout();
            splitContainerMainForm.Panel2.SuspendLayout();
            splitContainerMainForm.SuspendLayout();
            tabControlScenario.SuspendLayout();
            tabPageScript.SuspendLayout();
            panelScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScript).BeginInit();
            tabPageBlock.SuspendLayout();
            panelBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBlock).BeginInit();
            tabPageBackground.SuspendLayout();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBackground).BeginInit();
            tabPageObjects.SuspendLayout();
            panelMorph.SuspendLayout();
            panelObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjToMorph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipeToMorph).BeginInit();
            panelMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerMainForm
            // 
            splitContainerMainForm.Cursor = Cursors.VSplit;
            splitContainerMainForm.Dock = DockStyle.Fill;
            splitContainerMainForm.Location = new Point(0, 0);
            splitContainerMainForm.Name = "splitContainerMainForm";
            // 
            // splitContainerMainForm.Panel1
            // 
            splitContainerMainForm.Panel1.Controls.Add(treeViewMainForm);
            // 
            // splitContainerMainForm.Panel2
            // 
            splitContainerMainForm.Panel2.Controls.Add(tabControlScenario);
            splitContainerMainForm.Panel2.Cursor = Cursors.Arrow;
            splitContainerMainForm.Size = new Size(1451, 732);
            splitContainerMainForm.SplitterDistance = 376;
            splitContainerMainForm.TabIndex = 2;
            // 
            // treeViewMainForm
            // 
            treeViewMainForm.Dock = DockStyle.Fill;
            treeViewMainForm.Location = new Point(0, 0);
            treeViewMainForm.Name = "treeViewMainForm";
            treeViewMainForm.Size = new Size(376, 732);
            treeViewMainForm.TabIndex = 1;
            // 
            // tabControlScenario
            // 
            tabControlScenario.Controls.Add(tabPageScript);
            tabControlScenario.Controls.Add(tabPageBlock);
            tabControlScenario.Controls.Add(tabPageBackground);
            tabControlScenario.Controls.Add(tabPageObjects);
            tabControlScenario.Controls.Add(tabPageActivityTypes);
            tabControlScenario.Controls.Add(tabPageActivity);
            tabControlScenario.Controls.Add(tabPageTests);
            tabControlScenario.Dock = DockStyle.Fill;
            tabControlScenario.ItemSize = new Size(61, 30);
            tabControlScenario.Location = new Point(0, 0);
            tabControlScenario.Name = "tabControlScenario";
            tabControlScenario.SelectedIndex = 0;
            tabControlScenario.Size = new Size(1071, 732);
            tabControlScenario.TabIndex = 0;
            tabControlScenario.SelectedIndexChanged += tabControlScenario_SelectedIndexChanged;
            // 
            // tabPageScript
            // 
            tabPageScript.Controls.Add(buttonChoseScript);
            tabPageScript.Controls.Add(buttonCancelScript);
            tabPageScript.Controls.Add(buttonApplyScript);
            tabPageScript.Controls.Add(buttonDeleteScript);
            tabPageScript.Controls.Add(buttonLoadScript);
            tabPageScript.Controls.Add(textBoxDescriptionScript);
            tabPageScript.Controls.Add(textBoxNameScript);
            tabPageScript.Controls.Add(buttonCreateScript);
            tabPageScript.Controls.Add(labelScript);
            tabPageScript.Controls.Add(panelScript);
            tabPageScript.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageScript.Location = new Point(4, 34);
            tabPageScript.Name = "tabPageScript";
            tabPageScript.Padding = new Padding(3);
            tabPageScript.Size = new Size(1063, 694);
            tabPageScript.TabIndex = 0;
            tabPageScript.Text = "Сценарий";
            tabPageScript.UseVisualStyleBackColor = true;
            // 
            // buttonChoseScript
            // 
            buttonChoseScript.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChoseScript.Location = new Point(843, 24);
            buttonChoseScript.Name = "buttonChoseScript";
            buttonChoseScript.Size = new Size(203, 25);
            buttonChoseScript.TabIndex = 8;
            buttonChoseScript.Text = "Зафиксировать для работы";
            buttonChoseScript.UseVisualStyleBackColor = true;
            buttonChoseScript.Click += buttonChoseScript_Click;
            // 
            // buttonCancelScript
            // 
            buttonCancelScript.Enabled = false;
            buttonCancelScript.Location = new Point(383, 92);
            buttonCancelScript.Name = "buttonCancelScript";
            buttonCancelScript.Size = new Size(126, 26);
            buttonCancelScript.TabIndex = 7;
            buttonCancelScript.Text = "Отменить";
            buttonCancelScript.UseVisualStyleBackColor = true;
            buttonCancelScript.Click += buttonCancelScript_Click;
            // 
            // buttonApplyScript
            // 
            buttonApplyScript.Enabled = false;
            buttonApplyScript.Location = new Point(383, 57);
            buttonApplyScript.Name = "buttonApplyScript";
            buttonApplyScript.Size = new Size(126, 26);
            buttonApplyScript.TabIndex = 6;
            buttonApplyScript.Text = "Сохранить";
            buttonApplyScript.UseVisualStyleBackColor = true;
            buttonApplyScript.Click += buttonApplyScript_Click;
            // 
            // buttonDeleteScript
            // 
            buttonDeleteScript.Location = new Point(693, 25);
            buttonDeleteScript.Name = "buttonDeleteScript";
            buttonDeleteScript.Size = new Size(126, 26);
            buttonDeleteScript.TabIndex = 5;
            buttonDeleteScript.Text = "Удалить";
            buttonDeleteScript.UseVisualStyleBackColor = true;
            buttonDeleteScript.Click += buttonDeleteScript_Click;
            // 
            // buttonLoadScript
            // 
            buttonLoadScript.Location = new Point(383, 25);
            buttonLoadScript.Name = "buttonLoadScript";
            buttonLoadScript.Size = new Size(126, 26);
            buttonLoadScript.TabIndex = 3;
            buttonLoadScript.Text = "Редактировать";
            buttonLoadScript.UseVisualStyleBackColor = true;
            buttonLoadScript.Click += buttonLoadScript_Click;
            // 
            // textBoxDescriptionScript
            // 
            textBoxDescriptionScript.Location = new Point(6, 57);
            textBoxDescriptionScript.Multiline = true;
            textBoxDescriptionScript.Name = "textBoxDescriptionScript";
            textBoxDescriptionScript.PlaceholderText = "Описание";
            textBoxDescriptionScript.Size = new Size(355, 60);
            textBoxDescriptionScript.TabIndex = 4;
            // 
            // textBoxNameScript
            // 
            textBoxNameScript.Location = new Point(6, 25);
            textBoxNameScript.Name = "textBoxNameScript";
            textBoxNameScript.PlaceholderText = "Название";
            textBoxNameScript.Size = new Size(355, 26);
            textBoxNameScript.TabIndex = 1;
            // 
            // buttonCreateScript
            // 
            buttonCreateScript.Location = new Point(533, 24);
            buttonCreateScript.Name = "buttonCreateScript";
            buttonCreateScript.Size = new Size(126, 26);
            buttonCreateScript.TabIndex = 2;
            buttonCreateScript.Text = "Создать";
            buttonCreateScript.UseVisualStyleBackColor = true;
            buttonCreateScript.Click += buttonCreateScript_Click;
            // 
            // labelScript
            // 
            labelScript.AutoSize = true;
            labelScript.Location = new Point(6, 3);
            labelScript.Name = "labelScript";
            labelScript.Size = new Size(429, 19);
            labelScript.TabIndex = 1;
            labelScript.Text = "Выберете сценарий для редактирования или создайте новый.";
            // 
            // panelScript
            // 
            panelScript.BackColor = Color.WhiteSmoke;
            panelScript.Controls.Add(dataGridViewScript);
            panelScript.Dock = DockStyle.Bottom;
            panelScript.Location = new Point(3, 148);
            panelScript.Margin = new Padding(10);
            panelScript.Name = "panelScript";
            panelScript.Size = new Size(1057, 543);
            panelScript.TabIndex = 0;
            // 
            // dataGridViewScript
            // 
            dataGridViewScript.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewScript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewScript.Dock = DockStyle.Fill;
            dataGridViewScript.Location = new Point(0, 0);
            dataGridViewScript.Name = "dataGridViewScript";
            dataGridViewScript.RowTemplate.Height = 25;
            dataGridViewScript.Size = new Size(1057, 543);
            dataGridViewScript.TabIndex = 0;
            // 
            // tabPageBlock
            // 
            tabPageBlock.Controls.Add(panelBlock);
            tabPageBlock.Controls.Add(buttonChoseBlock);
            tabPageBlock.Controls.Add(buttonCancelBlock);
            tabPageBlock.Controls.Add(buttonApplyBlock);
            tabPageBlock.Controls.Add(buttonDeleteBlock);
            tabPageBlock.Controls.Add(buttonLoadBlock);
            tabPageBlock.Controls.Add(textBoxDescriptionBlock);
            tabPageBlock.Controls.Add(textBoxNameBlock);
            tabPageBlock.Controls.Add(buttonCreateBlock);
            tabPageBlock.Controls.Add(labelBlock);
            tabPageBlock.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageBlock.Location = new Point(4, 34);
            tabPageBlock.Name = "tabPageBlock";
            tabPageBlock.Padding = new Padding(3);
            tabPageBlock.Size = new Size(1063, 694);
            tabPageBlock.TabIndex = 1;
            tabPageBlock.Text = "Блок сценария";
            tabPageBlock.UseVisualStyleBackColor = true;
            // 
            // panelBlock
            // 
            panelBlock.Controls.Add(dataGridViewBlock);
            panelBlock.Dock = DockStyle.Bottom;
            panelBlock.Location = new Point(3, 148);
            panelBlock.Name = "panelBlock";
            panelBlock.Size = new Size(1057, 543);
            panelBlock.TabIndex = 19;
            // 
            // dataGridViewBlock
            // 
            dataGridViewBlock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBlock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBlock.Dock = DockStyle.Fill;
            dataGridViewBlock.Location = new Point(0, 0);
            dataGridViewBlock.Name = "dataGridViewBlock";
            dataGridViewBlock.RowTemplate.Height = 25;
            dataGridViewBlock.Size = new Size(1057, 543);
            dataGridViewBlock.TabIndex = 18;
            // 
            // buttonChoseBlock
            // 
            buttonChoseBlock.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChoseBlock.Location = new Point(852, 25);
            buttonChoseBlock.Name = "buttonChoseBlock";
            buttonChoseBlock.Size = new Size(203, 25);
            buttonChoseBlock.TabIndex = 17;
            buttonChoseBlock.Text = "Зафиксировать для работы";
            buttonChoseBlock.UseVisualStyleBackColor = true;
            buttonChoseBlock.Click += buttonChoseBlock_Click;
            // 
            // buttonCancelBlock
            // 
            buttonCancelBlock.Enabled = false;
            buttonCancelBlock.Location = new Point(386, 90);
            buttonCancelBlock.Name = "buttonCancelBlock";
            buttonCancelBlock.Size = new Size(126, 26);
            buttonCancelBlock.TabIndex = 16;
            buttonCancelBlock.Text = "Отменить";
            buttonCancelBlock.UseVisualStyleBackColor = true;
            // 
            // buttonApplyBlock
            // 
            buttonApplyBlock.Enabled = false;
            buttonApplyBlock.Location = new Point(386, 55);
            buttonApplyBlock.Name = "buttonApplyBlock";
            buttonApplyBlock.Size = new Size(126, 26);
            buttonApplyBlock.TabIndex = 15;
            buttonApplyBlock.Text = "Сохранить";
            buttonApplyBlock.UseVisualStyleBackColor = true;
            buttonApplyBlock.Click += buttonApplyBlock_Click;
            // 
            // buttonDeleteBlock
            // 
            buttonDeleteBlock.Location = new Point(697, 24);
            buttonDeleteBlock.Name = "buttonDeleteBlock";
            buttonDeleteBlock.Size = new Size(126, 26);
            buttonDeleteBlock.TabIndex = 14;
            buttonDeleteBlock.Text = "Удалить";
            buttonDeleteBlock.UseVisualStyleBackColor = true;
            buttonDeleteBlock.Click += buttonDeleteBlock_Click;
            // 
            // buttonLoadBlock
            // 
            buttonLoadBlock.Location = new Point(386, 23);
            buttonLoadBlock.Name = "buttonLoadBlock";
            buttonLoadBlock.Size = new Size(126, 26);
            buttonLoadBlock.TabIndex = 12;
            buttonLoadBlock.Text = "Редактировать";
            buttonLoadBlock.UseVisualStyleBackColor = true;
            buttonLoadBlock.Click += buttonLoadBlock_Click;
            // 
            // textBoxDescriptionBlock
            // 
            textBoxDescriptionBlock.Location = new Point(6, 57);
            textBoxDescriptionBlock.Multiline = true;
            textBoxDescriptionBlock.Name = "textBoxDescriptionBlock";
            textBoxDescriptionBlock.PlaceholderText = "Описание";
            textBoxDescriptionBlock.Size = new Size(355, 60);
            textBoxDescriptionBlock.TabIndex = 13;
            // 
            // textBoxNameBlock
            // 
            textBoxNameBlock.Location = new Point(6, 25);
            textBoxNameBlock.Name = "textBoxNameBlock";
            textBoxNameBlock.PlaceholderText = "Название";
            textBoxNameBlock.Size = new Size(355, 26);
            textBoxNameBlock.TabIndex = 10;
            // 
            // buttonCreateBlock
            // 
            buttonCreateBlock.Location = new Point(544, 24);
            buttonCreateBlock.Name = "buttonCreateBlock";
            buttonCreateBlock.Size = new Size(126, 26);
            buttonCreateBlock.TabIndex = 11;
            buttonCreateBlock.Text = "Создать";
            buttonCreateBlock.UseVisualStyleBackColor = true;
            buttonCreateBlock.Click += buttonCreateBlock_Click;
            // 
            // labelBlock
            // 
            labelBlock.AutoSize = true;
            labelBlock.Location = new Point(6, 3);
            labelBlock.Name = "labelBlock";
            labelBlock.Size = new Size(395, 19);
            labelBlock.TabIndex = 9;
            labelBlock.Text = "Выберете блок для редактирования или создайте новый.";
            // 
            // tabPageBackground
            // 
            tabPageBackground.Controls.Add(panelBackground);
            tabPageBackground.Controls.Add(textBoxSearchBackground);
            tabPageBackground.Controls.Add(buttonCancelBackground);
            tabPageBackground.Controls.Add(buttonApplyBackground);
            tabPageBackground.Controls.Add(buttonDeleteBackground);
            tabPageBackground.Controls.Add(buttonLoadBackground);
            tabPageBackground.Controls.Add(textBoxDescriptionBackground);
            tabPageBackground.Controls.Add(textBoxNameBackground);
            tabPageBackground.Controls.Add(buttonCreateBackground);
            tabPageBackground.Controls.Add(labelBackground);
            tabPageBackground.Location = new Point(4, 34);
            tabPageBackground.Name = "tabPageBackground";
            tabPageBackground.Padding = new Padding(3);
            tabPageBackground.Size = new Size(1063, 694);
            tabPageBackground.TabIndex = 4;
            tabPageBackground.Text = "Фоны";
            tabPageBackground.UseVisualStyleBackColor = true;
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(dataGridViewBackground);
            panelBackground.Dock = DockStyle.Bottom;
            panelBackground.Location = new Point(3, 148);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1057, 543);
            panelBackground.TabIndex = 30;
            // 
            // dataGridViewBackground
            // 
            dataGridViewBackground.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBackground.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBackground.Dock = DockStyle.Fill;
            dataGridViewBackground.Location = new Point(0, 0);
            dataGridViewBackground.Name = "dataGridViewBackground";
            dataGridViewBackground.RowTemplate.Height = 25;
            dataGridViewBackground.Size = new Size(1057, 543);
            dataGridViewBackground.TabIndex = 28;
            // 
            // textBoxSearchBackground
            // 
            textBoxSearchBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchBackground.Location = new Point(851, 25);
            textBoxSearchBackground.Name = "textBoxSearchBackground";
            textBoxSearchBackground.PlaceholderText = "Введите запрос для поиска.";
            textBoxSearchBackground.Size = new Size(204, 26);
            textBoxSearchBackground.TabIndex = 29;
            textBoxSearchBackground.TextChanged += textBoxSearchBackground_TextChanged;
            // 
            // buttonCancelBackground
            // 
            buttonCancelBackground.Enabled = false;
            buttonCancelBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelBackground.Location = new Point(378, 91);
            buttonCancelBackground.Name = "buttonCancelBackground";
            buttonCancelBackground.Size = new Size(126, 26);
            buttonCancelBackground.TabIndex = 26;
            buttonCancelBackground.Text = "Отменить";
            buttonCancelBackground.UseVisualStyleBackColor = true;
            buttonCancelBackground.Click += buttonCancelBackground_Click;
            // 
            // buttonApplyBackground
            // 
            buttonApplyBackground.Enabled = false;
            buttonApplyBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonApplyBackground.Location = new Point(378, 56);
            buttonApplyBackground.Name = "buttonApplyBackground";
            buttonApplyBackground.Size = new Size(126, 26);
            buttonApplyBackground.TabIndex = 25;
            buttonApplyBackground.Text = "Сохранить";
            buttonApplyBackground.UseVisualStyleBackColor = true;
            buttonApplyBackground.Click += buttonApplyBackground_Click;
            // 
            // buttonDeleteBackground
            // 
            buttonDeleteBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteBackground.Location = new Point(691, 24);
            buttonDeleteBackground.Name = "buttonDeleteBackground";
            buttonDeleteBackground.Size = new Size(126, 26);
            buttonDeleteBackground.TabIndex = 24;
            buttonDeleteBackground.Text = "Удалить";
            buttonDeleteBackground.UseVisualStyleBackColor = true;
            buttonDeleteBackground.Click += buttonDeleteBackground_Click;
            // 
            // buttonLoadBackground
            // 
            buttonLoadBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoadBackground.Location = new Point(378, 24);
            buttonLoadBackground.Name = "buttonLoadBackground";
            buttonLoadBackground.Size = new Size(126, 26);
            buttonLoadBackground.TabIndex = 22;
            buttonLoadBackground.Text = "Редактировать";
            buttonLoadBackground.UseVisualStyleBackColor = true;
            buttonLoadBackground.Click += buttonLoadBackground_Click;
            // 
            // textBoxDescriptionBackground
            // 
            textBoxDescriptionBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescriptionBackground.Location = new Point(6, 57);
            textBoxDescriptionBackground.Multiline = true;
            textBoxDescriptionBackground.Name = "textBoxDescriptionBackground";
            textBoxDescriptionBackground.PlaceholderText = "Описание";
            textBoxDescriptionBackground.Size = new Size(355, 60);
            textBoxDescriptionBackground.TabIndex = 23;
            // 
            // textBoxNameBackground
            // 
            textBoxNameBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNameBackground.Location = new Point(6, 25);
            textBoxNameBackground.Name = "textBoxNameBackground";
            textBoxNameBackground.PlaceholderText = "Название";
            textBoxNameBackground.Size = new Size(355, 26);
            textBoxNameBackground.TabIndex = 20;
            // 
            // buttonCreateBackground
            // 
            buttonCreateBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateBackground.Location = new Point(534, 24);
            buttonCreateBackground.Name = "buttonCreateBackground";
            buttonCreateBackground.Size = new Size(126, 26);
            buttonCreateBackground.TabIndex = 21;
            buttonCreateBackground.Text = "Создать";
            buttonCreateBackground.UseVisualStyleBackColor = true;
            buttonCreateBackground.Click += buttonCreateBackground_Click;
            // 
            // labelBackground
            // 
            labelBackground.AutoSize = true;
            labelBackground.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBackground.Location = new Point(6, 3);
            labelBackground.Name = "labelBackground";
            labelBackground.Size = new Size(390, 19);
            labelBackground.TabIndex = 19;
            labelBackground.Text = "Выберете фон для редактирования или создайте новый.";
            // 
            // tabPageObjects
            // 
            tabPageObjects.Controls.Add(panelMorph);
            tabPageObjects.Controls.Add(textBoxSearchMorph);
            tabPageObjects.Controls.Add(checkBoxIsMorph);
            tabPageObjects.Controls.Add(textBoxSearchObjects);
            tabPageObjects.Controls.Add(buttonCancelObjects);
            tabPageObjects.Controls.Add(buttonApplyObjects);
            tabPageObjects.Controls.Add(buttonDeleteObjects);
            tabPageObjects.Controls.Add(buttonLoadObjects);
            tabPageObjects.Controls.Add(textBoxNameObjects);
            tabPageObjects.Controls.Add(buttonCreateObject);
            tabPageObjects.Controls.Add(labelObjects);
            tabPageObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageObjects.Location = new Point(4, 34);
            tabPageObjects.Name = "tabPageObjects";
            tabPageObjects.Size = new Size(1063, 694);
            tabPageObjects.TabIndex = 3;
            tabPageObjects.Text = "Предметы";
            tabPageObjects.UseVisualStyleBackColor = true;
            // 
            // panelMorph
            // 
            panelMorph.Controls.Add(panelObjects);
            panelMorph.Controls.Add(buttonDefineFromMorph);
            panelMorph.Controls.Add(dataGridViewObjToMorph);
            panelMorph.Controls.Add(dataGridViewRecipeToMorph);
            panelMorph.Controls.Add(buttonAddToMorph);
            panelMorph.Dock = DockStyle.Bottom;
            panelMorph.Location = new Point(0, 120);
            panelMorph.Name = "panelMorph";
            panelMorph.Size = new Size(1063, 574);
            panelMorph.TabIndex = 46;
            // 
            // panelObjects
            // 
            panelObjects.Controls.Add(dataGridViewObjects);
            panelObjects.Dock = DockStyle.Bottom;
            panelObjects.Location = new Point(0, 294);
            panelObjects.Name = "panelObjects";
            panelObjects.Size = new Size(1063, 280);
            panelObjects.TabIndex = 46;
            // 
            // dataGridViewObjects
            // 
            dataGridViewObjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewObjects.Dock = DockStyle.Fill;
            dataGridViewObjects.Location = new Point(0, 0);
            dataGridViewObjects.Name = "dataGridViewObjects";
            dataGridViewObjects.RowTemplate.Height = 25;
            dataGridViewObjects.Size = new Size(1063, 280);
            dataGridViewObjects.TabIndex = 38;
            dataGridViewObjects.CellClick += dataGridViewObjects_CellClick;
            // 
            // buttonDefineFromMorph
            // 
            buttonDefineFromMorph.Enabled = false;
            buttonDefineFromMorph.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDefineFromMorph.ForeColor = Color.Red;
            buttonDefineFromMorph.Location = new Point(565, 6);
            buttonDefineFromMorph.Name = "buttonDefineFromMorph";
            buttonDefineFromMorph.Size = new Size(41, 33);
            buttonDefineFromMorph.TabIndex = 44;
            buttonDefineFromMorph.Text = "-";
            buttonDefineFromMorph.UseVisualStyleBackColor = true;
            buttonDefineFromMorph.Click += buttonDefineFromMorph_Click;
            // 
            // dataGridViewObjToMorph
            // 
            dataGridViewObjToMorph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjToMorph.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewObjToMorph.Enabled = false;
            dataGridViewObjToMorph.Location = new Point(3, 45);
            dataGridViewObjToMorph.Name = "dataGridViewObjToMorph";
            dataGridViewObjToMorph.RowTemplate.Height = 25;
            dataGridViewObjToMorph.Size = new Size(508, 200);
            dataGridViewObjToMorph.TabIndex = 42;
            // 
            // dataGridViewRecipeToMorph
            // 
            dataGridViewRecipeToMorph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecipeToMorph.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewRecipeToMorph.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipeToMorph.Enabled = false;
            dataGridViewRecipeToMorph.Location = new Point(565, 45);
            dataGridViewRecipeToMorph.Name = "dataGridViewRecipeToMorph";
            dataGridViewRecipeToMorph.RowTemplate.Height = 25;
            dataGridViewRecipeToMorph.Size = new Size(495, 200);
            dataGridViewRecipeToMorph.TabIndex = 45;
            // 
            // buttonAddToMorph
            // 
            buttonAddToMorph.Enabled = false;
            buttonAddToMorph.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddToMorph.ForeColor = Color.DarkGreen;
            buttonAddToMorph.Location = new Point(470, 6);
            buttonAddToMorph.Name = "buttonAddToMorph";
            buttonAddToMorph.Size = new Size(41, 33);
            buttonAddToMorph.TabIndex = 43;
            buttonAddToMorph.Text = "+";
            buttonAddToMorph.UseVisualStyleBackColor = true;
            buttonAddToMorph.Click += buttonAddToMorph_Click;
            // 
            // textBoxSearchMorph
            // 
            textBoxSearchMorph.Enabled = false;
            textBoxSearchMorph.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchMorph.Location = new Point(3, 85);
            textBoxSearchMorph.Name = "textBoxSearchMorph";
            textBoxSearchMorph.PlaceholderText = "Введите запрос для поиска.";
            textBoxSearchMorph.Size = new Size(355, 26);
            textBoxSearchMorph.TabIndex = 41;
            textBoxSearchMorph.TextChanged += textBoxSearchMorph_TextChanged;
            // 
            // checkBoxIsMorph
            // 
            checkBoxIsMorph.AutoSize = true;
            checkBoxIsMorph.Location = new Point(3, 56);
            checkBoxIsMorph.Name = "checkBoxIsMorph";
            checkBoxIsMorph.Size = new Size(67, 23);
            checkBoxIsMorph.TabIndex = 40;
            checkBoxIsMorph.Text = "Морф";
            checkBoxIsMorph.UseVisualStyleBackColor = true;
            checkBoxIsMorph.CheckedChanged += checkBoxIsMorph_CheckedChanged;
            // 
            // textBoxSearchObjects
            // 
            textBoxSearchObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchObjects.Location = new Point(841, 25);
            textBoxSearchObjects.Name = "textBoxSearchObjects";
            textBoxSearchObjects.PlaceholderText = "Введите запрос для поиска.";
            textBoxSearchObjects.Size = new Size(204, 26);
            textBoxSearchObjects.TabIndex = 39;
            textBoxSearchObjects.TextChanged += textBoxSearchObjects_TextChanged;
            // 
            // buttonCancelObjects
            // 
            buttonCancelObjects.Enabled = false;
            buttonCancelObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelObjects.Location = new Point(381, 88);
            buttonCancelObjects.Name = "buttonCancelObjects";
            buttonCancelObjects.Size = new Size(126, 26);
            buttonCancelObjects.TabIndex = 37;
            buttonCancelObjects.Text = "Отменить";
            buttonCancelObjects.UseVisualStyleBackColor = true;
            buttonCancelObjects.Click += buttonCancelObjects_Click;
            // 
            // buttonApplyObjects
            // 
            buttonApplyObjects.Enabled = false;
            buttonApplyObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonApplyObjects.Location = new Point(381, 53);
            buttonApplyObjects.Name = "buttonApplyObjects";
            buttonApplyObjects.Size = new Size(126, 26);
            buttonApplyObjects.TabIndex = 36;
            buttonApplyObjects.Text = "Сохранить";
            buttonApplyObjects.UseVisualStyleBackColor = true;
            buttonApplyObjects.Click += buttonApplyObjects_Click;
            // 
            // buttonDeleteObjects
            // 
            buttonDeleteObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteObjects.Location = new Point(701, 25);
            buttonDeleteObjects.Name = "buttonDeleteObjects";
            buttonDeleteObjects.Size = new Size(126, 26);
            buttonDeleteObjects.TabIndex = 35;
            buttonDeleteObjects.Text = "Удалить";
            buttonDeleteObjects.UseVisualStyleBackColor = true;
            buttonDeleteObjects.Click += buttonDeleteObjects_Click;
            // 
            // buttonLoadObjects
            // 
            buttonLoadObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoadObjects.Location = new Point(381, 21);
            buttonLoadObjects.Name = "buttonLoadObjects";
            buttonLoadObjects.Size = new Size(126, 26);
            buttonLoadObjects.TabIndex = 33;
            buttonLoadObjects.Text = "Редактировать";
            buttonLoadObjects.UseVisualStyleBackColor = true;
            buttonLoadObjects.Click += buttonLoadObjects_Click;
            // 
            // textBoxNameObjects
            // 
            textBoxNameObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNameObjects.Location = new Point(3, 25);
            textBoxNameObjects.Name = "textBoxNameObjects";
            textBoxNameObjects.PlaceholderText = "Название";
            textBoxNameObjects.Size = new Size(355, 26);
            textBoxNameObjects.TabIndex = 31;
            // 
            // buttonCreateObject
            // 
            buttonCreateObject.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateObject.Location = new Point(544, 25);
            buttonCreateObject.Name = "buttonCreateObject";
            buttonCreateObject.Size = new Size(126, 26);
            buttonCreateObject.TabIndex = 32;
            buttonCreateObject.Text = "Создать";
            buttonCreateObject.UseVisualStyleBackColor = true;
            buttonCreateObject.Click += buttonCreateObject_Click;
            // 
            // labelObjects
            // 
            labelObjects.AutoSize = true;
            labelObjects.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelObjects.Location = new Point(0, 3);
            labelObjects.Name = "labelObjects";
            labelObjects.Size = new Size(409, 19);
            labelObjects.TabIndex = 30;
            labelObjects.Text = "Выберете объект для редактирования или создайте новый.";
            // 
            // tabPageActivityTypes
            // 
            tabPageActivityTypes.Location = new Point(4, 34);
            tabPageActivityTypes.Name = "tabPageActivityTypes";
            tabPageActivityTypes.Padding = new Padding(3);
            tabPageActivityTypes.Size = new Size(1063, 694);
            tabPageActivityTypes.TabIndex = 5;
            tabPageActivityTypes.Text = "Типы активностей";
            tabPageActivityTypes.UseVisualStyleBackColor = true;
            // 
            // tabPageActivity
            // 
            tabPageActivity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageActivity.Location = new Point(4, 34);
            tabPageActivity.Name = "tabPageActivity";
            tabPageActivity.Size = new Size(1063, 694);
            tabPageActivity.TabIndex = 2;
            tabPageActivity.Text = "Активности";
            tabPageActivity.UseVisualStyleBackColor = true;
            // 
            // tabPageTests
            // 
            tabPageTests.Location = new Point(4, 34);
            tabPageTests.Name = "tabPageTests";
            tabPageTests.Padding = new Padding(3);
            tabPageTests.Size = new Size(1063, 694);
            tabPageTests.TabIndex = 6;
            tabPageTests.Text = "Проверки сценария";
            tabPageTests.UseVisualStyleBackColor = true;
            // 
            // panelMainForm
            // 
            panelMainForm.Controls.Add(splitContainerMainForm);
            panelMainForm.Dock = DockStyle.Fill;
            panelMainForm.Location = new Point(0, 0);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(1451, 732);
            panelMainForm.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 732);
            Controls.Add(panelMainForm);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Редактор сценариста";
            Load += MainForm_Load;
            splitContainerMainForm.Panel1.ResumeLayout(false);
            splitContainerMainForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMainForm).EndInit();
            splitContainerMainForm.ResumeLayout(false);
            tabControlScenario.ResumeLayout(false);
            tabPageScript.ResumeLayout(false);
            tabPageScript.PerformLayout();
            panelScript.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewScript).EndInit();
            tabPageBlock.ResumeLayout(false);
            tabPageBlock.PerformLayout();
            panelBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBlock).EndInit();
            tabPageBackground.ResumeLayout(false);
            tabPageBackground.PerformLayout();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBackground).EndInit();
            tabPageObjects.ResumeLayout(false);
            tabPageObjects.PerformLayout();
            panelMorph.ResumeLayout(false);
            panelObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjToMorph).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipeToMorph).EndInit();
            panelMainForm.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button buttonCancelBackground;
        private Button buttonApplyBackground;
        private Button buttonDeleteBackground;
        private Button buttonLoadBackground;
        private TextBox textBoxDescriptionBackground;
        private TextBox textBoxNameBackground;
        private Button buttonCreateBackground;
        private Label labelBackground;
        private TextBox textBoxSearchBackground;
        private DataGridView dataGridViewRecipeToMorph;
        private Button buttonDefineFromMorph;
        private Button buttonAddToMorph;
        private DataGridView dataGridViewObjToMorph;
        private TextBox textBoxSearchMorph;
        private CheckBox checkBoxIsMorph;
        private TextBox textBoxSearchObjects;
        private DataGridView dataGridViewObjects;
        private Button buttonCancelObjects;
        private Button buttonApplyObjects;
        private Button buttonDeleteObjects;
        private Button buttonLoadObjects;
        private TextBox textBoxNameObjects;
        private Button buttonCreateObject;
        private Label labelObjects;
        private TabPage tabPageActivityTypes;
        private TabPage tabPageTests;
        private Panel panelBlock;
        private Panel panelBackground;
        private Panel panelMorph;
        private Panel panelObjects;
    }
}