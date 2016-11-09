using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        // store
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }
        // store/Details?albumid=id
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }

        // store/browse?genre=genre
        public ActionResult Browse(string genre)
        {
            if (genre != null)
            {
                var genreModel = new Genre();
                genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
                return View(genreModel);

            }
            else
            {
                var genreModel = storeDB.Genres.ToList<Genre>();
                return View(genreModel);
            }

            
        }

        // get: /store/genremenu
        public ActionResult GenreMenu()
        {
            var genreMenu = storeDB.Genres.ToList();
            return PartialView(genreMenu);
        }
    }
}