using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Presenter
    {
        Model model;
        Form1 view;

        public Presenter(Form1 v)
        {
            model = new Model();
            view = v;
            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;
            view.timer1.Tick += TimerTick;
            view.timer1.Start();
            view.timer1.Enabled = false;
        }

        private void ViewStart(object sender, EventArgs e)
        {
            view.timer1.Enabled = true;
        }
        
        private void ViewStop(object sender, EventArgs e)
        {
            view.timer1.Enabled= false;
        }

        private void ViewReset(object sender, EventArgs e)
        {
            view.timer1.Stop();
            view.LabelTimer.Text = "00:00:00";
            model.Reset();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.LabelTimer.Text = model.Tick();
        }
    }
}
