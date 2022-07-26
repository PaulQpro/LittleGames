using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleGames.Games;

namespace LittleGames
{
    
    public partial class MemoCard : Button
    {
        public enum MemoCardStates
        {
            Closed,
            Opened,
            Paired
        }
        public MemoCountries.MemoObjects? CardObject = null;
        public bool INITIALIZED = false;
        public MemoCardStates State = MemoCardStates.Closed;
    }
}
