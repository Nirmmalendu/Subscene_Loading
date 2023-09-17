using UnityEngine;
using Unity.Entities;
using Unity.Scenes;

public class SubSceneLoader : MonoBehaviour
{
    public SubScene subScene;
    private SceneSystem sceneSystem;

    // Start is called before the first frame update
    void Start()
    {
        sceneSystem = World.DefaultGameObjectInjectionWorld.GetExistingSystem<SceneSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var subSceneEntity = subScene.SceneGUID;
            var subSceneReference = new SceneReference { SceneGUID = subSceneEntity };

            sceneSystem.LoadSceneAsync(subSceneReference);
        }
    }
}

