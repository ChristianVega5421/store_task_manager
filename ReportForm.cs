using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskManager_netcore.models;

namespace taskManager_netcore
{
    public partial class ReportForm : Form
    {

        private readonly TaskModel _task;
        public ReportForm(TaskModel task)
        {
            InitializeComponent();
            _task = task;
            TaskDescription.Text = _task.Description;
            TaskTitle.Text = _task.Name;
        }
    }
}
