using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///
/// <summary>

public class keybutton : MonoBehaviour
{
    public bool isDown=false;
    public Camera camera;
    public float count = 0;
    public float maxfov = 60f;
    public float minfov = 20f;
    public float[] viewLevel;
    private int index;


    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        //（1）
        //开镜后为匀速开镜变化（类似于pubg）
        //if(Input.GetMouseButtonDown(1))
        //{
        //    isDown = !isDown;
        //}
        
        ////从60~20
        //if (isDown)
        //{
        //    if(camera.fieldOfView > minfov)
        //    camera.fieldOfView -= 1;
        //}
        ////从20~60
        //else
        //{
        //    if (camera.fieldOfView < maxfov)
        //        camera.fieldOfView += 1;
        //}

        //（2）
        //isDown = Input.GetMouseButtonDown(1);//0鼠标左键、1鼠标右键、2鼠标中键或者滚轮
        //直接变化版本（类似csgo开镜）
        //if (isDown)
        //{
        //    this.camera.fieldOfView = 20;
        //    count++;
        //}

        //开镜、关镜的判断（用isDown的bool也行）
        //if(count%2==0)
        //{
        //    this.camera.fieldOfView = 60;
        //}
        //else
        //{
        //    this.camera.fieldOfView = 20;
        //}



        //（3）
        //先快后慢
        //60~20
        //if (isDown)
        //{
        //    camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, 20, 0.01f);
        //    //这个算法导致最后无限接近终点，这个思路可以应用于无限接近
        //    if(Mathf.Abs(camera.fieldOfView-60)<0.1f)
        //    {
        //        camera.fieldOfView = 60;
        //    }
        //}
        ////从20~60
        //else
        //{
        //    camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, 60, 0.01f);
        //    if (Mathf.Abs(camera.fieldOfView - 20) < 0.1f)
        //    {
        //        camera.fieldOfView = 20;
        //    }
        //}


        //(4)
        //可以更改的多次调节倍镜
        if(Input.GetMouseButtonDown(1))
        {
            //index = index < viewLevel.Length - 1 ? index + 1 : 0;
            index = (index + 1) % viewLevel.Length;
        }
        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, viewLevel[index], 0.01f);
        if (Mathf.Abs(camera.fieldOfView - viewLevel[index]) < 0.1f)
        {
            camera.fieldOfView = viewLevel[index];
        }

    }


}
