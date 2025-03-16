using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Sprite heart1, heart2, heart3;
    private Sprite heartFull, heratEmpty;

    public Text livePlayerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateLifeCount();
    }
    
    void Awake()
    {
        instance=this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateItemCount(){
        // livePlayer.text= .ToString()
    }

    public void UpdateLifeCount(){
        // livePlayerText.text= .ToString()
    }
}
