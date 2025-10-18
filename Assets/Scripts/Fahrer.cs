using UnityEngine;
using TMPro;

public class Fahrer : MonoBehaviour
{
    bool rundenZaehlenErlaubt = true;
    bool inBereich = false;
    int runde = 0;

    readonly float[] rundenzeitStart = new float[3];
    public TextMeshProUGUI[] rundenzeitAnzeige = new TextMeshProUGUI[3];
    void Update()
    {
        if (rundenZaehlenErlaubt)
        {
            if (transform.position.x > 20 && transform.position.x < 30)
            {
                if (transform.position.z > 12 && transform.position.z < 12.5f)
                {
                    inBereich = true;
                }
                else if (inBereich && transform.position.z > 12.5f && transform.position.z < 13)
                {
                    runde++;
                    if (runde > 0 && runde < 4)
                    {
                        rundenzeitStart[runde - 1] = Time.time;
                    }
                    inBereich = false;
                    rundenZaehlenErlaubt = false;
                    Invoke(nameof(RundenZaehlenErlauben), 10);
                }
            }
        }

        if (runde > 0 && runde < 4)
        {
            rundenzeitAnzeige[runde - 1].text = string.Format("Runde{0,2:0}: {1,6:0.0} sec.", runde, Time.time - rundenzeitStart[runde - 1]);
        }
    }

    void RundenZaehlenErlauben()
    {
        rundenZaehlenErlaubt = true;
    }
}
