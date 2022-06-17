using BSWeBtoon.Front.Data;
using BSWeBtoon.Front.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace BSWeBtoon.Front.Controllers
{
    public class MemberLoginController : Controller
    {
        public IActionResult Index()
        {
            List<Member> members = new List<Member>
            {
                new Member { MemberId="A001", MemberName="凍豆腐", CoinQuantity=200 , Login=1,setting=true },
                new Member { MemberId="A002", MemberName="大阪燒", CoinQuantity=0 , Login=2,setting=true },
                new Member { MemberId="A003", MemberName="鹽水雞", CoinQuantity=500 , Login=3,setting=true },
                new Member { MemberId="A004", MemberName="我愛的cp都是真的!", CoinQuantity=1000 , Login=4,setting=true },
                new Member { MemberId="A005", MemberName="一日顏狗，終生顏狗", CoinQuantity=300 , Login=1,setting=true },
                new Member { MemberId="A006", MemberName="叫我大美女", CoinQuantity=400 , Login=2,setting=true },
                new Member { MemberId="A007", MemberName="最帥就是我", CoinQuantity=100 , Login=3,setting=true },
                new Member { MemberId="A008", MemberName="天下王者無雙", CoinQuantity=600 , Login=4,setting=true },
                new Member { MemberId="A009", MemberName="迪特里是我ㄉ小可愛", CoinQuantity=700 , Login=1,setting=true },
            };
            ViewData["Member"] = members;
            return View();
        }
        //public IActionResult List()
        //{
        //    List<Member> members = new List<Member>
        //    {
        //        new Member { MemberId="A001", MemberName="凍豆腐", CoinQuantity=200 , Login=1,setting=true },
        //        new Member { MemberId="A002", MemberName="大阪燒", CoinQuantity=0 , Login=2,setting=true },
        //        new Member { MemberId="A003", MemberName="鹽水雞", CoinQuantity=500 , Login=3,setting=true },
        //        new Member { MemberId="A004", MemberName="我愛的cp都是真的!", CoinQuantity=1000 , Login=4,setting=true },
        //        new Member { MemberId="A005", MemberName="一日顏狗，終生顏狗", CoinQuantity=300 , Login=1,setting=true },
        //        new Member { MemberId="A006", MemberName="叫我大美女", CoinQuantity=400 , Login=2,setting=true },
        //        new Member { MemberId="A007", MemberName="最帥就是我", CoinQuantity=100 , Login=3,setting=true },
        //        new Member { MemberId="A008", MemberName="天下王者無雙", CoinQuantity=600 , Login=4,setting=true },
        //        new Member { MemberId="A009", MemberName="迪特里是我ㄉ小可愛", CoinQuantity=700 , Login=1,setting=true },
        //    };
        //    ViewData["Member"] = members; 
        //    return View();  
        //}
        //public IActionResult ListDB()
        //{
        //    MemberLoginContext context = new MemberLoginContext();

        //    var members = context.Members.ToList();
        //    string json = JsonConvert.SerializeObject(members);
        //    ViewData["jsonMembers"] = json;

        //    return View(); //他原始是Viewresult 但是因為他下面設定的就是Task<IActionResult> 所以就直接寫View

        //}

    }

}
