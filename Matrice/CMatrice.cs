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
    public partial class CMatrice : Form
    {
/*--------------------------------------------------Variables globales------------------------------------------------------------------------------*/
        private double[,] tabDblMatrice;
        private double dDeterminant;
        private int iLigne = 0;
        private int iColonne = 0;

/*--------------------------------------------------Constructeur------------------------------------------------------------------------------*/
        public CMatrice(double [,] Nombres, int iRow, int iColumn)
        {
            InitializeComponent();
            /*Récupération des données reçues décrivant la matrice*/
            iLigne = iRow;
            iColonne = iColumn;
            tabDblMatrice = Nombres;
            /*Affichage de la matrice sur le label*/
            Affichage(tabDblMatrice, iLigne, iColonne);
            Show();
            
        }

/*--------------------------------------------------Affichage de la matrice---------------------------------------------------------------------*/
        public void Affichage(double[,] tabAffiche, int iRow, int iColumn)
        {
            for (int iBcl1 = 0; iBcl1 < iRow; iBcl1++)
            {
                for (int iBcl2 = 0; iBcl2 < iColumn; iBcl2++)
                {
                    labelMatrice.Text = labelMatrice.Text + System.Convert.ToString(tabAffiche[iBcl1, iBcl2]);
                    if (iBcl2 == (iColumn - 1))
                    {
                        labelMatrice.Text = labelMatrice.Text + "\n\n";
                    }
                    else
                    {
                        labelMatrice.Text = labelMatrice.Text + "   ";
                    }
                    }
            }
            
        }

/*--------------------------------------------------Gestion des appuis sur les boutons------------------------------------------------------------*/
        private void On_ClickButton(object sender, EventArgs e)
        {
            
            switch (((Button)sender).Name)
            {
            // Appui sur Inverse = demande de calcul de la matrice inverse (méthode inachevée)
            case "ButtonInverse":
                    /*Calcul de la matrice avec les sous déterminants*/
                        double[,] tabDblMatriceInverse = CMatrice.Inverse(tabDblMatrice, iLigne, iColonne);
                        CMatrice MatriceInverse = new CMatrice(tabDblMatriceInverse, iLigne, iColonne);
                    
                break;

            // Appui sur Transposee = demande de calcul de la transposée de la matrice
            case "ButtonTransposee":
                double[,] tabDblMatriceTransposee = CMatrice.Transposee(tabDblMatrice, iLigne, iColonne);
                CMatrice MatriceTransposee = new CMatrice(tabDblMatriceTransposee, iLigne, iColonne);
                break;

                // Appui sur Transposee = demande de calcul du déterminant de la matrice
            case "ButtonDeterminant":
                
                dDeterminant =  CMatrice.DeterminantGauss(tabDblMatrice, iLigne, iColonne);
                labelDeterminant.Text = "Determinant : " + System.Convert.ToString(dDeterminant);
                
                break;
            }
        }

 /*--------------------------------------------------Methode : Addition de deux matrices----------------------------------------------------------*/
        public static CMatrice Addition(CMatrice mMat1, CMatrice mMat2)
        {
            double[,] tabDblResult = new double[mMat1.iLigne, mMat1.iColonne];
            for (int i = 0; i < mMat1.iLigne; i++)
            {
                for (int j = 0; j < mMat1.iColonne; j++)
                    {
                        /*Addition terme par terme*/
                        tabDblResult[i, j] = (mMat1.tabDblMatrice[i, j]) + (mMat2.tabDblMatrice[i, j]);
                    }
            }

            return new CMatrice(tabDblResult, mMat1.iLigne, mMat1.iColonne);
        }

/*--------------------------------------------------Methode : Soustraction de deux matrices-------------------------------------------------------*/
        public static CMatrice Soustraction(CMatrice mMat1, CMatrice mMat2)
        {
            double[,] tabDblResult = new double[mMat1.iLigne, mMat1.iColonne];
            for (int i = 0; i < mMat1.iLigne; i++)
            {
                for (int j = 0; j < mMat1.iColonne; j++)
                {   /*Soustraction terme par terme*/
                    tabDblResult[i, j] = mMat1.tabDblMatrice[i, j] - mMat2.tabDblMatrice[i, j];
                }
            }

            return new CMatrice(tabDblResult, mMat1.iLigne, mMat1.iColonne);
        }

/*--------------------------------------------------Methode : Multiplication de deux matrices--------------------------------------------------*/
        public static CMatrice Multiplication(CMatrice mMat1, CMatrice mMat2)
        {
            /*La multiplication entre matrice n est possible que si la dimension ligne de la matrice Matrice 1 = la dimension colonne de la matrice Matrice 2 ou l inverse*/
            double[,] tabDblResult = new double[mMat1.iLigne, mMat2.iColonne];

            for(int i = 0;i < mMat1.iLigne;i++) {
                for(int j = 0;j < mMat2.iColonne;j++){
                    for (int k = 0; k < mMat1.iColonne; k++)
                    {   /*h[i,j] = Somme (g[i,k] x f[k,j])  k allant de 1 à n*/
                        tabDblResult[i, j] += (mMat1.tabDblMatrice[i, k]) * (mMat2.tabDblMatrice[k, j]);
                    }
                }
            }
            /*Creation d'une matrice dans les dimensions de la ligne de la matrice 1 et de la colonne de la matrice 2*/
            return new CMatrice(tabDblResult, mMat1.iLigne, mMat2.iColonne);
        }

/*--------------------------------------------------Methode : Multiplication de la matrice par un réel-------------------------------------------*/
        public static CMatrice MultiplicationReel(CMatrice mMat1, double dCoefficient)
        {
            double[,] tabDblResult = new double[mMat1.iLigne, mMat1.iColonne];
            for (int i = 0; i < mMat1.iLigne; i++)
            {
                for (int j = 0; j < mMat1.iColonne; j++)
                {   /*Multiplication de chaque terme de la matrice par le réel*/
                    tabDblResult[i, j] = mMat1.tabDblMatrice[i, j] * dCoefficient;
                }
            }
            return new CMatrice(tabDblResult, mMat1.iLigne, mMat1.iColonne);
        }

/*--------------------------------------------------Methode : Calcul du déterminant de la matrice-------------------------------------------------*/
        public static double DeterminantGauss(double[,] tabMatriceDet, int iLig, int iCol)
        {
            double[,] tabDblCopyMatrice = new double[iLig, iCol];
            /*Clonage de la matrice afin de ne pas la modifier*/
            tabDblCopyMatrice = (double[,])tabMatriceDet.Clone();
            double dDetermi = 0;
            
            /*Matrice carrée d'ordre deux*/
            if ((iLig == 2) && (iCol == 2)){
                dDetermi = tabDblCopyMatrice[0, 0] * tabDblCopyMatrice[1, 1] - tabDblCopyMatrice[1, 0] * tabDblCopyMatrice[0, 1];
                
            }

                /*Matrice d'ordre supérieur*/
            else {
                double dCoefficient = 0;
                for (int i = 0; i < iCol; i++)
                {
                    for (int k = i + 1; k < iCol; k++)
                    {
                        dCoefficient = tabDblCopyMatrice[k, i] / tabDblCopyMatrice[i, i];
                        for (int j = i; j < iCol; j++){
                            /*Reorganisation des termes de la matrice afin de faire apparaitre une symétrie par rapport à la diagonale*/
                            tabDblCopyMatrice[k, j] = tabDblCopyMatrice[k, j] - dCoefficient * tabDblCopyMatrice[i, j];
                        }
                    }
                }
                dDetermi = 1;
                for (int i = 0; i < iCol; i++){
                    /*Déterminant = Multiplication de tous les termes sur la diagonale*/
                    dDetermi *= tabDblCopyMatrice[i, i];
                }
                
            }
            return dDetermi;
        }

/*--------------------------------------------------Methode : Calcul de la matrice inverse-----------------------------------------------------*/

        
        public static double[,] Inverse(double[,] tabMat1, int iRow, int iColumn)
        {
            double[,] tabDblMatricePivot = new double[iRow, iColumn];
            /*Clonage de la matrice afin de ne pas la modifier dans le reste du code*/
            tabDblMatricePivot = (double[,])tabMat1.Clone();
            double[,] tabMatriceIdentite = new double[iRow, iColumn];
            double dPivot = 0;

            /*Creation de la matrice identite*/
                for (int iBcl = 0; iBcl < iRow; iBcl++)
                {
                    for (int iBcl2 = 0; iBcl2 < iColumn; iBcl2++)
                    {
                        if(iBcl == iBcl2){
                            tabMatriceIdentite[iBcl, iBcl2] = 1;
                        }
                        else
                        {
                            tabMatriceIdentite[iBcl, iBcl2] = 0;
                        }
                    }
                }

                /*Ligne pivot*/
                for (int iPivot = 0; iPivot < iRow; iPivot++)
                {
                    int ColonnePivot = 0;
                        /*Recherche du premier terme positif de la ligne pivot*/
                        for (int jPivot = 0; jPivot < iColumn; jPivot++)
                        {
                            if (tabDblMatricePivot[iPivot, jPivot] != 0)
                            {
                                dPivot = tabDblMatricePivot[iPivot, jPivot];
                                /*Memorisation de la colonne du pivot*/
                                ColonnePivot = jPivot;
                                break;
                            }
                        }
                            
                        for (int jColonnesLignePivot = 0; jColonnesLignePivot < iColumn; jColonnesLignePivot++)
                        {                  
                            /*Division de tous les termes de la ligne pivot par le pivot*/
                                tabDblMatricePivot[iPivot, jColonnesLignePivot] = tabDblMatricePivot[iPivot, jColonnesLignePivot] / dPivot;
                                tabMatriceIdentite[iPivot, jColonnesLignePivot] = tabMatriceIdentite[iPivot, jColonnesLignePivot] / dPivot;                        
                        }

                        for (int iInjection = 0; iInjection < iRow; iInjection++)
                        {
                            /*Lignes ou l on doit injecter la ligne pivot*/
                            if(iPivot != iInjection){
                                /*On s assure de ne pas injecter la ligne pivot dans elle meme*/
                                /*On prend le terme de la ligne se trouvant sur la colonne du pivot*/
                                double dCoeffColonnePivot = tabDblMatricePivot[iInjection, ColonnePivot];
                                for (int jInjection = 0; jInjection < iColumn; jInjection++)
                                {
                                    /*On soustrait chaque terme de la ligne par (terme de la ligne sur la meme colonne que le pivot) x (terme de la ligne pivot)*/
                                    tabDblMatricePivot[iInjection, jInjection] = tabDblMatricePivot[iInjection, jInjection] - (dCoeffColonnePivot * tabDblMatricePivot[iPivot, jInjection]);
                                    tabMatriceIdentite[iInjection, jInjection] = tabMatriceIdentite[iInjection, jInjection] - (dCoeffColonnePivot * tabMatriceIdentite[iPivot, jInjection]);
                                
                                    }
                            }
                        }
                    }
            /*La matrice pivot est devenu la matrice identite et la matrice identite est devenu la matrice inverse de la matrice pivot*/
            return tabMatriceIdentite;
        }

/*--------------------------------------------------Methode : Calcul de la transposée de la matrice----------------------------------------------*/
        public static double[,] Transposee(double[,] tabMat1, int iRow, int iColumn)
        {
            double[,] tabDblResult = new double[iRow, iColumn];

            for (int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iColumn; j++)
                {
                    /*Les colonnes deviennent les lignes et les lignes deviennent les colonnes*/
                    tabDblResult[i, j] = tabMat1[j, i];
                }
            }
            return tabDblResult;
        }
        
    }
}
