﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Gender
  {
    public int GenderId { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
  }
}
