using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
   
    
    public delegate void ClockEvent(object sender);
    
    

    public class Clock
    {
        public int clockH = 0;
        public int clockM = 0;
        public int clockS = 0;
        public int alarmH = 1;
        public int alarmM = 30;
        public int alarmS = 0;

        
        public Clock(int h,int m,int s)
        {
            clockH = h;
            clockM = m;
            clockS = s;
        }

        
        
        public event ClockEvent Tick;
        public event ClockEvent Alarm;

        public void SetTime(int h,int m,int s)
        {
            Console.WriteLine($"Set Time to {h}:{m}:{s}");
            
            clockH = h;
            clockM = m;
            clockS = s;
        }
        public void SetAlarm(int h, int m, int s)
        {
            Console.WriteLine($"Set Alarm to {h}:{m}:{s}");
            alarmH = h;
            alarmM = m;
            alarmS = s;
        }
        public void StartClock()
        {
            Console.WriteLine($"Start Clock at {clockH}:{clockM}:{clockS}");
            do
            {
                Tick(this);
            } while (clockH != alarmH || clockM != alarmM || clockS != alarmS);
            Alarm(this);
        }
        


    }

   
    public class Form
    {
        public Clock myClock = new Clock(0,0,0);
        

        public Form()
        {
            
            myClock.Tick += new ClockEvent(Clock_Tick);
            myClock.Alarm += new ClockEvent(Clock_Alarm);
        }
        
        
        void Clock_Tick(object sender)
        {
            if (myClock.clockS < 59)
            {
                myClock.clockS++;
                Console.WriteLine($"{myClock.clockH}:{myClock.clockM}:{myClock.clockS}");
                return;
            }
            myClock.clockS = 0;
            if (myClock.clockM < 59)
            {
                myClock.clockM++;
                Console.WriteLine($"{myClock.clockH}:{myClock.clockM}:{myClock.clockS}");
                return;
            }
            myClock.clockM = 0;
            myClock.clockH++;
            myClock.clockH %= 24;
            Console.WriteLine($"{myClock.clockH}:{myClock.clockM}:{myClock.clockS}");
            return;
        }
        void Clock_Alarm(object sender)
        {
            Console.WriteLine($"Ring!!!");
        }


    }
    
    class clockprogram
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            string s = "";
            Console.WriteLine("请以“:”分隔输入此时的时间：");
            s = Console.ReadLine();
            string[] input = s.Split(':');
            int cH = Int32.Parse(input[0]);
            int cM = Int32.Parse(input[1]);
            int cS = Int32.Parse(input[2]);
            Console.WriteLine("请以“:”分隔输入闹钟的时间：");
            s = Console.ReadLine();
            input = s.Split(':');
            int aH = Int32.Parse(input[0]);
            int aM = Int32.Parse(input[1]);
            int aS = Int32.Parse(input[2]);


            form1.myClock.SetTime(cH, cM, cS);
            form1.myClock.SetAlarm(aH, aM, aS);
            form1.myClock.StartClock();
        }
    }
}