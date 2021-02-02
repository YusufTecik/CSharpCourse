using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CheckManager : ICheckService
    {
        public bool Check(Gamer gamer)
        {
            bool kullanici = true;
            if (kullanici == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
