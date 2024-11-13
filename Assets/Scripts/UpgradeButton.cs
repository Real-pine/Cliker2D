using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class UpgradeButton : MonoBehaviour
    {
        public string upgradeName;
        public TextMeshProUGUI upgradeDisplayer;
        [HideInInspector]
        public int goldPerUpgrade;
        public int baseGoldPerUpgrade;
        [HideInInspector]
        public int currentCost;
        public int startCost = 1;
        public int level = 1;
        
        public float upgradePow = 1.07f;
        public float costPow = 3.14f;
        
        private void Start()
        {
            currentCost = startCost;
            level = 1;
            goldPerUpgrade = baseGoldPerUpgrade;
            UpdateUI();
        }

        public void PurchaseUpgrade()
        {
            if (DataManager.Instance.gold >= currentCost)
            {
                DataManager.Instance.gold -= currentCost;
                level++;
                DataManager.Instance.goldPerClick += goldPerUpgrade;
                
                UpdateUpgrade();
                UpdateUI();
            }
        }

        public void UpdateUpgrade()
        {
            goldPerUpgrade = baseGoldPerUpgrade * (int)Mathf.Pow(upgradePow, level);
            currentCost = startCost * (int)Mathf.Pow(costPow, level);
        }

        public void UpdateUI()
        {
            upgradeDisplayer.text = $"{upgradeName}\nCost: {currentCost}\nLevel: {level}\nNext GoldPerClick: {goldPerUpgrade}";
        }
    }
}