using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Model.EF;
using Microsoft.Data.SqlClient;
using Npgsql;
using Model.ModelsSpr;
using DataAccessLayer;
using Model.ModelRelations;
using DataAccessLayer.RepoRel;
using DataAccessLayer.RepoSpr;
using Model.ModelSpr;

namespace WinFormsAppDiplom
{
    public partial class MainForm : Form
    {
        private string _connectionString;
        private User _currentUser;


        private Script _currentEditableScript;
        private Script _currentWorkScript;

        private Block _currentEditableBlock;
        private Block _currentWorkBlock;

        private Background _currentEditableBackground;
        private Background _currentWorkBackground;

        private Objects _currentEditableObjects;
        private Objects _currentWorkObjects;

        private Morph _currentEditableMorph;
        private Morph _currentWorkMorph;




        private IRepository<ScriptData> _scriptDataRepository;
        private IRepository<Script> _scriptRepository;
        private IRepository<Block> _blockRepository;
        private IRepository<Background> _backgroundRepository;
        private IRepository<Objects> _objectRepository;
        private IRepository<Morph> _morphRepository;


        public MainForm(string connString, User user)
        {
            InitializeComponent();

            _connectionString = connString;
            _currentUser = user;


            ConfigureRepositorys();
        }

        private void ConfigureRepositorys()
        {
            _scriptDataRepository = new ScriptDataRepository(_connectionString);
            _scriptRepository = new ScriptRepository(_connectionString);
            _blockRepository = new BlockRepository(_connectionString);
            _backgroundRepository = new BackgroundRepository(_connectionString);
            _objectRepository = new ObjectsRepository(_connectionString);
            _morphRepository = new MorphRepository(_connectionString);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDataGridViewScript();
        }

        private void FillDataGridViewScript()
        {
            dataGridViewScript.DataSource = _scriptRepository.GetObjects();
            dataGridViewScript.Columns[0].Visible = false;
            dataGridViewScript.AutoSize = true;
            dataGridViewScript.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewScript.Columns[1].HeaderText = "Название";
            dataGridViewScript.Columns[2].HeaderText = "Описание";
        }
        private void FillDataGridViewBlock()
        {
            if (_currentWorkScript == null)
            {
                dataGridViewBlock.DataSource = _blockRepository.GetObjects();
            }
            else
            {
                var repo = new BlockRepository(_connectionString);
                dataGridViewBlock.DataSource = repo.GetObjects(_currentWorkScript.Id);
            }
            dataGridViewBlock.Columns[0].Visible = false;
            dataGridViewBlock.AutoSize = true;
            dataGridViewBlock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBlock.Columns[1].Visible = false;
            dataGridViewBlock.Columns[2].HeaderText = "Название";
            dataGridViewBlock.Columns[3].HeaderText = "Описание";
        }
        private void FillDataGridViewBackground()
        {
            dataGridViewBackground.DataSource = _backgroundRepository.GetObjects();
            dataGridViewBackground.Columns[0].Visible = false;
            dataGridViewBackground.AutoSize = true;
            dataGridViewBackground.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBackground.Columns[1].HeaderText = "Название";
            dataGridViewBackground.Columns[2].HeaderText = "Описание";
        }
        private void FillDataGridViewObjects()
        {
            dataGridViewObjects.DataSource = _objectRepository.GetObjects();
            dataGridViewObjects.Columns[0].Visible = false;
            dataGridViewObjects.AutoSize = true;
            dataGridViewObjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjects.Columns[1].HeaderText = "Название";
            dataGridViewObjects.Columns[2].HeaderText = "Составной";
        }


