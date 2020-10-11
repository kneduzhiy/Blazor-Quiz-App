using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizoo.Helper
{
    public class TimerPlus : System.Timers.Timer
    {
        private DateTime _dueTime;

        public TimerPlus() : base() => this.Elapsed += this.ElapsedAction;

        protected new void Dispose()
        {
            this.Elapsed -= this.ElapsedAction;
            base.Dispose();
        }

        public double TimeLeft => (this._dueTime - DateTime.Now).TotalMilliseconds;
        public new void Start()
        {
            this._dueTime = DateTime.Now.AddMilliseconds(this.Interval);
            base.Start();
        }

        private void ElapsedAction(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.AutoReset)
                this._dueTime = DateTime.Now.AddMilliseconds(this.Interval);
        }
    }
}
