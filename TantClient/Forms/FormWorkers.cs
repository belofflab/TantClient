using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;
using TantClient.Services;
using TantClient.Models;

namespace TantClient.Forms
{
    public partial class FormWorkers : Form
    {
        private readonly WorkerService _workerService;
        private Worker[] _workers;

        public FormWorkers()
        {
            InitializeComponent();
            _workerService = new WorkerService();
            loadWorkers();
        }

        private async void loadWorkers()
        {

            string json = await _workerService.getWorkers();
            if (json == null)
            {
                return;
            }

            _workers = JsonConvert.DeserializeObject<Worker[]>(json);
            listBoxWorkers.DisplayMember = "name";
            listBoxWorkers.DataSource = _workers;
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                richTextBoxChoosenWorker.Clear();
                Worker selectedWorker = (Worker)listBoxWorkers.SelectedItem;
                richTextBoxChoosenWorker.AppendText($"Выбранный сотрудник: {selectedWorker.name}\n");
                richTextBoxChoosenWorker.AppendText($"Баланс: {selectedWorker.amount}₽\n");
                richTextBoxChoosenWorker.AppendText($"Замороженный баланс: {selectedWorker.freezed_amount}₽\n");
                richTextBoxChoosenWorker.AppendText($"Комиссия: {selectedWorker.comission}%\n");
            }
        }

        private void buttonPenalty_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                Worker selectedWorker = (Worker)listBoxWorkers.SelectedItem;

                using (InputAmountForm popupForm = new InputAmountForm())
                {
                    if (popupForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal amount = popupForm.Amount;
                        WorkerPenaltyData workerPenaltyData = new WorkerPenaltyData(selectedWorker.id, amount, true, "");
                        // await _workerService.Penalty(workerRewardData);

                        MessageBox.Show($"Выдали {selectedWorker.name} штраф на сумму: {amount}₽");
                    }
                }
            }
        }

        private async void buttonReward_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                Worker selectedWorker = (Worker)listBoxWorkers.SelectedItem;

                using (InputAmountForm popupForm = new InputAmountForm())
                {
                    if (popupForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal amount = popupForm.Amount;
                        WorkerRewardData workerRewardData = new WorkerRewardData(selectedWorker.id, amount, true, "");
                       // await _workerService.Reward(workerRewardData);
                        MessageBox.Show($"Поощрили {selectedWorker.name} на сумму: {amount}₽");
                    }
                }
            }
        }

        private async void buttonDeleteWorker_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                Worker selectedWorker = (Worker)listBoxWorkers.SelectedItem;
                // await _workerService.Delete(selectedWorker.id);
                MessageBox.Show("данный функционал отключен во избежание утери информации!");
            }
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("данный функционал отключен во избежание утери информации!");
        }
    }
}