        private void buttonCreateScript_Click(object sender, EventArgs e)
        {
            if (textBoxNameScript.Text != "")
            {
                var script = new Script();

                script.Name = textBoxNameScript.Text;
                script.Description = textBoxDescriptionScript.Text;

                _scriptRepository.Create(script);
                FillDataGridViewScript();

                CleanScriptTextBoxes();
                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("Заполните поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreateBlock_Click(object sender, EventArgs e)
        {
            if (textBoxNameBlock.Text != "")
            {
                var block = new Block();

                block.IdScript = _currentWorkScript.Id;
                block.Name = textBoxNameBlock.Text;
                block.Description = textBoxDescriptionBlock.Text;

                _blockRepository.Create(block);
                FillDataGridViewBlock();

                CleanBlockTextBoxes();
                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("Заполните поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreateBackground_Click(object sender, EventArgs e)
        {
            if (textBoxNameBackground.Text != "")
            {
                var back = new Background();

                back.Name = textBoxNameBackground.Text;
                back.Description = textBoxDescriptionBackground.Text;

                _backgroundRepository.Create(back);
                FillDataGridViewBackground();

                CleanBackgroundTextBoxes();
                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("Заполните поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {
            if (textBoxNameBackground.Text != "")
            {
                var obj = new Objects();

                obj.Name = textBoxNameBackground.Text;
                obj.Morph = checkBoxIsMorph.Checked;

                _objectRepository.Create(obj);
                FillDataGridViewObjects();

                if(checkBoxIsMorph.Checked == true)
                {
                    int id;
                    var res= _objectRepository.GetObjects().LastOrDefault();
                    if (res != null)
                    {
                        id=res.Id;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка поиска id созданного объекта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CleanObjectsTextBoxes();
                        return;
                    }

                    if (dataGridViewRecipeToMorph.DataSource!=null)
                    {
                        foreach(var objInComposition in (List<Objects>)dataGridViewRecipeToMorph.DataSource)
                        {
                            Morph morph = new Morph();
                            morph.IdMorph = id;
                            morph.IdObjectInTheComposition = objInComposition.Id;
                        }
                    }

                }

                CleanObjectsTextBoxes();
                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("Заполните поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateMorphByObj()
        {

        }

        private void CleanScriptTextBoxes()
        {
            textBoxNameScript.Text = "";
            textBoxDescriptionScript.Text = "";
        }
        private void CleanBlockTextBoxes()
        {
            textBoxNameBlock.Text = "";
            textBoxDescriptionBlock.Text = "";
        }
        private void CleanBackgroundTextBoxes()
        {
            textBoxNameBackground.Text = "";
            textBoxDescriptionBackground.Text = "";
        }

        private void CleanObjectsTextBoxes()
        {
            textBoxNameObjects.Text = "";
            checkBoxIsMorph.Checked = false;
        }

        private void ChangeEnalableScriptButtons(bool isEnalable)
        {
            buttonApplyScript.Enabled = isEnalable;
            buttonCancelScript.Enabled = isEnalable;
        }
        private void ChangeEnalableBlockButtons(bool isEnalable)
        {
            buttonApplyBlock.Enabled = isEnalable;
            buttonCancelBlock.Enabled = isEnalable;
        }
        private void ChangeEnalableBackgroundButtons(bool isEnalable)
        {
            buttonApplyBackground.Enabled = isEnalable;
            buttonCancelBackground.Enabled = isEnalable;
        }


        private void buttonLoadScript_Click(object sender, EventArgs e)
        {
            if (dataGridViewScript.CurrentCell != null)
            {
                var row = dataGridViewScript.CurrentCell.OwningRow;
                if (row != null)
                {
                    _currentEditableScript = new();
                    _currentEditableScript.Id = (int)row.Cells[0].Value;
                    textBoxNameScript.Text = row.Cells[1].Value.ToString();
                    try
                    {
                        textBoxDescriptionScript.Text = row.Cells[2].Value.ToString();
                    }
                    catch { }
                    ChangeEnalableScriptButtons(true);
                }
            }
            else
            {
                MessageBox.Show("Выделите нужный сценарий.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonLoadBlock_Click(object sender, EventArgs e)
        {
            if (dataGridViewBlock.CurrentCell != null)
            {
                var row = dataGridViewBlock.CurrentCell.OwningRow;
                if (row != null)
                {
                    _currentEditableBlock = new();
                    _currentEditableBlock.Id = (int)row.Cells[0].Value;
                    textBoxNameBlock.Text = row.Cells[1].Value.ToString();
                    try
                    {
                        textBoxDescriptionScript.Text = row.Cells[2].Value.ToString();
                    }
                    catch { }
                    ChangeEnalableBlockButtons(true);
                }
            }
            else
            {
                MessageBox.Show("Выделите нужный блок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonLoadBackground_Click(object sender, EventArgs e)
        {
            if (dataGridViewBackground.CurrentCell != null)
            {
                var row = dataGridViewBackground.CurrentCell.OwningRow;
                if (row != null)
                {
                    _currentEditableBackground = new();
                    _currentEditableBackground.Id = (int)row.Cells[0].Value;
                    textBoxNameBackground.Text = row.Cells[1].Value.ToString();
                    try
                    {
                        textBoxDescriptionBackground.Text = row.Cells[2].Value.ToString();
                    }
                    catch { }
                    ChangeEnalableBackgroundButtons(true);
                }
            }
            else
            {
                MessageBox.Show("Выделите нужный фон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonApplyScript_Click(object sender, EventArgs e)
        {
            if (_currentEditableScript != null)
            {
                if (textBoxNameScript.Text != "")
                {
                    _currentEditableScript.Name = textBoxNameScript.Text;
                    try
                    {
                        _currentEditableScript.Description = textBoxDescriptionScript.Text;
                    }
                    catch { }
                    _scriptRepository.Update(_currentEditableScript);

                    FillDataGridViewScript();
                    _currentEditableScript = null;

                    CleanScriptTextBoxes();
                    ChangeEnalableScriptButtons(false);
                }
                else
                {
                    MessageBox.Show("Выделите нужный сценарий.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonApplyBlock_Click(object sender, EventArgs e)
        {
            if (_currentEditableBlock != null)
            {
                if (textBoxNameBlock.Text != "")
                {
                    _currentEditableBlock.Name = textBoxNameBlock.Text;
                    try
                    {
                        _currentEditableBlock.Description = textBoxDescriptionBlock.Text;
                    }
                    catch { }
                    _blockRepository.Update(_currentEditableBlock);

                    FillDataGridViewBlock();
                    _currentEditableScript = null;

                    CleanBlockTextBoxes();
                    ChangeEnalableBlockButtons(false);
                }
                else
                {
                    MessageBox.Show("Выделите нужный блок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonApplyBackground_Click(object sender, EventArgs e)
        {
            if (_currentEditableBackground != null)
            {
                if (textBoxNameBackground.Text != "")
                {
                    _currentEditableBackground.Name = textBoxNameBackground.Text;
                    try
                    {
                        _currentEditableBackground.Description = textBoxDescriptionBackground.Text;
                    }
                    catch { }
                    _backgroundRepository.Update(_currentEditableBackground);

                    FillDataGridViewBackground();
                    _currentEditableBackground = null;

                    CleanBackgroundTextBoxes();
                    ChangeEnalableBackgroundButtons(false);
                }
                else
                {
                    MessageBox.Show("Выделите нужный фон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonCanselScript_Click(object sender, EventArgs e)
        {
            _currentEditableScript = null;
            CleanScriptTextBoxes();
            ChangeEnalableScriptButtons(false);
        }
        private void buttonCanselBlock_Click(object sender, EventArgs e)
        {
            _currentEditableBlock = null;
            CleanBlockTextBoxes();
            ChangeEnalableBlockButtons(false);
        }
        private void buttonCanselBackground_Click(object sender, EventArgs e)
        {
            _currentEditableBackground = null;
            CleanBackgroundTextBoxes();
            ChangeEnalableBackgroundButtons(false);
        }


        private void buttonDeleteScript_Click(object sender, EventArgs e)
        {
            if (dataGridViewScript.CurrentCell != null)
            {
                var row = dataGridViewScript.CurrentCell.OwningRow;
                _scriptRepository.Delete(Convert.ToInt32(row.Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Выделите нужный сценарий.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewScript();
        }
        private void buttonDeleteBlock_Click(object sender, EventArgs e)
        {
            if (dataGridViewBlock.CurrentCell != null)
            {
                var row = dataGridViewBlock.CurrentCell.OwningRow;
                _blockRepository.Delete(Convert.ToInt32(row.Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Выделите нужный блок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewBlock();
        }
        private void buttonDeleteBackground_Click(object sender, EventArgs e)
        {
            if (dataGridViewBackground.CurrentCell != null)
            {
                var row = dataGridViewBackground.CurrentCell.OwningRow;
                _backgroundRepository.Delete(Convert.ToInt32(row.Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Выделите нужный фон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewBackground();
        }


        private void buttonChoseScript_Click(object sender, EventArgs e)
        {

            if (dataGridViewScript.CurrentCell != null)
            {
                var row = dataGridViewScript.CurrentCell.OwningRow;
                _currentWorkScript = new();
                _currentWorkScript.Id = (int)row.Cells[0].Value;
                _currentWorkScript.Name = row.Cells[1].Value.ToString();
                _currentWorkScript.Description = row.Cells[2].Value.ToString();

                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("Выделите нужный сценарий.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonChoseBlock_Click(object sender, EventArgs e)
        {

            if (dataGridViewBlock.CurrentCell != null)
            {
                var row = dataGridViewBlock.CurrentCell.OwningRow;
                _currentWorkBlock = new();
                _currentWorkBlock.Id = (int)row.Cells[0].Value;
                _currentWorkBlock.Name = row.Cells[2].Value.ToString();
                _currentWorkBlock.Description = row.Cells[3].Value.ToString();

                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("Выделите нужный блок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonChoseBackground_Click(object sender, EventArgs e)
        {

            if (dataGridViewBackground.CurrentCell != null)
            {
                var row = dataGridViewBackground.CurrentCell.OwningRow;
                _currentWorkBackground = new();
                _currentWorkBackground.Id = (int)row.Cells[0].Value;
                _currentWorkBackground.Name = row.Cells[1].Value.ToString();
                _currentWorkBackground.Description = row.Cells[2].Value.ToString();

                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("Выделите нужный фон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBoxSearchBackground_TextChanged(object sender, EventArgs e)
        {

            if (dataGridViewBackground.DataSource != null && textBoxSearchBackground.Text != "")
            {
                List<Background> tempList = (List<Background>)dataGridViewBackground.DataSource;


                List<Background> result = (from row in tempList
                                           where row.Name.Contains(textBoxSearchBackground.Text)
                                           select row).ToList();

                List<Background> newList = new List<Background>();
                newList.AddRange(result);

                dataGridViewBackground.DataSource = newList;

                return;
            }

            dataGridViewBackground.DataSource = _backgroundRepository.GetObjects();

        }

        private void checkBoxIsMorph_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSearchMorph.Enabled = checkBoxIsMorph.Checked;
            dataGridViewObjects.Enabled = checkBoxIsMorph.Checked;
            buttonAddToMorph.Enabled = checkBoxIsMorph.Checked;
            buttonDefineFromMorph.Enabled = checkBoxIsMorph.Checked;
            dataGridViewRecipeToMorph.Enabled = checkBoxIsMorph.Checked;
        }

        private void ConfigureTreeView()
        {
            if (_currentWorkScript.Name != null)
            {
                treeViewMainForm.Nodes.Clear();

                TreeNode scriptNode = new TreeNode(_currentWorkScript.Name);

                var repo = new BlockRepository(_connectionString);
                List<Block> listOfBlocksByScript = repo.GetObjects(_currentWorkScript.Id);
                if (listOfBlocksByScript.Count != 0)
                {
                    foreach (var block in listOfBlocksByScript)
                    {
                        if (_currentWorkBlock != null && block.Name == _currentWorkBlock.Name)
                        {
                            TreeNode currentBlock = new TreeNode(block.Name);
                            currentBlock.BackColor = Color.LightGreen;
                            scriptNode.Nodes.Add(currentBlock);
                        }
                        else
                        {
                            scriptNode.Nodes.Add(block.Name);
                        }
                    }

                }

                treeViewMainForm.Nodes.Add(scriptNode);
            }
        }

        private void tabControlScenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexSelectedTab = tabControlScenario.SelectedIndex;

            switch (indexSelectedTab)
            {
                default:
                    FillDataGridViewScript();
                    break;
                case 1:
                    FillDataGridViewBlock();
                    break;
                case 2:
                    FillDataGridViewBackground();
                    break;
                case 3:
                    FillDataGridViewObjects();
                    break;
            }

        }


    }
}
