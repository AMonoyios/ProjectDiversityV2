using System.Collections.Generic;
using UnityEngine;

public sealed class StatsList : MonoBehaviour
{
    [SerializeField]
    private StatsScriptableObject statsSO;

    public Dictionary<string, Stat> statsDict;
     
    private void Start()
    {
        statsDict = new Dictionary<string, Stat>();

        foreach (Stat stat in statsSO.statsList)
        {
            statsDict.Add(stat.GetName, stat);
        }
    }

    public void Initialize()
    {
        SaveGameManager.statsLists.Add(this);
    }
}
