﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain
{
    public class Image
    {
        public int Id { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
