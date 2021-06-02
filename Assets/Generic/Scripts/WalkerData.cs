using Unity.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct WalkerData : IComponentData
{
    public Vector2 Position;
    public bool stuck;
}
