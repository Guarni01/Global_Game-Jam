using UnityEngine;

public class MaskController : MonoSingleton<LevelController>
{
    public bool Mask_1;
    public bool Mask_2;
    public bool Mask_3;

    // Update is called once per frame
    void Update()
    {
        if (LevelController.Instance.Level_1 && Input.GetKeyDown(KeyCode.A)) //PickMask1
        {
            Mask_1 = !Mask_1;
        }
        if (LevelController.Instance.Level_2 && Input.GetKeyDown(KeyCode.S)) //PickMask2
        {
            Mask_2 = !Mask_2;
        }
        if (LevelController.Instance.Level_3 && Input.GetKeyDown(KeyCode.D)) //PickMask3
        {
            Mask_3 = !Mask_3;
        }
        if (Mask_1)
        {
            
            //GameObject.SetActive(true);
        }
        if (Mask_2)
        {
            //GameObject.SetActive(true);
        }
        if (Mask_3)
        {
            //GameObject.SetActive(true);
        }


    }
}
