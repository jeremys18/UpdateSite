﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using update_site.repo;

namespace update_site.Controllers
{
    public abstract class BaseController : Controller
    {
        public SiteRepository  Repo = new SiteRepository();
    }
}
