﻿using Caliburn.Micro;
using EyeNurse.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeNurse.Client.ViewModels
{
    public class LockScreenViewModel : Screen
    {
        EyeNurseService _services;
        public LockScreenViewModel(EyeNurseService servcies)
        {
            _services = servcies;
        }

        #region properties

        public EyeNurseService Services => _services;

        #endregion

        #region public methods

        public void Exit()
        {
            TryClose();
        }
        #endregion
    }
}
