using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_App
{
    public class UserTask
    {
        public int Id;
        public string DenTask;
        public string TipTask;
        public DateTime DataStart;
        public DateTime DataStop;
        public string DescTask;
    }
    public class Admin
    {
        public int Id;
        public string DenTaskAd;
        public string DescTaskAd;
        public string NrZile;
        public string SevTaskAd;
    }
}
