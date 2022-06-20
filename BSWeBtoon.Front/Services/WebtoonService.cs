using BSWeBtoon.Front.Data;
using BSWeBtoon.Front.ViewModel;
using Mvcdemo.Model.Models;
using Mvcdemo.Model.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BSWeBtoon.Front.Services
{
    public class WebtoonService
    {
        //private readonly WebtoonContext context;

        private readonly CRUD_data repository;

        public WebtoonService(CRUD_data repository)
        {
            this.repository = repository;
            //context = new WebtoonContext();
        }
        public IEnumerable<WeekViewModel> ReadComic()
        {
            var repository = new CRUD_data(new BSWeBtoonContext());
            foreach (var item in repository.GetAll<Comic>().OrderBy((x) => x.LaunchDate))
            {
                yield return new WeekViewModel()
                {
                    ComicId=item.ComicId,
                    ComicName=item.ComicName,
                    ComicStatus=item.ComicStatus,
                    PeoplePic=item.PeoplePic,
                    NamePic=item.NamePic,
                    BgPic=item.BgPic,
                    Introduction=item.Introduction,
                    LaunchDate=item.LaunchDate,
                };
            }

            //foreach (var item in repository.GetAll<Product>().OrderBy((x) => x.PartNo))
            //{
            //    yield return new ProductViewModel()
            //    {
            //        PartNo = item.PartNo,
            //        PartName = item.PartName
            //    };
            //}
            //List<Comic> comicList = new List<Comic>();
            //using (BSWeBtoonContext context = new BSWeBtoonContext())
            //{
            //    comicList = context.Comics.ToList();


            //}
            //foreach (var c in comicList)
            //{
            //    var comicID = c.ComicId;
            //    var peoplePic = c.PeoplePic;
            //    var bgcPic = c.BgPic;
            //    var namePic = c.NamePic;
            //    var introduction = c.Introduction;
            //    var launcgDate = c.LaunchDate;
            //}



        }






        //static void CreateComic()
        //{
        //    List<Comic> comicList = new List<Comic>();
        //    using(BSWeBtoonContext context=new BSWeBtoonContext())
        //    {
        //        comicList = context.Comics.ToList();
        //    }

        //    foreach(var c in comicList)
        //    {
        //        var comicID = c.ComicId ;
        //        var peoplePic = c.PeoplePic;
        //        var bgcPic = c.BgPic;
        //        var namePic = c.NamePic;
        //        var introduction = c.Introduction;
        //        var launcgDate = c.LaunchDate;
        //    }
        //}

    }
}
