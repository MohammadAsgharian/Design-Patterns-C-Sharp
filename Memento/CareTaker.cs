﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CareTaker
    {
        Memento memento;
        public Memento Memento
        {
            get { return memento; }
            set
            {
                memento = value;
            }
        }
    }
}
