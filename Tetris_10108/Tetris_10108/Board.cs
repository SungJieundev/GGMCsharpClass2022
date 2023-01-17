﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Tetris_10108
{
    class Board
    {

        //Form1 form1 = new Form1();

        internal static Board GameBoard // 보드의 유일한 객체. 싱글톤 패턴으로 만듦.
        {
            get;
            private set;
        }
        static Board() // 정적 생성자
        {
            GameBoard = new Board(); //인스턴스 생성자
        }

        int[,] board = new int[GameRule.BX, GameRule.BY];

        internal int this[int x, int y] // 인덱서
        {
            get
            {
                return board[x, y];
            }
        }

        internal bool MoveEnable(int bn, int tn, int x, int y) // 보드 배열, 도형 배열 겹치는지 검사. 도형이 그 자리에 위치할 수 있는지
        {
            for(int xx= 0; xx<4; xx++)
            {
                for(int yy = 0; yy<4; yy++)
                {
                    if(BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        if (board[(x + xx), (y + yy)] != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        internal void Store(int bn, int turn, int x, int y)
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for(int yy = 0; yy<4; yy++)
                {
                    if((x+xx >= 0)&& (x+xx< GameRule.BX) && (y + yy >= 0) && (y + yy < GameRule.BY))
                    {
                        board[x + xx, y + yy] += BlockValue.bvals[bn, turn, xx, yy];
                    }
                }
            }
            CheckLines(y + 3);
        }

        private void CheckLines(int y)
        {
            int yy = 0;
            for(yy = 0; yy<4; yy++)
            {
                if(y - yy < GameRule.BY)
                {
                    if(CheckLine(y - yy))
                    {
                        SystemSounds.Beep.Play();
                        //OnScoreChange();
                        Score();
                        ClearLine(y - yy);
                        y++;
                    }
                }
            }
        }

        public delegate void EventHandler();
        public event EventHandler PlusScore;

        public void OnScoreChange()
        {
                PlusScore();       
        }

        public static int score = 0;
        public void Score()
        {
            score += 1;
            
        }

        private void ClearLine(int y)
        {
            for(; y>0; y--)
            {
                for(int xx = 0; xx<GameRule.BX; xx++) // 윗줄 전체를 사라질 아랫줄로 복사
                {
                    board[xx, y] = board[xx, y - 1]; // y- 1이 윗줄
                }
            }
        }

        private bool CheckLine(int y) // y 에 해당하는 한 라인이 꽉 차있는가.
        {
            for(int xx = 0; xx<GameRule.BX; xx++)
            {
                if(board[xx,y] == 0)
                {
                    return false;
                }
            }
            return true;
        }
        internal void ClearBoard()
        {
            for(int xx = 0; xx<GameRule.BX; xx++)
            {
                for(int yy = 0; yy<GameRule.BY; yy++)
                {
                    board[xx, yy] = 0;
                }
            }
        }
    }
}
