using System;
using System.Collections.Generic;

namespace Sno.Scoreboards
{
    [Serializable]
    public class scoreboardsavedata
    {
        public List<ScoreboardEntryData> highscores = new List<ScoreboardEntryData>();
    }
}
