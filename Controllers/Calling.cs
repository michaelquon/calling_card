using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace calling_card
{

    public class CallingController : Controller
    {
        [HttpGet]
        [Route("{FirstName}/{LastName}/{Age}/{FavoriteColor}")]
        public JsonResult callingCard(string FirstName, string LastName, int Age, string FavoriteColor)
        {
            var CardObject = new {
                                    FirstName = FirstName,
                                    LastName = LastName,
                                    Age = Age,
                                    FavoriteColor = FavoriteColor
            };
            return Json(CardObject);
        }
    }
}