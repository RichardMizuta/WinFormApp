using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WinFormApp1
{
    internal class CEnemy
    {
        public CEnemy(Control owner, Random rand)
        {
            _pbImgEnemy = new PictureBox();
            _enemyOwner = owner;
            _rnd = rand;
            _intMvwd = 10;
            _intMvud = 0;
            _pbImgEnemy.Click += new EventHandler(DoClick);
            _RandPlace();
            _enemyOwner.Controls.Add(_pbImgEnemy);

        }
        //敵の画像
        private PictureBox _pbImgEnemy;
        //敵が出現するオーナー
        private Control _enemyOwner;
        //ランダム変数
        private Random _rnd;
        //敵を倒したときの得点
        private int _intTokuten;
        //敵が動く際の幅
        private int _intMvwd;
        //上下左右に動く
        private int _intMvud;
        //敵のパターン
        private int _intMovePattern;

        public event EventHandler OnClick;
        private void DoClick(object sender, EventArgs e)
        {
            OnClick(this, e);
        }

        private void _RandPlace()
        {
            var intTop = _rnd.Next(_enemyOwner.Size.Height - _pbImgEnemy.Size.Height);
            _pbImgEnemy.Top = intTop;
            var intLeft = _rnd.Next(_enemyOwner.Size.Height - _pbImgEnemy.Size.Height);
            _pbImgEnemy.Left = intLeft;

            _intMovePattern = _rnd.Next(1, 4);
            _pbImgEnemy.SizeMode = PictureBoxSizeMode.AutoSize;

            switch (_intMovePattern)
            {
                case 1:
                    _pbImgEnemy.Image = Image.FromFile("enemy1.gif");
                    _intTokuten = 3000;
                    break;
                case 2:
                    _pbImgEnemy.Image = Image.FromFile("enemy2.gif");
                    _intTokuten = 1000;
                    break;
                case 3:
                    _pbImgEnemy.Image = Image.FromFile("enemy3.gif");
                    _intTokuten = 500;
                    break;
            }
        }
        public void MvEnm()
        {
            switch (_intMovePattern)
            {
                case 1:
                    var intMv = _rnd.Next(1, 5);
                    switch (intMv)
                    {
                        case 1:
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height+_intMvwd) < _enemyOwner.Height)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                            }
                            break;
                        case 2:
                            if ((_pbImgEnemy.Top - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                            }
                            break;
                        case 3:
                            if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvud) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Left += _intMvud;
                            }
                            break;
                        case 4:
                            if ((_pbImgEnemy.Left - _intMvud) > 0)
                            {
                                _pbImgEnemy.Left -= _intMvud;
                            }
                            break;
                    }
                    break;
                case 2:
                    if (_intMvud == 0)
                    {
                        _intMvud = _rnd.Next(1, 5);
                    }
                    switch (_intMvud)
                    {
                        case 1:
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                            } 
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 2:
                            if ((_pbImgEnemy.Top - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 3:
                            if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 4:
                            if ((_pbImgEnemy.Left - _intMvwd) > 0){
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;

                    }
                    break;
                case 3:
                    if (_intMvud == 0)
                    {
                        _intMvud = _rnd.Next(1, 5);
                    }
                    switch (_intMvud)
                    {
                        case 1:
                            //右下に進みたい
                            //if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height)
                            //{
                            //    _pbImgEnemy.Top += _intMvwd;
                            //} 
                            //else
                            //{
                            //    _intMvud = _rnd.Next(1, 5);
                            //}

                            if (((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height) && (_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                           　//右下に進める場合
                            {
                                _pbImgEnemy.Top += _intMvwd;
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else //右下に進めない場合
                            {
                                if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) >= _enemyOwner.Height)
                                //下が引っかかる場合
                                {
                                    _intMvud = 2;//右上に進む
                                }
                                else if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) >= _enemyOwner.Width)
                                //右が引っかかる場合
                                {
                                    _intMvud = 3;//左下に進む
                                }
                                else if (((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) >= _enemyOwner.Height) && ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) >= _enemyOwner.Width))
                                {
                                    //どっちも引っかかる場合　　　　　
                                    _intMvud = 4; //左上に進む
                                }
                            }
                            break;
                        case 2:
                            //右上に進みたい
                            if (((_pbImgEnemy.Top - _intMvwd) > 0) && (_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                           　//右上に進める場合
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else //右上に進めない場合
                            {
                                if ((_pbImgEnemy.Top - _intMvwd) <= 0)
                                //上が引っかかる場合
                                {
                                    _intMvud = 1;//右下に進む
                                }
                                else if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) >= _enemyOwner.Width)
                                //右が引っかかる場合
                                {
                                    _intMvud = 4;//左上に進む
                                }
                                else if (((_pbImgEnemy.Top - _intMvwd) <= 0) && ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) >= _enemyOwner.Width))
                                {
                                    //どっちも引っかかる場合　　　　　
                                    _intMvud = 3; //左下に進む
                                }
                            }
                            break;
                        case 3:
                            //左下に進みたい
                            if (((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height) && ((_pbImgEnemy.Left - _intMvwd) > 0))
                           　//左下に進める場合
                            {
                                _pbImgEnemy.Top += _intMvwd;
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else //左下に進めない場合
                            {
                                if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) >= _enemyOwner.Height)
                                //下が引っかかる場合
                                {
                                    _intMvud = 4;//左上に進む
                                }
                                else if ((_pbImgEnemy.Left - _intMvwd) <= 0)
                                //左が引っかかる場合
                                {
                                    _intMvud = 1;//右下に進む
                                }
                                else if (((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) >= _enemyOwner.Height) && ((_pbImgEnemy.Left - _intMvwd) <= 0))
                                {
                                    //どっちも引っかかる場合　　　　　
                                    _intMvud = 2; //右上に進む
                                }
                            }
                            break;
                        case 4:
                            if (((_pbImgEnemy.Top - _intMvwd) > 0) && ((_pbImgEnemy.Left - _intMvwd) > 0))
                           　//左上に進める場合
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else //左上に進めない場合
                            {
                                if ((_pbImgEnemy.Top - _intMvwd) <= 0)
                                //上が引っかかる場合
                                {
                                    _intMvud = 3;//左下に進む
                                }
                                else if ((_pbImgEnemy.Left - _intMvwd) <= 0)
                                //左が引っかかる場合
                                {
                                    _intMvud = 2;//右上に進む
                                }
                                else if (((_pbImgEnemy.Top - _intMvwd) <= 0) && ((_pbImgEnemy.Left - _intMvwd) <= 0))
                                {
                                    //どっちも引っかかる場合　　　　　
                                    _intMvud = 1; //右下に進む
                                }
                            }
                            break;
                    }
               break;

            }
        }
    }
}
