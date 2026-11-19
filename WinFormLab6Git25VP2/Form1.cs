namespace WinFormLab5_7Maksimov25VP2
{
    public partial class Form1 : Form
    {
        const  long N = 1000000000;
        const  long Repeats = 1000000;
        long[] mas = new long[N];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mas[0] = rnd.Next(0, 5);
            for (long i = 1; i < N; i++)
            {
                mas[i] = mas[i - 1] + rnd.Next(1, 5);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            //неоптимальный бинарный поиск
            bool foundA = false;
            int i = 0;
            int StartTimeA = Environment.TickCount;
            for (long r = 0; r < Repeats; r++)
            {
                foundA = false;
                long L = 0;
                long R = N - 1;

                while (R >= L)
                {
                    i = (int)((L + R) / 2); 
                    if (key == mas[i])
                    {
                        foundA = true;
                        break;
                    }
                    else if (key < mas[i])
                    {
                        R = i - 1;
                    }
                    else
                    {
                        L = i + 1;
                    }
                }
            }

            int ResultTimeA = Environment.TickCount - StartTimeA;
            basicTime.Text = ResultTimeA.ToString();

            if (foundA)
            {
                baisicInd.Text = i.ToString();
            }
            else
            {
                baisicInd.Text = "Поиск неудачен!";
            }
        }
    }
}
