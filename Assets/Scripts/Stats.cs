using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEditor;

using HelperNamespace;

public sealed class Stats : MonoBehaviour
{
    [SerializeField]
    private StatsScriptableObject statsSO;

    public Dictionary<string, Stat> statsDict;

    private void Start()
    {
        statsDict = new Dictionary<string, Stat>();

        foreach (Stat stat in statsSO.statsList)
        {
            statsDict.Add(stat.GetName(), stat);//new Stat(stat.GetName(), stat.GetValue(), stat.GetMinValue(), stat.GetMaxValue()));
        }
    }
}