using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Sno.Scoreboards
{
<<<<<<< Updated upstream
    public class ScoreboardEntryUI : MonoBehaviour
=======
    public class ScoreboardEntryUI
>>>>>>> Stashed changes
    {
        [SerializeField] private TextMeshProUGUI entryNameText = null;
        [SerializeField] private TextMeshProUGUI entryScoreText = null;

        public void Initialise(ScoreboardEntryData scoreboardEntryData)
        {
            entryNameText.text = scoreboardEntryData.entryName;
            entryScoreText.text = scoreboardEntryData.entryScore.ToString();

        }

    }
}
