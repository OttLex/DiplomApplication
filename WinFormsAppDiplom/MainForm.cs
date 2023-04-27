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
using Service;
using DataAccessLayer.DTO;

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

        private Objects _currentEditableObjects;
        private List<Morph> _currentEditableMorph;




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
            FillDataGridViewScript();
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
            dataGridViewScript.Columns["Id"].Visible = false;
            dataGridViewScript.AutoSize = true;
            dataGridViewScript.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewScript.Columns["Name"].HeaderText = "Название";
            dataGridViewScript.Columns["Name"].DisplayIndex=1;
            dataGridViewScript.Columns["Description"].HeaderText = "Описание";
            dataGridViewScript.Columns["Description"].DisplayIndex=2;
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
            dataGridViewBlock.Columns["Id"].Visible = false;
            dataGridViewBlock.Columns["Name"].HeaderText = "Название";
            dataGridViewBlock.Columns["Name"].DisplayIndex = 1;
            dataGridViewBlock.Columns["Description"].HeaderText = "Описание";
            dataGridViewBlock.Columns["Description"].DisplayIndex = 2;
        }
        private void FillDataGridViewBackground()
        {
            dataGridViewBackground.DataSource = _backgroundRepository.GetObjects();
            dataGridViewBackground.Columns["Id"].Visible = false;
            dataGridViewBackground.AutoSize = true;
            dataGridViewBackground.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBackground.Columns["Name"].HeaderText = "Название";
            dataGridViewBackground.Columns["Name"].DisplayIndex = 1;
            dataGridViewBackground.Columns["Description"].HeaderText = "Описание";
            dataGridViewBackground.Columns["Description"].DisplayIndex = 2 ;
        }
        private void FillDataGridViewObjects()
        {
            dataGridViewObjects.DataSource = _objectRepository.GetObjects();
            dataGridViewObjects.Columns["Id"].Visible = false;
            dataGridViewObjects.AutoSize = true;
            dataGridViewObjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjects.Columns["Name"].HeaderText = "Название";
            dataGridViewObjects.Columns["Name"].DisplayIndex = 1;
            dataGridViewObjects.Columns["Morph"].HeaderText = "Составной";
            dataGridViewObjects.Columns["Morph"].DisplayIndex = 2;
        }
        private void FillDataGridViewRecipeToMorph(int id = -1)
        {
            if (id == -1)
            {
                List<Morph> morphs = _morphRepository.GetObjects();
                List<Objects> objects=_objectRepository.GetObjects();

                List<MorphDTO> dtos = morphs.Join(objects, m => m.IdMorph, obj => obj.Id, (m, obj) => new MorphDTO
                {
                    Id = obj.Id,
                    IdMorph = m.IdMorph,
                    NameMorph = obj.Name,
                    IdObjectInTheComposition= m.IdObjectInTheComposition,
                    NameObjectInTheComposition = obj.Name,
                }).ToList();

                dataGridViewRecipeToMorph.DataSource = dtos;
            }
            else
            {
                MorphRepository repo = new MorphRepository(_connectionString);
                List<Morph> morphs = repo.GetObjects(id);
                List<Objects> objects = _objectRepository.GetObjects();

                List<MorphDTO> dtos = morphs.Join(objects, m => m.IdMorph, obj => obj.Id, (m, obj) => new MorphDTO
                {
                    Id = obj.Id,
                    IdMorph = m.IdMorph,
                    NameMorph = obj.Name,
                    IdObjectInTheComposition = m.IdObjectInTheComposition,
                    NameObjectInTheComposition = objects.Where(o=> o.Id==m.IdObjectInTheComposition).First().Name
                }).ToList();

                dataGridViewRecipeToMorph.DataSource = dtos;
            }

            dataGridViewRecipeToMorph.Columns["Id"].Visible = false;
            dataGridViewRecipeToMorph.Columns["IdMorph"].Visible = false;
            dataGridViewRecipeToMorph.Columns["IdObjectInTheComposition"].Visible = false;
            dataGridViewRecipeToMorph.AutoSize = true;
            dataGridViewRecipeToMorph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecipeToMorph.Columns["NameMorph"].HeaderText = "Название";
            dataGridViewRecipeToMorph.Columns["NameMorph"].DisplayIndex = 1;
            dataGridViewRecipeToMorph.Columns["NameObjectInTheComposition"].HeaderText = "Состав";
            dataGridViewRecipeToMorph.Columns["NameObjectInTheComposition"].DisplayIndex = 2;

        }
        private void FillDataGridViewObjToMorph()
        {
            dataGridViewObjToMorph.DataSource = _objectRepository.GetObjects();
            dataGridViewObjToMorph.Columns["Id"].HeaderText = "Id";
            dataGridViewObjToMorph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjToMorph.Columns["Name"].HeaderText = "Название";
            dataGridViewObjToMorph.Columns["Morph"].Visible = false;
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
            }
            else
            {
                MessageBox.Show("Заполните поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreateBlock_Click(object sender, EventArgs e)
        {
            if (_currentWorkScript != null)
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
            else
            {
                MessageBox.Show("Выберете сценрий в который создать блок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
            else
            {
                MessageBox.Show("Заполните поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreateObject_Click(object sender, EventArgs e)
        {
            if (textBoxNameObjects.Text != "")
            {
                if (checkBoxIsMorph.Checked == false)
                {
                    ConfigureObject();
                    FillDataGridViewObjects();
                }
                else
                {
                    ConfigureObject();
                    ConfigureMorph();
                    FillDataGridViewObjects();
                    CleanMorphTextBoxes();
                }

                CleanObjectsTextBoxes();
            }
            else
            {
                MessageBox.Show("Заполните поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigureObject()
        {
            var obj = new Objects();

            obj.Name = textBoxNameObjects.Text;
            obj.Morph = checkBoxIsMorph.Checked;

            _objectRepository.Create(obj);
        }
        private void ConfigureMorph()
        {
            int id;
            var res = _objectRepository.GetObjects().LastOrDefault();
            if (res != null)
            {
                id = res.Id;
            }
            else
            {
                MessageBox.Show("Ошибка поиска id созданного объекта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CleanObjectsTextBoxes();
                return;
            }

            if (dataGridViewRecipeToMorph.DataSource != null)
            {
                List<Morph> actualRecipe = (List<Morph>)dataGridViewRecipeToMorph.DataSource;
                // actualRecipe = actualRecipe.Where(x => x.IdMorph == id).ToList(); строчка для редактирования


                foreach (var objInComposition in actualRecipe)
                {
                    Morph morph = new Morph();
                    morph.IdMorph = id;
                    morph.IdObjectInTheComposition = objInComposition.IdObjectInTheComposition;
                    _morphRepository.Create(morph);
                }
            }
            else
            {
                MessageBox.Show("Рецепты не обнаружены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CleanObjectsTextBoxes();
                return;
            }
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
        private void CleanMorphTextBoxes()
        {
            textBoxNameObjects.Text = "";
            checkBoxIsMorph.Checked = false;
            dataGridViewObjToMorph.DataSource = null;
            dataGridViewRecipeToMorph.DataSource = null;
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
        private void ChangeEnalableObjectsButtons(bool isEnalable)
        {
            buttonApplyObjects.Enabled = isEnalable;
            buttonCancelObjects.Enabled = isEnalable;
        }
        private void ChangeEnalableMorphButtons(bool isEnalable)
        {
            textBoxSearchMorph.Enabled = isEnalable;

            dataGridViewObjToMorph.Enabled = isEnalable;
            buttonAddToMorph.Enabled = isEnalable;
            buttonDefineFromMorph.Enabled = isEnalable;
            dataGridViewRecipeToMorph.Enabled = isEnalable;
        }


        private void buttonLoadScript_Click(object sender, EventArgs e)
        {
            if (dataGridViewScript.CurrentCell != null)
            {
                var row = dataGridViewScript.CurrentCell.OwningRow;
                if (row != null)
                {
                    _currentEditableScript = new();
                    _currentEditableScript.Id = (int)row.Cells["Id"].Value;
                    textBoxNameScript.Text = row.Cells["Name"].Value.ToString();
                    try
                    {
                        textBoxDescriptionScript.Text = row.Cells["Description"].Value.ToString();
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
                    _currentEditableBlock.Id = (int)row.Cells["Id"].Value;
                    textBoxNameBlock.Text = row.Cells["Name"].Value.ToString();
                    try
                    {
                        textBoxDescriptionScript.Text = row.Cells["Description"].Value.ToString();
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
        private void buttonLoadObjects_Click(object sender, EventArgs e)
        {
            if (dataGridViewObjects.CurrentCell != null)
            {
                var row = dataGridViewObjects.CurrentCell.OwningRow;
                if (row != null)
                {
                    _currentEditableObjects = new();
                    _currentEditableObjects.Id = (int)row.Cells["Id"].Value;
                    textBoxNameObjects.Text = row.Cells["Name"].Value.ToString();
                    checkBoxIsMorph.Checked = (bool)row.Cells["Morph"].Value;

                    ChangeEnalableObjectsButtons(true);

                    if (checkBoxIsMorph.Checked)
                    {
                        FillDataGridViewObjToMorph();
                        FillDataGridViewRecipeToMorph(_currentEditableObjects.Id);
                        ChangeEnalableMorphButtons(checkBoxIsMorph.Checked);
                        if (dataGridViewRecipeToMorph.DataSource != null)
                        {
                            _currentEditableMorph = (List<Morph>)dataGridViewRecipeToMorph.DataSource;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выделите нужный объект.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void buttonApplyObjects_Click(object sender, EventArgs e)
        {
            if (checkBoxIsMorph.Checked == true && dataGridViewRecipeToMorph.DataSource == null)
            {
                MessageBox.Show("Рецепт не заполнен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentEditableObjects != null)
            {
                if (textBoxNameObjects.Text != "")
                {
                    _currentEditableObjects.Name = textBoxNameObjects.Text;
                    _currentEditableObjects.Morph = checkBoxIsMorph.Checked;

                    _objectRepository.Update(_currentEditableObjects);

                    if (checkBoxIsMorph.Checked)
                    {
                        foreach (var obj in _currentEditableMorph)
                        {
                            _morphRepository.Update(obj);
                        }
                    }

                    FillDataGridViewObjects();
                    _currentEditableObjects = null;
                    _currentEditableMorph = null;

                    CleanObjectsTextBoxes();
                    CleanMorphTextBoxes();
                    ChangeEnalableObjectsButtons(false);
                    ChangeEnalableMorphButtons(false);
                }
                else
                {
                    MessageBox.Show("Параметры заполненны не верно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonCancelScript_Click(object sender, EventArgs e)
        {
            _currentEditableScript = null;
            CleanScriptTextBoxes();
            ChangeEnalableScriptButtons(false);
        }
        private void buttonCancelBlock_Click(object sender, EventArgs e)
        {
            _currentEditableBlock = null;
            CleanBlockTextBoxes();
            ChangeEnalableBlockButtons(false);
        }
        private void buttonCancelBackground_Click(object sender, EventArgs e)
        {
            _currentEditableBackground = null;
            CleanBackgroundTextBoxes();
            ChangeEnalableBackgroundButtons(false);
        }
        private void buttonCancelObjects_Click(object sender, EventArgs e)
        {
            _currentEditableObjects = null;
            _currentEditableMorph = null;

            CleanObjectsTextBoxes();
            CleanMorphTextBoxes();
            ChangeEnalableObjectsButtons(false);
            ChangeEnalableMorphButtons(false);
        }


        private void buttonDeleteScript_Click(object sender, EventArgs e)
        {
            if (dataGridViewScript.CurrentCell != null)
            {
                var row = dataGridViewScript.CurrentCell.OwningRow;
                _scriptRepository.Delete(Convert.ToInt32(row.Cells["Id"].Value));
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
        private void buttonDeleteObjects_Click(object sender, EventArgs e)
        {
            if (dataGridViewObjects.CurrentCell != null)
            {
                var row = dataGridViewObjects.CurrentCell.OwningRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                Objects obj= _objectRepository.GetObject(id);
                if (obj.Morph == true)
                {
                    MorphRepository repo = new MorphRepository(_connectionString);
                    repo.DeleteByIdMorph(id);
                }
                _objectRepository.Delete(id);
            }
            else
            {
                MessageBox.Show("Выделите нужный предмет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewObjects();
        }


        private void buttonChoseScript_Click(object sender, EventArgs e)
        {

            if (dataGridViewScript.CurrentCell != null)
            {
                var row = dataGridViewScript.CurrentCell.OwningRow;
                _currentWorkScript = new();
                _currentWorkScript.Id = (int)row.Cells["Id"].Value;
                _currentWorkScript.Name = row.Cells["Name"].Value.ToString();
                try
                {
                    _currentWorkScript.Description = row.Cells["Description"].Value.ToString();
                }
                catch { }

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
        //private void buttonChoseBackground_Click(object sender, EventArgs e)
        //{

        //    if (dataGridViewBackground.CurrentCell != null)
        //    {
        //        var row = dataGridViewBackground.CurrentCell.OwningRow;
        //        _currentWorkBackground = new();
        //        _currentWorkBackground.Id = (int)row.Cells[0].Value;
        //        _currentWorkBackground.Name = row.Cells[1].Value.ToString();
        //        _currentWorkBackground.Description = row.Cells[2].Value.ToString();

        //        ConfigureTreeView();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Выделите нужный фон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}


        private void textBoxSearchScript_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewScript.DataSource != null && textBoxSearchScript.Text != "")
            {

                SearchByDataGridService<Script> searhObjects =
                        new SearchByDataGridService<Script>(
                                    (List<Script>)dataGridViewScript.DataSource,
                                                                        textBoxSearchScript.Text);
                dataGridViewScript.DataSource = searhObjects.Search();
                return;

            }

            dataGridViewScript.DataSource = _scriptRepository.GetObjects();
        }
        private void textBoxSearchBlock_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewBlock.DataSource != null && textBoxSearchBlock.Text != "")
            {

                SearchByDataGridService<Block> searhBlock =
                                        new SearchByDataGridService<Block>(
                                                    (List<Block>)dataGridViewBlock.DataSource,
                                                                                        textBoxSearchBlock.Text);
                dataGridViewBlock.DataSource = searhBlock.Search();
                return;
            }

            dataGridViewBlock.DataSource = _blockRepository.GetObjects();

        }
        private void textBoxSearchBackground_TextChanged(object sender, EventArgs e)
        {

            if (dataGridViewBackground.DataSource != null && textBoxSearchBackground.Text != "")
            {
                SearchByDataGridService<Background> searhBackgound= 
                                                        new SearchByDataGridService<Background>(
                                                                    (List<Background>)dataGridViewBackground.DataSource,
                                                                                                        textBoxSearchBackground.Text);
                dataGridViewBackground.DataSource = searhBackgound.Search();
                return;
            }

            dataGridViewBackground.DataSource = _backgroundRepository.GetObjects();

        }
        private void textBoxSearchObjects_TextChanged(object sender, EventArgs e)
        {

            if (dataGridViewObjects.DataSource != null && textBoxSearchObjects.Text != "")
            {

                SearchByDataGridService<Objects> searhObjects =
                                        new SearchByDataGridService<Objects>(
                                                    (List<Objects>)dataGridViewObjects.DataSource,
                                                                                        textBoxSearchObjects.Text);
                dataGridViewObjects.DataSource = searhObjects.Search();
                return;
            }

            dataGridViewObjects.DataSource = _objectRepository.GetObjects();

        }
        private void textBoxSearchMorph_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewObjToMorph.DataSource != null && textBoxSearchMorph.Text != "")
            {

                SearchByDataGridService<Objects> searhObjects =
                        new SearchByDataGridService<Objects>(
                                    (List<Objects>)dataGridViewObjToMorph.DataSource,
                                                                        textBoxSearchMorph.Text);
                dataGridViewObjToMorph.DataSource = searhObjects.Search();
                return;

            }

            dataGridViewObjToMorph.DataSource = _objectRepository.GetObjects();
        }



        private void buttonAddToMorph_Click(object sender, EventArgs e)
        {
            if (dataGridViewObjToMorph.CurrentCell != null)
            {
                var row = dataGridViewObjToMorph.CurrentCell.OwningRow;
                var morph = new Morph();
                int idForCurrentObj;

                if (_currentEditableObjects == null)
                {
                    try
                    {
                        idForCurrentObj = Convert.ToInt32(_objectRepository.GetObjects().Last().Id) + 1;

                    }
                    catch
                    {
                        idForCurrentObj = 1;

                    }
                }
                else
                {
                    idForCurrentObj = _currentEditableObjects.Id;
                }


                morph.IdMorph = idForCurrentObj;
                morph.IdObjectInTheComposition = Convert.ToInt32(row.Cells["Id"].Value);

                _currentEditableMorph.Add(morph);
                dataGridViewRecipeToMorph.DataSource = null;
                dataGridViewRecipeToMorph.DataSource = _currentEditableMorph;
            }
            else
            {
                MessageBox.Show("Выделите нужный предмет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonDefineFromMorph_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecipeToMorph.CurrentCell != null)
            {
                var row = dataGridViewRecipeToMorph.CurrentCell.OwningRow;
                Morph morphForRemoving = new();

                morphForRemoving.IdMorph = Convert.ToInt32(row.Cells[1].Value);
                morphForRemoving.IdObjectInTheComposition = Convert.ToInt32(row.Cells[2].Value);

                morphForRemoving= _currentEditableMorph.Where(m=>
                                                m.IdMorph==morphForRemoving.IdMorph &&
                                                m.IdObjectInTheComposition==morphForRemoving.IdObjectInTheComposition).First();
                _currentEditableMorph.Remove(morphForRemoving);

                dataGridViewRecipeToMorph.DataSource = null;
                dataGridViewRecipeToMorph.DataSource = _currentEditableMorph;
            }
        }

        private void checkBoxIsMorph_CheckedChanged(object sender, EventArgs e)
        {
            _currentEditableMorph = new();
            textBoxSearchMorph.Enabled = checkBoxIsMorph.Checked;
            buttonAddToMorph.Enabled = checkBoxIsMorph.Checked;
            buttonDefineFromMorph.Enabled = checkBoxIsMorph.Checked;
            dataGridViewRecipeToMorph.Enabled = checkBoxIsMorph.Checked;

            if (checkBoxIsMorph.Checked)
            {
                FillDataGridViewObjToMorph();
                ChangeEnalableMorphButtons(true);
            }
            else
            {
                dataGridViewObjToMorph.DataSource = null;
                ChangeEnalableMorphButtons(false);
            }
        }
        private void dataGridViewObjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewObjects.CurrentCell != null)
            {
                var row = dataGridViewObjects.CurrentCell.OwningRow;
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                FillDataGridViewRecipeToMorph(id);
            }
        }

        private void ConfigureTreeView()
        {
            try
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
            catch
            {
                MessageBox.Show("Ошибка построения древа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            treeViewMainForm.ExpandAll();
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
