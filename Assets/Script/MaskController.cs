using UnityEngine;

public class MaskController : MonoSingleton<LevelController>
{
    public bool Mask_1;
    public bool Mask_2;
    public bool Mask_3;

    // Update is called once per frame
    void Update()
    {
        if(Mask_1)
        {
            if(LevelController.Instance.Level_1 && Input.GetKeyDown(KeyCode.A))
            {
                //Ostacolo1
            }
        }
        if (Mask_2)
        {
            if (LevelController.Instance.Level_2 && Input.GetKeyDown(KeyCode.W))
            {
                // Ostacolo2
            }
        }
        if (Mask_3)
        {
            if (LevelController.Instance.Level_3 && Input.GetKeyDown(KeyCode.S))
            {
                //Ostacolo3
            }
        }
    }
}
