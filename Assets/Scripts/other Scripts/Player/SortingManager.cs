using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingManager : MonoBehaviour
{
    private static List<SortingTarget> sortingTargets = new List<SortingTarget>();
    public static void RegisterTarget(SortingTarget newTarget)
    {
        if (sortingTargets.Contains(newTarget)) { return; }
        sortingTargets.Add(newTarget);
    }

    public static void DeregisterTarget(SortingTarget target)
    {
        sortingTargets.Remove(target);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        sortingTargets.Sort((target1, target2) => target1.Height().CompareTo(target2.Height()));

        for (int i = 0; i < sortingTargets.Count; i++)
        {
            sortingTargets[i].SetOrder(sortingTargets.Count - i);
        }
    }
}
