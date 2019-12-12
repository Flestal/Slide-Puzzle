using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidePuzzle
{
    public partial class Form_44 : MetroFramework.Forms.MetroForm
    {
        //정답 배열
        readonly int[] answer = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,0};
        //숫자 보드
        int[] board = new int[16];
        //버튼 배열
        Button[] btns = new Button[16];
        //게임 시작
        bool start = false;
        
        public Form_44()//게임을 킬 때
        {
            InitializeComponent();
            btns[0] = button1;
            btns[1] = button2;
            btns[2] = button3;
            btns[3] = button4;
            btns[4] = button5;
            btns[5] = button6;
            btns[6] = button7;
            btns[7] = button8;
            btns[8] = button9;
            btns[9] = button10;
            btns[10] = button11;
            btns[11] = button12;
            btns[12] = button13;
            btns[13] = button14;
            btns[14] = button15;
            btns[15] = button16;//버튼 배열에 버튼 채워넣고
            Board_Reset();//보드 초기화
        }
        void Button_Clicked(int a,bool b=true)//버튼 클릭 함수, a는 클릭 위치, b는 드로우 여부(기본적으로 true)
        {
            int x = a / 4;
            int y = a % 4;
            int temp;
            if (board[a] == 0 && start)
            {
                textBox1.Text = start.ToString();
                Answer_Check();
            }
            switch(x)//이동 스크립트
            {
                case 0:
                    switch (y)
                    {
                        case 0:
                            if (board[a + 1] == 0)
                            {
                                temp = board[a+1];
                                board[a + 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 4] == 0)
                            {
                                temp = board[a + 4];
                                board[a + 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                        case 3:
                            if (board[a - 1] == 0)
                            {
                                temp = board[a - 1];
                                board[a - 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 4] == 0)
                            {
                                temp = board[a + 4];
                                board[a + 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                        default:
                            if (board[a + 1] == 0)
                            {
                                temp = board[a + 1];
                                board[a + 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a - 1] == 0)
                            {
                                temp = board[a - 1];
                                board[a - 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 4] == 0)
                            {
                                temp = board[a + 4];
                                board[a + 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (y)
                    {
                        case 0:
                            if (board[a + 1] == 0)
                            {
                                temp = board[a + 1];
                                board[a + 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a - 4] == 0)
                            {
                                temp = board[a - 4];
                                board[a - 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                        case 3:
                            if (board[a - 1] == 0)
                            {
                                temp = board[a - 1];
                                board[a - 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a - 4] == 0)
                            {
                                temp = board[a - 4];
                                board[a - 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                        default:
                            if (board[a + 1] == 0)
                            {
                                temp = board[a + 1];
                                board[a + 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a - 1] == 0)
                            {
                                temp = board[a - 1];
                                board[a - 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a - 4] == 0)
                            {
                                temp = board[a - 4];
                                board[a - 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                    }
                    break;
                default:
                    switch (y)
                    {
                        case 0:
                            if (board[a - 4] == 0)
                            {
                                temp = board[a - 4];
                                board[a - 4] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 1] == 0)
                            {
                                temp = board[a + 1];
                                board[a + 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 4] == 0)
                            {
                                temp = board[a + 4];
                                board[a + 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                        case 3:
                            if (board[a - 4] == 0)
                            {
                                temp = board[a - 4];
                                board[a - 4] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a - 1] == 0)
                            {
                                temp = board[a - 1];
                                board[a - 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 4] == 0)
                            {
                                temp = board[a + 4];
                                board[a + 4] = board[a];
                                board[a] = temp;
                            }
                            break;
                        default:
                            if (board[a - 4] == 0)
                            {
                                temp = board[a - 4];
                                board[a - 4] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 1] == 0)
                            {
                                temp = board[a + 1];
                                board[a + 1] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a + 4] == 0)
                            {
                                temp = board[a + 4];
                                board[a + 4] = board[a];
                                board[a] = temp;
                            }
                            else if (board[a - 1] == 0)
                            {
                                temp = board[a - 1];
                                board[a - 1] = board[a];
                                board[a] = temp;
                            }
                            break;
                    }
                    break;
            }
            if (b) Board_Draw();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_Clicked(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button_Clicked(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button_Clicked(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button_Clicked(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button_Clicked(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button_Clicked(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button_Clicked(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button_Clicked(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button_Clicked(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button_Clicked(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button_Clicked(10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button_Clicked(11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button_Clicked(12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button_Clicked(13);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button_Clicked(14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button_Clicked(15);
        }

        /*private void button17_Click(object sender, EventArgs e)
        {
            Button_Clicked(16);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button_Clicked(17);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button_Clicked(18);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button_Clicked(19);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button_Clicked(20);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button_Clicked(21);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button_Clicked(22);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button_Clicked(23);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button_Clicked(24);
        }*/

        private void button26_Click(object sender, EventArgs e)
        {
            Board_Reset();
        }
        void Board_Reset()//게임 초기화
        {
            for(int i = 0; i < 16; i++)//1부터 25까지 채워넣고
            {
                board[i] = i + 1;
            }
            board[15] = 0;//마지막 25번째 칸을 0으로 초기화
            textBox1.Text = "-----Slide Puzzle-----";
            start = false;//게임 시작 아닌 상태
            Board_Draw();//보드 드로우
        }
        void Board_Shuffle()
        {
            Random r = new Random();
            int rnd = r.Next(2500, 5000);//2500~4999회
            for(int i = 0; i < rnd; i++)
            {
                int num = r.Next(0, 16);//랜덤한 위치에
                Button_Clicked(num,false);//드로우 안하는 클릭을 날림
            }
            start = true;
            textBox1.Text = "---Game Start!---";
            Board_Draw();//초기값 드로우
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Board_Shuffle();
            start = false;//게임 정지 판정
        }
        
        void Board_Draw()
        {
            for(int i = 0; i < 16; i++)//배열의 모든 값을 받아서
            {
                if (board[i] == 0) btns[i].Text = "";//값이 없는 칸일 경우에는 버튼을 비우고
                else btns[i].Text = board[i].ToString();//값이 있으면 숫자를 채워넣음
            }
        }

        void Answer_Check()//답 체크
        {
            bool over = true;//게임 오버 체크
            for(int i = 0; i < 16; i++)
            {
                if (board[i] != answer[i])//보드의 값과 정답 위치의 값이 다르면
                {
                    over = false;//게임 오버 아님
                }
            }
            if (over)//게임 오버 체크가 되면
            {
                textBox1.Text = "----Game Over!----";//게임 오버 표시
                start = false;//게임 종료
            }
        }
    }
}
