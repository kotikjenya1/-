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
    public partial class AddEditForm : Form
    {
        public MusicPiece MusicPiece { get; private set; }
        private IMusicFactory _musicFactory;
        private MusicPiece _existingPiece;
        public AddEditForm(IMusicFactory musicFactory, MusicPiece piece = null)
        {
            InitializeComponent();
            _musicFactory = musicFactory;
            _existingPiece = piece;

            // Заполнение полей формы значениями редактируемого объекта
            if (piece != null)
            {
                txtTitle.Text = piece.Title;
                txtArtist.Text = piece.Artist;
                txtDuration.Text = piece.Duration.ToString();
                if (piece is Song song)
                {
                    txtLyrics.Text = song.Lyrics;
                }
            }

            // Подключение обработчиков событий для кнопок
            btnOK.Click += btnOK_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Создание нового объекта или обновление существующего
            if (_existingPiece == null)
            {
                MusicPiece = _musicFactory.CreateSong(
                    txtTitle.Text,
                    txtArtist.Text,
                    TimeSpan.Parse(txtDuration.Text),
                    txtGenre.Text,
                    txtLyrics.Text);
            }
            else
            {
                // Обновление существующего объекта
                _existingPiece.Title = txtTitle.Text;
                _existingPiece.Artist = txtArtist.Text;
                _existingPiece.Duration = TimeSpan.Parse(txtDuration.Text);
                if (_existingPiece is Song song)
                {
                    song.Lyrics = txtLyrics.Text;
                }
                MusicPiece = _existingPiece;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
