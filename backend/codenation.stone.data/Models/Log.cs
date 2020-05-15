﻿using System;
using System.Collections.Generic;
using System.Text;

namespace codenation.stone.data.Models
{
    public class Log
    {
        public Guid Id { get; set; }
        public string Level { get; set; }
        public int Events { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public User user{ get; set; }
    }
}
