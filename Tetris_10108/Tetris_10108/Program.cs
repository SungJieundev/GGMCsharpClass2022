using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_10108
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Form1 form1 = new Form1();

            Application.Run(new Form1());
            
            //Board board = new Board();

            //board.PlusScore += board.Score;
            //board.PlusScore += form1.ScoreTextChange;
        }
    }
}
