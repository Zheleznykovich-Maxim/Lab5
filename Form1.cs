using System.Diagnostics;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private List<Process> processQueue;
        private int currentProcessIndex;
        private int quantum;
        private Thread executionThread;
        private ManualResetEvent executionEvent;
        public Form1()
        {
            InitializeComponent();
            processQueue = new List<Process>();
            currentProcessIndex = 0;
            quantum = (int)quantumNumeric.Value;
            executionEvent = new ManualResetEvent(true);
        }
        private void track_Changed(object sender, EventArgs e)
        {
            trackValue.Text = trackBar1.Value.ToString();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            executionEvent.Reset();
            pauseButton.Enabled = false;
            resumeButton.Enabled = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (processQueue.Count > 0)
            {
                executionThread = new Thread(() => ExecuteProcesses());
                executionThread.Start();
                startButton.Enabled = false;
                pauseButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Добавьте задания в очередь перед запуском!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExecuteProcesses()
        {
            while (processQueue.Count > 0)
            {
                executionEvent.WaitOne();
                Process currentProcess = processQueue[currentProcessIndex];
                if (!currentProcess.IsFinished)
                {
                    currentProcess.Execute();
                    Thread.Sleep(quantum);

                    UpdateProcessList();
                }
                currentProcessIndex = (currentProcessIndex + 1) % processQueue.Count;

                //listBoxProcesses.Invoke(new Action(() =>
                //{
                //    listBoxProcesses.Items[currentProcessIndex].Text = $"{currentProcess.Name} - {currentProcess.RemainingTime} ms";
                //}));



                // Удаляем выполненный процесс из очереди

                //processQueue.RemoveAt(currentProcessIndex);
                //listBoxProcesses.Invoke(new Action(() =>
                //{
                //    listBoxProcesses.Items.RemoveAt(currentProcessIndex);
                //}));





            }

            MessageBox.Show("Очередь заданий пуста!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateProcessList()
        {
            if (listBoxProcesses.InvokeRequired)
            {
                listBoxProcesses.Invoke(new MethodInvoker(() => UpdateProcessList()));
            }
            else
            {
                listBoxProcesses.Items.Clear();
                foreach (Process process in processQueue)
                {
                    if (!process.IsFinished)
                    {
                        listBoxProcesses.Items.Add($"{process.Name} - {process.RemainingTime} ms");
                    }
                    else
                    {
                        listBoxProcesses.Items.Add($"{process.Name} - Завершён");
                    }

                }
            }
        }
        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            quantumNumeric.Enabled = false;
            if (processQueue.Count < trackBar1.Value)
            {
                int executionTime = (int)numericUpDownExecutionTime.Value;
                processQueue.Add(new Process($"Процесс {processQueue.Count + 1}", executionTime, quantum));
                UpdateProcessList();
                //listBoxProcesses.Invoke(new Action(() =>
                //{
                //    listBoxProcesses.Items.Add($"{processQueue[processQueue.Count - 1].Name} - " +
                //        $"{processQueue[processQueue.Count - 1].RemainingTime} ms");
                //}));
            }
            else
            {
                MessageBox.Show($"Невозможно добавить больше {trackValue.Text} заданий в очередь!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Quantum_ValueChanged(object sender, EventArgs e)
        {
            quantum = (int)quantumNumeric.Value;
        }

        private void resume_Click(object sender, EventArgs e)
        {
            executionEvent.Set();
            pauseButton.Enabled = true;
            resumeButton.Enabled = false;
        }
    }
}