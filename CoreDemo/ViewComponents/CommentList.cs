using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Begüm"
                },
                new UserComment
                {
                    ID=2,
                    Username="Beril"
                },
                new UserComment
                {
                    ID=3,
                    Username="İlk"
                },

            };
            return View(commentvalues);
        }
    }
}
