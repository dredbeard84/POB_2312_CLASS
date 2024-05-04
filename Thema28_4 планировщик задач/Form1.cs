namespace Thema28_4_планировщик_задач
{
    public partial class Form1 : Form
    {
        private List<MyTask> myTasks;
        public Form1()
        {
            InitializeComponent();
            myTasks = new List<MyTask>();
        }

        private void btAdd_Click(object sender, EventArgs e)
        { AddTask(tbxTask.Text, dtpTaskDate.Value, lbxPriority.SelectedItem.ToString()!); }
        private void btDel_Click(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            myTasks.RemoveAt(index);
            lbxTask.Items.RemoveAt(index);
            lbxTaskDate.Items.RemoveAt(index);
            lbxTaskPriority.Items.RemoveAt(index);
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            MyTask currentTask = myTasks[index];
            currentTask.setTaskName(tbxTask.Text);
            currentTask.setPriority(lbxPriority.Text);
            currentTask.setTaskDateTime(dtpTaskDate.Value);
            lbxTask.Items[index] = currentTask.getTaskName();
            lbxTaskDate.Items[index] = currentTask.getTaskDateTime();
            lbxPriority.Items[index] = currentTask.getPriority();
        }
        private void ClearForm()
        {
            tbxTask.Text = "";
            dtpTaskDate.Value = DateTime.Now;
            lbxPriority.SelectedIndex = -1;
        }
        private void AddTask(string task, DateTime dt, string p)
        {
            MyTask myTask = new MyTask(task, dt, p);
            myTasks.Add(myTask);
            lbxTask.Items.Add(tbxTask.Text);
            lbxTaskDate.Items.Add(dtpTaskDate.Value);
            lbxTaskPriority.Items.Add(lbxPriority.SelectedItem);
            ClearForm();
        }
        private void lbxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            MyTask currentTask = myTasks[index];
            tbxTask.Text = currentTask.getTaskName();
            lbxPriority.Text = currentTask.getPriority();
            dtpTaskDate.Value = currentTask.getTaskDateTime();
        }
    }
}