using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public class WalkerSystem : SystemBase
{
	protected override void OnUpdate()
	{
        Entities.ForEach((ref Translation translation) => {

		});
	}
}
