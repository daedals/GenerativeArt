using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Collections;

using Unity.Transforms;
using Unity.Rendering;

public class Test : MonoBehaviour
{
    [SerializeField] private Mesh mesh;
    [SerializeField] private Material material;


    private void Start()
    {
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        EntityArchetype archetype = entityManager.CreateArchetype(
            typeof(Translation),
            typeof(RenderMesh),
            typeof(LocalToWorld)
        );

        NativeArray<Entity> entities = new NativeArray<Entity>(5, Allocator.Temp);

        entityManager.CreateEntity(archetype, entities);
    }
}
