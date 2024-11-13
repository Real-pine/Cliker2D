using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatChangeType
{
    Add,
    Multiply,
    Override
}

[System.Serializable]
public class PlayerData
{
    public StatChangeType statChangeType;
    public long gold;
    public long goldPerClick;

}
