﻿using BurgerKing_kiosk.model.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BurgerKing_kiosk.viewModel
{
    public class CardViewModel
    {
        CardDB db = new CardDB();
        public bool GetBarcode(String name)
        {
            return db.GetUserBarCode(name);
        }
    }
}
