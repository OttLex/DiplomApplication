using System.Data;
using Model.ModelsSpr;
using DataAccessLayer;
using Model.ModelRelations;
using DataAccessLayer.RepoRel;
using DataAccessLayer.RepoSpr;
using Model.ModelSpr;
using Service;
using Model.DTO;
using System.Collections.Generic;

namespace WinFormsAppDiplom
{
    public partial class MainForm : Form
    {
        private string _connectionString;
        private User _currentUser;

        private Script? _currentWorkScript;
        private Block? _currentWorkBlock;

        private Script? _currentEditableScript;

        private Block? _currentEditableBlock;

        private Background? _currentEditableBackground;

        private CastTypes? _currentEditableCastTypes;

        private Objects? _currentEditableObjects;
        private List<Morph>? _currentEditableMorph;

        private Activity? _currentEditableActivity;
        private List<ActivityType>? _activityTypesList;

        private ObjectCast? _objectCastCreatable;



        private IRepository<Script> _scriptRepository;
        private IRepository<Block> _blockRepository;
        private IRepository<Background> _backgroundRepository;
        private IRepository<CastTypes> _castTypesRepository;
        private IRepository<Objects> _objectRepository;
        private IRepository<Morph> _morphRepository;
        private IRepository<Activity> _activityRepository;
        private IRepository<ActivityType> _activityTypeRepository;
        private IRepository<ObjectCast> _objectCastRepository;


        public MainForm(string connString, User user)
        {
            InitializeComponent();

            _connectionString = connString;
            _currentUser = user;

            ConfigureAccessLevel();

            ConfigureRepositorys();
            FillDataGridViewScript();
        }

        private void ConfigureAccessLevel()
        {          
            bool canEdit= _currentUser.AccessLevelId == 1 ?  true: false;

            buttonCreateScript.Visible= canEdit;
            buttonDeleteScript.Visible= canEdit;
            buttonLoadScript.Visible = canEdit;
            buttonApplyScript.Visible= canEdit;
            buttonCancelScript.Visible = canEdit;

            buttonCreateBlock.Visible = canEdit;
            buttonDeleteBlock.Visible = canEdit;
            buttonLoadBlock.Visible = canEdit;
            buttonApplyBlock.Visible = canEdit;
            buttonCancelBlock.Visible = canEdit;

            buttonCreateBackground.Visible = canEdit;
            buttonDeleteBackground.Visible = canEdit;
            buttonLoadBackground.Visible = canEdit;
            buttonApplyBackground.Visible = canEdit;
            buttonCancelBackground.Visible = canEdit;

            buttonCreateCastTypes.Visible = canEdit;
            buttonDeleteCastTypes.Visible = canEdit;
            buttonLoadCastTypes.Visible = canEdit;
            buttonApplyCastTypes.Visible = canEdit;
            buttonCancelCastTypes.Visible = canEdit;

            buttonCreateObject.Visible = canEdit;
            buttonDeleteObjects.Visible = canEdit;
            buttonLoadObjects.Visible = canEdit;
            buttonApplyObjects.Visible = canEdit;
            buttonCancelObjects.Visible = canEdit;
            buttonAddToMorph.Visible = canEdit;
            buttonDefineFromMorph.Visible = canEdit;

            buttonCreateActivity.Visible = canEdit;
            buttonDeleteActivity.Visible = canEdit;
            buttonLoadActivity.Visible = canEdit;
            buttonApplyActivity.Visible = canEdit;
            buttonCancelActivity.Visible = canEdit;
            comboBoxActivity.Visible = canEdit;

            buttonCreateCast.Visible = canEdit;
            buttonDeleteCast.Visible = canEdit;
            buttonLoadCast.Visible = canEdit;
            buttonApplyCast.Visible = canEdit;
            buttonCancelCast.Visible = canEdit;

            buttonTestInventorySpendRecive.Visible = canEdit;
        }

