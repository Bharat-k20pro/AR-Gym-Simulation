using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObj : MonoBehaviour
{
    public GameObject dumbell1, dumbell2, barbell, overHeadBarbell;
    public Transform parent1;
    // Start is called before the first frame update
    void Start()
    {
        // if (cajb1 != null)
        // {
        //     cajb1OriginalPosition = cajb1.transform.position;
        //     cajb1OriginalRotation = cajb1.transform.rotation;
        // }
    }

    public void onPickUpDumbell1()
    {
        if (dumbell1 != null)
        {
            // Vector3 distance = dumbell1.transform.position - bodyType1.transform.position;
            // float magnitude = distance.magnitude;

            // if (magnitude <= 0.9f)
            // {
            // dumbell1.transform.SetParent(parent1);
            // dumbell1.transform.localPosition = Vector3.zero;
            // dumbell1.transform.rotation = Quaternion.identity;
            // }
            dumbell1.gameObject.SetActive(true);
        }
    }

    public void onPickUpDumbell2()
    {
        if (dumbell2 != null)
        {
            // Vector3 distance = dumbell1.transform.position - bodyType1.transform.position;
            // float magnitude = distance.magnitude;

            // if (magnitude <= 0.9f)
            // {
            // dumbell2.transform.SetParent(parent2);
            // dumbell2.transform.localPosition = Vector3.zero;
            // dumbell2.transform.rotation = Quaternion.identity;
            // }
            dumbell2.gameObject.SetActive(true);
        }
    }

    public void onPickUpBarbell()
    {
        if (barbell != null)
        {
            // Vector3 distance = dumbell1.transform.position - bodyType1.transform.position;
            // float magnitude = distance.magnitude;

            // if (magnitude <= 0.9f)
            // {
            // barbell.transform.SetParent(parent3);
            // barbell.transform.localPosition = Vector3.zero;
            // // barbell.transform.rotation = Quaternion.identity;
            // barbell.transform.Rotate(-72.72f, 78.86f, 12.232f);
            // }
            barbell.gameObject.SetActive(true);
        }
    }

    public void onPickUpOverHeadBarbell()
    {
        if (overHeadBarbell != null)
        {
            overHeadBarbell.gameObject.SetActive(true);
        }
    }

    // public void onPickUpcajb1()
    // {
    //     cajb1.transform.SetParent(parent1);
    //     cajb1.transform.localPosition = Vector3.zero;
    // }

    // public void setActiveCajb()
    // {
    //     cajb1.gameObject.SetActive(true);
    // }

    // public void setUnActiveCajb()
    // {
    //     cajb1.gameObject.SetActive(false);
    // }

    // public void onPickUpcajb2()
    // {
    //     cajb2.transform.SetParent(parent2);
    //     cajb2.transform.localPosition = Vector3.zero;
    // }

    public void onDropDumbell1()
    {
        if (dumbell1 != null)
        {
            dumbell1.gameObject.SetActive(false);
        }
    }

    public void onDropDumbell2()
    {
        if (dumbell2 != null)
        {
            // dumbell2.transform.parent = null;
            // dumbell2.transform.position = objectOriginalPosition2;
            // dumbell2.transform.rotation = objectOriginalRotation2;
            dumbell2.gameObject.SetActive(false);
        }
    }

    public void onDropBarbell()
    {
        if (barbell != null)
        {
            // barbell.transform.parent = null;
            // barbell.transform.position = objectOriginalPosition3;
            // barbell.transform.rotation = objectOriginalRotation3;
            barbell.gameObject.SetActive(false);
        }
    }

    public void onDropOverHeadBarbell()
    {
        if (overHeadBarbell != null)
        {
            overHeadBarbell.gameObject.SetActive(false);
        }
    }

    // public void onDropCajb1()
    // {
    //     if (cajb1 != null)
    //     {
    //         cajb1.transform.parent = null;
    //         cajb1.transform.position = cajb1OriginalPosition;
    //         cajb1.transform.rotation = cajb1OriginalRotation;
    //     }
    // }

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            this.gameObject.GetComponent<Animator>().Play("Warrior Idle");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 1)
        {
            this.gameObject.GetComponent<Animator>().Play("Burpee");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 2)
        {
            this.gameObject.GetComponent<Animator>().Play("Air Squat Bent Arms");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 3)
        {
            this.gameObject.GetComponent<Animator>().Play("Air Squat");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 4)
        {
            this.gameObject.GetComponent<Animator>().Play("Back Squat");
            onDropDumbell1();
            onDropDumbell2();
            onPickUpBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 5)
        {
            this.gameObject.GetComponent<Animator>().Play("Bicep Curl 0");
            onPickUpDumbell1();
            onPickUpDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 6)
        {
            this.gameObject.GetComponent<Animator>().Play("Front Raises");
            onPickUpDumbell1();
            onPickUpDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 7)
        {
            this.gameObject.GetComponent<Animator>().Play("Overhead Squat");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onPickUpOverHeadBarbell();
        }
        if (val == 8)
        {
            this.gameObject.GetComponent<Animator>().Play("Pistol");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 9)
        {
            this.gameObject.GetComponent<Animator>().Play("Snatch");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 10)
        {
            this.gameObject.GetComponent<Animator>().Play("Snatch (1)");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 11)
        {
            this.gameObject.GetComponent<Animator>().Play("Sumo High Pull");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
        }
        if (val == 12)
        {
            this.gameObject.GetComponent<Animator>().Play("Clean And Jerk 0");
            onDropDumbell1();
            onDropDumbell2();
            onDropBarbell();
            onDropOverHeadBarbell();
            // onPickUpcajb1();
            // onPickUpcajb2();
        }
    }
}
