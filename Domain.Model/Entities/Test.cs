﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace Domain.Model.Entities
{
    [DisplayName("Испытание")]
    public class Test
    {
        [DisplayName("Номер испытания")]
        public int Testno { get; set; }
    }
}
