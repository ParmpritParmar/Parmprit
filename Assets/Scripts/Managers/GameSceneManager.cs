using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public enum sceneID
    {
        StudioSplash,
        IntroComic,
        MainMenu,
        GameScene,
        ArtShowcase,
        CoderIsland,
        DeathComic,
        OutroComic,
        Credits
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadGameScene(int id)
    {
        SceneManager.LoadScene(id);
    }
}
