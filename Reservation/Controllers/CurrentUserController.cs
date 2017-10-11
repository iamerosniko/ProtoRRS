using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Reservation.Controllers
{
    public class CurrentUserController : ApiController
    {
        private string logUser;
        // GET: api/CurrentUser
        public CurrentUser Get()
        {

            string currentDomainUser;
            //Intranet Deployment
            //currentDomainUser = Environment.UserName;
            //
            //Azure Deployment 
            currentDomainUser = HttpContext.Current.User.Identity.Name.ToString();
           
            currentDomainUser = currentDomainUser==null||currentDomainUser.Trim().Equals("") ? "" : currentDomainUser.Substring(0, currentDomainUser.IndexOf('@'));

            CurrentUser cu = new CurrentUser
            {
                id = 1,
                UserName = currentDomainUser
            };

            return cu;
        }

    }
}
