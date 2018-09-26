using System;
using System.Threading;

namespace Black
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finJeuBJ = false;
            int gagnant = 0;
            int carte1Joueur = 0;
            int carte2Joueur = 0;
            int carte1IA = 0;
            int carte2IA = 0;
            int carte3IA = 0;
            int carte4IA = 0;
            int carte5IA = 0;
            int carte6IA = 0;
            bool finJeuB = false;
            bool finPioche = false;
            int pioche = 0;
            double jetons = 100;
            double modif = 0;
            string sorte1Joueur = "aaa";
            string sorte2Joueur = "aaa";
            string sorte1IA = "aaa";
            string sorte2IA = "aaa";
            string sorte3IA = "aaa";
            string sorte4IA = "aaa";
            string sorte5IA = "aaa";
            string sorte6IA = "aaa";
            int choix = 0;
            int start = 0;
            int carteD = 0;
            int points = 0;
            string sorte3Joueur = "aaa";
            string sorte4Joueur = "aaa";
            string sorte5Joueur = "aaa";
            string sorte6Joueur = "aaa";
            int carte3Joueur = 0;
            int carte4Joueur = 0;
            int carte5Joueur = 0;
            int carte6Joueur = 0;
            //points des cartes
            int carte1JoueurP = 0;
            int carte2JoueurP = 0;
            int carte3JoueurP = 0;
            int carte4JoueurP = 0;
            int carte5JoueurP = 0;
            int carte6JoueurP = 0;
            int carte1IAP = 0;
            int carte2IAP = 0;
            int carte3IAP = 0;
            int carte4IAP = 0;
            int carte5IAP = 0;
            int carte6IAP = 0;
            int aaa = 0;
            int pointsP = 0;
            int nombreCarteC = 2;
            bool fin = false;
            int triche = 0;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();





            // nombre de la carte
            int prendreCarte()
            {
                Random carte = new Random();
                int carteFinal = carte.Next(1, 14);
                return carteFinal;
            }

            //pointage des cartes
            int pointage(int carteY, int pointsY)
            {
                if (carteY == 1)
                {
                    pointsY = 11;
                }
                else if (carteY >= 10)
                {
                    pointsY = 10;
                }
                else
                {
                    pointsY = carteY;
                }
                return pointsY;
            }


            // classe de la carte
            string sorteCarte()
            {
                Random sorte = new Random();
                int sorteFinal = sorte.Next(1, 5);
                string classe = ("sorte");
                if (sorteFinal == 1)
                {
                    classe = "coeur";
                }
                else if (sorteFinal == 2)
                {
                    classe = "pique";
                }
                else if (sorteFinal == 3)
                {
                    classe = "trefle";
                }
                else if (sorteFinal == 4)
                {
                    classe = "carreaux";
                }
                return classe;
            }


            //entrée du casino
            while (fin == false)
            {
                Console.WriteLine("Bienvenue au casino, voulez-vous jouer au blackjack ou savoir les regles du blackjack ?");
                Console.WriteLine("");
                Console.WriteLine("1-Jouer au blackjack");
                Console.WriteLine("");
                Console.WriteLine("2-Apprendre les regles du blackjack");
                Console.WriteLine("");
                choix = Convert.ToInt32(Console.ReadLine());


                //reglement BJ
                if (choix == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vous commencez avec 100 jetons, le but est d'en avoir 200 jetons.");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Lorsque vous battez le croupier vous gagnez 1,5x des jetons que vous aviez parrier.");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Si vous perdez l'échange vous perdez vos jetons, lorsque vous atteignez 0 jetons vous avez perdus");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Le but d'un échange est d'avoir en dessous de 21 points mais avoir plus de points que le croupier");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Lors de votre tour le croupier vous donnera 2 carte et vous verez une de ses cartes");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Vous aurez le choix de piochez autant de carte que vous voulez pour atteidre le nombre de points désirez");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("1- pour commencer a jouer");
                    start = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bonne chance");
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    Console.WriteLine("");

                }
                // jeu BJ
                else if (choix == 1)
                {
                    while (finJeuBJ == false)
                    {


                        Console.Clear();
                        Console.WriteLine("Veuiller entrer le nombre de jetons a parrier, vous en avez " + jetons);
                        Console.WriteLine("");
                        modif = Convert.ToInt32(Console.ReadLine());
                        if (modif > jetons)
                        {
                            triche = 1;
                        }
                        Console.WriteLine("");
                        jetons = jetons - modif;
                        Thread.Sleep(2000);
                        carte1Joueur = prendreCarte();
                        sorte1Joueur = sorteCarte();
                        Console.WriteLine("Votre premiere carte est un " + carte1Joueur + " de " + sorte1Joueur);
                        Console.WriteLine("");
                        Thread.Sleep(2000);
                        carte1JoueurP = pointage(carte1Joueur, aaa);
                        carte2Joueur = prendreCarte();
                        sorte2Joueur = sorteCarte();
                        Console.WriteLine("Votre deuxieme carte est un " + carte2Joueur + " de " + sorte2Joueur);
                        carte2JoueurP = pointage(carte2Joueur, aaa);
                        Console.WriteLine("");
                        Thread.Sleep(2000);
                        carte1IA = prendreCarte();
                        sorte1IA = sorteCarte();
                        carte2IA = prendreCarte();
                        sorte2IA = sorteCarte();
                        points = carte2JoueurP + carte1JoueurP + carte3JoueurP + carte4JoueurP + carte5JoueurP + carte6JoueurP;
                        Console.WriteLine("La premiere carte du croupier est un " + carte1IA + " de " + sorte1IA);
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("Voulez-vous prendre une autre carte ou rester comme ca ?");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("Vous avez actuellement " + points + " points");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("1- prendre une autre carte");
                        Console.WriteLine("");
                        Console.WriteLine("2- rester comme ca");

                        Console.WriteLine("");
                        carteD = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        if (carteD == 1)
                        {

                            carte3Joueur = prendreCarte();
                            sorte3Joueur = sorteCarte();
                            Console.WriteLine("Votre troisieme carte est un " + carte3Joueur + " de " + sorte3Joueur);
                            carte3JoueurP = pointage(carte3Joueur, aaa);
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            points = carte2JoueurP + carte1JoueurP + carte3JoueurP + carte4JoueurP + carte5JoueurP + carte6JoueurP;
                            Console.WriteLine("Vous avez actuellement " + points + " points");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            Console.WriteLine("Voulez-vous prendre une autre carte ou rester comme ca ?");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            Console.WriteLine("1- prendre une autre carte");
                            Console.WriteLine("");
                            Console.WriteLine("2- rester comme ca");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            pioche = Convert.ToInt32(Console.ReadLine());
                            if (pioche == 2)
                            {
                                carteD = 2;
                            }
                            else if (pioche == 1)
                            {
                                carte4Joueur = prendreCarte();
                                sorte4Joueur = sorteCarte();
                                Console.WriteLine("Votre quatrieme carte est un " + carte4Joueur + " de " + sorte4Joueur);
                                carte4JoueurP = pointage(carte4Joueur, aaa);
                                Thread.Sleep(2000);
                                Console.WriteLine("");
                                points = carte2JoueurP + carte1JoueurP + carte3JoueurP + carte4JoueurP + carte5JoueurP + carte6JoueurP;
                                Console.WriteLine("Vous avez actuellement " + points + " points");
                                Thread.Sleep(2000);
                                Console.WriteLine("");
                                Console.WriteLine("Voulez-vous prendre une autre carte ou rester comme ca ?");
                                Thread.Sleep(2000);
                                Console.WriteLine("");
                                Console.WriteLine("1- prendre une autre carte");
                                Console.WriteLine("");
                                Console.WriteLine("2- rester comme ca");
                                Thread.Sleep(2000);
                                Console.WriteLine("");
                                pioche = Convert.ToInt32(Console.ReadLine());
                                if (pioche == 2)
                                {
                                    carteD = 2;
                                }
                                else if (pioche == 1)
                                {
                                    carte5Joueur = prendreCarte();
                                    sorte5Joueur = sorteCarte();
                                    Console.WriteLine("Votre cinquieme carte est un " + carte5Joueur + " de " + sorte5Joueur);
                                    carte5JoueurP = pointage(carte5Joueur, aaa);
                                    Thread.Sleep(2000);
                                    Console.WriteLine("");
                                    points = carte2JoueurP + carte1JoueurP + carte3JoueurP + carte4JoueurP + carte5JoueurP + carte6JoueurP;
                                    Console.WriteLine("Vous avez actuellement " + points + " points");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("");
                                    Console.WriteLine("Voulez-vous prendre une autre carte ou rester comme ca ?");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("");
                                    Console.WriteLine("1- prendre une autre carte");
                                    Console.WriteLine("");
                                    Console.WriteLine("2- rester comme ca");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("");
                                    pioche = Convert.ToInt32(Console.ReadLine());
                                    if (pioche == 2)
                                    {
                                        carteD = 2;
                                    }
                                    else if (pioche == 1)
                                    {
                                        carte6Joueur = prendreCarte();
                                        sorte6Joueur = sorteCarte();
                                        Console.WriteLine("Votre sixieme carte est un " + carte6Joueur + " de " + sorte6Joueur);
                                        carte6JoueurP = pointage(carte6Joueur, aaa);
                                        Thread.Sleep(2000);
                                        Console.WriteLine("");
                                        points = carte2JoueurP + carte1JoueurP + carte3JoueurP + carte4JoueurP + carte5JoueurP + carte6JoueurP;
                                        Console.WriteLine("Vous avez actuellement " + points + " points");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous avez accumuler le nombre maximal de cartes ");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("");


                                    }

                                }

                            }


                        }
                        Console.Clear();
                        Console.WriteLine("C'est maintenant au tour du croupier");
                        carte1IAP = pointage(carte1IA, aaa);
                        carte2IAP = pointage(carte2IA, aaa);
                        pointsP = carte2IAP + carte1IAP + carte3IAP + carte4IAP + carte5IAP + carte6IAP;
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        if (pointsP <= 16)
                        {
                            Console.WriteLine("Le croupier prend une autre carte");
                            carte3IA = prendreCarte();
                            sorte3IA = sorteCarte();
                            carte3IAP = pointage(carte3IA, aaa);
                            pointsP = carte2IAP + carte1IAP + carte3IAP + carte4IAP + carte5IAP + carte6IAP;
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            nombreCarteC = 3;
                            if (pointsP <= 16)
                            {
                                Console.WriteLine("Le croupier prend une autre carte");
                                carte4IA = prendreCarte();
                                sorte4IA = sorteCarte();
                                carte4IAP = pointage(carte4IA, aaa);
                                pointsP = carte2IAP + carte1IAP + carte3IAP + carte4IAP + carte5IAP + carte6IAP;
                                Thread.Sleep(2000);
                                Console.WriteLine("");
                                nombreCarteC = 4;
                                if (pointsP <= 16)
                                {
                                    Console.WriteLine("Le croupier prend une autre carte");
                                    carte5IA = prendreCarte();
                                    sorte5IA = sorteCarte();
                                    carte5IAP = pointage(carte5IA, aaa);
                                    pointsP = carte2IAP + carte1IAP + carte3IAP + carte4IAP + carte5IAP + carte6IAP;
                                    Thread.Sleep(2000);
                                    Console.WriteLine("");
                                    nombreCarteC = 5;
                                    if (pointsP <= 16)
                                    {
                                        Console.WriteLine("Le croupier prend une autre carte");
                                        carte6IA = prendreCarte();
                                        sorte6IA = sorteCarte();
                                        carte6IAP = pointage(carte6IA, aaa);
                                        pointsP = carte2IAP + carte1IAP + carte3IAP + carte4IAP + carte5IAP + carte6IAP;
                                        Thread.Sleep(2000);
                                        Console.WriteLine("");
                                        nombreCarteC = 6;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Le croupier arrete de prendre des cartes");
                        pointsP = carte2IAP + carte1IAP + carte3IAP + carte4IAP + carte5IAP + carte6IAP;
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        if (triche == 1)
                        {
                            pointsP = 21;
                        }
                        Console.WriteLine("Il compte ces cartes et déclare qu'il a " + pointsP + " points");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("La premiere carte du croupier est un " + carte1IA + " de " + sorte1IA);
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("Sa deuxieme carte est un " + carte2IA + " de " + sorte2IA);
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        if (nombreCarteC >= 3)
                        {
                            Console.WriteLine("Sa troisieme carte est un " + carte3IA + " de " + sorte3IA);
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            if (nombreCarteC >= 4)
                            {
                                Console.WriteLine("Sa  quatrieme carte est un " + carte4IA + " de " + sorte4IA);
                                Thread.Sleep(2000);
                                Console.WriteLine("");
                                if (nombreCarteC >= 5)
                                {
                                    Console.WriteLine("Sa cinquieme carte est un " + carte5IA + " de " + sorte5IA);
                                    Thread.Sleep(2000);
                                    Console.WriteLine("");
                                    if (nombreCarteC >= 6)
                                    {
                                        Console.WriteLine("Sa sixieme carte est un " + carte6IA + " de " + sorte6IA);
                                        Thread.Sleep(2000);
                                        Console.WriteLine("");
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Vous avez " + points + " points");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("Et le croupier a " + pointsP + " points");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        nombreCarteC = 0;
                        carte1JoueurP = 0;
                        carte2JoueurP = 0;
                        carte3JoueurP = 0;
                        carte4JoueurP = 0;
                        carte5JoueurP = 0;
                        carte6JoueurP = 0;
                        carte1IAP = 0;
                        carte2IAP = 0;
                        carte3IAP = 0;
                        carte4IAP = 0;
                        carte5IAP = 0;
                        carte6IAP = 0;
                        gagnant = points - pointsP;
                        if (triche == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("C'est ce qui arrive lorsque l'on triche");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            Console.WriteLine("Le croupier prend tout vos jetons et les garde");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            Console.WriteLine("Il appelle ensuite les gardes qui vous poussent dehors");
                            Thread.Sleep(10000);
                            Console.WriteLine("");
                            Environment.Exit(-1);
                        }
                        else if (points >= 22)
                        {
                            Console.WriteLine("Vous avez dépassez la limite et perdez votre mise");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                        }
                        else if (pointsP >= 22)
                        {
                            Console.WriteLine("Le croupier a dépasser la limite et vous gagnez 1,5x votre mise");
                            jetons = modif * 1.5 + jetons;
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                        }
                        else if (gagnant == 0)
                        {
                            Console.WriteLine("Vous avez tous les 2 le meme nombre de points et vous gardez votre mise");
                            jetons = jetons + modif;
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                        }
                        else if (gagnant >= 1)
                        {
                            Console.WriteLine("Vous battez le croupier et emporter 1,5x votre mise");
                            jetons = modif * 1.5 + jetons;
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                        }
                        else if (gagnant <= -1)
                        {
                            Console.WriteLine("Le croupier vous bat et emporte votre mise");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                        }

                        if (jetons <= 0)
                        {
                            finJeuBJ = true;
                            Console.WriteLine("Vous avez perdu contre le croupier.");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else if (jetons >= 200)
                        {
                            finJeuBJ = true;
                            Console.WriteLine("Félicitations vous avez battu le croupier !!!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                    }
                }
                else if (choix == 3)
                {

                }
                Console.ReadKey();
            }
        }
    
    }
}
