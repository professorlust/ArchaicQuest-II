﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchaicQuestII.Core.Item
{
    public class Money
    {
        public int Amount { get; set; }
        public Description Description { get; set; }
    }

    public class Gold: Money
    {
        public Gold()
        {
            Description = new Description()
            {
                Look = "A gold coin.",
                Exam = "A gold coin.",
                Room = "A gold coin."
            };
        }
    }
}
