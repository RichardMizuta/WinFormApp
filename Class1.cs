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
            var intLeft = _rnd.Next(_enemyOwner.Size.Height - _-_pbImgEnemy.Size.Height);
            _pbImgEnemy.Left = intLeft;

            _intMovePattern = _rnd.Next(1, 4);
            _pbImgEnemy.SizeMode = PictureBoxSizeMode.AutoSize;

            switch (_intMovePattern)
            {
                case 1:
                    _pbImgEnemy.Image = Image.FromFile("enemy1.gif");
                    _intTokuten = 500;
                    break;
                case 2:
                    _pbImgEnemy.Image = Image.FromFile("enemy1.gif");
                    _intTokuten = 500;
                    break;
                case 3:
                    _pbImgEnemy.Image = Image.FromFile("enemy1.gif");
                    _intTokuten = 500;
                    break;
            }

        }
    }
}
