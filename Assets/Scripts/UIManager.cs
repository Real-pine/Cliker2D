using System;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{
    public class UIManager : MonoBehaviour
    {
        public TextMeshProUGUI goldDisplay;
        public TextMeshProUGUI goldPerClickDisplay;
        public TextMeshProUGUI goldPerSecDisplay;

        private void Update()
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            goldDisplay.text = $"Gold\n{DataManager.Instance.gold}";
            goldPerClickDisplay.text = $"PerClickGold\n{DataManager.Instance.goldPerClick}";
            // goldPerSecDisplay.text = $"Gold Per Sec: {IDataModeController.Instance.GetGoldPerSec()}";

        }
    }
}