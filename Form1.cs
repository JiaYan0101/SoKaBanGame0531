namespace Sokoban_Game
{
    public partial class Form1 : Form
    {
        private List<int[,]> maps = new List<int[,]>();//�a�ϲM��
        public int currentMapIndex = 0;//��e�a�Ϫ����ޭ�
        int Firstply_x = 4, Firstply_y = 5;//map1 ���a����l��m
        int Scenodply_x = 1, Scenodply_y = 1;//map2 ���a����l��m
        int Thirdply_x = 2, Thirdply_y = 4;//map3 ���a����l��m

        public Form1()
        {
            currentMapIndex = 0;
            //int[,] currentMap =  maps[currentMapIndex];
            //
            InitializeComponent();
            InitializeMaps();
            //�N�U�Ӧa�Ϥ������I���z����
            pictureBox_map.Controls.Add(pictureBox_player);
            pictureBox_player.BackColor = Color.Transparent;
            pictureBox_map.Controls.Add(pictureBox_target1);
            pictureBox_target1.BackColor = Color.Transparent;
            pictureBox_map.Controls.Add(pictureBox_target2);
            pictureBox_target2.BackColor = Color.Transparent;
            pictureBox_map.Controls.Add(pictureBox_target3);
            pictureBox_target3.BackColor = Color.Transparent;
            pictureBox_map.Controls.Add(pictureBox_target4);
            pictureBox_target4.BackColor = Color.Transparent;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 418, 447); //�]�w�����j�p
        }
        private void InitializeMaps() //��l�Ʀa��
        {
            int[,] map1 =
            {
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,2,0,0,0,0},
                {0,0,0,0,0,3,0,0,0,0},
                {0,0,2,3,1,1,0,0,0,0},
                {0,0,0,0,1,1,3,2,0,0},
                {0,0,0,0,3,0,0,0,0,0},
                {0,0,0,0,2,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
            };
            int[,] map2 =
            {
                {0,0,0,0,0,0,0,0,0,0},
                {0,1,1,1,0,0,0,0,0,0},
                {0,1,3,3,0,0,0,0,0,0},
                {0,1,3,1,0,0,0,2,0,0},
                {0,0,0,1,0,0,0,2,0,0},
                {0,0,0,1,1,1,1,2,0,0},
                {0,0,1,1,1,0,1,1,0,0},
                {0,0,1,1,1,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
            };
            int[,] map3 =
            {
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,1,1,1,1,1,0,0,0},
                {0,0,3,0,0,0,1,1,1,0},
                {0,1,1,1,3,1,1,3,1,0},
                {0,1,2,2,0,1,3,1,0,0},
                {0,0,2,2,0,1,1,1,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
            };
            maps.Add(map1);
            maps.Add(map2);
            maps.Add(map3);
        }
        //��s�C���a�Ϫ��U�Ӥ�����m
        private void UpdateCurrentMap()
        {
            if (currentMapIndex == 0) 
            {
                pictureBox_player.Location = new Point(Firstply_x * (this.Width / 10) - 2, Firstply_y * (this.Width / 10) - 3);
                pictureBox_box1.Location = new Point(5 * (this.Width / 10) - 4, 3 * (this.Width / 10) - 3);
                pictureBox_box2.Location = new Point(6 * (this.Width / 10) - 4, 5 * (this.Width / 10) - 4);
                pictureBox_box3.Location = new Point(4 * (this.Width / 10) - 4, 6 * (this.Width / 10) - 4);
                pictureBox_box4.Location = new Point(3 * (this.Width / 10) - 4, 4 * (this.Width / 10) - 3);
                pictureBox_target1.Location = new Point(5 * (this.Width / 10) - 4, 2 * (this.Width / 10) - 3);
                pictureBox_target2.Location = new Point(7 * (this.Width / 10) - 4, 5 * (this.Width / 10) - 4);
                pictureBox_target3.Location = new Point(4 * (this.Width / 10) - 4, 7 * (this.Width / 10) - 4);
                pictureBox_target4.Location = new Point(2 * (this.Width / 10) - 4, 4 * (this.Width / 10) - 3);
            }
            if (currentMapIndex == 1) 
            {
                pictureBox_player.Location = new Point(Scenodply_x * (this.Width / 10) - 2, Scenodply_y * (this.Width / 10) - 3);
                pictureBox_box1.Location = new Point(2 * (this.Width / 10) - 4, 2 * (this.Width / 10) - 3);
                pictureBox_box2.Location = new Point(3 * (this.Width / 10) - 4, 2 * (this.Width / 10) - 4);
                pictureBox_box3.Location = new Point(2 * (this.Width / 10) - 4, 3 * (this.Width / 10) - 4);
                pictureBox_box4.Visible = false;
                pictureBox_target1.Location = new Point(7 * (this.Width / 10) - 4, 3 * (this.Width / 10) - 3);
                pictureBox_target2.Location = new Point(7 * (this.Width / 10) - 4, 4 * (this.Width / 10) - 4);
                pictureBox_target3.Location = new Point(7 * (this.Width / 10) - 4, 5 * (this.Width / 10) - 4);
                pictureBox_target4.Visible = false;
            }
            if (currentMapIndex == 2)
            {
                pictureBox_player.Location = new Point(Thirdply_x * (this.Width / 10) - 2, Thirdply_y * (this.Width / 10) - 3);
                pictureBox_box1.Location = new Point(2 * (this.Width / 10) - 4, 3 * (this.Width / 10) - 3);
                pictureBox_box2.Location = new Point(4 * (this.Width / 10) - 4, 4 * (this.Width / 10) - 4);
                pictureBox_box3.Location = new Point(6 * (this.Width / 10) - 4, 5 * (this.Width / 10) - 4);
                pictureBox_box4.Visible = true;
                pictureBox_box4.Location = new Point(7 * (this.Width / 10) - 4, 4 * (this.Width / 10) - 3);
                pictureBox_target1.Location = new Point(2 * (this.Width / 10) - 4, 5 * (this.Width / 10) - 3);
                pictureBox_target2.Location = new Point(3 * (this.Width / 10) - 4, 5 * (this.Width / 10) - 4);
                pictureBox_target3.Location = new Point(2 * (this.Width / 10) - 4, 6 * (this.Width / 10) - 4);
                pictureBox_target4.Visible = true;
                pictureBox_target4.Location = new Point(3 * (this.Width / 10) - 4, 6 * (this.Width / 10) - 3);
            }
        }
        //�XBUG������(maybe)&�ݭn�Q��k²��
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //map1 ����L�P�_
            if (currentMapIndex == 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (maps[currentMapIndex][Firstply_y, Firstply_x - 1] == 1 || maps[currentMapIndex][Firstply_y, Firstply_x - 1] == 2)
                    {
                        Firstply_x -= 1;
                        pictureBox_player.Left -= (this.Width / 10) - 4;
                    }
                    else if (maps[currentMapIndex][Firstply_y, Firstply_x - 1] == 3)
                    {
                        if (maps[currentMapIndex][Firstply_y, Firstply_x - 2] == 1)
                        {
                            maps[currentMapIndex][Firstply_y, Firstply_x - 1] = 1; maps[currentMapIndex][Firstply_y, Firstply_x - 2] = 3;
                            Firstply_x -= 1;
                            pictureBox_player.Left -= (this.Width / 10) - 4;
                            ChangBoxLocation(-(this.Width / 10), 0);
                        }
                        else if (maps[currentMapIndex][Firstply_y, Firstply_x - 2] == 2)
                        {
                            maps[currentMapIndex][Firstply_y, Firstply_x - 1] = 1; maps[currentMapIndex][Firstply_y, Firstply_x - 2] = 4;
                            Firstply_x -= 1;
                            pictureBox_player.Left -= (this.Width / 10) - 4;
                            ChangBoxLocation(-(this.Width / 10), 0);
                        }
                    }
                    else if (maps[currentMapIndex][Firstply_y, Firstply_x - 1] == 4 && maps[currentMapIndex][Firstply_y, Firstply_x - 2] == 2)
                    {
                        maps[currentMapIndex][Firstply_y, Firstply_x - 1] = 2; maps[currentMapIndex][Firstply_y, Firstply_x - 2] = 4;
                        Firstply_x -= 1;
                        pictureBox_player.Left -= (this.Width / 10) - 4;
                        ChangBoxLocation(-(this.Width / 10), 0);
                    }
                }
                //
                if (e.KeyCode == Keys.Right)
                {
                    if (maps[currentMapIndex][Firstply_y, Firstply_x + 1] == 1 || maps[currentMapIndex][Firstply_y, Firstply_x + 1] == 2)
                    {
                        Firstply_x += 1;
                        pictureBox_player.Left += (this.Width / 10) - 4;
                    }
                    else if (maps[currentMapIndex][Firstply_y, Firstply_x + 1] == 3)
                    {
                        if (maps[currentMapIndex][Firstply_y, Firstply_x + 2] == 1)
                        {
                            maps[currentMapIndex][Firstply_y, Firstply_x + 1] = 1; maps[currentMapIndex][Firstply_y, Firstply_x + 2] = 3;
                            Firstply_x += 1;
                            pictureBox_player.Left += (this.Width / 10) - 4;
                            ChangBoxLocation(+(this.Width / 10), 0);
                        }
                        else if (maps[currentMapIndex][Firstply_y, Firstply_x + 2] == 2)
                        {
                            maps[currentMapIndex][Firstply_y, Firstply_x + 1] = 1; maps[currentMapIndex][Firstply_y, Firstply_x + 2] = 4;
                            Firstply_x += 1;
                            pictureBox_player.Left += (this.Width / 10) - 4;
                            ChangBoxLocation(+(this.Width / 10), 0);
                        }
                    }
                    else if (maps[currentMapIndex][Firstply_y, Firstply_x + 1] == 4 && maps[currentMapIndex][Firstply_y, Firstply_x + 2] == 2)
                    {
                        maps[currentMapIndex][Firstply_y, Firstply_x + 1] = 2; maps[currentMapIndex][Firstply_y, Firstply_x + 2] = 4;
                        Firstply_x += 1;
                        pictureBox_player.Left += (this.Width / 10) - 4;
                        ChangBoxLocation(+(this.Width / 10), 0);
                    }
                }
                //
                if (e.KeyCode == Keys.Up)
                {
                    if (maps[currentMapIndex][Firstply_y - 1, Firstply_x] == 1 || maps[currentMapIndex][Firstply_y - 1, Firstply_x] == 2)
                    {
                        Firstply_y -= 1;
                        pictureBox_player.Top -= (this.Height / 10) - 3;
                    }
                    else if (maps[currentMapIndex][Firstply_y - 1, Firstply_x] == 3)
                    {
                        if (maps[currentMapIndex][Firstply_y - 2, Firstply_x] == 1)
                        {
                            maps[currentMapIndex][Firstply_y - 1, Firstply_x] = 1; maps[currentMapIndex][Firstply_y - 2, Firstply_x] = 3;
                            Firstply_y -= 1;
                            pictureBox_player.Top -= (this.Height / 10) - 4;
                            ChangBoxLocation(0, -(this.Height / 10));
                        }
                        else if (maps[currentMapIndex][Firstply_y - 2, Firstply_x] == 2)
                        {
                            maps[currentMapIndex][Firstply_y - 1, Firstply_x] = 1; maps[currentMapIndex][Firstply_y - 2, Firstply_x] = 4;
                            Firstply_y -= 1;
                            pictureBox_player.Top -= (this.Height / 10) - 4;
                            ChangBoxLocation(0, -(this.Height / 10));
                        }
                    }
                    else if (maps[currentMapIndex][Firstply_y - 1, Firstply_x] == 4 && maps[currentMapIndex][Firstply_y - 2, Firstply_x] == 2)
                    {
                        maps[currentMapIndex][Firstply_y - 1, Firstply_x] = 2; maps[currentMapIndex][Firstply_y - 2, Firstply_x] = 4;
                        Firstply_y -= 1;
                        pictureBox_player.Top -= (this.Height / 10) - 4;
                        ChangBoxLocation(0, -(this.Height / 10));
                    }
                }
                //
                if (e.KeyCode == Keys.Down)
                {
                    if (maps[currentMapIndex][Firstply_y + 1, Firstply_x] == 1 || maps[currentMapIndex][Firstply_y + 1, Firstply_x] == 2)
                    {
                        Firstply_y += 1;
                        pictureBox_player.Top += (this.Height / 10) - 3;
                    }
                    else if (maps[currentMapIndex][Firstply_y + 1, Firstply_x] == 3)
                    {
                        if (maps[currentMapIndex][Firstply_y + 2, Firstply_x] == 1)
                        {
                            maps[currentMapIndex][Firstply_y + 1, Firstply_x] = 1; maps[currentMapIndex][Firstply_y + 2, Firstply_x] = 3;
                            Firstply_y += 1;
                            pictureBox_player.Top += (this.Height / 10) - 4;
                            ChangBoxLocation(0, +(this.Width / 10));
                        }
                        else if (maps[currentMapIndex][Firstply_y + 2, Firstply_x] == 2)
                        {
                            maps[currentMapIndex][Firstply_y + 1, Firstply_x] = 1; maps[currentMapIndex][Firstply_y + 2, Firstply_x] = 4;
                            Firstply_y += 1;
                            pictureBox_player.Top += (this.Height / 10) - 4;
                            ChangBoxLocation(0, +(this.Width / 10));
                        }
                    }
                    else if (maps[currentMapIndex][Firstply_y + 1, Firstply_x] == 4 && maps[currentMapIndex][Firstply_y + 2, Firstply_x] == 2)
                    {
                        maps[currentMapIndex][Firstply_y + 1, Firstply_x] = 2; maps[currentMapIndex][Firstply_y + 2, Firstply_x] = 4;
                        Firstply_y += 1;
                        pictureBox_player.Top += (this.Height / 10) - 4;
                        ChangBoxLocation(0, +(this.Width / 10));
                    }
                }
                //�P�_�c�l�O�_���b�ؼ��I�W
                if (maps[currentMapIndex][2, 5] == 4 && maps[currentMapIndex][5, 7] == 4 && maps[currentMapIndex][7, 4] == 4 && maps[currentMapIndex][4, 2] == 4)
                {
                    currentMapIndex += 1;
                    DialogResult result = MessageBox.Show("�O�_�e���U�@��?", "���߹L��!!!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        UpdateCurrentMap(); 
                        pictureBox_map.Image = Properties.Resources.�a��Level_2;
                    }
                    else 
                    {
                        Application.Exit();
                    }
                }
            }

            //map2 ����L�P�_
            if (currentMapIndex == 1)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (maps[currentMapIndex][Scenodply_y, Scenodply_x - 1] == 1 || maps[currentMapIndex][Scenodply_y, Scenodply_x - 1] == 2)
                    {
                        Scenodply_x -= 1;
                        pictureBox_player.Left -= (this.Width / 10) - 4;
                    }
                    else if (maps[currentMapIndex][Scenodply_y, Scenodply_x - 1] == 3)
                    {
                        if (maps[currentMapIndex][Scenodply_y, Scenodply_x - 2] == 1)
                        {
                            maps[currentMapIndex][Scenodply_y, Scenodply_x - 1] = 1; maps[currentMapIndex][Scenodply_y, Scenodply_x - 2] = 3;
                            Scenodply_x -= 1;
                            pictureBox_player.Left -= (this.Width / 10) - 4;
                            ChangBoxLocation(-(this.Width / 10), 0);
                        }
                        else if (maps[currentMapIndex][Scenodply_y, Scenodply_x - 2] == 2)
                        {
                            maps[currentMapIndex][Scenodply_y, Scenodply_x - 1] = 1; maps[currentMapIndex][Scenodply_y, Scenodply_x - 2] = 4;
                            Scenodply_x -= 1;
                            pictureBox_player.Left -= (this.Width / 10) - 4;
                            ChangBoxLocation(-(this.Width / 10), 0);
                        }
                    }
                    else if (maps[currentMapIndex][Scenodply_y, Scenodply_x - 1] == 4 && maps[currentMapIndex][Scenodply_y, Scenodply_x - 2] == 2)
                    {
                        maps[currentMapIndex][Scenodply_y, Scenodply_x - 1] = 2; maps[currentMapIndex][Scenodply_y, Scenodply_x - 2] = 4;
                        Scenodply_x -= 1;
                        pictureBox_player.Left -= (this.Width / 10) - 4;
                        ChangBoxLocation(-(this.Width / 10), 0);
                    }
                }
                //
                if (e.KeyCode == Keys.Right)
                {
                    if (maps[currentMapIndex][Scenodply_y, Scenodply_x + 1] == 1 || maps[currentMapIndex][Scenodply_y, Scenodply_x + 1] == 2)
                    {
                        Scenodply_x += 1;
                        pictureBox_player.Left += (this.Width / 10) - 4;
                    }
                    else if (maps[currentMapIndex][Scenodply_y, Scenodply_x + 1] == 3)
                    {
                        if (maps[currentMapIndex][Scenodply_y, Scenodply_x + 2] == 1)
                        {
                            maps[currentMapIndex][Scenodply_y, Scenodply_x + 1] = 1; maps[currentMapIndex][Scenodply_y, Scenodply_x + 2] = 3;
                            Scenodply_x += 1;
                            pictureBox_player.Left += (this.Width / 10) - 4;
                            ChangBoxLocation(+(this.Width / 10), 0);
                        }
                        else if (maps[currentMapIndex][Scenodply_y, Scenodply_x + 2] == 2)
                        {
                            maps[currentMapIndex][Scenodply_y, Scenodply_x + 1] = 1; maps[currentMapIndex][Scenodply_y, Scenodply_x + 2] = 4;
                            Scenodply_x += 1;
                            pictureBox_player.Left += (this.Width / 10) - 4;
                            ChangBoxLocation(+(this.Width / 10), 0);
                        }
                    }
                    else if (maps[currentMapIndex][Scenodply_y, Scenodply_x + 1] == 4 && maps[currentMapIndex][Scenodply_y, Scenodply_x + 2] == 2)
                    {
                        maps[currentMapIndex][Scenodply_y, Scenodply_x + 1] = 2; maps[currentMapIndex][Scenodply_y, Scenodply_x + 2] = 4;
                        Scenodply_x += 1;
                        pictureBox_player.Left += (this.Width / 10) - 4;
                        ChangBoxLocation(+(this.Width / 10), 0);
                    }
                }
                //
                if (e.KeyCode == Keys.Up)
                {
                    if (maps[currentMapIndex][Scenodply_y - 1, Scenodply_x] == 1 || maps[currentMapIndex][Scenodply_y - 1, Scenodply_x] == 2)
                    {
                        Scenodply_y -= 1;
                        pictureBox_player.Top -= (this.Height / 10) - 3;
                    }
                    else if (maps[currentMapIndex][Scenodply_y - 1, Scenodply_x] == 3)
                    {
                        if (maps[currentMapIndex][Scenodply_y - 2, Scenodply_x] == 1)
                        {
                            maps[currentMapIndex][Scenodply_y - 1, Scenodply_x] = 1; maps[currentMapIndex][Scenodply_y - 2, Scenodply_x] = 3;
                            Scenodply_y -= 1;
                            pictureBox_player.Top -= (this.Height / 10) - 4;
                            ChangBoxLocation(0, -(this.Height / 10));
                        }
                        else if (maps[currentMapIndex][Scenodply_y - 2, Scenodply_x] == 2)
                        {
                            maps[currentMapIndex][Scenodply_y - 1, Scenodply_x] = 1; maps[currentMapIndex][Scenodply_y - 2, Scenodply_x] = 4;
                            Scenodply_y -= 1;
                            pictureBox_player.Top -= (this.Height / 10) - 4;
                            ChangBoxLocation(0, -(this.Height / 10));
                        }
                    }
                    else if (maps[currentMapIndex][Scenodply_y - 1, Scenodply_x] == 4 && maps[currentMapIndex][Scenodply_y - 2, Scenodply_x] == 2)
                    {
                        maps[currentMapIndex][Scenodply_y - 1, Scenodply_x] = 2; maps[currentMapIndex][Scenodply_y - 2, Scenodply_x] = 4;
                        Scenodply_y -= 1;
                        pictureBox_player.Top -= (this.Height / 10) - 4;
                        ChangBoxLocation(0, -(this.Height / 10));
                    }
                }
                //
                if (e.KeyCode == Keys.Down)
                {
                    if (maps[currentMapIndex][Scenodply_y + 1, Scenodply_x] == 1 || maps[currentMapIndex][Scenodply_y + 1, Scenodply_x] == 2)
                    {
                        Scenodply_y += 1;
                        pictureBox_player.Top += (this.Height / 10) - 3;
                    }
                    else if (maps[currentMapIndex][Scenodply_y + 1, Scenodply_x] == 3)
                    {
                        if (maps[currentMapIndex][Scenodply_y + 2, Scenodply_x] == 1)
                        {
                            maps[currentMapIndex][Scenodply_y + 1, Scenodply_x] = 1; maps[currentMapIndex][Scenodply_y + 2, Scenodply_x] = 3;
                            Scenodply_y += 1;
                            pictureBox_player.Top += (this.Height / 10) - 4;
                            ChangBoxLocation(0, +(this.Width / 10));
                        }
                        else if (maps[currentMapIndex][Scenodply_y + 2, Scenodply_x] == 2)
                        {
                            maps[currentMapIndex][Scenodply_y + 1, Scenodply_x] = 1; maps[currentMapIndex][Scenodply_y + 2, Scenodply_x] = 4;
                            Scenodply_y += 1;
                            pictureBox_player.Top += (this.Height / 10) - 4;
                            ChangBoxLocation(0, +(this.Width / 10));
                        }
                    }
                    else if (maps[currentMapIndex][Scenodply_y + 1, Scenodply_x] == 4 && maps[currentMapIndex][Scenodply_y + 2, Scenodply_x] == 2)
                    {
                        maps[currentMapIndex][Scenodply_y + 1, Scenodply_x] = 2; maps[currentMapIndex][Scenodply_y + 2, Scenodply_x] = 4;
                        Scenodply_y += 1;
                        pictureBox_player.Top += (this.Height / 10) - 4;
                        ChangBoxLocation(0, +(this.Width / 10));
                    }
                }
                if (maps[currentMapIndex][7, 3] == 4 && maps[currentMapIndex][7, 4] == 4 && maps[currentMapIndex][7, 5] == 4)
                {
                    currentMapIndex += 1;
                    DialogResult result = MessageBox.Show("�O�_�e���U�@��?", "���߹L��!!!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        UpdateCurrentMap();
                        pictureBox_map.Image = Properties.Resources.�a��Level_3;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            //map3 ����L�P�_
            if (currentMapIndex == 2)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (maps[currentMapIndex][Thirdply_y, Thirdply_x - 1] == 1 || maps[currentMapIndex][Thirdply_y, Thirdply_x - 1] == 2)
                    {
                        Thirdply_x -= 1;
                        pictureBox_player.Left -= (this.Width / 10) - 4;
                    }
                    else if (maps[currentMapIndex][Thirdply_y, Thirdply_x - 1] == 3)
                    {
                        if (maps[currentMapIndex][Thirdply_y, Thirdply_x - 2] == 1)
                        {
                            maps[currentMapIndex][Thirdply_y, Thirdply_x - 1] = 1; maps[currentMapIndex][Thirdply_y, Thirdply_x - 2] = 3;
                            Thirdply_x -= 1;
                            pictureBox_player.Left -= (this.Width / 10) - 4;
                            ChangBoxLocation(-(this.Width / 10), 0);
                        }
                        else if (maps[currentMapIndex][Thirdply_y, Thirdply_x - 2] == 2)
                        {
                            maps[currentMapIndex][Thirdply_y, Thirdply_x - 1] = 1; maps[currentMapIndex][Thirdply_y, Thirdply_x - 2] = 4;
                            Thirdply_x -= 1;
                            pictureBox_player.Left -= (this.Width / 10) - 4;
                            ChangBoxLocation(-(this.Width / 10), 0);
                        }
                    }
                    else if (maps[currentMapIndex][Thirdply_y, Thirdply_x - 1] == 4 && maps[currentMapIndex][Thirdply_y, Thirdply_x - 2] == 2)
                    {
                        maps[currentMapIndex][Thirdply_y, Thirdply_x - 1] = 2; maps[currentMapIndex][Thirdply_y, Thirdply_x - 2] = 4;
                        Thirdply_x -= 1;
                        pictureBox_player.Left -= (this.Width / 10) - 4;
                        ChangBoxLocation(-(this.Width / 10), 0);
                    }
                }
                //
                if (e.KeyCode == Keys.Right)
                {
                    if (maps[currentMapIndex][Thirdply_y, Thirdply_x + 1] == 1 || maps[currentMapIndex][Thirdply_y, Thirdply_x + 1] == 2)
                    {
                        Thirdply_x += 1;
                        pictureBox_player.Left += (this.Width / 10) - 4;
                    }
                    else if (maps[currentMapIndex][Thirdply_y, Thirdply_x + 1] == 3)
                    {
                        if (maps[currentMapIndex][Thirdply_y, Thirdply_x + 2] == 1)
                        {
                            maps[currentMapIndex][Thirdply_y, Thirdply_x + 1] = 1; maps[currentMapIndex][Thirdply_y, Thirdply_x + 2] = 3;
                            Thirdply_x += 1;
                            pictureBox_player.Left += (this.Width / 10) - 4;
                            ChangBoxLocation(+(this.Width / 10), 0);
                        }
                        else if (maps[currentMapIndex][Thirdply_y, Thirdply_x + 2] == 2)
                        {
                            maps[currentMapIndex][Thirdply_y, Thirdply_x + 1] = 1; maps[currentMapIndex][Thirdply_y, Thirdply_x + 2] = 4;
                            Thirdply_x += 1;
                            pictureBox_player.Left += (this.Width / 10) - 4;
                            ChangBoxLocation(+(this.Width / 10), 0);
                        }
                    }
                    else if (maps[currentMapIndex][Thirdply_y, Thirdply_x + 1] == 4 && maps[currentMapIndex][Thirdply_y, Thirdply_x + 2] == 2)
                    {
                        maps[currentMapIndex][Thirdply_y, Thirdply_x + 1] = 2; maps[currentMapIndex][Thirdply_y, Thirdply_x + 2] = 4;
                        Thirdply_x += 1;
                        pictureBox_player.Left += (this.Width / 10) - 4;
                        ChangBoxLocation(+(this.Width / 10), 0);
                    }
                }
                //
                if (e.KeyCode == Keys.Up)
                {
                    if (maps[currentMapIndex][Thirdply_y - 1, Thirdply_x] == 1 || maps[currentMapIndex][Thirdply_y - 1, Thirdply_x] == 2)
                    {
                        Thirdply_y -= 1;
                        pictureBox_player.Top -= (this.Height / 10) - 3;
                    }
                    else if (maps[currentMapIndex][Thirdply_y - 1, Thirdply_x] == 3)
                    {
                        if (maps[currentMapIndex][Thirdply_y - 2, Thirdply_x] == 1)
                        {
                            maps[currentMapIndex][Thirdply_y - 1, Thirdply_x] = 1; maps[currentMapIndex][Thirdply_y - 2, Thirdply_x] = 3;
                            Thirdply_y -= 1;
                            pictureBox_player.Top -= (this.Height / 10) - 4;
                            ChangBoxLocation(0, -(this.Height / 10));
                        }
                        else if (maps[currentMapIndex][Thirdply_y - 2, Thirdply_x] == 2)
                        {
                            maps[currentMapIndex][Thirdply_y - 1, Thirdply_x] = 1; maps[currentMapIndex][Thirdply_y - 2, Thirdply_x] = 4;
                            Thirdply_y -= 1;
                            pictureBox_player.Top -= (this.Height / 10) - 4;
                            ChangBoxLocation(0, -(this.Height / 10));
                        }
                    }
                    else if (maps[currentMapIndex][Thirdply_y - 1, Thirdply_x] == 4 && maps[currentMapIndex][Thirdply_y - 2, Thirdply_x] == 2)
                    {
                        maps[currentMapIndex][Thirdply_y - 1, Thirdply_x] = 2; maps[currentMapIndex][Thirdply_y - 2, Thirdply_x] = 4;
                        Thirdply_y -= 1;
                        pictureBox_player.Top -= (this.Height / 10) - 4;
                        ChangBoxLocation(0, -(this.Height / 10));
                    }
                }
                //
                if (e.KeyCode == Keys.Down)
                {
                    if (maps[currentMapIndex][Thirdply_y + 1, Thirdply_x] == 1 || maps[currentMapIndex][Thirdply_y + 1, Thirdply_x] == 2)
                    {
                        Thirdply_y += 1;
                        pictureBox_player.Top += (this.Height / 10) - 3;
                    }
                    else if (maps[currentMapIndex][Thirdply_y + 1, Thirdply_x] == 3)
                    {
                        if (maps[currentMapIndex][Thirdply_y + 2, Thirdply_x] == 1)
                        {
                            maps[currentMapIndex][Thirdply_y + 1, Thirdply_x] = 1; maps[currentMapIndex][Thirdply_y + 2, Thirdply_x] = 3;
                            Thirdply_y += 1;
                            pictureBox_player.Top += (this.Height / 10) - 4;
                            ChangBoxLocation(0, +(this.Width / 10));
                        }
                        else if (maps[currentMapIndex][Thirdply_y + 2, Thirdply_x] == 2)
                        {
                            maps[currentMapIndex][Thirdply_y + 1, Thirdply_x] = 1; maps[currentMapIndex][Thirdply_y + 2, Thirdply_x] = 4;
                            Thirdply_y += 1;
                            pictureBox_player.Top += (this.Height / 10) - 4;
                            ChangBoxLocation(0, +(this.Width / 10));
                        }
                    }
                    else if (maps[currentMapIndex][Thirdply_y + 1, Thirdply_x] == 4 && maps[currentMapIndex][Thirdply_y + 2, Thirdply_x] == 2)
                    {
                        maps[currentMapIndex][Thirdply_y + 1, Thirdply_x] = 2; maps[currentMapIndex][Thirdply_y + 2, Thirdply_x] = 4;
                        Thirdply_y += 1;
                        pictureBox_player.Top += (this.Height / 10) - 4;
                        ChangBoxLocation(0, +(this.Width / 10));
                    }
                }
                if (maps[currentMapIndex][2, 5] == 4 && maps[currentMapIndex][5, 7] == 4 && maps[currentMapIndex][7, 4] == 4 && maps[currentMapIndex][4, 2] == 4)
                {
                    currentMapIndex += 1;
                    DialogResult result = MessageBox.Show("�O�_�n�h�X?", "���߹L��!!!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }
        public void ChangBoxLocation(int move_x,int move_y) //�P�_���a�O�_�P�c�l��Ĳ
        {
            foreach (Control x in this.Controls) 
            {
                if (x.Tag == "box" && pictureBox_player.Bounds.IntersectsWith(x.Bounds)) 
                {
                    x.Location = new Point(pictureBox_player.Left + move_x, pictureBox_player.Top + move_y);
                }
            }
        }
    }
}
