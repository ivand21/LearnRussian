using System;
using System.Collections.Generic;
using System.Text;

namespace LearnRussian.Model
{
    public class Score
    {
        public int GoodAnswers { get; set; }
        public int WrongAnswers { get; set; }
        public int TotalAnswers { get { return GoodAnswers + WrongAnswers; } }
        public double Percent
        {
            get
            {
                if (TotalAnswers > 0)
                {
                    return GoodAnswers * 100 / TotalAnswers;
                }
                else return 0;
            }
        }

        public Score()
        {
            GoodAnswers = 0;
            WrongAnswers = 0;
        }
    }
}
