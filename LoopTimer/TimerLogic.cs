using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTimer
{
    public class TimerLogic
    {
        public long Seconds { get; private set; }
        public long Minutes { get; private set; }
        public long Hours { get; private set; }
        public bool Paused { get; private set; }
        private int originalHours;
        private int originalMinutes;
        private int originalSeconds;
        public bool Looping { get; set; } = false; // Set to true if you want the timer to loop


        public event Action TimeUpdated; // Event to notify UI of changes

        public TimerLogic()
        {
            Reset();
        }

        public void Start()
        {
            // Start the timer logic
            Paused = false;
        }

        public void Pause()
        {
            Paused = !Paused;
        }

        public void Reset()
        {
            Hours = originalHours;
            Minutes = originalMinutes;
            Seconds = originalSeconds;
            Paused = false;
        }

        public void SetTime(int hours, int minutes, int seconds)
        {
            Hours = originalHours = hours;
            Minutes = originalMinutes = minutes;
            Seconds = originalSeconds = seconds;
        }
        public void Tick()
        {
            if (Paused) return;

            if (Seconds == 0)
            {
                if (Minutes == 0)
                {
                    if (Hours == 0)
                    {
                        if (Looping)
                        {
                            // Reset to original time values
                            Hours = originalHours;
                            Minutes = originalMinutes;
                            Seconds = originalSeconds;
                        }
                        else
                        {
                            return; // Stop the timer if not looping
                        }
                    }
                    else
                    {
                        Hours--;
                        Minutes = 59;
                        Seconds = 59;
                    }
                }
                else
                {
                    Minutes--;
                    Seconds = 59;
                }
            }
            else
            {
                Seconds--;
            }

            TimeUpdated?.Invoke();
        }
    }
}