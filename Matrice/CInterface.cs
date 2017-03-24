using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrice
{
/*--------------------------------------------------Attributs------------------------------------------------------------------------------*/ 
    public partial class CInterface : Form
    {
        // Donnees de la 1e Matrice
        double[,] tabMatrice1;
        CMatrice mMatrice1;
        int iColonneMat1 = 0;
        int iLigneMat1 = 0;
        int iRowMat1 = 0;
        int iColumnMat1 = 0;

        // Donnees de la 2e Matrice
        double[,] tabMatrice2;
        CMatrice mMatrice2;
        int iColonneMat2 = 0;
        int iLigneMat2 = 0;
        int iRowMat2 = 0;
        int iColumnMat2 = 0;

/*--------------------------------------------------Constructeur---------------------------------------------------------------------------*/ 
        public CInterface()
        {
            InitializeComponent();
            this.ValidationMat1.Enabled = false;
            this.ValidationMat2.Enabled = false;
            label1.Hide();
            MessageBox.Show("Donnez les dimensions de la matrice puis saisissez ses éléments en complétant ligne par ligne","Instructions");
        }

/*--------------------------------------------------Méthode de pour le débogage avec le label1-----------------------------------------------------------*/            
        public void AffichageResult(double [,] tabAffiche)
        {
            label1.Show();
            for (int iBcl1 = 0; iBcl1 < iLigneMat1; iBcl1++)
            {
                for (int iBcl2 = 0; iBcl2 < iColonneMat1; iBcl2++)
                {
                    label1.Text = label1.Text + System.Convert.ToString(tabAffiche[iBcl1, iBcl2]);
                    if (iBcl2 == (iColonneMat1 - 1))
                    {
                        label1.Text = label1.Text + "\n\n";
                    }
                    else
                    {
                        label1.Text = label1.Text + "   ";
                    }
                }
            }

        }
/*--------------------------------------------------Méthode de gestion des appuis sur les boutons-------------------------------------------------*/ 
        private void On_ClickButton(object sender, EventArgs e)
        {

            switch (((Button)sender).Name)
            {
                    //Appui sur Mat1 + Mat2
                case "Addition":
                    if ((mMatrice1 != null) && (mMatrice2 != null))
                    {
                        label1.Text = "Addition : ";
                        CMatrice mMatriceAdd = CMatrice.Addition(mMatrice1, mMatrice2);
                    }
                    break;

                    //Appui sur Mat1 - Mat2
                case "Soustraction":
                    if ((mMatrice1 != null) && (mMatrice2 != null))
                    {
                        label1.Text = "Soustraction";
                        CMatrice mMatriceDiff = CMatrice.Soustraction(mMatrice1, mMatrice2);
                    }
                break;

                //Appui sur Mat1 x Mat2
                case "Multiplication":
                    if ((mMatrice1 != null) && (mMatrice2 != null))
                    {
                        label1.Text = "Multiplication";
                        CMatrice mMatriceMulti = CMatrice.Multiplication(mMatrice1, mMatrice2);
                    }
                break;

                //Appui sur Mat1 * k
                case "MultiplicationReel":
                if ((mMatrice1 != null) && ((System.Convert.ToString(textBoxCoeff.Text)) != ""))
                {
                    double dCoeff;
                    dCoeff = System.Convert.ToDouble(textBoxCoeff.Text);
                    label1.Text = "MultiplicationReel";
                    CMatrice mMatriceMultiReel = CMatrice.MultiplicationReel(mMatrice1, dCoeff);
                }
                break;

                //Appui sur Validation Matrice 1 = Remplissage par ligne des éléments de la matrice
                case "ValidationMat1":
                this.label1.Text = System.Convert.ToString(textBoxMat1.Text);
                this.tabMatrice1[iRowMat1, iColumnMat1] = System.Convert.ToDouble(textBoxMat1.Text);
                this.labelNewItemMat1.Text = "Nouvel élément ajouté : " + System.Convert.ToString(tabMatrice1[iRowMat1, iColumnMat1]);

                    //Si la derniere colonne est atteinte 
                    if(iColumnMat1 == (iColonneMat1 - 1)){
                        // Et si la derniere ligne est atteinte
                        if (iRowMat1 == (iLigneMat1 - 1))
                        {   //On cree la matrice
                            iRowMat1 = 0;
                            mMatrice1 = new CMatrice(tabMatrice1, iLigneMat1, iColonneMat1);
                        }

                        // Sinon on change de ligne
                        else
                        {
                            iRowMat1++;
                        }
                        iColumnMat1 = 0;
                    }
                    //Sinon on change de colonne
                    else
                    {   
                        iColumnMat1++;
                    }
                    
                break;

                //Appui sur Validation Matrice 1 = Remplissage par ligne des éléments de la matrice
                case "ValidationMat2":
                this.label1.Text = System.Convert.ToString(textBoxMat2.Text);
                this.tabMatrice2[iRowMat2, iColumnMat2] = System.Convert.ToDouble(textBoxMat2.Text);
                this.labelNewItemMat2.Text = "Nouvel élément ajouté : " + System.Convert.ToString(tabMatrice2[iRowMat2, iColumnMat2]);

                    //Si la derniere colonne est atteinte 
                    if(iColumnMat2 == (iColonneMat2 - 1)){
                        // Et si la derniere ligne est atteinte
                        if (iRowMat2 == (iLigneMat2 - 1))
                        { //On cree la matrice
                            iRowMat2 = 0;
                            mMatrice2 = new CMatrice(tabMatrice2, iLigneMat2, iColonneMat2);
                        }
                        else 
                        {// Sinon on change de ligne
                            iRowMat2++;
                        }
                        iColumnMat2 = 0;
                    }
                    else
                    {   //Sinon on change de colonne
                        iColumnMat2++;
                    }
                    
                break;

                    //Appui sur Validation Parametre Matrice 1 = Validation des dimensions de la matrice 1
                case "ValidationParametreMat1":
                this.label1.Text = System.Convert.ToString(textBoxLigneMat1.Text);
                    //Verifications si les dimensions sont positives
                    if ((System.Convert.ToInt16(textBoxLigneMat1.Text) > 0) || (System.Convert.ToInt16(textBoxColonneMat1.Text) > 0))
                    {
                        this.iLigneMat1 = System.Convert.ToInt16(textBoxLigneMat1.Text);
                        this.iColonneMat1 = System.Convert.ToInt16(textBoxColonneMat1.Text);
                        this.tabMatrice1 = new double[iLigneMat1, iColonneMat1];
                        this.ValidationMat1.Enabled = true;
                    }
                    else { this.ValidationMat2.Enabled = false; }
                break;

                //Appui sur Validation Parametre Matrice 1 = Validation des dimensions de la matrice 2
                case "ValidationParametreMat2":
                this.label1.Text = System.Convert.ToString(textBoxLigneMat2.Text);
                //Verifications si les dimensions sont positives
                    if ((System.Convert.ToInt16(textBoxLigneMat2.Text) > 0) || (System.Convert.ToInt16(textBoxColonneMat2.Text) > 0))
                    {
                        this.iLigneMat2 = System.Convert.ToInt16(textBoxLigneMat2.Text);
                        this.iColonneMat2 = System.Convert.ToInt16(textBoxColonneMat2.Text);
                        this.tabMatrice2 = new double[iLigneMat2, iColonneMat2];
                        this.ValidationMat2.Enabled = true;
                    }
                    else { this.ValidationMat2.Enabled = false; }
                break;
            }
        }

    }
}
