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

namespace WinFormsAppDiplom
{
    public partial class MainForm : Form
    {
        private string _connectionString;
        private User _currentUser;
        private Script _currentEditableScript;
        private Script _currentWorkScript;

        private IRepository<ScriptData> _scriptDataRepository;
        private IRepository<Script> _scriptRepository;

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
        }
     
        private void Form1_Load(object sender, EventArgs e)
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

        private void buttonCreateScript_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                var script = new Script();
            
                script.Name=textBoxName.Text;
                script.Description=textBoxDescription.Text;

                _scriptRepository.Create(script);
                FillDataGridViewScript();

                CleanScriptTextBoxes();
            }
            else
            {
                MessageBox.Show("Выделите нужный сценарий.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CleanScriptTextBoxes()
        {
            textBoxName.Text = "";
            textBoxDescription.Text = "";
        }

        private void ChangeEnalableScriptButtons(bool isEnalable)
        {
            buttonApply.Enabled = isEnalable;
            buttonCancel.Enabled = isEnalable;  
        }

        private void buttonLoadScript_Click(object sender, EventArgs e)
        {
            if (dataGridViewScript.CurrentCell != null)
            {
               var row=  dataGridViewScript.CurrentCell.OwningRow;
               if (row != null)
               {
                    _currentEditableScript = new();
                    _currentEditableScript.Id = (int)row.Cells[0].Value;
                    textBoxName.Text = row.Cells[1].Value.ToString();
                    try
                    {
                     textBoxDescription.Text = row.Cells[2].Value.ToString();
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

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (_currentEditableScript != null)
            {
                if (textBoxName.Text != "")
                {
                    _currentEditableScript.Name=textBoxName.Text;
                    try
                    {
                        _currentEditableScript.Description=textBoxDescription.Text;
                    }catch { }
                    _scriptRepository.Update(_currentEditableScript);
                   
                    FillDataGridViewScript();
                    _currentEditableScript = null;

                    CleanScriptTextBoxes();
                    ChangeEnalableScriptButtons(false);
                }
                else
                {
                    MessageBox.Show("Имя не задано.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            _currentEditableScript = null;
            CleanScriptTextBoxes();
            ChangeEnalableScriptButtons(false);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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

        private void buttonChoseScript_Click(object sender, EventArgs e)
        {

            if (dataGridViewScript.CurrentCell != null)
            {
                var row = dataGridViewScript.CurrentCell.OwningRow;
                _currentWorkScript = new();
                _currentWorkScript.Id = (int)row.Cells[0].Value;
                _currentWorkScript.Name = row.Cells[1].Value.ToString();
                _currentWorkScript.Description = row.Cells[2].Value.ToString();


                treeViewMainForm = new();

            }
            else
            {
                MessageBox.Show("Выделите нужный сценарий.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
