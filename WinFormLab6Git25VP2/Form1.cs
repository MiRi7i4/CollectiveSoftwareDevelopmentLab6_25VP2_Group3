using System.Windows.Forms;

namespace CollectiveSoftwareDevelopmentLab6_25VP2_Group3
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
            long result = -1;
            long key = (int)keyInput.Value;
            //Оптимальный бинарный поиск
            result = -1;
            StartTime = Environment.TickCount;
            for (long i = 0; i < Repeats; i++)
            {
                long Le = 0;
                long Ri = N - 1;
                while (Le < Ri)
                {
                    ind = (Le + Ri) / 2;
                    if (key <= mas[ind])
                        Ri = ind;
                    else
                        Le = ind + 1;
                }
                if (mas[Ri] == key)
                {
                    result = Ri;
                }
            }

            ResultTime = Environment.TickCount - StartTime;
            optimalTime.Text = ResultTime.ToString();
            if (result == -1)
                optimalInd.Text = "не найдено";
            else
                optimalInd.Text = result.ToString();

            //Последовательный бинарный поиск
            long jump;
            result = -1;
            StartTime = Environment.TickCount;
            for (long i = 0; i < Repeats; i++)
            {
                ind = 0;
                jump = N / 2;
                while (jump > 0)
                {
                    while ((ind + jump < N) && (mas[ind + jump] <= key))
                        ind += jump;
                    jump /= 2;
                }
                if (key == mas[ind])
                    result = ind;
            }
            ResultTime = Environment.TickCount - StartTime;
            linearlikeBinTime.Text = ResultTime.ToString();
            if (result == -1)
                linearlikeBinInd.Text = "не найдено";
            else
                linearlikeBinInd.Text = result.ToString();
        }
    }
}
