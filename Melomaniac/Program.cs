using MusicLibrary;
using MusicLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melomaniac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание фабрики
            IMusicFactory musicFactory = new MusicFactory();

            // Создание песен с использованием фабрики
            Song song1 = musicFactory.CreateSong("Song One", "Artist A", new TimeSpan(0, 3, 45), "Pop", "Some lyrics");
            Song song2 = musicFactory.CreateSong("Song Two", "Artist B", new TimeSpan(0, 4, 10), "Rock", "Some more lyrics");

            // Создание альбома с использованием фабрики
            Album album = musicFactory.CreateAlbum("Album One", "Artist A", new DateTime(2023, 5, 1));

            // Создание менеджера альбома
            AlbumManager albumManager = new AlbumManager();

            // Добавление песен в альбом
            albumManager.AddSongToAlbum(album, song1);
            albumManager.AddSongToAlbum(album, song2);

            // Вычисление общей продолжительности альбома
            TimeSpan albumDuration = albumManager.CalculateAlbumDuration(album);
            Console.WriteLine($"Total duration of the album: {albumDuration}");

            // Вывод деталей альбома
            Console.WriteLine(album.GetDetails());

            // Создание сборного альбома с использованием фабрики
            CompilationAlbum compilation = musicFactory.CreateCompilationAlbum("Compilation One", "Various Artists", new DateTime(2023, 6, 1), "Best of 2023");

            // Добавление тех же песен в сборный альбом
            albumManager.AddSongToAlbum(compilation, song1);
            albumManager.AddSongToAlbum(compilation, song2);

            // Вычисление общей продолжительности сборного альбома
            TimeSpan compilationDuration = albumManager.CalculateAlbumDuration(compilation);
            Console.WriteLine($"Total duration of the compilation album: {compilationDuration}");

            // Вывод деталей сборного альбома
            Console.WriteLine(compilation.GetDetails());
        }
    }
}
