using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace GameMemorizeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCountRN.SelectedIndex = 0;
            comboBoxDiff.SelectedIndex = 0;
            richTextBoxRandomNumbers.SelectionAlignment = HorizontalAlignment.Center;
        }

        public int attemptNumber = 0;
        public int countRN = 5;
        public string diff = "Easy";
        public int timePeriodMs = 1000;
        public List<RandomNumber> numbers = new List<RandomNumber>();

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            attemptNumber++;
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            numbers = FillNumbers();

            textBoxMain.Text = "";
            string text = "";
            foreach (var number in numbers)
            {
                text += $"{number.Value} ";
            }
            richTextBoxRandomNumbers.Text = text;

            await Task.Delay(timePeriodMs);
            richTextBoxRandomNumbers.Text = "";
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string introducedStr = textBoxMain.Text;
            List<string> splittedStr = introducedStr.Trim().Split(" ").ToList();
            List<RandomNumber> introducedNumbers = new List<RandomNumber>();

            for (int i = 0; i < splittedStr.Count; i++)
            {
                introducedNumbers.Add(new RandomNumber(i, int.Parse(splittedStr[i])));
            }

            float accuracy = Utils.Comparison(numbers, introducedNumbers);

            using (GMNContext gmn = new GMNContext())
            {
                Result r = new Result
                {
                    Attempt_number = attemptNumber,
                    Player_name = richTextBoxPlayerName.Text,
                    Accuracy = (float)Math.Round(accuracy, 2),
                    Difficulty = diff,
                    DateTime = DateTime.Now
                };
                gmn.Results.Add(r);
                gmn.SaveChanges();
            }

            if (accuracy == 1)
            {
                if (comboBoxDiff.SelectedIndex < 2)
                    comboBoxDiff.SelectedIndex += 1;
                else
                {
                    using (GMNContext gmn = new GMNContext())
                    {
                        var results = gmn.Results.Where(r => r.Attempt_number == attemptNumber);

                        List<float> listEasy = new List<float>();
                        List<float> listNormal = new List<float>();
                        List<float> listHard = new List<float>();

                        foreach (var r in results)
                        {
                            if (r.Difficulty == "Easy") 
                                listEasy.Add(r.Accuracy);
                            if (r.Difficulty == "Normal") 
                                listNormal.Add(r.Accuracy);
                            if (r.Difficulty == "Hard") 
                                listHard.Add(r.Accuracy);
                        }

                        float accEasy = listEasy.Average();
                        float accNormal = listNormal.Average();
                        float accHard = listHard.Average();

                        MessageBox.Show(
                            "Результаты теста:\n" +
                            $"Точность: {accEasy} - {accNormal} - {accHard}\n" +
                            $"Кол-во попыток: {listEasy.Count} - {listNormal.Count} - {listHard.Count}"
                            );
                    }
                }
            }

            richTextBoxAccuracy.Text = accuracy.ToString();
        }


        private List<RandomNumber> FillNumbers()
        {
            List<RandomNumber> nums = new List<RandomNumber>();

            for (int i = 0; i < countRN; i++)
            {
                RandomNumber item = new RandomNumber(i, RandomNumber.SetRandomNumber(diff));
                nums.Add(item);
            }

            return nums;
        }

        private void comboBoxDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = comboBoxDiff.SelectedIndex;
            if (selIndex == 1)
                diff = "Normal";
            else if (selIndex == 2)
                diff = "Hard";
            else
                diff = "Easy";
        }

        private void comboBoxCountRN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = comboBoxCountRN.SelectedIndex;
            if (selIndex == 1)
                countRN = 7;
            else if (selIndex == 2)
                countRN = 9;
            else
                countRN = 5;
        }

        private void textBoxMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;

            if (!Char.IsDigit(symb) && !(symb == ' ' &&
                Char.IsDigit(textBoxMain.Text.Last())) &&
                e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}