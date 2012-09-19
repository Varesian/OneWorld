using UnityEngine;
using System.Collections;

public class FadeInOut : MonoBehaviour {

    public Color FadeInColor = new Color(0, 0, 0, 0);
    public Color FadeOutColor = new Color(0, 0, 0, 1);
    public float duration = 3f;
    public CameraFade fader;
    void Start()
    {
        if (!fader){
            fader = GetComponent<CameraFade>();
        }
    }
    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("i"))) {
            fader.StartFade(FadeInColor, duration);
        }
        if (Event.current.Equals(Event.KeyboardEvent("o"))) {
            fader.StartFade(FadeOutColor, duration);
        }
    }
}
