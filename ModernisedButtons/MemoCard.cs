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
    
    public class MemoCardCountries : Button
    {
        public MemoCountries.MemoObjects? CardObject = null;
        public bool INITIALIZED = false;
        public MemoCardStates State = MemoCardStates.Closed;
        public int Pair;
    }
    public enum MemoCardStates
    {
        Closed,
        Opened,
        Paired
    }

    public class MemoCardColors : Button
    {
        public MemoColors.MemoColorsEnum color;
        public bool INITIALIZED = false;
        public MemoCardStates State = MemoCardStates.Closed;
        public int Pair;
    }
}
