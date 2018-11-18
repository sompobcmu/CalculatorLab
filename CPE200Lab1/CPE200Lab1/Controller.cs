﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CPE200Lab1
{
    class Controller
    {
        protected ArrayList mList;
        public Controller()
        {
            mList = new ArrayList();
        }
        public void AddModel(Model m)
        {
            mList.Add(m);
        }

        public virtual void Calculate(string str)
        {
            throw new NotImplementedException();
        }
        public virtual void isNumber(string str)
        {
            throw new NotImplementedException();
        }
        public virtual void isOperator(string str)
        {
            throw new NotImplementedException();
        }
    }
}
