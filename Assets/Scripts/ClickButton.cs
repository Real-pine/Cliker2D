using UnityEngine;

namespace DefaultNamespace
{
    public class ClickButton : MonoBehaviour
    {
        public DataManager _dataManager;
        public void OnMouseDown()
        {
            DataManager.Instance.gold += DataManager.Instance.goldPerClick;
        }
    }
}