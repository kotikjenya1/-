using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicLibrary;
using MusicLibrary.Logic;

namespace MusicAppWinForms
{
    public partial class Form1 : Form
    {
        private AlbumManager _albumManager;
        private IMusicFactory _musicFactory;

        public Form1()
        {
            InitializeComponent();
            _albumManager = new AlbumManager();
            _musicFactory = new MusicFactory();
            UpdateTotalDuration();

            // Подключение событий для кнопок
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddEditForm(_musicFactory))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    lstMusicItems.Items.Add(addForm.MusicPiece);
                    UpdateTotalDuration();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstMusicItems.SelectedItem != null)
            {
                using (var editForm = new AddEditForm(_musicFactory, (MusicPiece)lstMusicItems.SelectedItem))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        lstMusicItems.Items[lstMusicItems.SelectedIndex] = editForm.MusicPiece;
                        UpdateTotalDuration();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstMusicItems.SelectedItem != null)
            {
                lstMusicItems.Items.Remove(lstMusicItems.SelectedItem);
                UpdateTotalDuration();
            }
        }
        private void UpdateTotalDuration()
        {
            TimeSpan totalDuration = new TimeSpan();
            foreach (var item in lstMusicItems.Items)
            {
                if (item is MusicPiece piece)
                {
                    totalDuration += piece.Duration;
                }
            }
            lblTotalDuration.Text = $"Total Duration: {totalDuration}";
        }
    }
}