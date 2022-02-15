using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAROGAME
{
    public partial class Form1 : Form
    {
        #region Properties
        Chessmanager Chessboard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            
            Chessboard = new Chessmanager(panelchessboard, playername, picturematch);

            Chessboard.EndedGame += ChessBoard_EndedGame;
            Chessboard.PlayerMarked += ChessBoard_PlayerMarked;

            countdown.Step = Constains.COUNT_DOWN_STEP;
            countdown.Maximum = Constains.COUNT_DOWN_TIME;
            countdown.Value = 0;

            tmCountDown.Interval = Constains.COUNT_DOWN_INTERVAL;

            NewGame();
        }
        #region Methods
        void EndGame()
        {
            tmCountDown.Stop();
            panelchessboard.Enabled = false;
        }

        void NewGame()
        {
            countdown.Value = 0;
            tmCountDown.Stop();
            uNDOToolStripMenuItem.Enabled = true;
            Chessboard.Drawchessboard();
        }

        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            Chessboard.Undo();
        }

        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCountDown.Start();
            countdown.Value = 0;
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            countdown.PerformStep();

            if (countdown.Value >= countdown.Maximum)
            {
                EndGame();
            }
        }
        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void uNDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
        #endregion
    }
}
