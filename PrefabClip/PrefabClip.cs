using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PrefabClip : PlayableAsset
{
    [SerializeField]
    private GameObject prefabA;

    [SerializeField]
    private GameObject prefabB;

    [SerializeField]
    private GameObject prefabC;

    // public override double duration => 1.0;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    {
        return ScriptPlayable<PrefabBehaviour>.Create(graph);
    }
}
