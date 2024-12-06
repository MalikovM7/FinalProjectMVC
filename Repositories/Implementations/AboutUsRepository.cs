﻿using FinalProjectMVC.Data;
using FinalProjectMVC.Models;
using FinalProjectMVC.Repositories.Interfaces;

namespace FinalProjectMVC.Repositories.Implementations
{
    public class AboutUsRepository : BaseRepository<AboutUsViewModel>, IAboutUsRepository
    {

        public AboutUsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
