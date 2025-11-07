using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        private int id;
        private string u_ime;
        private string u_geslo;
        private static int stIg = 1;

        public Igralec(Igralec drugi)
        {
            this.u_ime = drugi.u_ime;
            this.u_geslo = drugi.u_geslo;
            this.id = stIg;   
            stIg++;
        }

        public Igralec(string ime)
        {
            this.u_ime = ime.Trim();
            this.u_geslo = "";
            this.id = stIg;
            stIg++;
        }

        //Ustvari novega igralca z začetnimi praznimi podatki
        public Igralec() {
            u_ime = "";   
            u_geslo = "";
            id = stIg;
            stIg++;
        }

		//Omogoča branje ID številke igralca.
        public int Id {
            get
            {
                return id;
            }
        }

		//Omogoča branje in spreminjanje uporabniškega imena.
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

		//Omogoča branje in spreminjanje gesla.
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

		//Vrne trenutno število ustvarjenih igralcev.
        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
