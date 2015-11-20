
using odata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace odata.Controllers
{
    [EnableQuery]
    public class UsersController : ODataController
    {
        public IHttpActionResult Get()
        {
            List<User> usersList = new List<User>()
            {
                new User(){UserId = 1, FirstName="Mohamed", LastName="Adel", Address = new Address(){
                    AddressId = 1,
                    BuildingNumber = 27,
                    Street = "Faisal Street"
                }},
                new User(){UserId = 2, FirstName="Yasser", LastName="Hassan", Address = new Address(){
                    AddressId = 2,
                    BuildingNumber = 13,
                    Street = "New town Street"
                }}
            };

            return Ok(usersList.AsQueryable<User>());
        }
    }
}
