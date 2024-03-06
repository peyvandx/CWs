using AppDbContext;
using DTOs;
using Entities;
using IContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class Authentication : IAuthentication
    {
        public bool Login(LoginDTO LoginDto)
        {
            var db = new DefaultDbContext();
            var authResult = db.NewsWriters.FirstOrDefault(nw => nw.Email == LoginDto.Email && nw.Password == LoginDto.Password);
            if (authResult != null)
            {
                OnlineStuff.OnlineNewsWriter = authResult;
                return true;
            } else
            {
                return false;
            }
        }

        public void Register(NewsWriter newsWriter)
        {
            var db = new DefaultDbContext();
            var checkIfNewsWriterExists = db.NewsWriters.FirstOrDefault(nw => nw.Email == newsWriter.Email);
            if (checkIfNewsWriterExists == null )
            {
                //var lastNewsWriter = db.NewsWriters.OrderByDescending(nw => nw.Id).FirstOrDefault();
                //if (lastNewsWriter != null )
                //{
                //    // lazem nist id ra khodeman meghdar dehi konim, choon primary key hast, db khodesh meghdar mide behesh.
                //}
                db.NewsWriters.Add(newsWriter);
                db.SaveChanges();
            }
            else
            {
                // error with register
            }
        }
    }
}
