using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [Header("feartures")]
    public GameObject features;
    public GameObject features_Pnael_Close;

    [Header("MRP Price")]
    public GameObject Mrp_price;
 
    [Header("Contact US")]
    public GameObject contact_Us;
    public GameObject contact_Us_Close;

    [Header("Product image gallery")]
    public GameObject Product_Img_Gallery;

    public GameObject info_Panel;                   
   
    public void InfoPanelOpen()
    {
       if(info_Panel != null)
       {
            Animator animator = info_Panel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }

       }
       
    }

    
    public void Features_Info()
    {
        if (features.activeInHierarchy == false)
        {
            features.SetActive(true);
            contact_Us.SetActive(false);
            Product_Img_Gallery.SetActive(false);
            Mrp_price.SetActive(false);  
        }
        else
        {
            features.SetActive(false);
        }
    }

    public void ContactUs_Info()
    {
        if (contact_Us.activeInHierarchy == false)
        {
            features.SetActive(false);
            contact_Us.SetActive(true);
            Product_Img_Gallery.SetActive(false);
            Mrp_price.SetActive(false);  
        }
        else
        {
            contact_Us.SetActive(false);
        }
    }


    public void ProductImgGallery()
    {
        if (Product_Img_Gallery.activeInHierarchy == false)
        {
            Product_Img_Gallery.SetActive(true);
            features.SetActive(false);
            contact_Us.SetActive(false);
            Mrp_price.SetActive(false);
        }
        else
        {
            Product_Img_Gallery.SetActive(false);
        }
    }


    public void MrpPrice() 
    {
        if (Mrp_price.activeInHierarchy == false)
        {
            Mrp_price.SetActive(true);
            features.SetActive(false);
            contact_Us.SetActive(false);
            Product_Img_Gallery.SetActive(false);
        }
        else
        {
            Mrp_price.SetActive(false);
        }
    }

    public void Fetaures_Close()
    {
        if (features_Pnael_Close.activeInHierarchy == true)
        {
            features_Pnael_Close.SetActive(false);
        }
    }


    public void Contact_Us_Close()
    {
        if (contact_Us_Close.activeInHierarchy == true)
        {
            contact_Us_Close.SetActive(false);
        }
    }

    public void MRP_Prrice_Close()
    {
        if (Mrp_price.activeInHierarchy == true)
        {
            Mrp_price.SetActive(false);
        }
    }

    public void ProductGallery_Close()
    {
        if (Product_Img_Gallery.activeInHierarchy == true)
        {
            Product_Img_Gallery.SetActive(false);
        }
    }
}
