﻿using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfMovieImageDal:EfEntityRepositoryBase<MovieImage,ETicketsContext>,IMovieImageDal
    {
    }
}
