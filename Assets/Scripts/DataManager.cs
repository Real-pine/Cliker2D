using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager instance;

    public static DataManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject datamanagerObject = new GameObject("DataManager");
                instance = datamanagerObject.AddComponent<DataManager>();
                DontDestroyOnLoad(datamanagerObject);
            }
            return instance;
        }
    }
    
    [SerializeField] private PlayerData baseStat;
    public PlayerData CurrentStat { get; private set; } = new PlayerData();
    public List<PlayerData> statModifiers = new List<PlayerData>();

    private readonly int startGoldPerClick = 1;

    public long gold
    {
        get{return CurrentStat.gold;}
        set{CurrentStat.gold = value;}
    }

    public long goldPerClick
    {
        get {return CurrentStat.goldPerClick;}
        set { CurrentStat.goldPerClick = value; }
    }
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        SetGoldPerClick();
    }

    public void SetGoldPerClick()
    {
        goldPerClick = startGoldPerClick;
    }
}
