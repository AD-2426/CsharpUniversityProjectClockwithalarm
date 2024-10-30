using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int alarmHour = 0;
        private int alarmMinute = 0;
        private bool alarmSet = false;
        public Form1()
        {
            InitializeComponent();
            timerClock.Interval = 1000; // Таймер срабатывает каждую секунду
            timerClock.Start(); // Запуск таймера
        }

        private void buttonSetAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                alarmHour = int.Parse(textBoxHour.Text);
                alarmMinute = int.Parse(textBoxMinute.Text);

                if (alarmHour < 0 || alarmHour > 23 || alarmMinute < 0 || alarmMinute > 59)
                {
                    MessageBox.Show("Дұрыс уақыт еңгізіңіз!");
                }
                else
                {
                    alarmSet = true;
                    labelAlarmStatus.Text = $"Будильник мына уақытқа қойылды \n{alarmHour:D2}:{alarmMinute:D2}";
                }
            }
            catch
            {
                MessageBox.Show("Уақыт енгізуі қате!");
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelCurrentTime.Text = now.ToString("HH:mm:ss");

            // Тексеру, қазірдік уақытты будильникпен тең екенін тексереді
            if (alarmSet && now.Hour == alarmHour && now.Minute == alarmMinute)
            {
                alarmSet = false;
                labelAlarmStatus.Text = "Будильник өшірулі";
                PlayAlarmSound(); // Дауыстықты ойнату
                MessageBox.Show("Будильник істеді!");

                
            }
        }

        private void buttonResetAlarm_Click(object sender, EventArgs e)
        {
            alarmSet = false;
            labelAlarmStatus.Text = "Будильник өшірілді";
        }
        
        private void PlayAlarmSound()
        {
            // wav. дауыстық файлының жолы
            string soundFilePath = @"C:\Users\AD\source\repos\WindowsFormsApp2\WindowsFormsApp2\alarm.wav";

            try
            {
                SoundPlayer player = new SoundPlayer(soundFilePath);
                player.Play(); // Начинает воспроизведение звука
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Дауысты ойнату кезінде қате шықты: {ex.Message}");
            }
        }

    }
}
