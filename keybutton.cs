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
        //��1��
        //������Ϊ���ٿ����仯��������pubg��
        //if(Input.GetMouseButtonDown(1))
        //{
        //    isDown = !isDown;
        //}
        
        ////��60~20
        //if (isDown)
        //{
        //    if(camera.fieldOfView > minfov)
        //    camera.fieldOfView -= 1;
        //}
        ////��20~60
        //else
        //{
        //    if (camera.fieldOfView < maxfov)
        //        camera.fieldOfView += 1;
        //}

        //��2��
        //isDown = Input.GetMouseButtonDown(1);//0��������1����Ҽ���2����м����߹���
        //ֱ�ӱ仯�汾������csgo������
        //if (isDown)
        //{
        //    this.camera.fieldOfView = 20;
        //    count++;
        //}

        //�������ؾ����жϣ���isDown��boolҲ�У�
        //if(count%2==0)
        //{
        //    this.camera.fieldOfView = 60;
        //}
        //else
        //{
        //    this.camera.fieldOfView = 20;
        //}



        //��3��
        //�ȿ����
        //60~20
        //if (isDown)
        //{
        //    camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, 20, 0.01f);
        //    //����㷨����������޽ӽ��յ㣬���˼·����Ӧ�������޽ӽ�
        //    if(Mathf.Abs(camera.fieldOfView-60)<0.1f)
        //    {
        //        camera.fieldOfView = 60;
        //    }
        //}
        ////��20~60
        //else
        //{
        //    camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, 60, 0.01f);
        //    if (Mathf.Abs(camera.fieldOfView - 20) < 0.1f)
        //    {
        //        camera.fieldOfView = 20;
        //    }
        //}


        //(4)
        //���Ը��ĵĶ�ε��ڱ���
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