        private void ConfigureRepositorys()
        {
            _scriptRepository = new ScriptRepository(_connectionString);
            _blockRepository = new BlockRepository(_connectionString);
            _backgroundRepository = new BackgroundRepository(_connectionString);
            _castTypesRepository = new CastTypesRepository(_connectionString);
            _objectRepository = new ObjectsRepository(_connectionString);
            _morphRepository = new MorphRepository(_connectionString);
            _activityRepository = new ActivityRepository(_connectionString);
            _activityTypeRepository = new ActivityTypeRepository(_connectionString);
            _objectCastRepository = new ObjectCastRepository(_connectionString);
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
            dataGridViewScript.Columns["Name"].HeaderText = "��������";
            dataGridViewScript.Columns["Name"].DisplayIndex = 1;
            dataGridViewScript.Columns["Description"].HeaderText = "��������";
            dataGridViewScript.Columns["Description"].DisplayIndex = 2;
        }
        private void FillDataGridViewBlock()
        {
            if (_currentWorkScript != null)
            {
                var repo = new BlockRepository(_connectionString);
                dataGridViewBlock.DataSource = repo.GetObjects(_currentWorkScript.Id);
                dataGridViewBlock.Columns[0].Visible = false;
                dataGridViewBlock.AutoSize = true;
                dataGridViewBlock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewBlock.Columns["Id"].Visible = false;
                dataGridViewBlock.Columns["Name"].HeaderText = "��������";
                dataGridViewBlock.Columns["Name"].DisplayIndex = 1;
                dataGridViewBlock.Columns["Description"].HeaderText = "��������";
                dataGridViewBlock.Columns["Description"].DisplayIndex = 2;
            }
        }
        private void FillDataGridViewBackground()
        {
            dataGridViewBackground.DataSource = _backgroundRepository.GetObjects();
            dataGridViewBackground.Columns["Id"].Visible = false;
            dataGridViewBackground.AutoSize = true;
            dataGridViewBackground.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBackground.Columns["Name"].HeaderText = "��������";
            dataGridViewBackground.Columns["Name"].DisplayIndex = 1;
            dataGridViewBackground.Columns["Description"].HeaderText = "��������";
            dataGridViewBackground.Columns["Description"].DisplayIndex = 2;
        }
        private void FillDataGridViewCastTypes()
        {
            dataGridViewCastTypes.DataSource = _castTypesRepository.GetObjects();
            dataGridViewCastTypes.Columns["Id"].Visible = false;
            dataGridViewCastTypes.AutoSize = true;
            dataGridViewCastTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCastTypes.Columns["Name"].HeaderText = "��������";
            dataGridViewCastTypes.Columns["Name"].DisplayIndex = 1;
        }
        private void FillDataGridViewObjects()
        {
            dataGridViewObjects.DataSource = _objectRepository.GetObjects();
            dataGridViewObjects.Columns["Id"].Visible = false;
            dataGridViewObjects.AutoSize = true;
            dataGridViewObjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjects.Columns["Name"].HeaderText = "��������";
            dataGridViewObjects.Columns["Name"].DisplayIndex = 1;
            dataGridViewObjects.Columns["Morph"].HeaderText = "���������";
            dataGridViewObjects.Columns["Morph"].DisplayIndex = 2;
        }
        private void FillDataGridViewRecipeToMorph(int id = -1)
        {
            List<Objects> objects = _objectRepository.GetObjects();

            if (id == -1)
            {
                List<Morph> morphs = _morphRepository.GetObjects();

                List<MorphDTO> dtos = morphs.Join(objects, m => m.IdMorph, obj => obj.Id, (m, obj) => new MorphDTO
                {
                    Id = obj.Id,
                    IdMorph = m.IdMorph,
                    NameMorph = obj.Name,
                    IdObjectInTheComposition = m.IdObjectInTheComposition,
                    NameObjectInTheComposition = obj.Name,
                }).ToList();

                dataGridViewRecipeToMorph.DataSource = dtos;
            }
            else
            {
                MorphRepository repo = new MorphRepository(_connectionString);
                List<Morph> morphs = repo.GetObjects(id);

                List<MorphDTO> dtos = morphs.Join(objects, m => m.IdMorph, obj => obj.Id, (m, obj) => new MorphDTO
                {
                    Id = obj.Id,
                    IdMorph = m.IdMorph,
                    NameMorph = obj.Name,
                    IdObjectInTheComposition = m.IdObjectInTheComposition,
                    NameObjectInTheComposition = objects.Where(o => o.Id == m.IdObjectInTheComposition).FirstOrDefault().Name
                }).ToList();

                dataGridViewRecipeToMorph.DataSource = dtos;
            }

            dataGridViewRecipeToMorph.Columns["Id"].Visible = false;
            dataGridViewRecipeToMorph.Columns["IdMorph"].Visible = false;
            dataGridViewRecipeToMorph.Columns["IdObjectInTheComposition"].Visible = false;
            //dataGridViewRecipeToMorph.AutoSize = true;
            dataGridViewRecipeToMorph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecipeToMorph.Columns["NameMorph"].HeaderText = "��������";
            dataGridViewRecipeToMorph.Columns["NameMorph"].DisplayIndex = 1;
            dataGridViewRecipeToMorph.Columns["NameObjectInTheComposition"].HeaderText = "������";
            dataGridViewRecipeToMorph.Columns["NameObjectInTheComposition"].DisplayIndex = 2;

        }
        private void FillDataGridViewObjToMorph()
        {
            dataGridViewObjToMorph.DataSource = _objectRepository.GetObjects();
            dataGridViewObjToMorph.Columns["Id"].HeaderText = "Id";
            dataGridViewObjToMorph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjToMorph.Columns["Name"].HeaderText = "��������";
            dataGridViewObjToMorph.Columns["Morph"].Visible = false;
        }
        private void FillDataGridViewActivity()
        {
            List<Activity> activities = _activityRepository.GetObjects();
            if (_activityTypesList == null)
            {
                _activityTypesList = _activityTypeRepository.GetObjects();
            }

            List<ActivityDTO> dtos = activities.Join(_activityTypesList, act => act.ActivityTypeId, actT => actT.Id, (act, actT) => new ActivityDTO
            {
                Id = act.Id,
                Name = act.Name,
                ActivityTypeId = act.ActivityTypeId,
                ActivityName = actT.Name,
                Description = act.Description,
            }).ToList();

            dataGridViewActivity.DataSource = dtos;

            dataGridViewActivity.Columns["ActivityTypeId"].Visible = false;
            dataGridViewActivity.Columns["Id"].Visible = false;
            dataGridViewActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewActivity.Columns["Name"].HeaderText = "��������";
            dataGridViewActivity.Columns["Name"].DisplayIndex = 1;
            dataGridViewActivity.Columns["ActivityName"].HeaderText = "��� ����������";
            dataGridViewActivity.Columns["Description"].HeaderText = "��������";
        }
        private void FillComboBoxActivity()
        {
            if (_activityTypesList == null)
            {
                _activityTypesList = _activityTypeRepository.GetObjects();
            }
            comboBoxActivity.DataSource = _activityTypesList;

            comboBoxActivity.DisplayMember = "Name";
            comboBoxActivity.ValueMember = "Id";
        }
        private void FillDataGridViewCast()
        {
            if (_currentWorkBlock != null)
            {
                _objectCastCreatable = new ObjectCast();
                _objectCastCreatable.IdBlock = _currentWorkBlock.Id;
            }
            else
            {
                MessageBox.Show("�������� ������ ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            List<ObjectCastDTO> currentCasts = new();
            List<ObjectCast> casts = _objectCastRepository.GetObjects();
            List<Block> blocks = _blockRepository.GetObjects();

            List<Background> backgrounds = (List<Background>)dataGridViewCastBackground.DataSource;
            List<ActivityDTO> activities = (List<ActivityDTO>)dataGridViewCastActivity.DataSource;
            List<CastTypes> castTypes = (List<CastTypes>)dataGridViewCastType.DataSource;
            List<Objects> objects = (List<Objects>)dataGridViewCastObjectRecive.DataSource;


            foreach (ObjectCast cast in casts)
            {
                ObjectCastDTO dto = new ObjectCastDTO();

                dto.Id = cast.Id;
                dto.IdBlock = cast.IdBlock;
                dto.NameBlock = blocks.Where(bl => bl.Id == cast.IdBlock).First().Name;

                dto.IdStep = cast.IdStep;
                dto.IdBackground = cast.IdBackground;

                dto.NameBackground = backgrounds.Where(bg => bg.Id == cast.IdBackground).FirstOrDefault().Name;

                dto.IdActivity = cast.IdActivity;
                dto.NameActivity = activities.Where(acts => acts.Id == cast.IdActivity).FirstOrDefault().Name;

                dto.IdCastType = cast.IdCastType;
                dto.NameCastType = castTypes.Where(ct => ct.Id == cast.IdCastType).FirstOrDefault().Name;

                dto.IdObjectSpent = cast.IdObjectSpent;
                dto.IdObjectRecive = cast.IdObjectRecive;

                dto.NameObjectSpent = objects.Where(o => o.Id == cast.IdObjectSpent).FirstOrDefault().Name;
                dto.NameObjectRecive = objects.Where(o => o.Id == cast.IdObjectRecive).FirstOrDefault().Name;

                dto.Description = cast.Description;

                currentCasts.Add(dto);
            }

            dataGridViewCast.DataSource = currentCasts;

            dataGridViewCast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCast.Columns["Id"].Visible = false;
            dataGridViewCast.Columns["IdBlock"].Visible = false;
            dataGridViewCast.Columns["IdBackground"].Visible = false;
            dataGridViewCast.Columns["IdActivity"].Visible = false;
            dataGridViewCast.Columns["IdCastType"].Visible = false;
            dataGridViewCast.Columns["IdObjectSpent"].Visible = false;
            dataGridViewCast.Columns["IdObjectRecive"].Visible = false;

            dataGridViewCast.Columns["NameBlock"].HeaderText = "����";
            dataGridViewCast.Columns["NameBlock"].DisplayIndex = 1;
            dataGridViewCast.Columns["IdStep"].HeaderText = "���";

            dataGridViewCast.Columns["NameBackground"].HeaderText = "���";
            dataGridViewCast.Columns["NameActivity"].HeaderText = "��� ����������";
            dataGridViewCast.Columns["NameCastType"].HeaderText = "��� ����������";

            dataGridViewCast.Columns["NameObjectSpent"].HeaderText = "�������������� ������";
            dataGridViewCast.Columns["NameObjectRecive"].HeaderText = "���������� ������";
            dataGridViewCast.Columns["Description"].HeaderText = "��������";

        }

        private void FillCastParamsViews()
        {
            FilldataGridViewCastBackground();
            FilldataGridViewCastType();
            FilldataGridViewCastObjectSpend();
            FilldataGridViewCastObjectRecive();
            FilldataGridViewCastActivity();
            FilldataGridViewObjectsInOperation();
        }
        private void FilldataGridViewCastBackground()
        {
            dataGridViewCastBackground.DataSource = _backgroundRepository.GetObjects();
            dataGridViewCastBackground.Columns["Id"].Visible = false;
            dataGridViewCastBackground.AutoSize = true;
            dataGridViewCastBackground.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCastBackground.Columns["Name"].HeaderText = "��������";
            dataGridViewCastBackground.Columns["Name"].DisplayIndex = 1;
            dataGridViewCastBackground.Columns["Description"].HeaderText = "��������";
            dataGridViewCastBackground.Columns["Description"].DisplayIndex = 2;
        }
        private void FilldataGridViewCastType()
        {
            dataGridViewCastType.DataSource = _castTypesRepository.GetObjects();
            dataGridViewCastType.Columns["Id"].Visible = false;
            dataGridViewCastType.AutoSize = true;
            dataGridViewCastType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCastType.Columns["Name"].HeaderText = "��������";
            dataGridViewCastType.Columns["Name"].DisplayIndex = 1;
        }
        private void FilldataGridViewCastObjectSpend()
        {
            dataGridViewCastObjectSpend.DataSource = _objectRepository.GetObjects();
            dataGridViewCastObjectSpend.AutoSize = true;
            dataGridViewCastObjectSpend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCastObjectSpend.Columns["Id"].Visible = false;
            dataGridViewCastObjectSpend.Columns["Name"].HeaderText = "��������";
            dataGridViewCastObjectSpend.Columns["Name"].DisplayIndex = 1;
            dataGridViewCastObjectSpend.Columns["Morph"].HeaderText = "���������";
            dataGridViewCastObjectSpend.Columns["Morph"].DisplayIndex = 2;
        }
        private void FilldataGridViewCastObjectRecive()
        {
            dataGridViewCastObjectRecive.DataSource = _objectRepository.GetObjects();
            dataGridViewCastObjectRecive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCastObjectRecive.Columns["Id"].Visible = false;
            dataGridViewCastObjectRecive.AutoSize = true;
            dataGridViewCastObjectRecive.Columns["Name"].HeaderText = "��������";
            dataGridViewCastObjectRecive.Columns["Name"].DisplayIndex = 1;
            dataGridViewCastObjectRecive.Columns["Morph"].HeaderText = "���������";
            dataGridViewCastObjectRecive.Columns["Morph"].DisplayIndex = 2;
        }
        private void FilldataGridViewCastActivity()
        {
            List<Activity> activities = _activityRepository.GetObjects();
            if (_activityTypesList == null)
            {
                _activityTypesList = _activityTypeRepository.GetObjects();
            }

            List<ActivityDTO> dtos = activities.Join(_activityTypesList, act => act.ActivityTypeId, actT => actT.Id, (act, actT) => new ActivityDTO
            {
                Id = act.Id,
                Name = act.Name,
                ActivityTypeId = act.ActivityTypeId,
                ActivityName = actT.Name,
                Description = act.Description,
            }).ToList();

            dataGridViewCastActivity.DataSource = dtos;

            dataGridViewCastActivity.Columns["ActivityTypeId"].Visible = false;
            dataGridViewCastActivity.Columns["Id"].Visible = false;
            dataGridViewCastActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCastActivity.Columns["Name"].HeaderText = "��������";
            dataGridViewCastActivity.Columns["Name"].DisplayIndex = 1;
            dataGridViewCastActivity.Columns["ActivityName"].HeaderText = "��� ����������";
            dataGridViewCastActivity.Columns["Description"].HeaderText = "��������";
        }
        private void FilldataGridViewObjectsInOperation()
        {
            dataGridViewCastObjectSpend.AutoSize = true;
            dataGridViewCastObjectSpend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCastObjectSpend.Columns["Id"].Visible = false;
            dataGridViewCastObjectSpend.Columns["Name"].HeaderText = "��������";
            dataGridViewCastObjectSpend.Columns["Name"].DisplayIndex = 1;
            dataGridViewCastObjectSpend.Columns["Morph"].HeaderText = "���������";
            dataGridViewCastObjectSpend.Columns["Morph"].DisplayIndex = 2;
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
                MessageBox.Show("��������� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("��������� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("�������� ������� � ������� ������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("��������� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreateCastTypes_Click(object sender, EventArgs e)
        {
            if (textBoxNameCastTypes.Text != "")
            {
                var castTypes = new CastTypes();

                castTypes.Name = textBoxNameCastTypes.Text;

                _castTypesRepository.Create(castTypes);
                FillDataGridViewCastTypes();

                CleanCastTypesTextBoxes();
            }
            else
            {
                MessageBox.Show("��������� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("��������� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreateActiivity_Click(object sender, EventArgs e)
        {
            if (textBoxNameActivity.Text != "" && comboBoxActivity.SelectedIndex != -1)
            {
                var activity = new Activity();

                activity.Name = textBoxNameActivity.Text;
                activity.Description = textBoxDescriptionActivity.Text;
                activity.ActivityTypeId = comboBoxActivity.SelectedIndex + 1;

                _activityRepository.Create(activity);
                FillDataGridViewActivity();

                CleanActivityTextBoxes();
            }
            else
            {
                MessageBox.Show("��������� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreateCast_Click(object sender, EventArgs e)
        {
            if (_objectCastCreatable != null && _currentWorkBlock != null
                && _objectCastCreatable.IdBackground != null)
            {

                List<ObjectCast> objectCasts = _objectCastRepository.GetObjects();

                if (objectCasts.Count > 0)
                {
                    _objectCastCreatable.IdStep = _objectCastRepository.GetObjects()
                        .Where(obj => obj.IdBlock == _objectCastCreatable.IdBlock)
                        .Select(o => o.IdStep)
                        .Max()+1;
                       
                }
                else
                {
                    _objectCastCreatable.IdStep = 1;
                }

                _objectCastRepository.Create(_objectCastCreatable);

                _objectCastCreatable = new();
                _objectCastCreatable.IdBlock = _currentWorkBlock.Id;

                FillDataGridViewCast();
                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("�������� ���� ��� �������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("������ ������ id ���������� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CleanObjectsTextBoxes();
                return;
            }

            if (dataGridViewRecipeToMorph.DataSource != null)
            {
                //var MorphDto = _currentEditableMorph.Join(objects, m => m.IdObjectInTheComposition, o => o.Id, (m, o) => new
                //{
                //    idObj = m.IdMorph,
                //    nameObj = textBoxNameObjects.Text,
                //    idObjInConposition = m.IdObjectInTheComposition,
                //    nameMorph = o.Name
                //}).ToList();

                List<MorphDTO> MorphDto= (List<MorphDTO>)dataGridViewRecipeToMorph.DataSource;


                foreach (var objInComposition in MorphDto)
                {
                    Morph morph = new Morph();
                    morph.IdMorph = id;
                    morph.IdObjectInTheComposition = objInComposition.IdObjectInTheComposition;
                    _morphRepository.Create(morph);
                }
            }
            else
            {
                MessageBox.Show("������� �� ����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void CleanCastTypesTextBoxes()
        {
            textBoxNameCastTypes.Text = "";
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
        private void CleanActivityTextBoxes()
        {
            textBoxNameActivity.Text = "";
            textBoxDescriptionActivity.Text = "";
            comboBoxActivity.SelectedIndex = -1;
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
        private void ChangeEnalableCastTypesButtons(bool isEnalable)
        {
            buttonApplyCastTypes.Enabled = isEnalable;
            buttonCancelCastTypes.Enabled = isEnalable;
        }
        private void ChangeEnalableObjectsButtons(bool isEnalable)
        {
            buttonApplyObjects.Enabled = isEnalable;
            buttonCancelObjects.Enabled = isEnalable;
            dataGridViewRecipeToMorph.Enabled = isEnalable;
        }
        private void ChangeEnalableMorphButtons(bool isEnalable)
        {
            textBoxSearchMorph.Enabled = isEnalable;

            dataGridViewObjToMorph.Enabled = isEnalable;
            buttonAddToMorph.Enabled = isEnalable;
            buttonDefineFromMorph.Enabled = isEnalable;
            dataGridViewRecipeToMorph.Enabled = isEnalable;
        }
        private void ChangeEnalableActivityButtons(bool isEnalable)
        {
            buttonApplyActivity.Enabled = isEnalable;
            buttonCancelActivity.Enabled = isEnalable;
        }
        private void ChangeEnalableObjectCastButtons(bool isEnalable)
        {
            buttonApplyCast.Enabled = isEnalable;
            buttonCancelCast.Enabled = isEnalable;
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
                MessageBox.Show("�������� ������ ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        textBoxDescriptionBlock.Text = row.Cells["Description"].Value.ToString();
                    }
                    catch { }
                    ChangeEnalableBlockButtons(true);
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    _currentEditableBackground.Id = (int)row.Cells["Id"].Value;
                    textBoxNameBackground.Text = row.Cells["Name"].Value.ToString();
                    try
                    {
                        textBoxDescriptionBackground.Text = row.Cells["Description"].Value.ToString();
                    }
                    catch { }
                    ChangeEnalableBackgroundButtons(true);
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ���.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonLoadCastTypes_Click(object sender, EventArgs e)
        {
            if (dataGridViewCastTypes.CurrentCell != null)
            {
                var row = dataGridViewCastTypes.CurrentCell.OwningRow;
                if (row != null)
                {
                    _currentEditableCastTypes = new();
                    _currentEditableCastTypes.Id = (int)row.Cells["Id"].Value;
                    textBoxNameCastTypes.Text = row.Cells["Name"].Value.ToString();

                    ChangeEnalableCastTypesButtons(true);
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ��� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            var morphDTOs = (List<MorphDTO>)dataGridViewRecipeToMorph.DataSource;
                            foreach (var dto in morphDTOs)
                            {
                                Morph morph = new Morph();
                                morph.Id = dto.Id;
                                morph.IdMorph= dto.IdMorph;
                                morph.IdObjectInTheComposition = dto.IdObjectInTheComposition;

                                if (_currentEditableMorph == null)
                                {
                                    _currentEditableMorph= new List<Morph>();
                                }
                                _currentEditableMorph.Add(morph);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonLoadActivity_Click(object sender, EventArgs e)
        {
            if (dataGridViewActivity.CurrentCell != null)
            {
                var row = dataGridViewActivity.CurrentCell.OwningRow;
                if (row != null)
                {
                    _currentEditableActivity = new();
                    _currentEditableActivity.Id = (int)row.Cells["Id"].Value;
                    textBoxNameActivity.Text = row.Cells["Name"].Value.ToString();

                    if (_activityTypesList == null)
                    {
                        _activityTypesList = _activityTypeRepository.GetObjects();
                    }

                    var currentType = _activityTypesList.Where(at => at.Id == Convert.ToInt32(row.Cells["ActivityTypeId"].Value)).First();
                    comboBoxActivity.SelectedIndex = currentType.Id - 1;
                    try
                    {
                        textBoxDescriptionActivity.Text = row.Cells["Description"].Value.ToString();
                    }
                    catch { }
                    ChangeEnalableActivityButtons(true);
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonLoadCast_Click(object sender, EventArgs e)
        {
            if (dataGridViewCast.CurrentCell != null)
            {
                var row = dataGridViewCast.CurrentCell.OwningRow;
                if (row != null)
                {
                    _objectCastCreatable = new();
                    _objectCastCreatable.Id = (int)row.Cells["Id"].Value;

                    _objectCastCreatable.IdBlock = (int)row.Cells["IdBlock"].Value;
                    _objectCastCreatable.IdStep = (int)row.Cells["IdStep"].Value;
                    _objectCastCreatable.IdBackground = (int)row.Cells["IdBackground"].Value;

                    try
                    {
                        _objectCastCreatable.IdActivity = (int)row.Cells["IdActivity"].Value;
                    }
                    catch { }

                    try
                    {
                    _objectCastCreatable.IdCastType = (int)row.Cells["IdCastType"].Value;
                    }
                    catch { }

                    try
                    {
                        _objectCastCreatable.IdObjectRecive = (int)row.Cells["IdObjectRecive"].Value;
                    }
                    catch { }

                    try
                    {
                        _objectCastCreatable.IdObjectSpent = (int)row.Cells["IdObjectSpent"].Value;
                    }
                    catch { }

                    try
                    {
                        _objectCastCreatable.Description = row.Cells["Description"].Value.ToString();
                    }
                    catch
                    {

                    }



                    labelCastBackgroundValue.Text = row.Cells["NameBlock"].Value.ToString();
                    labelCastCastTypeValue.Text = row.Cells["NameCastType"].Value.ToString();
                    labelObjectToSpendValue.Text = row.Cells["NameObjectSpent"].Value.ToString();
                    labelObjectToReciveValue.Text = row.Cells["NameObjectRecive"].Value.ToString();
                    labelCastActivityValue.Text = row.Cells["NameActivity"].Value.ToString();

                    if (_objectCastCreatable.Description.Length > 0)
                    {
                        checkBoxCastDescription.Checked = true;
                    }
                    else
                    {
                        checkBoxCastDescription.Checked = false;
                    }
                    ChangeEnalableObjectCastButtons(true);
                }
                else
                {
                    MessageBox.Show("�������� ������ ���.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                    catch
                    {
                        _currentEditableScript.Description = "";
                    }
                    _scriptRepository.Update(_currentEditableScript);

                    FillDataGridViewScript();
                    _currentEditableScript = null;

                    CleanScriptTextBoxes();
                    ChangeEnalableScriptButtons(false);
                }
                else
                {
                    MessageBox.Show("������� ���������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonApplyBlock_Click(object sender, EventArgs e)
        {
            if (_currentEditableBlock != null && _currentWorkScript != null)
            {
                if (textBoxNameBlock.Text != "")
                {
                    _currentEditableBlock.Name = textBoxNameBlock.Text;
                    _currentEditableBlock.IdScript = _currentWorkScript.Id;
                    try
                    {
                        _currentEditableBlock.Description = textBoxDescriptionBlock.Text;
                    }
                    catch
                    {
                        _currentEditableBlock.Description = "";
                    }
                    _blockRepository.Update(_currentEditableBlock);

                    FillDataGridViewBlock();
                    _currentEditableScript = null;

                    CleanBlockTextBoxes();
                    ChangeEnalableBlockButtons(false);
                }
                else
                {
                    MessageBox.Show("������� ���������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("������� ���������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonApplyCastTypes_Click(object sender, EventArgs e)
        {
            if (_currentEditableCastTypes != null)
            {
                if (textBoxNameCastTypes.Text != "")
                {
                    _currentEditableCastTypes.Name = textBoxNameCastTypes.Text;

                    _castTypesRepository.Update(_currentEditableCastTypes);

                    FillDataGridViewCastTypes();
                    _currentEditableCastTypes = null;

                    CleanCastTypesTextBoxes();
                    ChangeEnalableCastTypesButtons(false);
                }
                else
                {
                    MessageBox.Show("������� ���������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonApplyObjects_Click(object sender, EventArgs e)
        {
            if (checkBoxIsMorph.Checked == true && dataGridViewRecipeToMorph.DataSource == null)
            {
                MessageBox.Show("������ �� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentEditableObjects != null && _currentEditableMorph != null)
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
                    MessageBox.Show("������� ���������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonApplyActivity_Click(object sender, EventArgs e)
        {
            if (_currentEditableActivity != null)
            {
                if (textBoxNameActivity.Text != "")
                {
                    _currentEditableActivity.Name = textBoxNameActivity.Text;
                    _currentEditableActivity.ActivityTypeId = comboBoxActivity.SelectedIndex + 1;
                    try
                    {
                        _currentEditableActivity.Description = textBoxDescriptionActivity.Text;
                    }
                    catch { }
                    _activityRepository.Update(_currentEditableActivity);

                    FillDataGridViewActivity();
                    _currentEditableActivity = null;

                    CleanActivityTextBoxes();
                    ChangeEnalableActivityButtons(false);
                }
                else
                {
                    MessageBox.Show("������� ���������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonApplyCast_Click(object sender, EventArgs e)
        {
            if (_objectCastCreatable != null && _currentWorkBlock != null)
            {
                _objectCastRepository.Update(_objectCastCreatable);

                _objectCastCreatable = new();
                _objectCastCreatable.IdBlock = _currentWorkBlock.Id;

                FillDataGridViewCast();
                ChangeEnalableObjectCastButtons(false);
            }
            else
            {
                MessageBox.Show("�������� ���� ��� �������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void buttonCancelCastTypes_Click(object sender, EventArgs e)
        {
            _currentEditableCastTypes = null;
            CleanCastTypesTextBoxes();
            ChangeEnalableCastTypesButtons(false);
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
        private void buttonCancelActivity_Click(object sender, EventArgs e)
        {
            _currentEditableActivity = null;
            CleanActivityTextBoxes();
            ChangeEnalableActivityButtons(false);
        }
        private void buttonCancelCast_Click(object sender, EventArgs e)
        {
            ResetObjectCast();
            ChangeEnalableObjectCastButtons(false);
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
                MessageBox.Show("�������� ������ ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("�������� ������ ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewBlock();
            ConfigureTreeView();
        }
        private void buttonDeleteBackground_Click(object sender, EventArgs e)
        {
            if (dataGridViewBackground.CurrentCell != null)
            {
                var row = dataGridViewBackground.CurrentCell.OwningRow;
                _backgroundRepository.Delete(Convert.ToInt32(row.Cells["Id"].Value));
            }
            else
            {
                MessageBox.Show("�������� ������ ���.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewBackground();
        }
        private void buttonDeleteCastTypes_Click(object sender, EventArgs e)
        {
            if (dataGridViewCastTypes.CurrentCell != null)
            {
                var row = dataGridViewCastTypes.CurrentCell.OwningRow;
                _castTypesRepository.Delete(Convert.ToInt32(row.Cells["Id"].Value));
            }
            else
            {
                MessageBox.Show("�������� ������ ��� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewCastTypes();
        }
        private void buttonDeleteObjects_Click(object sender, EventArgs e)
        {
            if (dataGridViewObjects.CurrentCell != null)
            {
                var row = dataGridViewObjects.CurrentCell.OwningRow;
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                Objects obj = _objectRepository.GetObject(id);
                if (obj.Morph == true)
                {
                    MorphRepository repo = new MorphRepository(_connectionString);
                    repo.DeleteByIdMorph(id);
                }
                _objectRepository.Delete(id);
            }
            else
            {
                MessageBox.Show("�������� ������ �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewObjects();
        }
        private void buttonDeleteActivity_Click(object sender, EventArgs e)
        {
            if (dataGridViewActivity.CurrentCell != null)
            {
                var row = dataGridViewActivity.CurrentCell.OwningRow;
                _activityRepository.Delete(Convert.ToInt32(row.Cells["Id"].Value));
            }
            else
            {
                MessageBox.Show("�������� ������ ����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewBackground();
        }
        private void buttonDeleteCast_Click(object sender, EventArgs e)
        {
            if (dataGridViewCast.CurrentCell != null)
            {
                var row = dataGridViewCast.CurrentCell.OwningRow;
                _objectCastRepository.Delete(Convert.ToInt32(row.Cells["Id"].Value));
            }
            else
            {
                MessageBox.Show("�������� ������ ���.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDataGridViewCast();
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
                MessageBox.Show("�������� ������ ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonChoseBlock_Click(object sender, EventArgs e)
        {

            if (dataGridViewBlock.CurrentCell != null)
            {
                var row = dataGridViewBlock.CurrentCell.OwningRow;
                _currentWorkBlock = new();
                _currentWorkBlock.Id = (int)row.Cells["Id"].Value;
                _currentWorkBlock.Name = row.Cells["Name"].Value.ToString();
                _currentWorkBlock.Description = row.Cells["Description"].Value.ToString();

                ConfigureTreeView();
            }
            else
            {
                MessageBox.Show("�������� ������ ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

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
                SearchByDataGridService<Background> searhBackgound =
                                                        new SearchByDataGridService<Background>(
                                                                    (List<Background>)dataGridViewBackground.DataSource,
                                                                                                        textBoxSearchBackground.Text);
                dataGridViewBackground.DataSource = searhBackgound.Search();
                return;
            }

            dataGridViewBackground.DataSource = _backgroundRepository.GetObjects();

        }
        private void textBoxSearchCastTypes_TextChanged(object sender, EventArgs e)
        {

            if (dataGridViewCastTypes.DataSource != null && textBoxSearchCastTypes.Text != "")
            {
                SearchByDataGridService<CastTypes> searchCastTypes =
                                                        new SearchByDataGridService<CastTypes>(
                                                                    (List<CastTypes>)dataGridViewCastTypes.DataSource,
                                                                                                        textBoxSearchCastTypes.Text);
                dataGridViewCastTypes.DataSource = searchCastTypes.Search();
                return;
            }

            dataGridViewCastTypes.DataSource = _castTypesRepository.GetObjects();
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
        private void textBoxSearchActivity_TextChanged(object sender, EventArgs e)
        {

            if (dataGridViewActivity.DataSource != null && textBoxSearchActivity.Text != "")
            {
                SearchByDataGridService<ActivityDTO> searhActivity =
                                                        new SearchByDataGridService<ActivityDTO>(
                                                                    (List<ActivityDTO>)dataGridViewActivity.DataSource,
                                                                                                        textBoxSearchActivity.Text);
                dataGridViewActivity.DataSource = searhActivity.Search();
                return;
            }

            FillDataGridViewActivity();

        }

        private void textBoxSearchCastBackground_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewCastBackground.DataSource != null && textBoxSearchCastBackground.Text != "")
            {
                SearchByDataGridService<Background> searhBackgound =
                                                        new SearchByDataGridService<Background>(
                                                                    (List<Background>)dataGridViewCastBackground.DataSource,
                                                                                                        textBoxSearchCastBackground.Text);
                dataGridViewCastBackground.DataSource = searhBackgound.Search();
                return;
            }

            FilldataGridViewCastBackground();
        }
        private void textBoxSearchCastType_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewCastType.DataSource != null && textBoxSearchCastType.Text != "")
            {
                SearchByDataGridService<CastTypes> searchCastTypes =
                                                        new SearchByDataGridService<CastTypes>(
                                                                    (List<CastTypes>)dataGridViewCastType.DataSource,
                                                                                                        textBoxSearchCastType.Text);
                dataGridViewCastType.DataSource = searchCastTypes.Search();
                return;
            }

            FilldataGridViewCastType();
        }
        private void textBoxSearchCastObjectSpend_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewCastObjectSpend.DataSource != null && textBoxSearchCastObjectSpend.Text != "")
            {

                SearchByDataGridService<Objects> searhObjects =
                                        new SearchByDataGridService<Objects>(
                                                    (List<Objects>)dataGridViewCastObjectSpend.DataSource,
                                                                                        textBoxSearchCastObjectSpend.Text);
                dataGridViewCastObjectSpend.DataSource = searhObjects.Search();
                return;
            }

            FilldataGridViewCastObjectSpend();
        }
        private void textBoxSearchCastObjectRecive_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewCastObjectRecive.DataSource != null && textBoxSearchCastObjectRecive.Text != "")
            {

                SearchByDataGridService<Objects> searhObjects =
                                        new SearchByDataGridService<Objects>(
                                                    (List<Objects>)dataGridViewCastObjectRecive.DataSource,
                                                                                        textBoxSearchCastObjectRecive.Text);
                dataGridViewCastObjectRecive.DataSource = searhObjects.Search();
                return;
            }

            FilldataGridViewCastObjectRecive();
        }
        private void textBoxSearchCastActivity_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewCastActivity.DataSource != null && textBoxSearchCastActivity.Text != "")
            {
                SearchByDataGridService<ActivityDTO> searhActivity =
                                                        new SearchByDataGridService<ActivityDTO>(
                                                                    (List<ActivityDTO>)dataGridViewCastActivity.DataSource,
                                                                                                        textBoxSearchCastActivity.Text);
                dataGridViewCastActivity.DataSource = searhActivity.Search();
                return;
            }

            FilldataGridViewCastActivity();
        }


        private void buttonAddToMorph_Click(object sender, EventArgs e)
        {
            if (dataGridViewObjToMorph.CurrentCell != null && _currentEditableMorph != null)
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


                List<Objects> objects = (List<Objects>)dataGridViewObjects.DataSource;

                morph.IdMorph = idForCurrentObj;
                morph.IdObjectInTheComposition = Convert.ToInt32(row.Cells["Id"].Value);
                _currentEditableMorph.Add(morph);

                var MorphDto = _currentEditableMorph.Join(objects, m => m.IdObjectInTheComposition, o => o.Id, (m, o) => new MorphDTO()
                {
                    IdMorph = m.IdMorph,
                    NameMorph = textBoxNameObjects.Text,
                    IdObjectInTheComposition = m.IdObjectInTheComposition,
                    NameObjectInTheComposition = o.Name
                }).ToList();

                dataGridViewRecipeToMorph.DataSource = null;
                dataGridViewRecipeToMorph.DataSource = MorphDto;

                dataGridViewRecipeToMorph.Columns["Id"].Visible = false;
                dataGridViewRecipeToMorph.Columns["IdMorph"].Visible = false;
                dataGridViewRecipeToMorph.Columns["IdObjectInTheComposition"].Visible = false;
                //dataGridViewRecipeToMorph.AutoSize = true;
                dataGridViewRecipeToMorph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewRecipeToMorph.Columns["NameMorph"].HeaderText = "��������";
                dataGridViewRecipeToMorph.Columns["NameMorph"].DisplayIndex = 1;
                dataGridViewRecipeToMorph.Columns["NameObjectInTheComposition"].HeaderText = "������";
                dataGridViewRecipeToMorph.Columns["NameObjectInTheComposition"].DisplayIndex = 2;


            }
            else
            {
                MessageBox.Show("�������� ������ �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonDefineFromMorph_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecipeToMorph.CurrentCell != null && _currentEditableMorph != null)
            {
                var row = dataGridViewRecipeToMorph.CurrentCell.OwningRow;
                Morph morphForRemoving = new();

                morphForRemoving.IdMorph = Convert.ToInt32(row.Cells["IdMorph"].Value);
                morphForRemoving.IdObjectInTheComposition = Convert.ToInt32(row.Cells["IdObjectInTheComposition"].Value);

                morphForRemoving = _currentEditableMorph.Where(m =>
                                                m.IdMorph == morphForRemoving.IdMorph &&
                                                m.IdObjectInTheComposition == morphForRemoving.IdObjectInTheComposition).First();
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
            dataGridViewRecipeToMorph.DataSource = null;

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

        private void ResetObjectCast()
        {
            if (_currentWorkBlock != null)
            {
                _objectCastCreatable = new();
                _objectCastCreatable.IdBlock = _currentWorkBlock.Id;

                labelCastBackgroundValue.Text = "-";
                labelCastCastTypeValue.Text = "-";
                labelObjectToSpendValue.Text = "-";
                labelObjectToReciveValue.Text = "-";
                labelCastActivityValue.Text = "-";
                checkBoxCastDescription.Checked = false;
            }
            else
            {
                MessageBox.Show("�������� ������ ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonResetCreatebleCast_Click(object sender, EventArgs e)
        {
            ResetObjectCast();
        }
        private void dataGridViewCastBackground_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewCastBackground.CurrentCell != null)
            {
                var row = dataGridViewCastBackground.CurrentCell.OwningRow;
                if (row != null && _objectCastCreatable != null)
                {
                    _objectCastCreatable.IdBackground = (int)row.Cells["Id"].Value;

                    labelCastBackgroundValue.Text = row.Cells["Name"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewCastObjectSpend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCastObjectSpend.CurrentCell != null)
            {
                var row = dataGridViewCastObjectSpend.CurrentCell.OwningRow;
                if (row != null && _objectCastCreatable != null)
                {
                    _objectCastCreatable.IdObjectSpent = (int)row.Cells["Id"].Value;

                    labelObjectToSpendValue.Text = row.Cells["Name"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewCastObjectRecive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCastObjectRecive.CurrentCell != null)
            {
                var row = dataGridViewCastObjectRecive.CurrentCell.OwningRow;
                if (row != null && _objectCastCreatable != null)
                {
                    _objectCastCreatable.IdObjectRecive = (int)row.Cells["Id"].Value;

                    labelObjectToReciveValue.Text = row.Cells["Name"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewCastActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCastActivity.CurrentCell != null)
            {
                var row = dataGridViewCastActivity.CurrentCell.OwningRow;
                if (row != null && _objectCastCreatable != null)
                {
                    _objectCastCreatable.IdActivity = (int)row.Cells["Id"].Value;

                    labelCastActivityValue.Text = row.Cells["Name"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewCastType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCastType.CurrentCell != null)
            {
                var row = dataGridViewCastType.CurrentCell.OwningRow;
                if (row != null && _objectCastCreatable != null)
                {
                    _objectCastCreatable.IdCastType = (int)row.Cells["Id"].Value;

                    labelCastCastTypeValue.Text = row.Cells["Name"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textBoxDescriptionCast_TextChanged(object sender, EventArgs e)
        {

            if (_objectCastCreatable != null)
            {
                _objectCastCreatable.Description = textBoxDescriptionCast.Text;
                if (_objectCastCreatable.Description.Length > 0)
                {
                    checkBoxCastDescription.Checked = true;
                }
                else
                {
                    checkBoxCastDescription.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("�������� ���� ��� �������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void buttonTestInventorySpendRecive_Click(object sender, EventArgs e)
        {
            if (dataGridViewCast.DataSource != null)
            {
                var checkService = new CheckSpentAndReciveObjectsService((List<ObjectCastDTO>)dataGridViewCast.DataSource);

                var result = checkService.Test();

                listBoxTestSpendReciveInvemtory.DataSource = result;
            }
            else
            {
                MessageBox.Show("��������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigureTreeView()
        {
            try
            {
                if (_currentWorkScript != null)
                {
                    treeViewMainForm.Nodes.Clear();

                    TreeNode scriptNode = new TreeNode(_currentWorkScript.Name);

                    var repo = new BlockRepository(_connectionString);
                    List<Block> listOfBlocksByScript = repo.GetObjects(_currentWorkScript.Id);
                    List<ObjectCast> objectCasts = _objectCastRepository.GetObjects();

                    if (listOfBlocksByScript.Count != 0)
                    {
                        foreach (var block in listOfBlocksByScript)
                        {
                            if (_currentWorkBlock != null && block.Name == _currentWorkBlock.Name)
                            {
                                TreeNode currentBlock = new TreeNode(block.Name);
                                currentBlock.BackColor = Color.LightGreen;
                                try
                                {
                                    int count = objectCasts.Where(oc => oc.IdBlock == block.Id).Select(objs => objs.IdStep).First();
                                    currentBlock.Nodes.Add(new TreeNode("���������� �����: " + count.ToString()));
                                }
                                catch { }

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
                MessageBox.Show("������ ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    FillDataGridViewCastTypes();
                    break;
                case 4:
                    FillDataGridViewObjects();
                    break;
                case 5:
                    FillComboBoxActivity();
                    FillDataGridViewActivity();
                    break;
                case 6:
                    FillCastParamsViews();
                    FillDataGridViewCast();
                    break;
            }

        }


    }
}
