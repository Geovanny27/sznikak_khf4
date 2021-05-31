using System;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreadedApp
{
    delegate void BikeAction(Button bike);
    public partial class Form1 : Form
    {
        //ManualResetEvent típusú változó
        private ManualResetEvent manualWait = new ManualResetEvent(false);
        //AutoResetEvent típusú változó
        private AutoResetEvent autoWait = new AutoResetEvent(false);
        //Random változó
        Random random = new Random();
        //a lépésszám amit a végén kiírunk
        private long pixelCount = 0;
        //a lock miatt szükséges mező
        private object syncRoot = new object();

        //form inicializálása
        public Form1()
        {
            InitializeComponent();
        }

        //a lépésszám növelése
        //először zároljuk, utána növeljük csak meg
        void increasePixels(long step)
        {
            lock (syncRoot)
            {
                pixelCount += step;
            }
        }

        //a lépésszám lekérése
        //először zároljuk, utána kérjük csak le
        long getPixels()
        {
            lock (syncRoot)
            {
                return pixelCount;
            }
        }

        public void BikeThreadFunction(object param)
        {
            try
            {
                //átkasztoljuk Buttonné a paraméterként változót
                Button bike = (Button)param;

                bike.Tag = Thread.CurrentThread;

                //először csak az első panelig engedjük futni a gombokat
                //ha még nem érte el, akkor megy még
                //ha elérte, akkor blokkolva várakoztatjuk
                while (bike.Left < pStart.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                    if (bike.Left >= pStart.Left)
                        manualWait.WaitOne();
                }
                //utána a második panelig engedjük futni a gombokat
                //ha még nem érte el, akkor megy még
                //ha elérte, akkor blokkolva várakoztatjuk
                while (bike.Left < pRest.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                    if (bike.Left >= pRest.Left)
                        autoWait.WaitOne();
                }
                //végül mehetnek az utolsó panelig
                while (bike.Left < pTarget.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
            }
            catch (ThreadInterruptedException)
            {
                //elkapjuk, hogy ne szálljon el a program
            }
        }
        //a bicikli mozgatására szolgáló függvény
        //minden bicikli saját szálon fog futni
        public void MoveBike(Button bike)
        {
            if (InvokeRequired)
            {
                Invoke(new BikeAction(MoveBike), bike);
            }
            else
            {
                int move = random.Next(3, 9);
                bike.Left += move;
                increasePixels(move);
            }
        }
        //a Step1 gomb
        //mind a három biciklit egyszerre indítja el
        private void bStart_Click(object sender, EventArgs e)
        {
            StartBike(bBike1);
            StartBike(bBike2);
            StartBike(bBike3);
        }
        //a start metódus
        //elindítja a biciklit amennyiben az (kb) a kezdeti pozicióban van
        private void StartBike(Button bBike)
        {
            if(bBike.Left < pStart.Left)
            {
                Thread t = new Thread(BikeThreadFunction);
                bBike.Tag = t;
                t.IsBackground = true; // Ne blokkolja a szál a processz megszűnését
                t.Start(bBike);
            }
        }
        //-
        private void pTarget_Paint(object sender, PaintEventArgs e)
        {

        }
        //Elindítjuk egyszerre az összes biciklit az első panelről, 
        //majd reseteljük a panelt, hogy a frissen érkező biciklik is megálljanak
        private void bStep1_Click(object sender, EventArgs e)
        {
            manualWait.Set();
            manualWait.Reset();
        }

        //Elindítunk egyszerre egz biciklit a második panelről, 
        //majd reseteljük a panelt, hogy a frissen érkező biciklik is megálljanak
        private void bStep2_Click(object sender, EventArgs e)
        {
            autoWait.Set();
            autoWait.Reset();
        }

        private void bBike3_Click(object sender, EventArgs e)
        {

        }
        //a metódus amely lefut a biciklikre kattintáaskor
        //megszakítja a futást, majd a kezdőpozicióba helyezi a biciklit
        //ezt követően el is indítja azt
        private void bike_Click(object sender, EventArgs e)
        {
            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag;
            // Ha még nem indítottuk ez a szálat, ez null.
            if (thread == null)
                return;
            // Megszakítjuk a szál várakozását, ez az adott szálban egy
            // ThreadInterruptedException-t fog kiváltani
            // A függvény leírásáról részleteket az előadás anyagaiban találsz
            thread.Interrupt();
            // Megvárjuk, amíg a szál leáll
            thread.Join();

            manualWait.Reset();
            autoWait.Reset();

            bike.Left = 12;
            StartBike(bike);
        }

        //a metódus amely arra szolgál, hogy a legutolsó gombra nyomáskor a lépésszám jelenjen meg
            private void bVelocity_Click(object sender, EventArgs e)
        {
            bPixelCount.Text = getPixels().ToString();
        }
    }
}
