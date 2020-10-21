using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCM
{
    public static class Controleur
    {
        private static Modele vmodele;
        public static Modele Vmodele { get => vmodele; set => vmodele = value; }
        public static void init()
        {
            vmodele = new Modele();
        }
        
        public static Modele getModele()
        {
            return vmodele;
        }

       /* public static Modele setModele()
        {

        }
        */
    }
}
