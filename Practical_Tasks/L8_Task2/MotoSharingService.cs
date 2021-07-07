using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_Task2
{
    abstract class MotoSharingService
    {
        public abstract void UserRegistration();
        public abstract void PasswordChange();
        public abstract void MotoRent();
        public abstract void HistoryUpdate();
    }
}
